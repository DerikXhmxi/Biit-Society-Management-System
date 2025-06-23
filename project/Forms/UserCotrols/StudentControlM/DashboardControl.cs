using project.DataHandlers;
using project.DataHandlers.ViewModel;
using project.Forms.StudentSocietyControlM;
using project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Forms.StudentControlM
{
    public partial class DashboardControl : UserControl
    {

        public DashboardControl()
        {
            InitializeComponent();

        }
        Student student;
        public DashboardControl(Student s)
        {
            InitializeComponent();
            student = s;

        }

        private void LoadEventCards(List<Event> events)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = true;
                flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            foreach (var ev in events)
            {
                UpcomingEventControl card = new UpcomingEventControl
               (ev);

                flowLayoutPanel1.Controls.Add(card);
            }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblWellcome.Text += "\t   "+student.Name +"        \t"+DateTime.Now;
            lblSocietyJoined.Text += SocietyViewModel.GetCountOfSocietyJoinedByStudent(student.AridNo);
            lblNoOfCertificates.Text += "2";
            lblNoOfTeams.Text += SocietyTeamMembershipViewModel.getTeamsJoinedByStudent(student.AridNo).Count;
            lblNoOfEvents.Text += EventViewModel.GetUpcomingEvents(student.AridNo).Count;
            LoadEventCards(EventViewModel.GetUpcomingEvents(student.AridNo));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
