namespace ParkView.Models
{
    public class SearchForm
    {
        public string destination { get; set; }

        public DateTime check_in { get; set; }

        public DateTime check_out { get; set; }

        public int numberRooms { get; set; }

        public int adultCount { get; set; }

        public int childrenCount { get; set; }
    }
}
