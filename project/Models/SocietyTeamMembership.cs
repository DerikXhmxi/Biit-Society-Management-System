using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Models
{
    public class SocietyTeamMembership
    {
        public int MembershipID { get; set; }
        public int TeamID { get; set; }  // Linked to SocietyTeam Table
        public int MemberID { get; set; }  // Linked to SocietyMember Table
        public string Role { get; set; }  // e.g., Leader, Coordinator, Volunteer
        public DateTime JoiningDate { get; set; }
        public bool IsDeleted { get; set; }
    }

}
