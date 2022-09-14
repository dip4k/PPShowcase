using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPShowcase.Migrations
{
    public partial class makecreationtime_required : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Product",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Category",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2022, 9, 14, 20, 2, 41, 344, DateTimeKind.Local).AddTicks(4763), new DateTime(2022, 9, 14, 20, 2, 41, 344, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2022, 9, 14, 20, 2, 41, 344, DateTimeKind.Local).AddTicks(4775), new DateTime(2022, 9, 14, 20, 2, 41, 344, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2022, 9, 14, 20, 2, 41, 344, DateTimeKind.Local).AddTicks(4776), new DateTime(2022, 9, 14, 20, 2, 41, 344, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2022, 9, 14, 20, 2, 41, 344, DateTimeKind.Local).AddTicks(4777), new DateTime(2022, 9, 14, 20, 2, 41, 344, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 2, 41, 344, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 2, 41, 344, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 2, 41, 344, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 2, 41, 344, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 2, 41, 344, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 2, 41, 344, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 2, 41, 344, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2022, 9, 14, 20, 2, 41, 344, DateTimeKind.Local).AddTicks(4867));
        }
    }
}
