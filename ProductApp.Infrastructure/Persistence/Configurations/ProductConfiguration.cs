using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductApp.Domain.Entities;

namespace ProductApp.Infrastructure.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Description)
                .HasMaxLength(300)
                .IsRequired();

            builder.Property(p => p.Stock)
                .HasDefaultValue(0)
                .IsRequired();
        }
    }
}
