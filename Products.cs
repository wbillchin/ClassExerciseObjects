using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExerciseObjects
{
    public abstract class Product
    {
        // Common properties for all products
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; private set; }

        public int UPC { get; set; }
        public string Manufacturer { get; set; }


        // Constructor
        public Product(string aName, decimal price, int quantityInStock)
        {
            Name = aName;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        // Method to update stock
        public void UpdateStock(int quantity)
        {
            QuantityInStock += quantity;
            Console.WriteLine($"{quantity} units added. New stock: {QuantityInStock}");
        }

        // Method to check availability
        public bool IsInStock()
        {
            return HasStock(1);
        }

        public bool HasStock(int aNumber)
        {
            return QuantityInStock >= aNumber;
        }


        // Abstract method for display, to be implemented by subclasses
        public abstract void DisplayDetails();
    }


    public class Book : Product
    {
        public string Author { get; private set; }
        public string ISBN { get; private set; }

        public Book(string name, decimal price, int quantityInStock, string author, string isbn)
            : base(name, price, quantityInStock)
        {
            Author = author;
            ISBN = isbn;
        }

        public string Publisher()
        {
            return Manufacturer;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Book: {Name} by {Author}");
            Console.WriteLine($"Price: ${Price}, Stock: {QuantityInStock}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }


    public class Clothing : Product
    {
        public string Size { get; private set; }
        public string Material { get; private set; }


        public Clothing(string name, decimal price, int quantityInStock, string size, string material)
            : base(name, price, quantityInStock)
        {
            Size = size;
            Material = material;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Clothing: {Name}, Size: {Size}");
            Console.WriteLine($"Price: ${Price}, Stock: {QuantityInStock}");
            Console.WriteLine($"Material: {Material}");
        }
    }

    class ProductManager
    {
        static void doSomething()
        {
            double priceCutOff = 99.5;
            // Create instances of each product type
            Book book = new Book("The Great Gatsby", 15.99m, 10, "F. Scott Fitzgerald", "1234567890");
            Clothing shirt = new Clothing("T-Shirt", 19.99m, 20, "M", "Cotton");

            book.Price = 99.99m;
            shirt.UpdateStock(50);

            Console.WriteLine("book publisher is " + book.Publisher());

            int quantityDesired = 20;

            if ( book.HasStock(quantityDesired) == true )
            {

                DateTime purchaseDateTime = DateTime.Now;

                Console.WriteLine("Invoice Year: " + purchaseDateTime.Year);
                int membershipJoinedYear = 2010;

                Console.WriteLine("Thanks for being a member for "
                    + (purchaseDateTime.Year - membershipJoinedYear));

                // been purchased
                book.UpdateStock(-quantityDesired);
            }

            // Display details of each product
            book.DisplayDetails();
            Console.WriteLine(book.IsInStock() ? "In Stock" : "Out of Stock");

            shirt.DisplayDetails();
            Console.WriteLine(shirt.IsInStock() ? "In Stock" : "Out of Stock");

            // Update stock for one product
            book.UpdateStock(5); // Adds 5 more books to the stock
        }
    }
}
