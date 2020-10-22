using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Domain
{
    public class Notification : BaseEntitity
    {
        public int UserId { get; set; }
        public int LeaveId { get; set; }
        public UserLeave UserLeave { get; set; }
        public string Description { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }

        
    }
}
