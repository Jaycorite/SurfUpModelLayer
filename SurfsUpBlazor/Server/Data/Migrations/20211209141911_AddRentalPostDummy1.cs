using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurfsUpBlazor.Server.Data.Migrations
{
    public partial class AddRentalPostDummy1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RentalPosts",
                columns: new[] { "Id", "AvailableDateFrom", "AvailableDateTo", "Category", "Deposit", "Description", "PostedDate", "Price", "Title" },
                values: new object[] { 1, new DateTime(2021, 12, 9, 15, 19, 11, 724, DateTimeKind.Local).AddTicks(1320), new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "Surfboard", 300, "A nice looking surfboard", new DateTime(2021, 12, 9, 15, 19, 11, 724, DateTimeKind.Local).AddTicks(1323), 100, "First post" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
