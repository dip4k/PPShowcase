using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using PPShowcase.Data.Entity;

namespace PPShowcase.Data.EntityConfigurationMap
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code)
                .IsRequired();
            builder.HasIndex(x => x.Code)
                .IsUnique();
            builder.Property(x => x.Name)
                .IsRequired();

            builder.Property(p => p.RowVersion)
                .IsConcurrencyToken();

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.CreationTime)
                .HasDefaultValueSql("getdate()")
                .IsRequired();
        }
    }
}
