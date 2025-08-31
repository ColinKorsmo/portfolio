using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using homework_5_ColinKorsmo.Models;
using Microsoft.Extensions.Logging; 
using System.Collections.Generic; 
using System.Threading.Tasks;
using System.Linq; 


namespace homework_5_ColinKorsmo.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly CatalogDbContext _context; 
        private readonly ILogger<ProductsModel> _logger;

        public ProductsModel(CatalogDbContext context, ILogger<ProductsModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IList<Product> Products { get; set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();

            _logger.LogInformation("Retrieved {ProductCount} products from the database.", Products.Count);
        }
    }
}
