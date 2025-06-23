using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Models
{
    public class TeamMembership
    {
        public int MembershipID { get; set; }
        public int TeamID { get; set; }
        public string AridNo { get; set; }
        public bool IsDeleted { get; set; }
    }

}
