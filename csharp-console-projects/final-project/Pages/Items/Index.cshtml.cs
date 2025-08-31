using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using final_project.Models;

namespace final_project.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly final_project.Models.FinalProjectDbContext _context;

        public IndexModel(final_project.Models.FinalProjectDbContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int TotalPages {get; set;}

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;

        [BindProperty(SupportsGet =  true)]
        public string CurrentSearch {get; set;} = string.Empty;

        [BindProperty(SupportsGet = true)]
        public List<int> SelectedItems {get; set;} = new();

        public async Task OnGetAsync()
        {
            var query = _context.Items.Include(i => i.Aspect).Select(i => i);

            if (!string.IsNullOrEmpty(CurrentSearch))
            { 
                query = query.Where(i => i.Name.ToUpper().Contains(CurrentSearch.ToUpper()));
            }
            switch (CurrentSort)
            {
                case "items_asc":
                    query = query.OrderBy(i => i.Name);
                    break;
                case "items_desc":
                    query = query.OrderByDescending(i => i.Name);
                    break;
            }
            switch (CurrentSort)
            {
                case "aspect_asc":
                    query = query.OrderBy(i => i.Aspect);
                    break;
                case "aspect_desc":
                    query = query.OrderByDescending(i => i.Aspect);
                    break;
            }
            TotalPages = (int)Math.Ceiling(_context.Items.Count() / (double)PageSize);
            
            Item = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (SelectedItems != null && SelectedItems.Any())
            foreach (var itemId in SelectedItems)
            {
                var item = await _context.Items.FindAsync(itemId);
                if (item != null)
                {
                item.IsSelected = true;
                _context.Update(item);
                }
            }

        await _context.SaveChangesAsync();

        return RedirectToPage("/SelectedItems");
        }
    }
}
