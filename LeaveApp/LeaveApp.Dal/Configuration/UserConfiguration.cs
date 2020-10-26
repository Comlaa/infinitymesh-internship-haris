using LeaveApp.Dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApp.Dal.Configuration
{
    public class UserConfiguration : BaseEntitityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.HasData(new User[]
            {   new User{
                Id = 1,
                Name = "Haris Mlaco",
                Password = "12345",
                Email = "haris.mlaco@edu.fit.ba",
                Department = "Engineering",
                JobTitle = "Software Developer",
            },
            new User{
                Id = 2,
                Name = "Admir Mujkic",
                Password = "123",
                Email = "admir.mujkic@infinitymesh.com",
                Department = "Engineering",
                JobTitle = "Software Architect",
            }
            });
        }
    }
}
