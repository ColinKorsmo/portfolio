using System;
using System.ComponentModel.DataAnnotations;

namespace final_project.Models;

public class Aspect
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Item> Items { get; set; }
}
