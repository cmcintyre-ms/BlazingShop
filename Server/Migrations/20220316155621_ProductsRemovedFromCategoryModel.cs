using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazingShop.Server.Migrations
{
    public partial class ProductsRemovedFromCategoryModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 21, 344, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 21, 347, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 21, 347, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 21, 347, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 21, 347, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 21, 347, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 21, 347, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 21, 347, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 21, 347, DateTimeKind.Local).AddTicks(2318));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 42, 52, 413, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 42, 52, 416, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 42, 52, 416, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 42, 52, 416, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 42, 52, 416, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 42, 52, 416, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 42, 52, 416, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 42, 52, 416, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 42, 52, 416, DateTimeKind.Local).AddTicks(2455));
        }
    }
}
