using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using final_project.Models;

namespace final_project.Pages.Items
{
    public class CreateModel : PageModel
    {
        private readonly final_project.Models.FinalProjectDbContext _context;

        public CreateModel(final_project.Models.FinalProjectDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AspectId"] = new SelectList(_context.Aspects, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Item Item { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Items.Add(Item);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
