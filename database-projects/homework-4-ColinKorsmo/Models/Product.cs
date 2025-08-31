using System.ComponentModel.DataAnnotations;

namespace homework_4_ColinKorsmo.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"({ProductID}) {Name} - {Description} - ${Price:N2}";
        }
    }
}