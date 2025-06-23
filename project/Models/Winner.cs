using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Models
{
    public class Winner
    {
        public int WinnerID { get; set; }
        public int EventID { get; set; }
        public string AridNo { get; set; }  // Student Identifier
        public string Position { get; set; }  // First, Second, Third Place, etc.
        public bool IsDeleted { get; set; }
    }

}
