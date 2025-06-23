using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Models
{
    public class SocietyMember
    {
        public int MemberID { get; set; }
        public string AridNo { get; set; }
        public int SocietyID { get; set; }
        public string Role { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool IsDeleted { get; set; }
    }

}
