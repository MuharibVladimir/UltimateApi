using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UltimateApi.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "546328a0-f4aa-453f-9d9b-5d1f0c9f4be8", "cdd71d18-6f64-4530-bdb5-9e1a5d4f9327", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ae66e15-1cb4-4b97-9170-8967d5b358f8", "10d03384-acc2-4117-93f7-0d65a53d2b53", "Manager", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "546328a0-f4aa-453f-9d9b-5d1f0c9f4be8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ae66e15-1cb4-4b97-9170-8967d5b358f8");
        }
    }
}
