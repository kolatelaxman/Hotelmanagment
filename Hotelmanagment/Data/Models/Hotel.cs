namespace Hotelmanagment.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string location { get; set; }

        public string city { get; set; }

        public string address { get; set; }

        public int locationId { get; set; }
        public DateTime BookingDateTime { get; set; }

    }
}
