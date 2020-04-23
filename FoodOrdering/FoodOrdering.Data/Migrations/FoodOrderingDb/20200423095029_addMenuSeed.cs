using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodOrdering.Data.Migrations.FoodOrderingDb
{
    public partial class addMenuSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "57b8d303-e29e-4433-8cb7-3d2f24a8e26e",
                column: "DateRegistered",
                value: new DateTime(2020, 4, 23, 9, 50, 28, 337, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "DateCreated", "Description", "Name", "ProductId" },
                values: new object[,]
                {
                    { "43692e17-12bb-4cd7-b688-b0a97d3188df", new DateTime(2020, 4, 23, 9, 50, 28, 340, DateTimeKind.Utc).AddTicks(3910), "Burger menu", "Burgers", null },
                    { "abb6df87-2b3f-4151-941e-76ed546b8caa", new DateTime(2020, 4, 23, 9, 50, 28, 340, DateTimeKind.Utc).AddTicks(5290), "Beverages menu", "Beverages", null },
                    { "f1c48325-b4b2-401c-9dae-c03bc4980b0e", new DateTime(2020, 4, 23, 9, 50, 28, 340, DateTimeKind.Utc).AddTicks(5331), "Combo meals menu", "Combo Meals", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "43692e17-12bb-4cd7-b688-b0a97d3188df");

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "abb6df87-2b3f-4151-941e-76ed546b8caa");

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "f1c48325-b4b2-401c-9dae-c03bc4980b0e");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "57b8d303-e29e-4433-8cb7-3d2f24a8e26e",
                column: "DateRegistered",
                value: new DateTime(2020, 4, 23, 9, 46, 18, 800, DateTimeKind.Utc).AddTicks(4083));
        }
    }
}
