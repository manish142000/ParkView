using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkView.Migrations
{
    public partial class seededb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rooms_roomCategories_CategoryId",
                table: "rooms");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "roomCategories");

            migrationBuilder.DropColumn(
                name: "DiscountCouponName",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "bookings");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "rooms",
                newName: "RoomCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_rooms_CategoryId",
                table: "rooms",
                newName: "IX_rooms_RoomCategoryId");

            migrationBuilder.AddColumn<int>(
                name: "CouponId",
                table: "bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "discountCoupons",
                columns: table => new
                {
                    CouponId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouponName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_discountCoupons", x => x.CouponId);
                });

            migrationBuilder.InsertData(
                table: "hotels",
                columns: new[] { "HotelId", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Ooty", "ParkView Ooty" },
                    { 2, "Darjeeling", "ParkView Darjeeling" },
                    { 3, "Shimla", "ParkView Shimla" },
                    { 4, "Manali", "ParkView Manali" },
                    { 5, "Coorg", "ParkView Coorg" }
                });

            migrationBuilder.InsertData(
                table: "roomCategories",
                columns: new[] { "RoomCategoryId", "CategoryName", "DailyRate" },
                values: new object[,]
                {
                    { 1, "Presidential Suite", 28000 },
                    { 2, "Executive", 20000 },
                    { 3, "Super Deluxe", 14000 },
                    { 4, "Deluxe", 8000 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "C-DX01", 5, 4, true, 2 },
                    { "C-DX02", 5, 4, true, 2 },
                    { "C-DX03", 5, 4, true, 2 },
                    { "C-DX04", 5, 4, true, 2 },
                    { "C-DX05", 5, 4, true, 2 },
                    { "C-DX06", 5, 4, true, 2 },
                    { "C-DX07", 5, 4, true, 2 },
                    { "C-DX08", 5, 4, true, 2 },
                    { "C-DX09", 5, 4, true, 2 },
                    { "C-DX10", 5, 4, true, 2 },
                    { "C-DX11", 5, 4, true, 2 },
                    { "C-DX12", 5, 4, true, 2 },
                    { "C-DX13", 5, 4, true, 2 },
                    { "C-DX14", 5, 4, true, 2 },
                    { "C-DX15", 5, 4, true, 2 },
                    { "C-DX16", 5, 4, true, 2 },
                    { "C-DX17", 5, 4, true, 2 },
                    { "C-DX18", 5, 4, true, 2 },
                    { "C-DX19", 5, 4, true, 2 },
                    { "C-DX20", 5, 4, true, 2 },
                    { "C-DX21", 5, 4, true, 2 },
                    { "C-DX22", 5, 4, true, 2 },
                    { "C-DX23", 5, 4, true, 2 },
                    { "C-DX24", 5, 4, true, 2 },
                    { "C-DX25", 5, 4, true, 2 },
                    { "C-EX01", 5, 2, true, 3 },
                    { "C-EX02", 5, 2, true, 3 },
                    { "C-EX03", 5, 2, true, 3 },
                    { "C-EX04", 5, 2, true, 3 },
                    { "C-EX05", 5, 2, true, 3 },
                    { "C-EX06", 5, 2, true, 3 },
                    { "C-EX07", 5, 2, true, 3 },
                    { "C-EX08", 5, 2, true, 3 },
                    { "C-EX09", 5, 2, true, 3 },
                    { "C-EX10", 5, 2, true, 3 },
                    { "C-PS01", 5, 1, true, 4 },
                    { "C-PS02", 5, 1, true, 4 },
                    { "C-PS03", 5, 1, true, 4 },
                    { "C-PS04", 5, 1, true, 4 },
                    { "C-PS05", 5, 1, true, 4 },
                    { "C-SD01", 5, 3, true, 2 },
                    { "C-SD02", 5, 3, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "C-SD03", 5, 3, true, 2 },
                    { "C-SD04", 5, 3, true, 2 },
                    { "C-SD05", 5, 3, true, 2 },
                    { "C-SD06", 5, 3, true, 2 },
                    { "C-SD07", 5, 3, true, 2 },
                    { "C-SD08", 5, 3, true, 2 },
                    { "C-SD09", 5, 3, true, 2 },
                    { "C-SD10", 5, 3, true, 2 },
                    { "C-SD11", 5, 3, true, 2 },
                    { "C-SD12", 5, 3, true, 2 },
                    { "C-SD13", 5, 3, true, 2 },
                    { "C-SD14", 5, 3, true, 2 },
                    { "C-SD15", 5, 3, true, 2 },
                    { "C-SD16", 5, 3, true, 2 },
                    { "C-SD17", 5, 3, true, 2 },
                    { "C-SD18", 5, 3, true, 2 },
                    { "C-SD19", 5, 3, true, 2 },
                    { "C-SD20", 5, 3, true, 2 },
                    { "D-DX01", 2, 4, true, 2 },
                    { "D-DX02", 2, 4, true, 2 },
                    { "D-DX03", 2, 4, true, 2 },
                    { "D-DX04", 2, 4, true, 2 },
                    { "D-DX05", 2, 4, true, 2 },
                    { "D-DX06", 2, 4, true, 2 },
                    { "D-DX07", 2, 4, true, 2 },
                    { "D-DX08", 2, 4, true, 2 },
                    { "D-DX09", 2, 4, true, 2 },
                    { "D-DX10", 2, 4, true, 2 },
                    { "D-DX11", 2, 4, true, 2 },
                    { "D-DX12", 2, 4, true, 2 },
                    { "D-DX13", 2, 4, true, 2 },
                    { "D-DX14", 2, 4, true, 2 },
                    { "D-DX15", 2, 4, true, 2 },
                    { "D-DX16", 2, 4, true, 2 },
                    { "D-DX17", 2, 4, true, 2 },
                    { "D-DX18", 2, 4, true, 2 },
                    { "D-DX19", 2, 4, true, 2 },
                    { "D-DX20", 2, 4, true, 2 },
                    { "D-DX21", 2, 4, true, 2 },
                    { "D-DX22", 2, 4, true, 2 },
                    { "D-DX23", 2, 4, true, 2 },
                    { "D-DX24", 2, 4, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "D-DX25", 2, 4, true, 2 },
                    { "D-EX01", 2, 2, true, 3 },
                    { "D-EX02", 2, 2, true, 3 },
                    { "D-EX03", 2, 2, true, 3 },
                    { "D-EX04", 2, 2, true, 3 },
                    { "D-EX05", 2, 2, true, 3 },
                    { "D-EX06", 2, 2, true, 3 },
                    { "D-EX07", 2, 2, true, 3 },
                    { "D-EX08", 2, 2, true, 3 },
                    { "D-EX09", 2, 2, true, 3 },
                    { "D-EX10", 2, 2, true, 3 },
                    { "D-PS01", 2, 1, true, 4 },
                    { "D-PS02", 2, 1, true, 4 },
                    { "D-PS03", 2, 1, true, 4 },
                    { "D-PS04", 2, 1, true, 4 },
                    { "D-PS05", 2, 1, true, 4 },
                    { "D-SD01", 2, 3, true, 2 },
                    { "D-SD02", 2, 3, true, 2 },
                    { "D-SD03", 2, 3, true, 2 },
                    { "D-SD04", 2, 3, true, 2 },
                    { "D-SD05", 2, 3, true, 2 },
                    { "D-SD06", 2, 3, true, 2 },
                    { "D-SD07", 2, 3, true, 2 },
                    { "D-SD08", 2, 3, true, 2 },
                    { "D-SD09", 2, 3, true, 2 },
                    { "D-SD10", 2, 3, true, 2 },
                    { "D-SD11", 2, 3, true, 2 },
                    { "D-SD12", 2, 3, true, 2 },
                    { "D-SD13", 2, 3, true, 2 },
                    { "D-SD14", 2, 3, true, 2 },
                    { "D-SD15", 2, 3, true, 2 },
                    { "D-SD16", 2, 3, true, 2 },
                    { "D-SD17", 2, 3, true, 2 },
                    { "D-SD18", 2, 3, true, 2 },
                    { "D-SD19", 2, 3, true, 2 },
                    { "D-SD20", 2, 3, true, 2 },
                    { "M-DX01", 4, 4, true, 2 },
                    { "M-DX02", 4, 4, true, 2 },
                    { "M-DX03", 4, 4, true, 2 },
                    { "M-DX04", 4, 4, true, 2 },
                    { "M-DX05", 4, 4, true, 2 },
                    { "M-DX06", 4, 4, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "M-DX07", 4, 4, true, 2 },
                    { "M-DX08", 4, 4, true, 2 },
                    { "M-DX09", 4, 4, true, 2 },
                    { "M-DX10", 4, 4, true, 2 },
                    { "M-DX11", 4, 4, true, 2 },
                    { "M-DX12", 4, 4, true, 2 },
                    { "M-DX13", 4, 4, true, 2 },
                    { "M-DX14", 4, 4, true, 2 },
                    { "M-DX15", 4, 4, true, 2 },
                    { "M-DX16", 4, 4, true, 2 },
                    { "M-DX17", 4, 4, true, 2 },
                    { "M-DX18", 4, 4, true, 2 },
                    { "M-DX19", 4, 4, true, 2 },
                    { "M-DX20", 4, 4, true, 2 },
                    { "M-DX21", 4, 4, true, 2 },
                    { "M-DX22", 4, 4, true, 2 },
                    { "M-DX23", 4, 4, true, 2 },
                    { "M-DX24", 4, 4, true, 2 },
                    { "M-DX25", 4, 4, true, 2 },
                    { "M-EX01", 4, 2, true, 3 },
                    { "M-EX02", 4, 2, true, 3 },
                    { "M-EX03", 4, 2, true, 3 },
                    { "M-EX04", 4, 2, true, 3 },
                    { "M-EX05", 4, 2, true, 3 },
                    { "M-EX06", 4, 2, true, 3 },
                    { "M-EX07", 4, 2, true, 3 },
                    { "M-EX08", 4, 2, true, 3 },
                    { "M-EX09", 4, 2, true, 3 },
                    { "M-EX10", 4, 2, true, 3 },
                    { "M-PS01", 4, 1, true, 4 },
                    { "M-PS02", 4, 1, true, 4 },
                    { "M-PS03", 4, 1, true, 4 },
                    { "M-PS04", 4, 1, true, 4 },
                    { "M-PS05", 4, 1, true, 4 },
                    { "M-SD01", 4, 3, true, 2 },
                    { "M-SD02", 4, 3, true, 2 },
                    { "M-SD03", 4, 3, true, 2 },
                    { "M-SD04", 4, 3, true, 2 },
                    { "M-SD05", 4, 3, true, 2 },
                    { "M-SD06", 4, 3, true, 2 },
                    { "M-SD07", 4, 3, true, 2 },
                    { "M-SD08", 4, 3, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "M-SD09", 4, 3, true, 2 },
                    { "M-SD10", 4, 3, true, 2 },
                    { "M-SD11", 4, 3, true, 2 },
                    { "M-SD12", 4, 3, true, 2 },
                    { "M-SD13", 4, 3, true, 2 },
                    { "M-SD14", 4, 3, true, 2 },
                    { "M-SD15", 4, 3, true, 2 },
                    { "M-SD16", 4, 3, true, 2 },
                    { "M-SD17", 4, 3, true, 2 },
                    { "M-SD18", 4, 3, true, 2 },
                    { "M-SD19", 4, 3, true, 2 },
                    { "M-SD20", 4, 3, true, 2 },
                    { "O-DX01", 1, 4, true, 2 },
                    { "O-DX02", 1, 4, true, 2 },
                    { "O-DX03", 1, 4, true, 2 },
                    { "O-DX04", 1, 4, true, 2 },
                    { "O-DX05", 1, 4, true, 2 },
                    { "O-DX06", 1, 4, true, 2 },
                    { "O-DX07", 1, 4, true, 2 },
                    { "O-DX08", 1, 4, true, 2 },
                    { "O-DX09", 1, 4, true, 2 },
                    { "O-DX10", 1, 4, true, 2 },
                    { "O-DX11", 1, 4, true, 2 },
                    { "O-DX12", 1, 4, true, 2 },
                    { "O-DX13", 1, 4, true, 2 },
                    { "O-DX14", 1, 4, true, 2 },
                    { "O-DX15", 1, 4, true, 2 },
                    { "O-DX16", 1, 4, true, 2 },
                    { "O-DX17", 1, 4, true, 2 },
                    { "O-DX18", 1, 4, true, 2 },
                    { "O-DX19", 1, 4, true, 2 },
                    { "O-DX20", 1, 4, true, 2 },
                    { "O-DX21", 1, 4, true, 2 },
                    { "O-DX22", 1, 4, true, 2 },
                    { "O-DX23", 1, 4, true, 2 },
                    { "O-DX24", 1, 4, true, 2 },
                    { "O-DX25", 1, 4, true, 2 },
                    { "O-EX01", 1, 2, true, 3 },
                    { "O-EX02", 1, 2, true, 3 },
                    { "O-EX03", 1, 2, true, 3 },
                    { "O-EX04", 1, 2, true, 3 },
                    { "O-EX05", 1, 2, true, 3 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "O-EX06", 1, 2, true, 3 },
                    { "O-EX07", 1, 2, true, 3 },
                    { "O-EX08", 1, 2, true, 3 },
                    { "O-EX09", 1, 2, true, 3 },
                    { "O-EX10", 1, 2, true, 3 },
                    { "O-PS01", 1, 1, true, 4 },
                    { "O-PS02", 1, 1, true, 4 },
                    { "O-PS03", 1, 1, true, 4 },
                    { "O-PS04", 1, 1, true, 4 },
                    { "O-PS05", 1, 1, true, 4 },
                    { "O-SD01", 1, 3, true, 2 },
                    { "O-SD02", 1, 3, true, 2 },
                    { "O-SD03", 1, 3, true, 2 },
                    { "O-SD04", 1, 3, true, 2 },
                    { "O-SD05", 1, 3, true, 2 },
                    { "O-SD06", 1, 3, true, 2 },
                    { "O-SD07", 1, 3, true, 2 },
                    { "O-SD08", 1, 3, true, 2 },
                    { "O-SD09", 1, 3, true, 2 },
                    { "O-SD10", 1, 3, true, 2 },
                    { "O-SD11", 1, 3, true, 2 },
                    { "O-SD12", 1, 3, true, 2 },
                    { "O-SD13", 1, 3, true, 2 },
                    { "O-SD14", 1, 3, true, 2 },
                    { "O-SD15", 1, 3, true, 2 },
                    { "O-SD16", 1, 3, true, 2 },
                    { "O-SD17", 1, 3, true, 2 },
                    { "O-SD18", 1, 3, true, 2 },
                    { "O-SD19", 1, 3, true, 2 },
                    { "O-SD20", 1, 3, true, 2 },
                    { "S-DX01", 3, 4, true, 2 },
                    { "S-DX02", 3, 4, true, 2 },
                    { "S-DX03", 3, 4, true, 2 },
                    { "S-DX04", 3, 4, true, 2 },
                    { "S-DX05", 3, 4, true, 2 },
                    { "S-DX06", 3, 4, true, 2 },
                    { "S-DX07", 3, 4, true, 2 },
                    { "S-DX08", 3, 4, true, 2 },
                    { "S-DX09", 3, 4, true, 2 },
                    { "S-DX10", 3, 4, true, 2 },
                    { "S-DX11", 3, 4, true, 2 },
                    { "S-DX12", 3, 4, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "S-DX13", 3, 4, true, 2 },
                    { "S-DX14", 3, 4, true, 2 },
                    { "S-DX15", 3, 4, true, 2 },
                    { "S-DX16", 3, 4, true, 2 },
                    { "S-DX17", 3, 4, true, 2 },
                    { "S-DX18", 3, 4, true, 2 },
                    { "S-DX19", 3, 4, true, 2 },
                    { "S-DX20", 3, 4, true, 2 },
                    { "S-DX21", 3, 4, true, 2 },
                    { "S-DX22", 3, 4, true, 2 },
                    { "S-DX23", 3, 4, true, 2 },
                    { "S-DX24", 3, 4, true, 2 },
                    { "S-DX25", 3, 4, true, 2 },
                    { "S-EX01", 3, 2, true, 3 },
                    { "S-EX02", 3, 2, true, 3 },
                    { "S-EX03", 3, 2, true, 3 },
                    { "S-EX04", 3, 2, true, 3 },
                    { "S-EX05", 3, 2, true, 3 },
                    { "S-EX06", 3, 2, true, 3 },
                    { "S-EX07", 3, 2, true, 3 },
                    { "S-EX08", 3, 2, true, 3 },
                    { "S-EX09", 3, 2, true, 3 },
                    { "S-EX10", 3, 2, true, 3 },
                    { "S-PS01", 3, 1, true, 4 },
                    { "S-PS02", 3, 1, true, 4 },
                    { "S-PS03", 3, 1, true, 4 },
                    { "S-PS04", 3, 1, true, 4 },
                    { "S-PS05", 3, 1, true, 4 },
                    { "S-SD01", 3, 3, true, 2 },
                    { "S-SD02", 3, 3, true, 2 },
                    { "S-SD03", 3, 3, true, 2 },
                    { "S-SD04", 3, 3, true, 2 },
                    { "S-SD05", 3, 3, true, 2 },
                    { "S-SD06", 3, 3, true, 2 },
                    { "S-SD07", 3, 3, true, 2 },
                    { "S-SD08", 3, 3, true, 2 },
                    { "S-SD09", 3, 3, true, 2 },
                    { "S-SD10", 3, 3, true, 2 },
                    { "S-SD11", 3, 3, true, 2 },
                    { "S-SD12", 3, 3, true, 2 },
                    { "S-SD13", 3, 3, true, 2 },
                    { "S-SD14", 3, 3, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "S-SD15", 3, 3, true, 2 },
                    { "S-SD16", 3, 3, true, 2 },
                    { "S-SD17", 3, 3, true, 2 },
                    { "S-SD18", 3, 3, true, 2 },
                    { "S-SD19", 3, 3, true, 2 },
                    { "S-SD20", 3, 3, true, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookings_CouponId",
                table: "bookings",
                column: "CouponId");

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_discountCoupons_CouponId",
                table: "bookings",
                column: "CouponId",
                principalTable: "discountCoupons",
                principalColumn: "CouponId",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_bookings_discountCoupons_CouponId",
                table: "bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_rooms_roomCategories_RoomCategoryId",
                table: "rooms");

            migrationBuilder.DropTable(
                name: "discountCoupons");

            migrationBuilder.DropIndex(
                name: "IX_bookings_CouponId",
                table: "bookings");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX21");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX22");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX23");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX24");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX25");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-PS01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-PS02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-PS03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-PS04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-PS05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX21");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX22");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX23");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX24");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX25");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-PS01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-PS02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-PS03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-PS04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-PS05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX21");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX22");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX23");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX24");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX25");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-PS01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-PS02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-PS03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-PS04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-PS05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX21");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX22");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX23");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX24");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX25");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-PS01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-PS02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-PS03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-PS04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-PS05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX21");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX22");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX23");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX24");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX25");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-PS01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-PS02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-PS03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-PS04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-PS05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD20");

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "roomCategories",
                keyColumn: "RoomCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "roomCategories",
                keyColumn: "RoomCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "roomCategories",
                keyColumn: "RoomCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "roomCategories",
                keyColumn: "RoomCategoryId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "CouponId",
                table: "bookings");

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

            migrationBuilder.AddColumn<string>(
                name: "DiscountCouponName",
                table: "bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "DiscountPrice",
                table: "bookings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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
