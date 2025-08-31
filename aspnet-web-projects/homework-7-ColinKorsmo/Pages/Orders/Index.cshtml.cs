using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using homework_7_ColinKorsmo.Models;

namespace homework_7_ColinKorsmo.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly homework_7_ColinKorsmo.Models.OrderDbContext _context;

        public IndexModel(homework_7_ColinKorsmo.Models.OrderDbContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get;set;} = 1;
        public int PageSize {get;set;} = 10;
        public int TotalPages {get;set;}

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get;set;} = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string CurrentSearch {get;set;} = string.Empty;

        public async Task OnGetAsync()
        {
            var query = _context.Orders.Include(o => o.ProductOrders!).ThenInclude (po => po.Product).Select(o => o);

            if (!string.IsNullOrEmpty(CurrentSearch))
            {
                query = query.Where(o => o.CustomerName.ToUpper().Contains(CurrentSearch.ToUpper()));
            }
            switch (CurrentSort)
            {
                case "name_asc": query = query.OrderBy(o => o.CustomerName);
                break;
                case "name_desc": query = query.OrderByDescending(o => o.CustomerName);
                break;
            }
            switch (CurrentSort)
            {
                case "date_asc": query = query.OrderBy(o => o.OrderDate);
                break;
                case "date_desc": query = query.OrderByDescending(o => o.OrderDate);
                break;
            }

            TotalPages = (int)Math.Ceiling(_context.Orders.Count() / (double)PageSize);

            Order = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
