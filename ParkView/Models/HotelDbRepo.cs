namespace ParkView.Models
{
    public class HotelDbRepo : IHotel
    {
        private readonly HotelDbContext _context;

        public HotelDbRepo( HotelDbContext context )
        {
            _context = context;
        }

        public IEnumerable<Hotel> GetAllHotels()
        {
            return _context.hotels.ToList();
        }

        public Hotel GetHotelById(int id)
        {
            return _context.hotels.FirstOrDefault(x => x.HotelId == id);
        }

        public IEnumerable<Hotel> GetHotelsByLocation(string Location)
        {
            return _context.hotels.Where(x => x.Location.ToLower().Contains(Location.ToLower()));
        }
    }
}
