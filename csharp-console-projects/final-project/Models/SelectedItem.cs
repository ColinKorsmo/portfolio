using System;
using System.ComponentModel.DataAnnotations;

namespace final_project.Models;

public class SelectedItem
{
    [Key]
    public int Id {get; set;}
    public string Name {get; set;}
    public decimal Price {get; set;}
    public Aspect Aspect {get; set;}
}