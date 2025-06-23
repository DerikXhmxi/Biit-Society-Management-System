using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Models
{
    
        public class Society
        {
            public int SocietyID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int MentorID { get; set; }
            public bool IsDeleted { get; set; }
        }

    
}
