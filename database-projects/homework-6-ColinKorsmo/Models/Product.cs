using System.ComponentModel.DataAnnotations;

namespace homework_6_ColinKorsmo.Models;

public class Product
{
    public int ProductID { get; set; }  

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Description { get; set; } = string.Empty; 

    [Display(Name = "Product Image")]
    public string ImageURL { get; set; } = string.Empty;

    public List<Review> Reviews {get; set;} = default!;

}
