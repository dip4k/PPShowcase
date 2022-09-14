﻿// <auto-generated />
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
    [Migration("20220914145816_addRowVersion")]
    partial class addRowVersion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationTime = new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9064),
                            Description = "Laptops",
                            LastModificationTime = new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9072),
                            Name = "laptops"
                        },
                        new
                        {
                            Id = 2,
                            CreationTime = new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9074),
                            Description = "Smart phones",
                            LastModificationTime = new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9074),
                            Name = "smartphones"
                        },
                        new
                        {
                            Id = 3,
                            CreationTime = new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9075),
                            Description = "Bags",
                            LastModificationTime = new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9075),
                            Name = "bags"
                        },
                        new
                        {
                            Id = 4,
                            CreationTime = new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9076),
                            Description = "skincare",
                            LastModificationTime = new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9076),
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

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

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
                            CreationTime = new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9151),
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
                            CreationTime = new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9154),
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
                            CreationTime = new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9156),
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
                            CreationTime = new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9157),
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
                            CreationTime = new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9158),
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
                            CreationTime = new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9160),
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
                            CreationTime = new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9161),
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
                            CreationTime = new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9162),
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