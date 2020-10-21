using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApp.Dal.Domain
{
    public abstract class BaseEntitity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        protected BaseEntitity (string CreatedBy_)
        {
            CreatedBy = CreatedBy_;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
