﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Domain
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int DepartmentID { get; set; }
        public int JobTitleID { get; set; }
        public List<UserRole> Roles { get; set; }

    }
}
