using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Domain
{
    public class UserRole
    {
        public virtual User UserID { get; set; }
        public virtual Role RoleID { get; set; }
    }
}
