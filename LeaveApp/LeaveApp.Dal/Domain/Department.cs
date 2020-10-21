using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Domain
{
    public class Department : ICreateInfo
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
    }
}
