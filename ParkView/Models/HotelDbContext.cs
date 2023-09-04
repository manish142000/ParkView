
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

            // Seeding the hotels table
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    HotelId = 1,
                    Location = "Ooty",
                    Name = "ParkView Ooty"
                });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    HotelId = 2,
                    Location = "Darjeeling",
                    Name = "ParkView Darjeeling"
                });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    HotelId = 3,
                    Location = "Shimla",
                    Name = "ParkView Shimla"
                });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    HotelId = 4,
                    Location = "Manali",
                    Name = "ParkView Manali"
                });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    HotelId = 5,
                    Location = "Coorg",
                    Name = "ParkView Coorg"
                });

            // Seeding the roomCategories Table
            modelBuilder.Entity<RoomCategory>().HasData(
                new RoomCategory
                {
                    RoomCategoryId = 1,
                    CategoryName = "Presidential Suite",
                    DailyRate = 28000
                });

            modelBuilder.Entity<RoomCategory>().HasData(
                new RoomCategory
                {
                    RoomCategoryId = 2,
                    CategoryName = "Executive",
                    DailyRate = 20000
                });

            modelBuilder.Entity<RoomCategory>().HasData(
                new RoomCategory
                {
                    RoomCategoryId = 3,
                    CategoryName = "Super Deluxe",
                    DailyRate = 14000
                });

            modelBuilder.Entity<RoomCategory>().HasData(
                new RoomCategory
                {
                    RoomCategoryId = 4,
                    CategoryName = "Deluxe",
                    DailyRate = 8000
                });

            // Seeding the rooms table
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-PS01",
                    HotelId = 1,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-PS02",
                    HotelId = 1,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-PS03",
                    HotelId = 1,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-PS04",
                    HotelId = 1,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-PS05",
                    HotelId = 1,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-EX01",
                    HotelId = 1,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-EX02",
                    HotelId = 1,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-EX03",
                    HotelId = 1,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-EX04",
                    HotelId = 1,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-EX05",
                    HotelId = 1,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-EX06",
                    HotelId = 1,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-EX07",
                    HotelId = 1,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-EX08",
                    HotelId = 1,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-EX09",
                    HotelId = 1,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-EX10",
                    HotelId = 1,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });


            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD01",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD02",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD03",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD04",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD05",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD06",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD07",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD08",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD09",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD10",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD11",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD12",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD13",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD14",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD15",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD16",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD17",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD18",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD19",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-SD20",
                    HotelId = 1,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });


            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX01",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX02",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX03",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX04",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX05",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX06",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX07",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX08",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX09",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX10",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX11",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX12",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX13",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX14",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX15",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX16",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX17",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX18",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX19",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX20",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX21",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX22",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX23",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX24",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "O-DX25",
                    HotelId = 1,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });



            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-PS01",
                    HotelId = 2,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-PS02",
                    HotelId = 2,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-PS03",
                    HotelId = 2,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-PS04",
                    HotelId = 2,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-PS05",
                    HotelId = 2,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-EX01",
                    HotelId = 2,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-EX02",
                    HotelId = 2,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-EX03",
                    HotelId = 2,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-EX04",
                    HotelId = 2,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-EX05",
                    HotelId = 2,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-EX06",
                    HotelId = 2,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-EX07",
                    HotelId = 2,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-EX08",
                    HotelId = 2,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-EX09",
                    HotelId = 2,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-EX10",
                    HotelId = 2,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });


            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD01",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD02",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD03",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD04",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD05",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD06",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD07",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD08",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD09",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD10",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD11",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD12",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD13",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD14",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD15",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD16",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD17",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD18",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD19",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-SD20",
                    HotelId = 2,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });


            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX01",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX02",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX03",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX04",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX05",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX06",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX07",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX08",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX09",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX10",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX11",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX12",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX13",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX14",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX15",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX16",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX17",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX18",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX19",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX20",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX21",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX22",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX23",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX24",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "D-DX25",
                    HotelId = 2,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });


            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-PS01",
                    HotelId = 3,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-PS02",
                    HotelId = 3,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-PS03",
                    HotelId = 3,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-PS04",
                    HotelId = 3,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-PS05",
                    HotelId = 3,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-EX01",
                    HotelId = 3,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-EX02",
                    HotelId = 3,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-EX03",
                    HotelId = 3,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-EX04",
                    HotelId = 3,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-EX05",
                    HotelId = 3,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-EX06",
                    HotelId = 3,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-EX07",
                    HotelId = 3,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-EX08",
                    HotelId = 3,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-EX09",
                    HotelId = 3,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-EX10",
                    HotelId = 3,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });


            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD01",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD02",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD03",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD04",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD05",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD06",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD07",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD08",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD09",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD10",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD11",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD12",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD13",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD14",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD15",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD16",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD17",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD18",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD19",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-SD20",
                    HotelId = 3,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });


            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX01",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX02",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX03",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX04",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX05",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX06",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX07",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX08",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX09",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX10",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX11",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX12",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX13",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX14",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX15",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX16",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX17",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX18",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX19",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX20",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX21",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX22",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX23",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX24",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "S-DX25",
                    HotelId = 3,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });


            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-PS01",
                    HotelId = 4,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-PS02",
                    HotelId = 4,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-PS03",
                    HotelId = 4,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-PS04",
                    HotelId = 4,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-PS05",
                    HotelId = 4,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-EX01",
                    HotelId = 4,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-EX02",
                    HotelId = 4,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-EX03",
                    HotelId = 4,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-EX04",
                    HotelId = 4,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-EX05",
                    HotelId = 4,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-EX06",
                    HotelId = 4,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-EX07",
                    HotelId = 4,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-EX08",
                    HotelId = 4,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-EX09",
                    HotelId = 4,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-EX10",
                    HotelId = 4,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });


            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD01",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD02",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD03",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD04",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD05",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD06",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD07",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD08",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD09",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD10",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD11",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD12",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD13",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD14",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD15",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD16",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD17",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD18",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD19",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-SD20",
                    HotelId = 4,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });


            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX01",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX02",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX03",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX04",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX05",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX06",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX07",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX08",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX09",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX10",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX11",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX12",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX13",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX14",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX15",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX16",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX17",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX18",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX19",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX20",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX21",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX22",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX23",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX24",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "M-DX25",
                    HotelId = 4,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-PS01",
                    HotelId = 5,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-PS02",
                    HotelId = 5,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-PS03",
                    HotelId = 5,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-PS04",
                    HotelId = 5,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-PS05",
                    HotelId = 5,
                    RoomCategoryId = 1,
                    capacity = 4,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-EX01",
                    HotelId = 5,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-EX02",
                    HotelId = 5,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-EX03",
                    HotelId = 5,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-EX04",
                    HotelId = 5,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-EX05",
                    HotelId = 5,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-EX06",
                    HotelId = 5,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-EX07",
                    HotelId = 5,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-EX08",
                    HotelId = 5,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-EX09",
                    HotelId = 5,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-EX10",
                    HotelId = 5,
                    RoomCategoryId = 2,
                    capacity = 3,
                    Status = true
                });


            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD01",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD02",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD03",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD04",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD05",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD06",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD07",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD08",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD09",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD10",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD11",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD12",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD13",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD14",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD15",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD16",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD17",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD18",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD19",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-SD20",
                    HotelId = 5,
                    RoomCategoryId = 3,
                    capacity = 2,
                    Status = true
                });


            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX01",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX02",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX03",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX04",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX05",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX06",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX07",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX08",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX09",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX10",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX11",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX12",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX13",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX14",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX15",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX16",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX17",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX18",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX19",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX20",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX21",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX22",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX23",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX24",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = "C-DX25",
                    HotelId = 5,
                    RoomCategoryId = 4,
                    capacity = 2,
                    Status = true
                });
        }

    }
}
