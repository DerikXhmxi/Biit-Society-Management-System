using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public int EventID { get; set; }
        public string TeamName { get; set; }
        public bool IsDeleted { get; set; }
    }

}
