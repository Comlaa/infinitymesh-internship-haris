using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Models
{
    public class UserLeaveViewModel
    {
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
    }
}
