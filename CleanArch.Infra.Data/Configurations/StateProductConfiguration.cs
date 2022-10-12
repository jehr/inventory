using Domain.Models.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infra.Data.Configurations
{
    public class StateProductConfiguration : IEntityTypeConfiguration<StateProduct>
    {
        public void Configure(EntityTypeBuilder<StateProduct> builder)
        {
            builder.Property(x => x.Name)
                 .HasMaxLength(50);
        }
    }
}
