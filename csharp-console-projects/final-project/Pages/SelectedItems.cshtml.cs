using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using final_project.Models;

namespace final_project.Pages
{
    public class SelectedItemsModel : PageModel
    {
        private readonly FinalProjectDbContext _context;

        public SelectedItemsModel(FinalProjectDbContext context)
        {
            _context = context;
        }

        public IList<Item> SelectedItems { get; set; } = new List<Item>();

        [BindProperty]
        public List<int> SelectedItemsIds { get; set; } = new List<int>();

        public void OnPost()
        {
            if (SelectedItemsIds != null && SelectedItemsIds.Any())
            {
                SelectedItems = _context.Items
                    .Where(i => SelectedItemsIds.Contains(i.Id))
                    .ToList();
            }

        }
    }
}
