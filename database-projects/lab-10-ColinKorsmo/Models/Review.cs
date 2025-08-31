using System.ComponentModel.DataAnnotations;

namespace lab_10_ColinKorsmo.Models;

public class Review
{
    public int ReviewID { get; set; }
    
    [Range(1, 5)]
    public int Score { get; set; }

    public string ReviewText { get; set; } = string.Empty;  // Review text

    public int ProductID { get; set; }  

    public Product Product { get; set; } = default!;
}
