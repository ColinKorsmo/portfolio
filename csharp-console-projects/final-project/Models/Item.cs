using System;
using System.ComponentModel.DataAnnotations;

namespace final_project.Models;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int AspectId { get; set; }
    
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }
    public Aspect Aspect { get; set; }
    public bool IsSelected {get;set;}
}
