using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace backend_app.Models
{
    public class LoginContext:DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options) : base(options)
        {

        }
        public DbSet<User> Login { get; set; }

    }
}
