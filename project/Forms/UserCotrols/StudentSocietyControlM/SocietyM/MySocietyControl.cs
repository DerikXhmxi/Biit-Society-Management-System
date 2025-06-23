using project.DataHandlers;
using project.Forms.StudentControlM;
using project.Models;
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
    public partial class MySocietyControl : UserControl
    {
        public MySocietyControl()
        {
            InitializeComponent();
        }
        Student student;
        public MySocietyControl(Student s)
        {
            InitializeComponent();
            student = s;
            LoadSocietiesCards(SocietyViewModel.GetSocietiesJoinedByStudent(s.AridNo));
        }

        private void LoadSocietiesCards(List<Society> societies)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
       
            
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            foreach (var ev in societies)
            {
             

                flowLayoutPanel1.Controls.Add(new SocietyCard(ev , student));
            }
        }



    }
}
