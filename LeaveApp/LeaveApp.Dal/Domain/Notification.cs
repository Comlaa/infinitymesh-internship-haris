using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Domain
{
    public class Notification : BaseEntitity
    {
        public string Description { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
        public Notification(string Autorh) : base(Autorh) { }
    }
}
