using project.DataHandlers.ViewModel;
using project.Forms.UserCotrols.StudentSocietyControlM.EventM;
using project.Models;
using project.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Forms.StudentSocietyControlM.EventM
{
    public partial class AddEvent : Form
    {
        private Society society;
        private Student student;


        public AddEvent()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        public AddEvent(Society soc, Student stud)
        {
            InitializeComponent();
            this.society = soc;

            this.student = stud;

      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Event x;
        private void button3_Click(object sender, EventArgs e)
        {

            x = new Event
            {
                Title = txtName.Text,
                Description = txtDes.Text,
                EventDate = dtpEvent.Value.Date,
                Venue = txtVenue.Text,
                RequiresFee = chkBxFee.Checked,
                FeeAmount = Convert.ToDecimal(txtAmount.Text),
                CreatedByStudentAridNo = student.AridNo,
                IsDeleted = false,
                SocietyID = society.SocietyID,
                EventApprovalDate = DateTime.Now

            };

            DialogResult result;
            result = MessageBoxHelper.ShowConfirmation("You can now make Form for Participant by clicking Generate Form button\nDo you want to Create Form??");



            if (result == DialogResult.No)
            {
                if (EventViewModel.AddEvent(x))
                {
                    NotificationService.NotifyEventApprovalRequest(student.AridNo , x.SocietyID ,x.EventID+"" , x.Title);
         
                }
            }
            else
            {


                int newEventId = EventViewModel.InsertEventAndGetId(x);
                x.EventID = newEventId;

                EventFilesViewModel.AddEventFile(new EventFile
                {
                    EventId = newEventId,
                    FileName = fileName,
                    FilePath = path,
                    FileType = type


                });

                FormGenerationForEvent form = new FormGenerationForEvent(x);
                form.ShowDialog();





            }

        }
        string fileName;
        string path;
        string type;
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string originalPath = ofd.FileName;
                 fileName = Path.GetFileName(originalPath);

                type = Path.GetExtension(originalPath);
                // Target folder inside app
                string targetDir = Path.Combine("E://SocietyProject","EventFiles");
                Directory.CreateDirectory(targetDir); // just in case

                // Destination path
                path = Path.Combine(targetDir, fileName);

                // Copy file
                File.Copy(originalPath, path, overwrite: true); // overwrite if exists

                // Save path to database (only file name or relative path recommended)
                  MessageBox.Show("File uploadeded successfully.");
             
            }
        }
    }
}
