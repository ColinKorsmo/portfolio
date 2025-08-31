using System.ComponentModel.DataAnnotations;

namespace lab_6_ColinKorsmo.Models
{
    public enum Product
    {
        MindSync,
        Seraphine,
        SoulSear,
        PhantomClaw
    }

    public class Cancel
    {
        [Required(ErrorMessage = "First Name is required.")]
        [Display(Name = "First Name")]
        [StringLength(60, MinimumLength = 3)]
        public string FirstName { get; set; } = default!;

        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last Name")]
        [StringLength(60, MinimumLength = 3)]
        public string LastName { get; set; } = default!;

        [Required(ErrorMessage = "Email Address is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; } = default!;

        [Required(ErrorMessage = "Phone Number is required.")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; } = default!;

        [Required(ErrorMessage = "Product selection is required.")]
        public Product? ProductName { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to the non-disclosure terms.")]
        [Display(Name = "Agree to non-disclosure terms.")]
        public bool AgreeToNDA { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to waive all liability.")]
        [Display(Name = "Agree to waive all liability.")]
        public bool AgreeToLiability { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to the early termination fee.")]
        [Display(Name = "Agree to early termination fee.")]
        public bool AgreeToFee { get; set; }
    }
}
