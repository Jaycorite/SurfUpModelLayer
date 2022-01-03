using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurfsUpBlazor.Server.Data.Migrations
{
    public partial class DummyRental5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "PostedDate" },
                values: new object[] { "Kiteboard for a nice summer day.", new DateTime(2021, 12, 11, 21, 34, 50, 135, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.InsertData(
                table: "RentalPosts",
                columns: new[] { "Id", "AvailableDateFrom", "AvailableDateTo", "Category", "Deposit", "Description", "PostedDate", "Price", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 11, 21, 34, 50, 135, DateTimeKind.Local).AddTicks(2841), new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Surfboard", 300, "A nice looking surfboard.", new DateTime(2021, 12, 11, 21, 34, 50, 135, DateTimeKind.Local).AddTicks(2844), 100, "First post" },
                    { 2, new DateTime(2021, 12, 11, 21, 34, 50, 135, DateTimeKind.Local).AddTicks(2850), new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "Paddleboard", 200, "I hope it works.", new DateTime(2021, 12, 11, 21, 34, 50, 135, DateTimeKind.Local).AddTicks(2852), 200, "2 post" },
                    { 4, new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Paddleboard", 320, "My favorite paddleboard in good condition.", new DateTime(2021, 12, 11, 21, 34, 50, 135, DateTimeKind.Local).AddTicks(2866), 75, "4th post" },
                    { 5, new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "Surfboard", 400, "This surfboard will give you an unforgettable experience.", new DateTime(2021, 12, 11, 21, 34, 50, 135, DateTimeKind.Local).AddTicks(2873), 200, "Best post" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "PostedDate" },
                values: new object[] { "Kiteboard for a nice summer day", new DateTime(2021, 12, 11, 21, 21, 13, 647, DateTimeKind.Local).AddTicks(1568) });
        }
    }
}
