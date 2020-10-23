using LeaveApp.Dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApp.Dal.Configuration
{
    class RoleConfiguration : BaseEntitityConfiguration<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);

            builder.HasData(new Role[]
            {
                new Role {
                Id = 1,
                RoleName = "Admin",
                DateModified = DateTime.Now,
            },
                 new Role {
                Id = 2,
                RoleName = "Moderator",
                DateModified = DateTime.Now,
            }
            });
        }
    }
}
