using LeaveApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.DB
{
    public class DBContext
    {
        public List<JobTitle> JobTitles { get; set; }
        public List<Department> Departments { get; set; }
        public List<Leave> Leaves { get; set; }
        public List<Notification> Notifications { get; set; }
        public List<Role> Roles { get; set; }
        public List<User> Users { get; set; }
        public List<UserLeave> UserLeaves { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
