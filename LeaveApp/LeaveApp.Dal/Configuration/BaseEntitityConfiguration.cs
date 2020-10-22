using LeaveApp.Dal.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApp.Dal.Configuration
{
    public abstract class BaseEntitityConfiguration<TEntitity> : IEntityTypeConfiguration<TEntitity> where TEntitity : BaseEntitity
    {
        public virtual void Configure(EntityTypeBuilder<TEntitity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.ModifiedAt)
                .HasComment("This is the default comment.");
        }
    }
}
