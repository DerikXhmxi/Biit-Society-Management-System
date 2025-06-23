using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Utilities
{
    internal class MessageBoxHelper
    {
      
        public static void  ShowInfo(String message ,String title = "Information")
        {   
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowWarning(String message , String title = "Warning") {

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        public static void ShowError(String message, String title = "Error")
        {

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public static DialogResult ShowConfirmation(String message , String title = "Confirm") {

            return MessageBox.Show(message, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
    
    }
}
