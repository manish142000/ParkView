using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkView.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountCouponName",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "bookings");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookings_discountCoupons_CouponId",
                table: "bookings");

            migrationBuilder.DropTable(
                name: "discountCoupons");

            migrationBuilder.DropIndex(
                name: "IX_bookings_CouponId",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "CouponId",
                table: "bookings");

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
        }
    }
}
