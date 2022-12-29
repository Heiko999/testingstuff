using Microsoft.EntityFrameworkCore;

namespace Biletrado Reservations 
{
    public class ReservationDbContext : DbContext
    {
    public DbSet<Reservation> Reservations { get; set; }

        public MyDbContext(DbContextOptions<ReservationDbContext> options)
             : base(options)
        { 
        }
    }
}
