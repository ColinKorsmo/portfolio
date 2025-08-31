using homework_4_ColinKorsmo.Models;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        using var context = new ProductDbContext();
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();
        
        SeedData.Initialize(context);

        while (true)
        {
            Console.WriteLine("(A)dd a product, (U)pdate a product, (R)emove a product, (L)ist all products");
            Console.Write("> ");
            var choice = Console.ReadLine()?.ToUpper();

            switch (choice)
            {
                case "A":
                    AddProduct(context);
                    break;
                case "L":
                    ListProducts(context);
                    break;
                case "U":
                    UpdateProduct(context);
                    break;
                case "R":
                    RemoveProduct(context);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddProduct(ProductDbContext context)
    {
        Console.Write("Enter a name for the new product: ");
        var name = Console.ReadLine();
        Console.Write("Enter a description: ");
        var description = Console.ReadLine();
        Console.Write("Enter a price: ");
        var price = decimal.Parse(Console.ReadLine()!);

        var product = new Product { Name = name!, Description = description!, Price = price };
        context.Products.Add(product);
        context.SaveChanges();
        Console.WriteLine("Product added.");
    }

    static void ListProducts(ProductDbContext context)
    {
        var products = context.Products.ToList();
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }

    static void UpdateProduct(ProductDbContext context)
    {
        Console.Write("Enter the Product ID to update: ");
        var id = int.Parse(Console.ReadLine()!);
        var product = context.Products.Find(id);
        
        if (product == null)
        {
            Console.WriteLine("Product not found.");
            return;
        }

        Console.Write($"Name [{product.Name}] (Leave empty for no change): ");
        var name = Console.ReadLine();
        Console.Write($"Description [{product.Description}] (Leave empty for no change): ");
        var description = Console.ReadLine();
        Console.Write($"Price [{product.Price}] (Leave empty for no change): ");
        var priceInput = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(name))
        {
            product.Name = name;
        }
        if (!string.IsNullOrWhiteSpace(description))
        {
            product.Description = description;
        }
        if (decimal.TryParse(priceInput, out var price))
        {
            product.Price = price;
        }

        context.SaveChanges();
    }

    static void RemoveProduct(ProductDbContext context)
    {
        Console.Write("Enter the Product ID to remove: ");
        var id = int.Parse(Console.ReadLine()!);
        var product = context.Products.Find(id);
        
        if (product == null)
        {
            Console.WriteLine("Product not found.");
            return;
        }

        Console.Write($"Are you sure you want to remove - {product} [Y/N]? ");
        var confirmation = Console.ReadLine()?.ToUpper();

        if (confirmation == "Y")
        {
            context.Products.Remove(product);
            context.SaveChanges();
            Console.WriteLine("Product removed.");
        }
        else
        {
            Console.WriteLine("Removal cancelled.");
        }
    }
}
