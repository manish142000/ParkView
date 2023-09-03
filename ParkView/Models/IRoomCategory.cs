namespace ParkView.Models
{
    public interface IRoomCategory
    {
        public IEnumerable<RoomCategory> GetAllCategories();

        public RoomCategory GetCategorybyId(int id);
    }
}
