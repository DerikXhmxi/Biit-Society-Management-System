using project.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace project.DataHandlers
{
    internal class Validations
    {
        public static (bool isValid, String errorMsg) ValidName(String name)
        {
            if (String.IsNullOrEmpty(name)) return (false, "Name must not be Empty");
            foreach (char c in name)
            {
               
                if (!isLetter(c))
                {
                    return (false, "Name can only Contain Alphabets");

                }
            }
            return (true, null);


        }
        private static bool isLetter(char ch)
        {
            if((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                return true;
            }
            return false;

        }


        public static (bool isValid , String errorMsg) ValidPhoneNo(String phoneNo)
        {
            int x;
            if (phoneNo.Length == 10)
            {

                bool isValid = phoneNo.All(Char.IsDigit);
                if (isValid)
                {
                    return (true, "valid PhoneNo");
                }
                else
                    return (false, "PhoneNo can only contain number ");


            }
            return (false, "Invalid Phone No");
        }

        
        public static (bool isValid , String errorMsg) ValidAridNo(String AridNo)
        {
            string pre ="";
            string post = "";
            string mid = "";
           bool isValid = false;
            if (AridNo.Contains("-"))
            {
                String[] part = AridNo.Split('-');

                if(part.Length == 3)
                {
                    pre = part[0];
                    mid = part[1];
                    post = part[2];
                    int n;

                    if (pre.Length == 4)
                    {
                     isValid =   int.TryParse(pre, out n);

                        if (!isValid ) {
                        
                            return (false, "Enter valid year of Registration");
                        }
                        
                        else {

                            if (!(n > 2000 && n < 2025))
                            {
                                return (false, "Enter valid year of Registration");

                            }
                        }



                        

                    }
                    else
                    {
                        return (false, "Enter valid registration year");
                    }

                    if (!mid.Equals("Arid", comparisonType: StringComparison.CurrentCultureIgnoreCase))
                    {
                        return (false, "Enter Valid character");
                    }

                    if (post.Length == 4)
                    {
                        isValid = int.TryParse(post, out n);

                        if (!isValid)
                        {
                            return (false, "Enter valid Registration No");
                        }



                    }
                    else
                    {
                        return (false, "Enter valid registration No");
                    }

                    return (true, "Valid Arid no");

                }
                else
                {
                    return (false, "Enter Valid Arid No");
                }



            }
            else
            {
                return (false, "Enter Valid Arid No");
            }

        }
        public static (bool isValid, String errorMsg) ValidAge(int age)
        {


            if (age <= 13 || age >= 100)
            {
                return (false, "Enter a valid age(13-100)");

            }

            return (true, null);


        }
        public static (bool isValid, String errorMsg) ValidUserName(String username)
        {
            if (username.Length != 0)
            {
                char ch = username[0];
                if (!isLetter(ch))
                {


                    return (isValid: false, errorMsg: "UserName must start with alphabet");
                }
            }
            else
            {
                return (isValid: false, errorMsg: "username cannot be empty");
            }

            foreach (char c in username.ToCharArray())
            {

                if (!(

                   isLetter(c)||
                    (c == '_') ||
                    (c >= '0' && c <= '9'))
                    )
                {

                    return (false, "UserName can only start with and contain\n Alphabets, number and \'_\'");


                }
            }
            return (true, null);

        }

        public static (bool isValid, String errorMsg) ValidEmail(String email)
        {

            //   MessageBox.Show(txtEmail.Text);
            if (email.Length != 0)
            {
                if (!isLetter(email[0]))
                {
                    return (false, "First character must be alphabet")
                    ;
                }
                if (email.Contains("@"))
                {
                    int ind = email.LastIndexOf('@');
                    String pre = email.Substring(0, ind);
                    String post = email.Substring(ind + 1);


                    //    MessageBox.Show("pre : "+pre +"\npost : "+post +"\n index: "+ind);

                    if (ind != email.Length - 1)
                    {

                        foreach (char c in pre.ToCharArray())
                        {

                            if (!(
isLetter(c) ||
                                (c >= '0' && c <= '9'))
                                )
                            {

                                return (false, "email must contain only alphabet and number")
                   ;
                            }

                        }

                        int i = post.LastIndexOf('.');
                        if (i != -1)
                        {
                            string mail = post.Substring(0, i);
                            string org = post.Substring(i + 1);

                            //         MessageBox.Show("pre : " + pre + "\npost : " + post + "\n index: " + ind + "mail : " + mail + "\norg : " + org + "\n index: " + ind);

                            if (i != post.Length - 1)
                            {
                                foreach (char ch in mail.ToCharArray())
                                {
                                    if (!isLetter(ch)
                         )
                                    {
                                        return (false, "\"Enter valid mail server\"")
                ;

                                    }
                                }
                                foreach (char ch in org.ToCharArray())
                                {
                                    if (!isLetter(ch))
                                    {

                                        return (false, "only contain alphabets");

                                    }
                                }
                                return (true, null);
                            }

                            return (false, "invalid email");


                        }
                        else
                        {
                            for (int j = email.LastIndexOf('@') + 1; j < email.Length; j++)
                            {
                                if (!isLetter(email[j])
                     )
                                {

                                    return (false, "Enter valid mail server");
                                }

                            }
                        }


                    }
                }

                return (false, "invalid email ");
            }

            return (false, "Email cannot be empty");


        }

        public static (bool isValid, String errorMsg) ValidPassword(String pass)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;
            bool hasSpecial = false;


            foreach (char ch in pass)
            {
                if (ch >= 'A' && ch <= 'Z')
                {
                    hasUpper = true;
                }
                if (ch >= 'a' && ch <= 'z')
                {
                    hasLower = true;
                }
                if (ch >= '0' && ch <= '9')
                {
                    hasNumber = true;
                }
                if (!((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z') || (ch >= '1' && ch <= '9')))
                {
                    hasSpecial = true;
                }

            }
            if (!(pass.Length >= 6))

            {
                return (false, "Password must be 6 character Long");

            }
            if (hasSpecial && hasUpper && hasLower && hasNumber)
            {
                return (true, null);
            }
            return (false, "must contain upper lower alphabet\n,number and special character");





        }
    }
}
