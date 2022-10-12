using Domain.Models.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infra.Data.Configurations
{
    public class TypeProductConfiguration : IEntityTypeConfiguration<TypeProduct>
    {
        public void Configure(EntityTypeBuilder<TypeProduct> builder)
        {
            builder.Property(x => x.Name)
                .HasMaxLength(50);
        }
    }
}
