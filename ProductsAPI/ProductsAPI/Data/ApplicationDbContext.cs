using Microsoft.EntityFrameworkCore;
using ProductsAPI.Entities;

namespace ProductsAPI.Data
{
    public class ApplicationDbContext
    {
        public class AppDbContext : DbContext
        {
            public DbSet<Product> Products { get; set; }
            protected readonly IConfiguration Configuration;
            public AppDbContext(IConfiguration configuration)
            {
                Configuration = configuration;
            }
            protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }
        }
    }
}
