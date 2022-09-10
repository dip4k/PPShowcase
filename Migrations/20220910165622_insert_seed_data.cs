using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPShowcase.Migrations
{
    public partial class insert_seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "AddedDate", "Description", "LastModificationTime", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2497), "Laptops", new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2504), "laptops" },
                    { 2, new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2508), "Smart phones", new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2508), "smartphones" },
                    { 3, new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2509), "Bags", new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2509), "bags" },
                    { 4, new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2510), "skincare", new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2510), "skincare" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AddedDate", "CategoryId", "Code", "IsActive", "LastModificationTime", "ManufacturingDate", "Name", "UnitPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2579), 2, "iphone9", true, null, new DateTime(2018, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone 9", 549m },
                    { 2, new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2583), 2, "iphonex", true, null, new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone X", 899m },
                    { 3, new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2584), 2, "sam9", true, null, new DateTime(2018, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Universe 9", 1249m },
                    { 4, new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2585), 2, "oppof19", true, null, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "OPPOF19", 280m },
                    { 5, new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2587), 2, "huaweip30", true, null, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huawei P30", 499m },
                    { 6, new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2588), 1, "macbookpro", true, null, new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "MacBook Pro", 1749m },
                    { 7, new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2589), 1, "samsunggalaxybook", true, null, new DateTime(2020, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy Book", 1499m },
                    { 8, new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2589), 1, "surface4", true, null, new DateTime(2019, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft Surface Laptop 4", 1549m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
