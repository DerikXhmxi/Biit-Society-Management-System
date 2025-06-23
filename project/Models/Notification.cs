using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Models
{
    public class Notification
    {

        public int NotificationID { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string RecipientAridNo { get; set; } // ARID number of the recipient
        public string SenderId { get; set; } // ARID number of the sender
        public string EventId { get; set; } 
        public DateTime CreatedAt { get; set; }
        public bool IsRead { get; set; }
        public int SocietyID { get; set; } // ID of the society associated with the notification
        public bool IsDeleted { get; set; } // Flag to indicate if the notification is deleted


    }
}
