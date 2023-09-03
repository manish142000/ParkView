namespace ParkView.Models
{
    public class RoomCategoryDbRepo : IRoomCategory
    {
        private readonly HotelDbContext _context;
        public RoomCategoryDbRepo( HotelDbContext context )
        {
            _context = context;
        }

        public IEnumerable<RoomCategory> GetAllCategories()
        {
            return _context.roomCategories.ToList();
        }

        public RoomCategory GetCategorybyId(int id)
        {
            return _context.roomCategories.FirstOrDefault(x => x.RoomCategoryId == id);
        }
    }
}
