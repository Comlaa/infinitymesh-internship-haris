using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Domain
{
    public class User : BaseEntitity    
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int DepartmentID { get; set; }
        public int JobTitleID { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public List<UserLeave> UserLeaves { get; set; }


    }
}
