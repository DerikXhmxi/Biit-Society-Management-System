using project.Models;
using project.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DataHandlers
{
    internal class TeacherData
    {
        public static void AddTeacher(Teacher teacher)
        {
            if (DatabaseHelper.InsertData(@"Insert into Teacher(
    TeacherId,Name , Email , PhoneNo ,Password,Department,IsFinancePanelMember,@IsMentor,isDeleted) values(@TeacherId ,@Name , @Email , @PhoneNo ,@Password,@Department,@IsFinancePanelMember,@IsMentor,@isDeleted)", new Dictionary<string, object>()
            {
                {"@TeacherId", teacher.TeacherID},
                {"@Name",teacher.Name },
                {"@Email" ,teacher.Email},
                {"@PhoneNo",teacher.PhoneNo },
                {"@Password",teacher.Password },
                {"@Department",teacher.Department},
                {"@IsFinancePanelMember",teacher.IsFinancePanelMember },
                { "@IsMentor", teacher.IsMentor },
                {"@isDeleted", "1" }

            }
             ))
            {
                MessageBoxHelper.ShowInfo("Data Inserted");
            }
            else
            {
                MessageBoxHelper.ShowError("no record inserted");
            }

        }


    }
}
