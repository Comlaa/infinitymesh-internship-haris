using LeaveApp.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.DB
{
    public class LeaveAppDbContext : DbContext
    {
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLeave> UserLeaves { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}
