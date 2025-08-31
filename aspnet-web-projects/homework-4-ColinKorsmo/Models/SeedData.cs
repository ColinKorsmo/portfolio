using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace homework_4_ColinKorsmo.Models
{
    public static class SeedData
    {
        public static void Initialize(ProductDbContext context)
        {
            if (context.Products.Any())
            {
                return;
            }

            context.Products.AddRange(
                new Product { Name = "MindSync", Description = "Neural Implant Device", Price = 1995.99m },
                new Product { Name = "Seraphine", Description = "AI Assistant", Price = 200.00m },
                new Product { Name = "SoulSear", Description = "Military Grade Death Ray", Price = 4300000000.00m },
                new Product { Name = "PhantomClaw", Description = "High Quality Gaming Mouse", Price = 99.95m }
            );

            context.SaveChanges();
        }
    }
}
