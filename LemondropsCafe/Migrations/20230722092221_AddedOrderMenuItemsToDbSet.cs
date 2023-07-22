using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LemondropsCafe.Migrations
{
    /// <inheritdoc />
    public partial class AddedOrderMenuItemsToDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderMenuItem_MenuItems_MenuItemId",
                table: "OrderMenuItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderMenuItem_Orders_OrderId",
                table: "OrderMenuItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderMenuItem",
                table: "OrderMenuItem");

            migrationBuilder.RenameTable(
                name: "OrderMenuItem",
                newName: "OrderMenuItems");

            migrationBuilder.RenameIndex(
                name: "IX_OrderMenuItem_MenuItemId",
                table: "OrderMenuItems",
                newName: "IX_OrderMenuItems_MenuItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderMenuItems",
                table: "OrderMenuItems",
                columns: new[] { "OrderId", "MenuItemId" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMenuItems_MenuItems_MenuItemId",
                table: "OrderMenuItems",
                column: "MenuItemId",
                principalTable: "MenuItems",
                principalColumn: "MenuItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMenuItems_Orders_OrderId",
                table: "OrderMenuItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderMenuItems_MenuItems_MenuItemId",
                table: "OrderMenuItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderMenuItems_Orders_OrderId",
                table: "OrderMenuItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderMenuItems",
                table: "OrderMenuItems");

            migrationBuilder.RenameTable(
                name: "OrderMenuItems",
                newName: "OrderMenuItem");

            migrationBuilder.RenameIndex(
                name: "IX_OrderMenuItems_MenuItemId",
                table: "OrderMenuItem",
                newName: "IX_OrderMenuItem_MenuItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderMenuItem",
                table: "OrderMenuItem",
                columns: new[] { "OrderId", "MenuItemId" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMenuItem_MenuItems_MenuItemId",
                table: "OrderMenuItem",
                column: "MenuItemId",
                principalTable: "MenuItems",
                principalColumn: "MenuItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMenuItem_Orders_OrderId",
                table: "OrderMenuItem",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
