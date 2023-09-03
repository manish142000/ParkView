using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkView.Models
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingId { get; set; }

        public string UserEmail { get; set; }

        public DateTime  CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        [ForeignKey("DiscountCoupon")]
        public int CouponId { get; set; }
        public DiscountCoupon DiscountCoupon { get; set; }

        public double TotalCost { get; set; } 
    }
}
