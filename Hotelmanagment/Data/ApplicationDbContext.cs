using Hotelmanagment.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotelmanagment.Data
{
    public class ApplicationDbContext  : DbContext
    {
        public DbSet<Location> Locations { get; set; }
        public DbSet<HotelBook> HotelBooks { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
