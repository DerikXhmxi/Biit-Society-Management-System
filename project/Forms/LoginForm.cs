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

namespace project.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // FORM LOAD 
        private void LoginForm_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            lblErrorUserName.Visible = false;
            lblErrorPassword.Visible = false;

        }

        // LOGIN BUTTON 
        private void button1_Click(object sender, EventArgs e)
        {
            String userName = txtUsername.Text;
            String password = txtPassword.Text;




            if (String.IsNullOrEmpty(userName))
            {
                lblErrorUserName.Text = "password is required ";
                lblErrorUserName.Visible = true;
            }
            else
            {

                lblErrorUserName.Visible = false;
            }


            if (String.IsNullOrEmpty(password))
            {
                lblErrorPassword.Text = "This field is required";
                lblErrorPassword.Visible = true;
            }
            else
            {
                lblErrorPassword.Visible = false;
            }

            if (!String.IsNullOrEmpty(userName) && !String.IsNullOrEmpty(password))
            {
                User user = UserViewModel.Authenticate(userName, password);

                if (user != null)
                {
                    if (user.Role == "Student")
                    {

                        Student s = StudentViewModel.GetByAridNo(user.RelatedId);



                        MessageBoxHelper.ShowInfo("Student");

                        StudentDashboard dashboard = new StudentDashboard(s);
                        dashboard.Show();
                        this.Hide();


                    }
                    else if (user.Role == "Teacher")
                    {

                        MessageBoxHelper.ShowInfo("Teacher");
                    }
                    else
                    {

                    }
                    //    }
                    //   else
                    //  {
                    //     MessageBoxHelper.ShowError("Please Fill the required Field !");
                    // }
                }
                else
                {
                    MessageBoxHelper.ShowError("INVALID CREDENTIALS !");


                }

            }
        }

        // USER NAME VALIDATE 
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            String userName = txtUsername.Text;


            if (String.IsNullOrEmpty(userName))
            {
                lblErrorUserName.Text = "USERNAME is required ";
                lblErrorUserName.Visible = true;
                btnLogin.Enabled = false;
            }
            else
            {
                if (!String.IsNullOrEmpty(txtPassword.Text))
                {
                    btnLogin.Enabled = true;

                }
                lblErrorUserName.Visible = false;
            }
        }

        //PASS VALIDATE ON TEXTCHANGED 
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            String password = txtPassword.Text;


            if (String.IsNullOrEmpty(password))
            {
                lblErrorPassword.Text = "PASSWORD is required";
                lblErrorPassword.Visible = true;
                btnLogin.Enabled = false;
            }
            else
            {
                if (!String.IsNullOrEmpty(txtUsername.Text))
                {
                    btnLogin.Enabled = true;

                }
                lblErrorPassword.Visible = false;
            }

        }

        //EXIT BUTTON 
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // SIGNUP BUTTON 

        private void button3_Click(object sender, EventArgs e)
        {
            StudentSignUpForm studentSignUpForm = new StudentSignUpForm(this);
            studentSignUpForm.Show();
            this.Hide();
        }




        private void button3_MouseEnter(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.DarkSlateGray;
            btnSignUp.ForeColor = Color.White;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.White;
            btnSignUp.ForeColor = Color.DarkSlateGray;
        }




    }

  
}
