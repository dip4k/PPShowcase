using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPShowcase.Migrations
{
    public partial class addRowVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Product",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Category",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9064), new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9074), new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9075), new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9076), new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 28, 15, 984, DateTimeKind.Local).AddTicks(9162));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Category");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9354), new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9369), new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9371), new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9372), new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 15, 51, 106, DateTimeKind.Local).AddTicks(9481));
        }
    }
}
