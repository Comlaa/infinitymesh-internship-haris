using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Domain
{
    public class UserRole :BaseEntitity
    {
        public virtual User UserID { get; set; }
        public virtual Role RoleID { get; set; }
        public UserRole(string Autorh) : base(Autorh) { }
    }
}
