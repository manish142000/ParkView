namespace ParkView.Models
{
    public interface IHotel
    {

        public IEnumerable<Hotel> GetAllHotels();

        public Hotel GetHotelById(int id);

        public IEnumerable<Hotel> GetHotelsByLocation(string Location);
        
    }
}
