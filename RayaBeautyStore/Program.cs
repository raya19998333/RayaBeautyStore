using RayaBeautyStore.Context;
using RayaBeautyStore.Models;

namespace RayaBeautyStore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using var db = new ApplicationDbContext();
            db.Database.EnsureCreated();

            while (true)
            {
                Console.WriteLine("\n💄 Raya Beauty Store");
                Console.WriteLine("1 - Add Product");
                Console.WriteLine("2 - View Products");
                Console.WriteLine("3 - Place Order");
                Console.WriteLine("4 - Exit");
                Console.Write("Choose: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Category: ");
                        string cat = Console.ReadLine();

                        Console.Write("Price: ");
                        double price = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Is Available (true/false): ");
                        bool isAvailable = Convert.ToBoolean(Console.ReadLine());

                        Console.Write("Description: ");
                        string desc = Console.ReadLine();

                        db.Products.Add(new Product
                        {
                            Name = name,
                            Category = cat,
                            Price = price,
                            IsAvailable = isAvailable,
                            Description = desc
                        });

                        db.SaveChanges();
                        Console.WriteLine("✅ Product added!");
                        break;

                    case "2":
                        var products = db.Products.ToList();
                        Console.WriteLine("\n📦 Products:");
                        foreach (var p in products)
                            Console.WriteLine($"{p.ProductId}: {p.Name} - {p.Category} - ${p.Price} -" +
                                $" {(p.IsAvailable ? "Available" : "Out of Stock")} - {p.Description}");
                        break;

                    case "3":
                        Console.Write("Product ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        var product = db.Products.Find(id);
                        if (product == null)
                        {
                            Console.WriteLine("❌ Product not found");
                            break;
                        }

                        Console.Write("Quantity: ");
                        int qty = Convert.ToInt32(Console.ReadLine());

                        db.Orders.Add(new Order { ProductId = product.ProductId, Quantity = qty });
                        db.SaveChanges();
                        Console.WriteLine($"✅ Order placed! Total: ${product.Price * qty}");
                        break;

                    case "4":
                        Console.WriteLine("👋 Goodbye!");
                        return;

                    default:
                        Console.WriteLine("❌ Invalid choice");
                        break;
                }
            }
        }
    }
}