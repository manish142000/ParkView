using System.ComponentModel.DataAnnotations.Schema;

namespace ParkView.Models
{
    public class Room
    {
        public string RoomId { get; set; }

        [ForeignKey("Hotel")]
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        [ForeignKey("RoomCategory")]
        public int RoomCategoryId { get; set; }
        public RoomCategory RoomCategory { get; set; }
    
        //public string RoomNumber { get; set; }

        public int capacity { get; set; }

        public bool Status { get; set; }
        
    }
}
