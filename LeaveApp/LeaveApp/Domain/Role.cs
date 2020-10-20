﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Domain
{
    public class Role
    {
        public int ID { get; set; }
        public string RoleName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}