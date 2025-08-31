using System;
using System.ComponentModel.DataAnnotations;

namespace homework_7_ColinKorsmo.Models;

public class Order
{
    public int OrderID { get; set; }

    [Display(Name = "Customer Name")]
    public string CustomerName { get; set; } = string.Empty;

    [Display(Name = "Order Date")]
    [DataType(DataType.Date)]
    public DateTime OrderDate { get; set; }

    [Display(Name="Products in Order")]
    public List<ProductOrder>? ProductOrders {get; set;} = default!;
}

public class ProductOrder
{
    public int ProductID {get;set;}
    public int OrderID {get;set;}
    public Product Product {get;set;} = default!;
    public Order Order {get;set;} = default!;

}
