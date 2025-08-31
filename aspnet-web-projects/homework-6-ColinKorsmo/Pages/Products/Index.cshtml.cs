using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using homework_6_ColinKorsmo.Models;

namespace homework_6_ColinKorsmo.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly homework_6_ColinKorsmo.Models.AppDbContext _context;

        public IndexModel(homework_6_ColinKorsmo.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products
            .Include(p => p.Reviews)
            .ToListAsync();
        }
    }
}
