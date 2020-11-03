using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Domain
{
    public class Leave : BaseEntitity
    { 
        public string LeaveType { get; set; }
        public string Description { get; set; }
        public string SpecialLeave { get; set; }
        public int TotalDays { get; set; }
        public List<UserLeave> UserLeaves { get; set; }


        public Leave()
        {
        }
        public Leave(Leave leave)
        {
            LeaveType = leave.LeaveType;
            Description = leave.Description;
            TotalDays = leave.TotalDays;
            SpecialLeave = leave.SpecialLeave;
        }

    }
}
