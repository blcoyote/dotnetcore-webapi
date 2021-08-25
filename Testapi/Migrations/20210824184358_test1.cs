using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37732ef8-7d9d-4227-be61-93bb9a1bc34e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a360de0-719a-4bbb-8cf1-952369e92df5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b1dd8eb6-32d6-489d-befb-54536592a4cd", "d1ffd4cb-5ab8-426b-b43c-e47c3d8c0cdc", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b5ebb72-c773-4e17-b1ef-1e6dc57386f9", "89f46ad1-b3e7-4532-8ab8-d771931a2255", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b5ebb72-c773-4e17-b1ef-1e6dc57386f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1dd8eb6-32d6-489d-befb-54536592a4cd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37732ef8-7d9d-4227-be61-93bb9a1bc34e", "f2169eff-4733-415e-9823-06eda1b9eeef", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a360de0-719a-4bbb-8cf1-952369e92df5", "3caebb1b-e9ae-4b0e-a1ea-dc3b7f2e7284", "Administrator", "ADMINISTRATOR" });
        }
    }
}
