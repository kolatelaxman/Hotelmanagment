namespace Hotelmanagment.Models.Dtos
{
    public class HotelDto
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string location { get; set; } = null!;
        public DateTime BookingDateTime { get; set; }

    }
}
