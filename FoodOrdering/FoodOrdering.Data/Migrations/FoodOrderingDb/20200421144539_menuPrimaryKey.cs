using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodOrdering.Data.Migrations.FoodOrderingDb
{
    public partial class menuPrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductId",
                table: "Menus",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menus_ProductId",
                table: "Menus",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Products_ProductId",
                table: "Menus",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Products_ProductId",
                table: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_Menus_ProductId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Menus");
        }
    }
}
