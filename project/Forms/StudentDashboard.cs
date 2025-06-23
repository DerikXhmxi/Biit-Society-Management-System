using project.DataHandlers;
using project.Forms.StudentControlM;
using project.Forms.StudentSocietyControlM;
using project.Forms.UserCotrols;
using project.Forms.UserCotrols.StudentSocietyControlM.EventM;
using project.Forms.UserCotrols.TeamControlM;
using project.Models;
using project.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Forms
{
    public partial class StudentDashboard : Form
    {
        Student student;
        public StudentDashboard()
        {
            InitializeComponent();
        }
        public StudentDashboard(Student s)
        {


            InitializeComponent();
            student = s;

            ShowDashboardControl(new DashboardControl(student));

          


        }
        List<SocietyMember> members = new List<SocietyMember>();
        private void StudentDashboard_Load(object sender, EventArgs e)
        {
           members = SocietyMemberViewModel.GetByAridNoAndLeader(student.AridNo);
            if (members.Count>0)
            {
                btnManageEvent.Enabled = true;
            }
            else
            {
                btnManageEvent.Enabled = false;
            }
        

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            

        }

        private void ShowDashboardControl(UserControl control)
        {
            pnlMain.Controls.Clear();
            pnlMain.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(control);
        }
       


        
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardControl dc = new DashboardControl(student);
            dc.Dock = DockStyle.Fill;
            ShowDashboardControl(dc);

        }

        private void btnMySocieties_Click(object sender, EventArgs e)
        {
            ShowDashboardControl(new MySocietyControl(student));
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.White;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.DarkSlateGray;
        }

        private void btnMySocieties_MouseHover(object sender, EventArgs e)
        {
            btnMySocieties.ForeColor = Color.White;

        }

        private void btnMySocieties_MouseLeave(object sender, EventArgs e)
        {
            btnMySocieties.ForeColor = Color.DarkSlateGray;

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            btnJoinSociety.ForeColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            btnJoinSociety.ForeColor = Color.DarkSlateGray;


        }


        
        private void button6_MouseHover(object sender, EventArgs e)
        {
            btnTeam.ForeColor = Color.White;

        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            btnTeam.ForeColor = Color.DarkSlateGray;

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnNotification.ForeColor = Color.White;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnNotification.ForeColor = Color.DarkSlateGray;

        }

        private void button3_MouseHover_1(object sender, EventArgs e)
        {
            btnProfile.ForeColor = Color.White;


        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnProfile.ForeColor = Color.DarkSlateGray;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            ShowDashboardControl(new JoinNewSocietyControlMain(student));


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowDashboardControl(new StudentProfileControl(student));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDashboardControl(new StudentNotificationControl(student));
        }


  

        private void button6_Click(object sender, EventArgs e)
        {
            ShowDashboardControl(new TeamControl(student));
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            ShowDashboardControl(new EventParticipateControl(student))
;        }

        private void btnManageEvent_Click(object sender, EventArgs e)
        {
            ShowDashboardControl(new    EventMainControl(members,student));

        }
    }
}
