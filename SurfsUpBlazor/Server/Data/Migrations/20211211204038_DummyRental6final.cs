using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurfsUpBlazor.Server.Data.Migrations
{
    public partial class DummyRental6final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "RentalPosts",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableDateFrom", "PostedDate" },
                values: new object[] { new DateTime(2021, 12, 11, 21, 40, 38, 63, DateTimeKind.Local).AddTicks(2210), new DateTime(2021, 12, 11, 21, 40, 38, 63, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableDateFrom", "PostedDate" },
                values: new object[] { new DateTime(2021, 12, 11, 21, 40, 38, 63, DateTimeKind.Local).AddTicks(2218), new DateTime(2021, 12, 11, 21, 40, 38, 63, DateTimeKind.Local).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedDate",
                value: new DateTime(2021, 12, 11, 21, 40, 38, 63, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedDate",
                value: new DateTime(2021, 12, 11, 21, 40, 38, 63, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "PostedDate", "Title" },
                values: new object[] { "Kiteboard", new DateTime(2021, 12, 11, 21, 40, 38, 63, DateTimeKind.Local).AddTicks(2243), "This is a great post" });

            migrationBuilder.InsertData(
                table: "RentalPosts",
                columns: new[] { "Id", "AvailableDateFrom", "AvailableDateTo", "Category", "Deposit", "Description", "PostedDate", "Price", "Title" },
                values: new object[] { 6, new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Surfboard", 250, "I hope you will treat this board with care.", new DateTime(2021, 12, 11, 21, 40, 38, 63, DateTimeKind.Local).AddTicks(2250), 100, "Best post" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "RentalPosts",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableDateFrom", "PostedDate" },
                values: new object[] { new DateTime(2021, 12, 11, 21, 34, 50, 135, DateTimeKind.Local).AddTicks(2841), new DateTime(2021, 12, 11, 21, 34, 50, 135, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableDateFrom", "PostedDate" },
                values: new object[] { new DateTime(2021, 12, 11, 21, 34, 50, 135, DateTimeKind.Local).AddTicks(2850), new DateTime(2021, 12, 11, 21, 34, 50, 135, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedDate",
                value: new DateTime(2021, 12, 11, 21, 34, 50, 135, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedDate",
                value: new DateTime(2021, 12, 11, 21, 34, 50, 135, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "PostedDate", "Title" },
                values: new object[] { "Surfboard", new DateTime(2021, 12, 11, 21, 34, 50, 135, DateTimeKind.Local).AddTicks(2873), "Best post" });
        }
    }
}
