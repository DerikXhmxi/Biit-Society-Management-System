using project.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.DataHandlers
{
    internal class StudentData
    {
        public static void  AddStudent(Student student)
        {
           if( DatabaseHelper.InsertData(@"Insert into Student(AridNo ,Name , Email , PhoneNo ,Password,Department,isDeleted) values(@AridNo ,@Name , @Email , @PhoneNo ,@Password,@Department,@isDeleted)", new Dictionary<string, object>()
            {
                {"@AridNo", student.AridNo},
                {"@Name",student.Name },
                {"@Email" ,student.Email },
                {"@PhoneNo",student.PhoneNo },
                {"@Password",student.Password },
                {"@Department",student.Department },
                {"isDeleted", "1" }

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

        public static bool UpdateStudentRecord(Student student)
        {
            if (
                DatabaseHelper.UpdateData(@"Update Student set AridNo = @AridNo ,Name = @Name , Email = @Email , PhoneNo = @PhoneNo ,Password = @Password,Department = @Department,isDeleted = @isDeleted where AridNo = @AridNo"
                , new Dictionary<string, object>(){
  
                {"@AridNo", student.AridNo},
                {"@Name",student.Name },
                {"@Email" ,student.Email },
                {"@PhoneNo",student.PhoneNo },
                {"@Password",student.Password },
                {"@Department",student.Department },
                {"isDeleted", student.IsDeleted }

            }
             ))
            {
                MessageBoxHelper.ShowInfo("Data Updated");
                return true;
            }
            else
            {
                MessageBoxHelper.ShowError("no record Updated");
                return false;
            }

        }

        public static bool DeleteStudentRecord(String AridNo)
        {
            if (
                DatabaseHelper.UpdateData(@"Update Student set isDeleted = 0 where AridNo = @AridNo"
                , new Dictionary<string, object>(){

                {"@AridNo", AridNo},
              

            }
             ))
            {
                MessageBoxHelper.ShowInfo("Data Updated");
                return true;
            }
            else
            {
                MessageBoxHelper.ShowError("no record Updated");
                return false;
            }

        }

        public static List<Student> GetStudentBy(String where, String whereValue)
        {
            List<Student> students = new List<Student>();
            List<Dictionary<string, object>> x =
                DatabaseHelper.GetData($"Select * from Student where {where} = @parameter",
              new Dictionary<string, object>
              {

                  {"@parameter",whereValue }


              });
            if (x != null)
                for (int i = 0; i < x.Count; i++)
                {
                    Student s = new Student
                    {
                        AridNo = x[i]["AridNo"] as string,
                        Name = x[i]["Name"] as string,
                        Email = x[i]["Email"] as string,
                        PhoneNo = x[i]["PhoneNo"] as string,
                        Password = x[i]["Password"] as string,
                        Department = x[i]["Department"] as string,
                        IsDeleted = Convert.ToBoolean(x[i]["isDeleted"])
                    };


                    students.Add(s);
                } 
        
            return students;




        }

        public static Student GetStudentByAridNo(String AridNo) {

            List<Dictionary<String, object>> x = DatabaseHelper.GetData("Select * from Student where AridNo = @AridNo", new Dictionary<string, object>
            {
                { "@AridNo",AridNo } 
            });

            return new Student
            {
                AridNo = x[0]["AridNo"] as string,
                Name = x[0]["Name"] as string,
                Email = x[0]["Email"] as string,
                PhoneNo = x[0]["PhoneNo"] as string,
                Password = x[0]["Password"] as string,
                Department = x[0]["Department"] as string,
                IsDeleted = Convert.ToBoolean(x[0]["isDeleted"])

            };

        }

        public static List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
                List<Dictionary<String,object>> x=
                DatabaseHelper.GetData("Select * from Student", null);
            for (int i = 0; i < x.Count; i++)
            {
                Student s = new Student
                {
                    AridNo = x[i]["AridNo"] as string,
                    Name = x[i]["Name"] as string,
                    Email = x[i]["Email"] as string,
                    PhoneNo = x[i]["PhoneNo"] as string,
                    Password = x[i]["Password"] as string,
                    Department = x[i]["Department"] as string,
                    IsDeleted =Convert.ToBoolean(x[i]["isDeleted"])
                };
                students.Add(s);
            }
            return students;
         

        }
    }
}
