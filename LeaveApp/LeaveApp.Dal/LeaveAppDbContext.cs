using LeaveApp.Dal.Configuration;
using LeaveApp.Dal.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace LeaveApp.Dal
{
    public class LeaveAppDbContext : DbContext
    {
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLeave> UserLeaves { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public LeaveAppDbContext(DbContextOptions<LeaveAppDbContext> options) : base (options)  {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
