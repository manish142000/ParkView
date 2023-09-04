namespace ParkView.Models
{
    public interface IBookingRoom
    {
        public IEnumerable<Room> GetRoomByBookingId(int id);


    }
}
