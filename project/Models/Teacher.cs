using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Models
{
    public class Teacher
    {
        public string TeacherID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Password { get; set; }
        public string Department { get; set; }
        public bool IsMentor { get; set; }
        public bool IsFinancePanelMember { get; set; }
        public bool IsDeleted { get; set; }
    }


}
