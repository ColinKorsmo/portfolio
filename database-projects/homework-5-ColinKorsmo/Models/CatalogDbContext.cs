using Microsoft.EntityFrameworkCore;

namespace homework_5_ColinKorsmo.Models
{
    public class CatalogDbContext : DbContext
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
