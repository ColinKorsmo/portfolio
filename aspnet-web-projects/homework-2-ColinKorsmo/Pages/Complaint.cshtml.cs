using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace homework_2_ColinKorsmo.Pages
{
    public class ComplaintModel : PageModel
    {
        private readonly ILogger<ComplaintModel> _logger;

        public ComplaintModel(ILogger<ComplaintModel> logger)
        {
            _logger = logger;
        }

        //product field
        [BindProperty]
        [Required(ErrorMessage = "Please select a product.")]
        public int? SelectedProduct { get; set; }

        //name field
        [BindProperty]
        [Required(ErrorMessage = "The Name field is required.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 30 characters.")]
        public string? Name { get; set; }

        //email field
        [BindProperty]
        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? Email { get; set; }

        //message field
        [BindProperty]
        [Required(ErrorMessage = "The Message field is required.")]
        [StringLength(500, ErrorMessage = "Message cannot exceed 500 characters.")]
        public string? Message { get; set; }

        public bool IsSubmitted { get; set; } = false;

        public string? ProductName { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Assign product number to product name
            ProductName = SelectedProduct switch
            {
                1 => "MindSync",
                2 => "Seraphine",
                3 => "SoulSear",
                4 => "Phantom Claw",
                _ => "Unknown Product"
            };

            // Log warning with complaint details
            _logger.LogWarning("Complaint received: Product: {ProductName}, Name: {Name}, Email: {Email}, Message: {Message}",
                ProductName, Name, Email, Message);

            IsSubmitted = true;

            return Page();
        }
    }
}
