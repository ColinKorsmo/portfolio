using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using homework_5_ColinKorsmo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq; 

namespace homework_5_ColinKorsmo.Pages
{
    public class BuyNowModel : PageModel
    {
        private readonly CatalogDbContext _context;

        public BuyNowModel(CatalogDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        [DataType(DataType.Currency)]
        public decimal Shipping { get; set; } = 19.99M;

        public decimal Tax => Product.Price * 0.0825M;

        public decimal Total => Product.Price + Shipping + Tax;

        [DataType(DataType.Date)]
        public DateTime StartDeliveryDate { get; set; } = DateTime.Now.AddDays(7);

        [DataType(DataType.Date)]
        public DateTime EndDeliveryDate { get; set; }

        public void OnGet(int id)
        {
            Product = _context.Products.FirstOrDefault(p => p.ProductID == id);
        
            EndDeliveryDate = StartDeliveryDate.AddDays(7);
        }
    }
}
