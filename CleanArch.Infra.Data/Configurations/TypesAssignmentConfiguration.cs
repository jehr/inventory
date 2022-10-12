using Domain.Models.Assignment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Data.Configurations
{
    public class TypesAssignmentConfiguration : IEntityTypeConfiguration<TypesAssignment>
    {
        public void Configure(EntityTypeBuilder<TypesAssignment> builder)
        {
            builder.Property(x => x.Name)
               .HasMaxLength(50);
        }
    }
}
