using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApp.Dal.Domain
{
    public interface ICreateInfo
    {
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
    }
}
