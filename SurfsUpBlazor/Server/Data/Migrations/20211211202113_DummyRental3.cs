using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurfsUpBlazor.Server.Data.Migrations
{
    public partial class DummyRental3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "RentalPosts",
                columns: new[] { "Id", "AvailableDateFrom", "AvailableDateTo", "Category", "Deposit", "Description", "PostedDate", "Price", "Title" },
                values: new object[] { 3, new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), "Kiteboard", 250, "Kiteboard for a nice summer day", new DateTime(2021, 12, 11, 21, 21, 13, 647, DateTimeKind.Local).AddTicks(1568), 150, "3rd post" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "RentalPosts",
                columns: new[] { "Id", "AvailableDateFrom", "AvailableDateTo", "Category", "Deposit", "Description", "PostedDate", "Price", "Title" },
                values: new object[] { 1, new DateTime(2021, 12, 9, 16, 6, 14, 143, DateTimeKind.Local).AddTicks(9035), new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Surfboard", 300, "A nice looking surfboard", new DateTime(2021, 12, 9, 16, 6, 14, 143, DateTimeKind.Local).AddTicks(9037), 100, "First post" });

            migrationBuilder.InsertData(
                table: "RentalPosts",
                columns: new[] { "Id", "AvailableDateFrom", "AvailableDateTo", "Category", "Deposit", "Description", "PostedDate", "Price", "Title" },
                values: new object[] { 2, new DateTime(2021, 12, 9, 16, 6, 14, 143, DateTimeKind.Local).AddTicks(9043), new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Paddleboard", 200, "I hope it works", new DateTime(2021, 12, 9, 16, 6, 14, 143, DateTimeKind.Local).AddTicks(9045), 200, "2 post" });
        }
    }
}
