using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int SocietyID { get; set; }
        public DateTime EventDate { get; set; }
        public string Venue { get; set; }
        public bool RequiresFee { get; set; }
        public decimal FeeAmount { get; set; }
        public string CreatedByStudentAridNo { get; set; }
        public int ApprovedByTeacherID { get; set; }
        public bool IsDeleted { get; set; }
        public string EventApprovalStatus { get; set; }
        public DateTime EventApprovalDate { get; set; }
    }

}
