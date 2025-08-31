using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace homework_5_ColinKorsmo.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        public string ImageURL { get; set; }
    }
}
