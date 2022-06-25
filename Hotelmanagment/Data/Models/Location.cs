using System.ComponentModel.DataAnnotations;

namespace Hotelmanagment.Models
{
    public class Location
    {
        public int Id { get; set; }
        [StringLength(100)]

        public string Name { get; set; }
        [StringLength(100)]
         

        public string hotelname { get; set; }
    }
}
