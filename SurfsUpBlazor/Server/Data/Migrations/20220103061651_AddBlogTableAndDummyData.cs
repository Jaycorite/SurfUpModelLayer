using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurfsUpBlazor.Server.Data.Migrations
{
    public partial class AddBlogTableAndDummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "PostedDate", "Text", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 3, 7, 16, 51, 475, DateTimeKind.Local).AddTicks(7755), "A nice looking surfboard.", "First Blog" },
                    { 2, new DateTime(2022, 1, 5, 7, 16, 51, 475, DateTimeKind.Local).AddTicks(7759), "A nice looking surfboard.", "2. Blog" },
                    { 3, new DateTime(2022, 1, 6, 7, 16, 51, 475, DateTimeKind.Local).AddTicks(7761), "A nice looking surfboard.", "3rd blog" },
                    { 4, new DateTime(2022, 1, 8, 7, 16, 51, 475, DateTimeKind.Local).AddTicks(7764), "A nice looking surfboard.", "The last Blog" },
                    { 5, new DateTime(2022, 1, 10, 7, 16, 51, 475, DateTimeKind.Local).AddTicks(7767), "A nice looking surfboard.", "Just a Blog" },
                    { 6, new DateTime(2022, 1, 14, 7, 16, 51, 475, DateTimeKind.Local).AddTicks(7769), "A nice looking surfboard.", "My new Blog" }
                });

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableDateFrom", "AvailableDateTo", "PostedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 7, 16, 51, 475, DateTimeKind.Local).AddTicks(7572), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 3, 7, 16, 51, 475, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableDateFrom", "AvailableDateTo", "PostedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 7, 16, 51, 475, DateTimeKind.Local).AddTicks(7580), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 3, 7, 16, 51, 475, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvailableDateFrom", "AvailableDateTo", "PostedDate" },
                values: new object[] { new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 3, 7, 16, 51, 475, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvailableDateFrom", "AvailableDateTo", "PostedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 3, 7, 16, 51, 475, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvailableDateFrom", "AvailableDateTo", "Description", "PostedDate" },
                values: new object[] { new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "This surfboard will give you luck.", new DateTime(2022, 1, 3, 7, 16, 51, 475, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvailableDateFrom", "AvailableDateTo", "PostedDate" },
                values: new object[] { new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 3, 7, 16, 51, 475, DateTimeKind.Local).AddTicks(7612) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableDateFrom", "AvailableDateTo", "PostedDate" },
                values: new object[] { new DateTime(2021, 12, 11, 21, 40, 38, 63, DateTimeKind.Local).AddTicks(2210), new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 11, 21, 40, 38, 63, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableDateFrom", "AvailableDateTo", "PostedDate" },
                values: new object[] { new DateTime(2021, 12, 11, 21, 40, 38, 63, DateTimeKind.Local).AddTicks(2218), new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 11, 21, 40, 38, 63, DateTimeKind.Local).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvailableDateFrom", "AvailableDateTo", "PostedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 11, 21, 40, 38, 63, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvailableDateFrom", "AvailableDateTo", "PostedDate" },
                values: new object[] { new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 11, 21, 40, 38, 63, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvailableDateFrom", "AvailableDateTo", "Description", "PostedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "This surfboard will give you an unforgettable experience.", new DateTime(2021, 12, 11, 21, 40, 38, 63, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "RentalPosts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvailableDateFrom", "AvailableDateTo", "PostedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 11, 21, 40, 38, 63, DateTimeKind.Local).AddTicks(2250) });
        }
    }
}
