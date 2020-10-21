using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Domain
{
    public class Department : BaseEntitity
    {

        public string Name { get; set; }

        public Department(string Autorh) : base(Autorh) { }

    }
}
