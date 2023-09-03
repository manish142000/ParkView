
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ParkView.Models
{
    public class HotelDbContext : IdentityDbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {

        }

        public DbSet<Hotel> hotels { get; set; }

        public DbSet<RoomCategory> roomCategories { get; set; }

        public DbSet<Room> rooms { get; set; }

        public DbSet<BookingRoom> bookingRooms { get; set; }

        public DbSet<Booking> bookings { get; set; }

        public DbSet<User> users { get; set; }

        public DbSet<DiscountCoupon> discountCoupons { get; set; }  


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
