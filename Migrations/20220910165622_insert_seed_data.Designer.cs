// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PPShowcase.Data;

#nullable disable

namespace PPShowcase.Migrations
{
    [DbContext(typeof(PPShowcaseContext))]
    [Migration("20220910165622_insert_seed_data")]
    partial class insert_seed_data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PPShowcase.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            AddedDate = new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2497),
                            Description = "Laptops",
                            LastModificationTime = new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2504),
                            Name = "laptops"
                        },
                        new
                        {
                            CategoryId = 2,
                            AddedDate = new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2508),
                            Description = "Smart phones",
                            LastModificationTime = new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2508),
                            Name = "smartphones"
                        },
                        new
                        {
                            CategoryId = 3,
                            AddedDate = new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2509),
                            Description = "Bags",
                            LastModificationTime = new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2509),
                            Name = "bags"
                        },
                        new
                        {
                            CategoryId = 4,
                            AddedDate = new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2510),
                            Description = "skincare",
                            LastModificationTime = new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2510),
                            Name = "skincare"
                        });
                });

            modelBuilder.Entity("PPShowcase.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ManufacturingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddedDate = new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2579),
                            CategoryId = 2,
                            Code = "iphone9",
                            IsActive = true,
                            ManufacturingDate = new DateTime(2018, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "iPhone 9",
                            UnitPrice = 549m
                        },
                        new
                        {
                            Id = 2,
                            AddedDate = new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2583),
                            CategoryId = 2,
                            Code = "iphonex",
                            IsActive = true,
                            ManufacturingDate = new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "iPhone X",
                            UnitPrice = 899m
                        },
                        new
                        {
                            Id = 3,
                            AddedDate = new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2584),
                            CategoryId = 2,
                            Code = "sam9",
                            IsActive = true,
                            ManufacturingDate = new DateTime(2018, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Samsung Universe 9",
                            UnitPrice = 1249m
                        },
                        new
                        {
                            Id = 4,
                            AddedDate = new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2585),
                            CategoryId = 2,
                            Code = "oppof19",
                            IsActive = true,
                            ManufacturingDate = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "OPPOF19",
                            UnitPrice = 280m
                        },
                        new
                        {
                            Id = 5,
                            AddedDate = new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2587),
                            CategoryId = 2,
                            Code = "huaweip30",
                            IsActive = true,
                            ManufacturingDate = new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Huawei P30",
                            UnitPrice = 499m
                        },
                        new
                        {
                            Id = 6,
                            AddedDate = new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2588),
                            CategoryId = 1,
                            Code = "macbookpro",
                            IsActive = true,
                            ManufacturingDate = new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MacBook Pro",
                            UnitPrice = 1749m
                        },
                        new
                        {
                            Id = 7,
                            AddedDate = new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2589),
                            CategoryId = 1,
                            Code = "samsunggalaxybook",
                            IsActive = true,
                            ManufacturingDate = new DateTime(2020, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Samsung Galaxy Book",
                            UnitPrice = 1499m
                        },
                        new
                        {
                            Id = 8,
                            AddedDate = new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2589),
                            CategoryId = 1,
                            Code = "surface4",
                            IsActive = true,
                            ManufacturingDate = new DateTime(2019, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Microsoft Surface Laptop 4",
                            UnitPrice = 1549m
                        });
                });

            modelBuilder.Entity("PPShowcase.Models.Product", b =>
                {
                    b.HasOne("PPShowcase.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
