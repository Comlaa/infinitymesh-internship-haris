using LeaveApp.Dal.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApp.Dal.Configuration
{
    class UserLeaveConfiguration : IEntityTypeConfiguration<UserLeave>
    {
        public void Configure(EntityTypeBuilder<UserLeave> builder)
        {
            builder.HasKey(p => new { p.UserId, p.LeaveId });

            builder.HasOne(p => p.User)
                .WithMany(p => p.UserLeaves)
               .HasForeignKey(p => p.UserId);

            builder.HasOne(p => p.Leave)
                .WithMany(p => p.UserLeaves)
               .HasForeignKey(p => p.LeaveId);

        }
    }
}
