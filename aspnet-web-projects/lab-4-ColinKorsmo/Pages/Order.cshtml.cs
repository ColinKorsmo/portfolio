using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_4_ColinKorsmo.Pages;

public class OrderModel : PageModel
{   
    [BindProperty]
    public string Name { get; set; } = string.Empty;

    [BindProperty]
    [Display(Name = "Serial Number")]
    [Range(1000, 99999, ErrorMessage = "Serial Number must be between 1,000 and 99,999.")]
    public int SerialNumber { get; set; }

    [BindProperty]
    [Display(Name = "Credit card number")]
    [CreditCard(ErrorMessage = "Invalid credit card number.")]
    public string CreditCardNumber { get; set; } = string.Empty;

    public bool IsSubmitted { get; set; } = false;

    public void OnPost()
    {
        if (ModelState.IsValid)
            {
                IsSubmitted = true;
            }

    }
}