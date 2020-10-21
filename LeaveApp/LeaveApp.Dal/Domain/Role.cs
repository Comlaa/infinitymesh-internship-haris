using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Domain
{
    public class Role : ICreateInfo
    {
        public int ID { get; set; }
        public string RoleName { get; set; }
        public DateTime DateModified { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
    }
}
