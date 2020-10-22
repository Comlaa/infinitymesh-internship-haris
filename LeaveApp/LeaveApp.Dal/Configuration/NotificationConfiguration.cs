using LeaveApp.Dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApp.Dal.Configuration
{
    class NotificationConfiguration : BaseEntitityConfiguration<Notification>
    {
        public override void Configure(EntityTypeBuilder<Notification> builder)
        {
            base.Configure(builder);

            builder.HasOne(p => p.UserLeave)
                .WithMany(p => p.Notifications)
                .HasForeignKey(p => new { p.UserId, p.LeaveId});

        }
    }
}
