using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using homework_3_ColinKorsmo.Models;

namespace homework_3_ColinKorsmo.Pages
{
    public class CheckoutModel : PageModel
    {
        [BindProperty]
        public Order OrderObject { get; set; } = default;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/Confirmation");
        }
    }
}
