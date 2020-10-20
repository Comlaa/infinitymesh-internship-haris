using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Models
{
    public class UserViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public int DepartmentID { get; set; }
        public int JobTitleID { get; set; }
    }
}
