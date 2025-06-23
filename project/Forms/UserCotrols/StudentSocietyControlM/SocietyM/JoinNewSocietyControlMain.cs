using project.DataHandlers;
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
    public partial class JoinNewSocietyControlMain : UserControl
    {
        Student s;
        public JoinNewSocietyControlMain()
        {
            InitializeComponent();
            LoadAllSocietyControls(SocietyViewModel.GetAllSocieties() );
        }

        public JoinNewSocietyControlMain(Student s)
        {
            this.s = s;
            InitializeComponent();
            LoadAllSocietyControls(SocietyViewModel.GetAllSocieties());
        }


        private void LoadAllSocietyControls(List<Society> societies)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Padding = new Padding(20);

            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            foreach (var ev in societies)
            {


                flowLayoutPanel1.Controls.Add(new AllSocietiesControl(ev , s));
            }
        }
    }
}
