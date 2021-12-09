using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurfsUpBlazor.Server.Data.Migrations
{
    public partial class AddRentalPostDummy2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableDateFrom", "PostedDate" },
                values: new object[] { new DateTime(2021, 12, 9, 16, 6, 14, 143, DateTimeKind.Local).AddTicks(9035), new DateTime(2021, 12, 9, 16, 6, 14, 143, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.InsertData(
                table: "RentalPosts",
                columns: new[] { "Id", "AvailableDateFrom", "AvailableDateTo", "Category", "Deposit", "Description", "PostedDate", "Price", "Title" },
                values: new object[] { 2, new DateTime(2021, 12, 9, 16, 6, 14, 143, DateTimeKind.Local).AddTicks(9043), new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Paddleboard", 200, "I hope it works", new DateTime(2021, 12, 9, 16, 6, 14, 143, DateTimeKind.Local).AddTicks(9045), 200, "2 post" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableDateFrom", "PostedDate" },
                values: new object[] { new DateTime(2021, 12, 9, 15, 19, 11, 724, DateTimeKind.Local).AddTicks(1320), new DateTime(2021, 12, 9, 15, 19, 11, 724, DateTimeKind.Local).AddTicks(1323) });
        }
    }
}
