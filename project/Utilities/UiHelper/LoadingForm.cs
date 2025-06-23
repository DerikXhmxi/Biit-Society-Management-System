using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Utilities.UiHelper
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.TopMost = true;
        }
        public void UpdateProgress(int percent, string message = null)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateProgress(percent, message)));
                return;
            }

            progressBar1.Value = percent;
            if (!string.IsNullOrEmpty(message))
                label1.Text = message;
        }
    }
}
