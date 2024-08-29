using Microsoft.EntityFrameworkCore;

namespace ReservationAppApi.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }

        public DbSet<Reservation> Reservations { get; set; }    
    }
}
