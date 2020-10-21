using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Domain
{
    public class JobTitle : BaseEntitity
{

        public string Name { get; set; }
        public JobTitle(string Autorh) : base(Autorh) { }
   
    }
}
