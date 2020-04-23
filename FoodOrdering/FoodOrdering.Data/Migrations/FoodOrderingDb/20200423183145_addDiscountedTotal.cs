using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodOrdering.Data.Migrations.FoodOrderingDb
{
    public partial class addDiscountedTotal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DiscountedTotal",
                table: "Orders",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: "6a06d7c6-6cac-46b7-8581-2a93f0b17c1b",
                columns: new[] { "DateCreated", "Validity" },
                values: new object[] { new DateTime(2020, 4, 23, 18, 31, 43, 967, DateTimeKind.Utc).AddTicks(725), new DateTime(2021, 4, 23, 18, 31, 43, 967, DateTimeKind.Utc).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "57b8d303-e29e-4433-8cb7-3d2f24a8e26e",
                column: "DateRegistered",
                value: new DateTime(2020, 4, 23, 18, 31, 43, 963, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "43692e17-12bb-4cd7-b688-b0a97d3188df",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 31, 43, 966, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "abb6df87-2b3f-4151-941e-76ed546b8caa",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 31, 43, 966, DateTimeKind.Utc).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "f1c48325-b4b2-401c-9dae-c03bc4980b0e",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 31, 43, 966, DateTimeKind.Utc).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c39961e-8bfb-4ef7-a923-7e1da1b5c544",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 31, 43, 966, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2487dc90-94da-4fcc-a258-6875119aae8d",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 31, 43, 966, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "372e1e02-9777-4781-81ce-3a6f6d793f85",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 31, 43, 966, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "59e94b90-76e9-42ab-9c3c-6c8121d0f303",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 31, 43, 966, DateTimeKind.Utc).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5bcbd116-bd35-44b8-a16e-f7cee41ce669",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 31, 43, 966, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8482fa30-d72b-4ba5-9ac5-c72359c9a2c9",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 31, 43, 966, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b09869b7-4c60-4ccf-a890-fbcfc209b763",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 31, 43, 966, DateTimeKind.Utc).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ce9f0db6-6f15-42ed-be33-d1c26c4a8842",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 31, 43, 966, DateTimeKind.Utc).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef485769-1125-499a-b816-35ca59505d82",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 31, 43, 966, DateTimeKind.Utc).AddTicks(8200));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountedTotal",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: "6a06d7c6-6cac-46b7-8581-2a93f0b17c1b",
                columns: new[] { "DateCreated", "Validity" },
                values: new object[] { new DateTime(2020, 4, 23, 18, 30, 59, 404, DateTimeKind.Utc).AddTicks(4296), new DateTime(2021, 4, 23, 18, 30, 59, 404, DateTimeKind.Utc).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "57b8d303-e29e-4433-8cb7-3d2f24a8e26e",
                column: "DateRegistered",
                value: new DateTime(2020, 4, 23, 18, 30, 59, 400, DateTimeKind.Utc).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "43692e17-12bb-4cd7-b688-b0a97d3188df",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 30, 59, 403, DateTimeKind.Utc).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "abb6df87-2b3f-4151-941e-76ed546b8caa",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 30, 59, 403, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "f1c48325-b4b2-401c-9dae-c03bc4980b0e",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 30, 59, 403, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c39961e-8bfb-4ef7-a923-7e1da1b5c544",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 30, 59, 404, DateTimeKind.Utc).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2487dc90-94da-4fcc-a258-6875119aae8d",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 30, 59, 404, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "372e1e02-9777-4781-81ce-3a6f6d793f85",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 30, 59, 403, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "59e94b90-76e9-42ab-9c3c-6c8121d0f303",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 30, 59, 404, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5bcbd116-bd35-44b8-a16e-f7cee41ce669",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 30, 59, 404, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8482fa30-d72b-4ba5-9ac5-c72359c9a2c9",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 30, 59, 404, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b09869b7-4c60-4ccf-a890-fbcfc209b763",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 30, 59, 404, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ce9f0db6-6f15-42ed-be33-d1c26c4a8842",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 30, 59, 404, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef485769-1125-499a-b816-35ca59505d82",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 18, 30, 59, 404, DateTimeKind.Utc).AddTicks(726));
        }
    }
}
