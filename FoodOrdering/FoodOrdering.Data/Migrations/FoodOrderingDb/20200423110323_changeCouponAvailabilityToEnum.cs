﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodOrdering.Data.Migrations.FoodOrderingDb
{
    public partial class changeCouponAvailabilityToEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IsUsed",
                table: "Coupons",
                nullable: true,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: "6a06d7c6-6cac-46b7-8581-2a93f0b17c1b",
                columns: new[] { "DateCreated", "Validity" },
                values: new object[] { new DateTime(2020, 4, 23, 11, 3, 22, 160, DateTimeKind.Utc).AddTicks(7618), new DateTime(2021, 4, 23, 11, 3, 22, 160, DateTimeKind.Utc).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "57b8d303-e29e-4433-8cb7-3d2f24a8e26e",
                column: "DateRegistered",
                value: new DateTime(2020, 4, 23, 11, 3, 22, 158, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "43692e17-12bb-4cd7-b688-b0a97d3188df",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 11, 3, 22, 160, DateTimeKind.Utc).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "abb6df87-2b3f-4151-941e-76ed546b8caa",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 11, 3, 22, 160, DateTimeKind.Utc).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "f1c48325-b4b2-401c-9dae-c03bc4980b0e",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 11, 3, 22, 160, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c39961e-8bfb-4ef7-a923-7e1da1b5c544",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 11, 3, 22, 160, DateTimeKind.Utc).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2487dc90-94da-4fcc-a258-6875119aae8d",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 11, 3, 22, 160, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "372e1e02-9777-4781-81ce-3a6f6d793f85",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 11, 3, 22, 160, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "59e94b90-76e9-42ab-9c3c-6c8121d0f303",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 11, 3, 22, 160, DateTimeKind.Utc).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5bcbd116-bd35-44b8-a16e-f7cee41ce669",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 11, 3, 22, 160, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8482fa30-d72b-4ba5-9ac5-c72359c9a2c9",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 11, 3, 22, 160, DateTimeKind.Utc).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b09869b7-4c60-4ccf-a890-fbcfc209b763",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 11, 3, 22, 160, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ce9f0db6-6f15-42ed-be33-d1c26c4a8842",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 11, 3, 22, 160, DateTimeKind.Utc).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef485769-1125-499a-b816-35ca59505d82",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 11, 3, 22, 160, DateTimeKind.Utc).AddTicks(5032));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "IsUsed",
                table: "Coupons",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: "6a06d7c6-6cac-46b7-8581-2a93f0b17c1b",
                columns: new[] { "DateCreated", "Validity" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(7518), new DateTime(2021, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "57b8d303-e29e-4433-8cb7-3d2f24a8e26e",
                column: "DateRegistered",
                value: new DateTime(2020, 4, 23, 10, 39, 38, 831, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "43692e17-12bb-4cd7-b688-b0a97d3188df",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "abb6df87-2b3f-4151-941e-76ed546b8caa",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "f1c48325-b4b2-401c-9dae-c03bc4980b0e",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c39961e-8bfb-4ef7-a923-7e1da1b5c544",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2487dc90-94da-4fcc-a258-6875119aae8d",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "372e1e02-9777-4781-81ce-3a6f6d793f85",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "59e94b90-76e9-42ab-9c3c-6c8121d0f303",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5bcbd116-bd35-44b8-a16e-f7cee41ce669",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8482fa30-d72b-4ba5-9ac5-c72359c9a2c9",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b09869b7-4c60-4ccf-a890-fbcfc209b763",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ce9f0db6-6f15-42ed-be33-d1c26c4a8842",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef485769-1125-499a-b816-35ca59505d82",
                column: "DateCreated",
                value: new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(5268));
        }
    }
}
