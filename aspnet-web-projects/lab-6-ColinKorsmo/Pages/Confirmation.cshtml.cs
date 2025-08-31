using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab_6_ColinKorsmo.Models;

namespace lab_6_ColinKorsmo.Pages
{
    public class ConfirmationModel : PageModel
    {
        private readonly ILogger<ConfirmationModel> _logger;

        [BindProperty]
        public Cancel CancelObject { get; set; } = default!;

        public ConfirmationModel(ILogger<ConfirmationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(Cancel cancelObject)
        {
            CancelObject = cancelObject; 
            _logger.LogWarning($"OnGet() - {CancelObject.FirstName}");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("OnPost() Invalid Model State. Returning to previous page.");
                return RedirectToPage("/Cancel");
            }

            _logger.LogWarning($"OnPost() - {CancelObject.FirstName}");
            return Page();
        }
    }
}
