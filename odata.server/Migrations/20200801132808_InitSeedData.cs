using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace odata.server.Migrations
{
    public partial class InitSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogId", "Creation", "Name", "Url" },
                values: new object[] { 2, new DateTime(2020, 8, 1, 20, 28, 7, 838, DateTimeKind.Local).AddTicks(1161), "The second post", "https://google.com.vn" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 2);
        }
    }
}
