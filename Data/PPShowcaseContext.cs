using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using PPShowcase.Data.Entity;
using PPShowcase.Data.EntityConfigurationMap;
using PPShowcase.Data.SeedData;
using PPShowcase.Models;

namespace PPShowcase.Data
{
    public class PPShowcaseContext : DbContext
    {
        public PPShowcaseContext(DbContextOptions<PPShowcaseContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductEntityConfiguration).Assembly);

            modelBuilder.Entity<Category>().HasData(SeedDataStore.GetCategorySeed());
            modelBuilder.Entity<Product>().HasData(SeedDataStore.GetProductSeed());
        }

        

        public DbSet<Product> Product { get; set; } = default!;

        public DbSet<Category> Category { get; set; }

        public DbSet<PPShowcase.Models.ProductDto> ProductDto { get; set; }

        public DbSet<PPShowcase.Models.CategoryDto> CategoryDto { get; set; }
    }
}
