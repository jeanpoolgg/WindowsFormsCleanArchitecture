using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
    public class AppDbContext : DbContext
    {           
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BrandModel> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
