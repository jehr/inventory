using Domain.Models.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasIndex(x => new { x.Serial })
                .IsUnique(true);

            builder.Property(x => x.Price)
               .HasMaxLength(10);

            builder.Property(x => x.Description)
               .HasMaxLength(250);

        }
    }
}
