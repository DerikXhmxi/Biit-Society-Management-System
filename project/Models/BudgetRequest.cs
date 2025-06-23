using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Models
{
    public class BudgetRequest
    {
        public int BudgetRequestID { get; set; }
        public int EventID { get; set; }
        public decimal RequestedAmount { get; set; }
        public decimal ApprovedAmount { get; set; }
        public string Status { get; set; }
        public int DecisionBy { get; set; }
        public string Comments { get; set; }
        public bool IsDeleted { get; set; }
    }

}
