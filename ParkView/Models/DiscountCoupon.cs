using System.ComponentModel.DataAnnotations;

namespace ParkView.Models
{
    public class DiscountCoupon
    {
        [Key]
        public int CouponId { get; set; }

        public string CouponName { get; set; }

        public int DiscountAmount { get; set; }
    }
}
