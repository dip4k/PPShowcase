using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPShowcase.Migrations
{
    public partial class add_Table_contsraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddedDate",
                table: "Product",
                newName: "CreationTime");

            migrationBuilder.RenameColumn(
                name: "AddedDate",
                table: "Category",
                newName: "CreationTime");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Category",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Product",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Product_Code",
                table: "Product",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_Name",
                table: "Category",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Product_Code",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Category_Name",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "CreationTime",
                table: "Product",
                newName: "AddedDate");

            migrationBuilder.RenameColumn(
                name: "CreationTime",
                table: "Category",
                newName: "AddedDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Category",
                newName: "CategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "AddedDate", "LastModificationTime" },
                values: new object[] { new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2497), new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "AddedDate", "LastModificationTime" },
                values: new object[] { new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2508), new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "AddedDate", "LastModificationTime" },
                values: new object[] { new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2509), new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "AddedDate", "LastModificationTime" },
                values: new object[] { new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2510), new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedDate",
                value: new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedDate",
                value: new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedDate",
                value: new DateTime(2022, 9, 10, 22, 26, 22, 696, DateTimeKind.Local).AddTicks(2589));
        }
    }
}
