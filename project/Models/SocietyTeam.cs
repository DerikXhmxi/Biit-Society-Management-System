using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Models
{
    public class SocietyTeam
    {
        public int TeamID { get; set; }
        public int SocietyID { get; set; }  // Linked to Society Table
        public string TeamName { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }

}
