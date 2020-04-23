using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodOrdering.Data.Migrations.FoodOrderingDb
{
    public partial class addCustomerSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "DateRegistered", "Email", "FirstName", "LastName" },
                values: new object[] { "57b8d303-e29e-4433-8cb7-3d2f24a8e26e", new DateTime(2020, 4, 23, 9, 46, 18, 800, DateTimeKind.Utc).AddTicks(4083), "james@example.com", "James", "Anonymous" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "57b8d303-e29e-4433-8cb7-3d2f24a8e26e");
        }
    }
}
