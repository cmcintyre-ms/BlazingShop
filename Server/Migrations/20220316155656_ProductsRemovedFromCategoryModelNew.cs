using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazingShop.Server.Migrations
{
    public partial class ProductsRemovedFromCategoryModelNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 55, 669, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 55, 672, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 55, 672, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 55, 672, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 55, 672, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 55, 672, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 55, 672, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 55, 672, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 16, 15, 56, 55, 672, DateTimeKind.Local).AddTicks(9069));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
