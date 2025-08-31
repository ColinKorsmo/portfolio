using System;
using System.ComponentModel.DataAnnotations;

namespace lab_8_ColinKorsmo.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "First Name must be between 3 and 20 characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 and 20 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty; 

        [Required(ErrorMessage = "Admittance Date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Admittance Date")]
        public DateTime AdmitDate { get; set; } 

        [Required(ErrorMessage = "Description of Symptoms is required.")]
        [Display(Name = "Description of Symptoms")]
        public string SymptomDescription { get; set; } = string.Empty;
    }
}
