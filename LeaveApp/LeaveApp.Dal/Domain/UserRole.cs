using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Domain
{
    public class UserRole
    {
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

    }
}
