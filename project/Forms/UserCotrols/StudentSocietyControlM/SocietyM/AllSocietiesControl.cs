using project.DataHandlers;
using project.Models;
using project.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Forms.StudentSocietyControlM
{
    public partial class AllSocietiesControl : UserControl
    {
        public AllSocietiesControl()
        {
            InitializeComponent();
        }
        Society society;
        Student s;
        public AllSocietiesControl(Society s , Student std)
        {
            
            InitializeComponent();
            this.s = std;

            society = s;

            label1.Text = s.Name;
            label2.Text = s.Description;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

         SocietyMember m =   SocietyMemberViewModel.GetByAridAndSociety(s.AridNo, society.SocietyID);

            if (m == null)
            {

                bool x = SocietyMemberViewModel.AddMember(new SocietyMember
                {
                    AridNo = s.AridNo,
                    SocietyID = society.SocietyID,
                    JoiningDate = DateTime.Now,
                    Role = "Member",
                    IsDeleted = false,


                });
                if (x)
                {
                    MessageBoxHelper.ShowInfo("Your Request Is Sent to Society President for approval to join the society");
                    NotificationService.NotifyStudentJoinRequest(s.AridNo, society.SocietyID);
                }
                else
                {
                    MessageBoxHelper.ShowError("Unable to Join the Society");

                }
            }
            else
            {
                MessageBoxHelper.ShowError("Society Aleady Joined");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
