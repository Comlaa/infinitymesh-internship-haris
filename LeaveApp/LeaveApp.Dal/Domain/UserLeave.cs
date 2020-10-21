using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Domain
{
    public class UserLeave : BaseEntitity
    {
        public virtual User UserID { get; set; }
        public virtual Leave LeaveID { get; set; }
        public Notification NotificationID { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public User ApprovedBy { get; set; }
        public bool IsAproved { get; set; }
        public User UserReplacment { get; set; }
        public UserLeave(string Autorh) : base(Autorh) { }
    }
}
