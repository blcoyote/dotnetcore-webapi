using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class roles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05b77e88-6420-417a-bd0e-609673df41cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e33f3ac-fc5e-4575-99ec-35d756cfba03");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37732ef8-7d9d-4227-be61-93bb9a1bc34e", "f2169eff-4733-415e-9823-06eda1b9eeef", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a360de0-719a-4bbb-8cf1-952369e92df5", "3caebb1b-e9ae-4b0e-a1ea-dc3b7f2e7284", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "05b77e88-6420-417a-bd0e-609673df41cf", "4eef8d07-9803-4ab0-935c-51fcfd4c62fb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e33f3ac-fc5e-4575-99ec-35d756cfba03", "96be7ee0-55eb-419f-b718-7beb1b20adfd", "Administrator", "ADMINISTRATOR" });
        }
    }
}
