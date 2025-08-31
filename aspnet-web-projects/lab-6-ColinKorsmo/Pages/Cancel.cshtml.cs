using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab_6_ColinKorsmo.Models;

namespace lab_6_ColinKorsmo.Pages
{
    public class CancelModel : PageModel
    {
        [BindProperty]
        public Cancel? CancelObject { get; set; } = default;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("Confirmation");
        }
    }

}
