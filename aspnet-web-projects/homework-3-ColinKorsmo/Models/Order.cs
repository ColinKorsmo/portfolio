using System.ComponentModel.DataAnnotations;

namespace homework_3_ColinKorsmo.Models
{
    public class Order
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "The First Name field is required.")]

        public required string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "The Last Name field is required.")]
        public required string LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "The Email field is required.")]
        public required string Email { get; set; }
        [Required(ErrorMessage = "The Address field is required.")]
        public required string Address { get; set; }

        [Required(ErrorMessage = "The Country field is required.")]
        [Display(Name = "Country")]
        public Country? Country { get; set; }

        [Required(ErrorMessage = "The State field is required.")]
        [Display(Name = "State")]
        public State? State { get; set; }

        [RegularExpression(@"\d{5}$", ErrorMessage = "Invalid Zip Code")]
        [Display(Name = "Zip Code")]
        public required string Zip { get; set; }

        [Display(Name = "Shipping address is the same as my billing address")]
        public bool SameShippingInfo { get; set; }

        [Display(Name = "Save this information for next time")]
        public bool SaveInformation { get; set; }

        [Required]
        public required PaymentType PaymentType { get; set; }

        [Display(Name = "Name on card")]
        [Required(ErrorMessage = "The Name on card field is required.")]
        public required string NameOnCard { get; set; }

        [CreditCard]
        [Required(ErrorMessage = "The Credit Card number field field is required.")]
        [Display(Name = "Credit card number")]
        public required string CreditCardNumber { get; set; }
    }

    public enum Country
    {
        [Display(Name = "Australia")]
        Australia,
        [Display(Name = "Canada")]
        Canada,
        [Display(Name = "Mexico")]
        Mexico,
        [Display(Name = "United Kingdom")]
        UnitedKingdom,
        [Display(Name = "United States")]
        UnitedStates
    }

    public enum State
    {
        [Display(Name = "Alaska")]
        Alaska,
        [Display(Name = "Florida")]
        Florida,
        [Display(Name = "New York")]
        NewYork,
        [Display(Name = "Texas")]
        Texas,
        [Display(Name = "Utah")]
        Utah
    }

    public enum PaymentType
    {
        
        [Display(Name = "Credit Card")]
        CreditCard,
        [Display(Name = "Debit Card")]
        DebitCard,
        [Display(Name = "PayPal")]
        PayPal
    }
}
