using Microsoft.EntityFrameworkCore;

namespace homework_4_ColinKorsmo.Models
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=products.db");
        }
    }
}
