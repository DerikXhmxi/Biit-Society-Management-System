using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Models
{
    public class EventParticipation
    {
        public int ParticipationID { get; set; }
        public int EventID { get; set; }
        public string AridNo { get; set; }
        public string Role { get; set; }
        public bool FeePaid { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool IsDeleted { get; set; }
    }

}
