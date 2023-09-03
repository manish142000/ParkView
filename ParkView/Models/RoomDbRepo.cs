namespace ParkView.Models
{
    public class RoomDbRepo : IRoom
    {
        private readonly HotelDbContext _context;
        public RoomDbRepo( HotelDbContext context )
        {
            _context = context;
        }

        public IEnumerable<Room> GetAllRooms()
        {
            return _context.rooms.ToList();
        }

        public IEnumerable<Room> GetHotelsByRoomCategory(int CategoryId)
        {
            return _context.rooms.Where( x => x.RoomCategoryId == CategoryId );
        }

        public Room GetRoomById(string id)
        {
            return _context.rooms.FirstOrDefault(x => x.RoomId == id);
        }

        public IEnumerable<Room> GetRoomsByHotelId(int HotelId)
        {
            return _context.rooms.Where( x => x.HotelId == HotelId );
        }
    }
}
