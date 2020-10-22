using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Domain
{
    public class UserLeave
    {
        public int UserId { get; set; }
        public int LeaveId { get; set; }
        public virtual User User { get; set; }
        public virtual Leave Leave { get; set; }
        public List<Notification> Notifications{ get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string ApprovedBy { get; set; }
        public bool IsAproved { get; set; }
        public string UserReplacment { get; set; }
        
    }
}
