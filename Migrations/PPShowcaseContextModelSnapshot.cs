﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PPShowcase.Data;

#nullable disable

namespace PPShowcase.Migrations
{
    [DbContext(typeof(PPShowcaseContext))]
    partial class PPShowcaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PPShowcase.Data.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationTime = new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9354),
                            Description = "Laptops",
                            LastModificationTime = new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9362),
                            Name = "laptops"
                        },
                        new
                        {
                            Id = 2,
                            CreationTime = new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9369),
                            Description = "Smart phones",
                            LastModificationTime = new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9370),
                            Name = "smartphones"
                        },
                        new
                        {
                            Id = 3,
                            CreationTime = new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9371),
                            Description = "Bags",
                            LastModificationTime = new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9371),
                            Name = "bags"
                        },
                        new
                        {
                            Id = 4,
                            CreationTime = new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9372),
                            Description = "skincare",
                            LastModificationTime = new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9373),
                            Name = "skincare"
                        });
                });

            modelBuilder.Entity("PPShowcase.Data.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ManufacturingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Code = "iphone9",
                            CreationTime = new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9469),
                            IsActive = true,
                            ManufacturingDate = new DateTime(2018, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "iPhone 9",
                            UnitPrice = 549m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Code = "iphonex",
                            CreationTime = new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9473),
                            IsActive = true,
                            ManufacturingDate = new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "iPhone X",
                            UnitPrice = 899m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Code = "sam9",
                            CreationTime = new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9475),
                            IsActive = true,
                            ManufacturingDate = new DateTime(2018, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Samsung Universe 9",
                            UnitPrice = 1249m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Code = "oppof19",
                            CreationTime = new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9476),
                            IsActive = true,
                            ManufacturingDate = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "OPPOF19",
                            UnitPrice = 280m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Code = "huaweip30",
                            CreationTime = new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9478),
                            IsActive = true,
                            ManufacturingDate = new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Huawei P30",
                            UnitPrice = 499m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Code = "macbookpro",
                            CreationTime = new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9479),
                            IsActive = true,
                            ManufacturingDate = new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MacBook Pro",
                            UnitPrice = 1749m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Code = "samsunggalaxybook",
                            CreationTime = new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9480),
                            IsActive = true,
                            ManufacturingDate = new DateTime(2020, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Samsung Galaxy Book",
                            UnitPrice = 1499m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Code = "surface4",
                            CreationTime = new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9481),
                            IsActive = true,
                            ManufacturingDate = new DateTime(2019, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Microsoft Surface Laptop 4",
                            UnitPrice = 1549m
                        });
                });

            modelBuilder.Entity("PPShowcase.Data.Entity.Product", b =>
                {
                    b.HasOne("PPShowcase.Data.Entity.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PPShowcase.Data.Entity.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
