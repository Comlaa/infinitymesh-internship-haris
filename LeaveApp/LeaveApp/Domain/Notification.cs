using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Domain
{
    public class Notification
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
    }
}
