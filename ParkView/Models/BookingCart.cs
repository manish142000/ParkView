namespace ParkView.Models
{
    public class BookingCart
    {
        public int BookingCartId { get; set; }

        public List<Room> Rooms { get; set; }       


        public double total { get; set; } 
    }
}
