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
                UserName = "comlaa",
                Password = "12345",
                Email = "haris.mlaco@edu.fit.ba",
                DepartmentID = 1,
                JobTitleID = 1,
            },
            new User{
                Id = 2,
                UserName = "amujkic",
                Password = "12345",
                Email = "amujkic@infinitymesh.com",
                DepartmentID = 1,
                JobTitleID = 2,
            },
            new User{
                Id = 3,
                UserName = "nalibegovic",
                Password = "12345",
                Email = "nedzada@edu.fit.ba",
                DepartmentID = 1,
                JobTitleID = 1,
            }});

        }
    }
}
