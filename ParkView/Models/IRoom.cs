namespace ParkView.Models
{
    public interface IRoom
    {
        public IEnumerable<Room> GetAllRooms();

        public Room GetRoomById(string id);

        public IEnumerable<Room> GetHotelsByRoomCategory(int CategoryId );

        public IEnumerable<Room> GetRoomsByHotelId(int HotelId);
    }
}
