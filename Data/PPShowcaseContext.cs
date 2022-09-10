using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

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
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    AddedDate = DateTime.Now,
                    Name = "laptops",
                    Description = "Laptops",
                    LastModificationTime = DateTime.Now
                },
                new Category()
                {
                    CategoryId = 2,
                    AddedDate = DateTime.Now,
                    Name = "smartphones",
                    Description = "Smart phones",
                    LastModificationTime = DateTime.Now
                },

                new Category()
                {
                    CategoryId = 3,
                    AddedDate = DateTime.Now,
                    Name = "bags",
                    Description = "Bags",
                    LastModificationTime = DateTime.Now
                },

                new Category()
                {
                    CategoryId = 4,
                    AddedDate = DateTime.Now,
                    Name = "skincare",
                    Description = "skincare",
                    LastModificationTime = DateTime.Now
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "iPhone 9",
                    Code = "iphone9",
                    CategoryId = 2,
                    IsActive = true,
                    AddedDate = DateTime.Now,
                    ManufacturingDate = new DateTime(2018, 10, 25),
                    UnitPrice = 549
                },
                new Product
                {
                    Id = 2,
                    Name = "iPhone X",
                    Code = "iphonex",
                    CategoryId = 2,
                    IsActive = true,
                    AddedDate = DateTime.Now,
                    ManufacturingDate = new DateTime(2019, 10, 25),
                    UnitPrice = 899
                },
                new Product
                {
                    Id = 3,
                    Name = "Samsung Universe 9",
                    Code = "sam9",
                    CategoryId = 2,
                    IsActive = true,
                    AddedDate = DateTime.Now,
                    ManufacturingDate = new DateTime(2018, 05, 25),
                    UnitPrice = 1249
                }, new Product
                {
                    Id = 4,
                    Name = "OPPOF19",
                    Code = "oppof19",
                    CategoryId = 2,
                    IsActive = true,
                    AddedDate = DateTime.Now,
                    ManufacturingDate = new DateTime(2020, 10, 10),
                    UnitPrice = 280
                },
                new Product
                {
                    Id = 5,
                    Name = "Huawei P30",
                    Code = "huaweip30",
                    CategoryId = 2,
                    IsActive = true,
                    AddedDate = DateTime.Now,
                    ManufacturingDate = new DateTime(2020, 04, 02),
                    UnitPrice = 499
                },
                new Product
                {
                    Id = 6,
                    Name = "MacBook Pro",
                    Code = "macbookpro",
                    CategoryId = 1,
                    IsActive = true,
                    AddedDate = DateTime.Now,
                    ManufacturingDate = new DateTime(2019, 10, 25),
                    UnitPrice = 1749
                }, new Product
                {
                    Id = 7,
                    Name = "Samsung Galaxy Book",
                    Code = "samsunggalaxybook",
                    CategoryId = 1,
                    IsActive = true,
                    AddedDate = DateTime.Now,
                    ManufacturingDate = new DateTime(2020, 10, 25),
                    UnitPrice = 1499
                },
                new Product
                {
                    Id = 8,
                    Name = "Microsoft Surface Laptop 4",
                    Code = "surface4",
                    CategoryId = 1,
                    IsActive = true,
                    AddedDate = DateTime.Now,
                    ManufacturingDate = new DateTime(2019, 04, 25),
                    UnitPrice = 1549
                });
        }

        public DbSet<PPShowcase.Models.Product> Product { get; set; } = default!;

        public DbSet<PPShowcase.Models.Category> Category { get; set; }
    }
}
