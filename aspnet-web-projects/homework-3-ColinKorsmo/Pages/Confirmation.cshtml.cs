using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using homework_3_ColinKorsmo.Models;

namespace homework_3_ColinKorsmo.Pages
{
    public class ConfirmationModel : PageModel
    {
        private readonly ILogger<ConfirmationModel> _logger;

        [BindProperty]
        public Order OrderObject { get; set; } = default!;

        public ConfirmationModel(ILogger<ConfirmationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(Order orderObject)
        {
            OrderObject = orderObject;
            _logger.LogWarning($"OnGet() - {OrderObject.FirstName}");
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return RedirectToPage("/Checkout");
            }

            return Page();
        }
    }
}
