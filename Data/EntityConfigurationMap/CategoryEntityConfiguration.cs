using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using PPShowcase.Data.Entity;

namespace PPShowcase.Data.EntityConfigurationMap
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Name).IsRequired();
            builder.HasMany(x => x.Products).WithOne();
            builder.Property(x => x.CreationTime)
                .HasDefaultValueSql("getdate()")
                .IsRequired();
        }
    }
}
