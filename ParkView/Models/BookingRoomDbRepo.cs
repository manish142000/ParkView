namespace ParkView.Models
{
    public class BookingRoomDbRepo : IBookingRoom
    {
        private readonly HotelDbContext _context;

        public BookingRoomDbRepo(HotelDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Room> GetRoomByBookingId(int id)
        {
            IEnumerable<BookingRoom> temp = _context.bookingRooms.Where( x => x.BookingId == id );

            List<Room> rooms = new List<Room> ();

            foreach( var item in temp)
            {
                rooms.Add(item.Room);
            }

            return rooms;
        }
    }
}
