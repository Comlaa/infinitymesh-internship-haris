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

        public Leave(string Autorh) : base(Autorh) { }

    }
}
