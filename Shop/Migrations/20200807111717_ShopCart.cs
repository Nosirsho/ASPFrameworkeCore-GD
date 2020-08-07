using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class ShopCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shopCartItems_Car_carid",
                table: "shopCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_shopCartItems",
                table: "shopCartItems");

            migrationBuilder.RenameTable(
                name: "shopCartItems",
                newName: "ShopCartItem");

            migrationBuilder.RenameIndex(
                name: "IX_shopCartItems_carid",
                table: "ShopCartItem",
                newName: "IX_ShopCartItem_carid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopCartItem",
                table: "ShopCartItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCartItem_Car_carid",
                table: "ShopCartItem",
                column: "carid",
                principalTable: "Car",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCartItem_Car_carid",
                table: "ShopCartItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopCartItem",
                table: "ShopCartItem");

            migrationBuilder.RenameTable(
                name: "ShopCartItem",
                newName: "shopCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShopCartItem_carid",
                table: "shopCartItems",
                newName: "IX_shopCartItems_carid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_shopCartItems",
                table: "shopCartItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_shopCartItems_Car_carid",
                table: "shopCartItems",
                column: "carid",
                principalTable: "Car",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
