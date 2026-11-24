using Form_Api.Model;
using Microsoft.EntityFrameworkCore;

namespace Form_Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Signupform> signupforms { get; set; }
    }
}
