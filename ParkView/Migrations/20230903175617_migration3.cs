using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkView.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rooms_roomCategories_CategoryId",
                table: "rooms");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "roomCategories");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "rooms",
                newName: "RoomCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_rooms_CategoryId",
                table: "rooms",
                newName: "IX_rooms_RoomCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_rooms_roomCategories_RoomCategoryId",
                table: "rooms",
                column: "RoomCategoryId",
                principalTable: "roomCategories",
                principalColumn: "RoomCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rooms_roomCategories_RoomCategoryId",
                table: "rooms");

            migrationBuilder.RenameColumn(
                name: "RoomCategoryId",
                table: "rooms",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_rooms_RoomCategoryId",
                table: "rooms",
                newName: "IX_rooms_CategoryId");

            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "roomCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_rooms_roomCategories_CategoryId",
                table: "rooms",
                column: "CategoryId",
                principalTable: "roomCategories",
                principalColumn: "RoomCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
