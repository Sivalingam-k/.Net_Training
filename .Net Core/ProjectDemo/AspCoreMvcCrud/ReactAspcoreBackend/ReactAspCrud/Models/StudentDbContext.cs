using Microsoft.EntityFrameworkCore;

namespace ReactAspCrud.Models
{
    public class StudentDbContext : DbContext//Database Connection
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }


        public DbSet<Student> Students { get; set; }
        public DbSet<Student1> Student1s { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

    }
}
