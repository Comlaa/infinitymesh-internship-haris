using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Domain
{
    public class Role : BaseEntitity
    {
        public string RoleName { get; set; }
        public DateTime DateModified { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public Role(string Autorh) : base(Autorh) { }
    }
}
