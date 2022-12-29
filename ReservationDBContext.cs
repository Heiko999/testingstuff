public class ReservationDbContext : DbContext
{
    public DbSet<Reservation> Reservations { get; set; }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    { }
}
