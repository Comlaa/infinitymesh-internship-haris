using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Domain
{
    public class User : BaseEntitity    
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public List<UserLeave> UserLeaves { get; set; }

        public User()
        {

        }
        public User(User user)
        {
            Name = user.Name;
            Password = user.Password;
            Email = user.Email;
            Department = user.Department;
            JobTitle = user.JobTitle;
        }
    }
}
