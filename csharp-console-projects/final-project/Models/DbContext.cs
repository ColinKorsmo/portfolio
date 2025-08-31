using Microsoft.EntityFrameworkCore;

namespace final_project.Models
{
    public class FinalProjectDbContext : DbContext
    {
        public FinalProjectDbContext(DbContextOptions<FinalProjectDbContext> options)
            : base(options)
        { 

        }

        public DbSet<Aspect> Aspects { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<SelectedItem> SelectedItems {get; set;}
    }
}
