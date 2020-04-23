using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodOrdering.Data.Migrations.FoodOrderingDb
{
    public partial class addProductSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "57b8d303-e29e-4433-8cb7-3d2f24a8e26e",
                column: "DateRegistered",
                value: new DateTime(2020, 4, 23, 9, 57, 27, 884, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "43692e17-12bb-4cd7-b688-b0a97d3188df",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 9, 57, 27, 887, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "abb6df87-2b3f-4151-941e-76ed546b8caa",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 9, 57, 27, 887, DateTimeKind.Utc).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "f1c48325-b4b2-401c-9dae-c03bc4980b0e",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 9, 57, 27, 887, DateTimeKind.Utc).AddTicks(5068));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "Description", "MenuId", "Name", "Price" },
                values: new object[,]
                {
                    { "372e1e02-9777-4781-81ce-3a6f6d793f85", new DateTime(2020, 4, 23, 9, 57, 27, 887, DateTimeKind.Utc).AddTicks(8763), "Very delicious hotdog", "43692e17-12bb-4cd7-b688-b0a97d3188df", "Hotdog", 15.00m },
                    { "59e94b90-76e9-42ab-9c3c-6c8121d0f303", new DateTime(2020, 4, 23, 9, 57, 27, 887, DateTimeKind.Utc).AddTicks(9874), "Bun with cheese filling", "43692e17-12bb-4cd7-b688-b0a97d3188df", "CheeseBurger", 75.00m },
                    { "5bcbd116-bd35-44b8-a16e-f7cee41ce669", new DateTime(2020, 4, 23, 9, 57, 27, 888, DateTimeKind.Utc).AddTicks(23), "Potato fried fries", "43692e17-12bb-4cd7-b688-b0a97d3188df", "French Fries", 60.00m },
                    { "ef485769-1125-499a-b816-35ca59505d82", new DateTime(2020, 4, 23, 9, 57, 27, 888, DateTimeKind.Utc).AddTicks(79), "Coca cola", "abb6df87-2b3f-4151-941e-76ed546b8caa", "Coke", 25.00m },
                    { "b09869b7-4c60-4ccf-a890-fbcfc209b763", new DateTime(2020, 4, 23, 9, 57, 27, 888, DateTimeKind.Utc).AddTicks(126), "Cold Sprite", "abb6df87-2b3f-4151-941e-76ed546b8caa", "Sprite", 23.00m },
                    { "ce9f0db6-6f15-42ed-be33-d1c26c4a8842", new DateTime(2020, 4, 23, 9, 57, 27, 888, DateTimeKind.Utc).AddTicks(185), "Cold Tea", "abb6df87-2b3f-4151-941e-76ed546b8caa", "Iced Tea", 20.00m },
                    { "2487dc90-94da-4fcc-a258-6875119aae8d", new DateTime(2020, 4, 23, 9, 57, 27, 888, DateTimeKind.Utc).AddTicks(233), "1pc chicken with coke", "f1c48325-b4b2-401c-9dae-c03bc4980b0e", "Chicken Combo Meal", 104.00m },
                    { "1c39961e-8bfb-4ef7-a923-7e1da1b5c544", new DateTime(2020, 4, 23, 9, 57, 27, 888, DateTimeKind.Utc).AddTicks(280), "1pc pork with ice tea/coke", "f1c48325-b4b2-401c-9dae-c03bc4980b0e", "Pork Combo", 125.00m },
                    { "8482fa30-d72b-4ba5-9ac5-c72359c9a2c9", new DateTime(2020, 4, 23, 9, 57, 27, 888, DateTimeKind.Utc).AddTicks(328), "1pc fish fillet with sprite", "f1c48325-b4b2-401c-9dae-c03bc4980b0e", "Fish Combo", 155.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c39961e-8bfb-4ef7-a923-7e1da1b5c544");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2487dc90-94da-4fcc-a258-6875119aae8d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "372e1e02-9777-4781-81ce-3a6f6d793f85");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "59e94b90-76e9-42ab-9c3c-6c8121d0f303");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5bcbd116-bd35-44b8-a16e-f7cee41ce669");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8482fa30-d72b-4ba5-9ac5-c72359c9a2c9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b09869b7-4c60-4ccf-a890-fbcfc209b763");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ce9f0db6-6f15-42ed-be33-d1c26c4a8842");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef485769-1125-499a-b816-35ca59505d82");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "57b8d303-e29e-4433-8cb7-3d2f24a8e26e",
                column: "DateRegistered",
                value: new DateTime(2020, 4, 23, 9, 50, 28, 337, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "43692e17-12bb-4cd7-b688-b0a97d3188df",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 9, 50, 28, 340, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "abb6df87-2b3f-4151-941e-76ed546b8caa",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 9, 50, 28, 340, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "f1c48325-b4b2-401c-9dae-c03bc4980b0e",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 9, 50, 28, 340, DateTimeKind.Utc).AddTicks(5331));
        }
    }
}
