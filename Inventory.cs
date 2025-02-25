using Inventory_Management_System_Product;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_Inventory
{
    class Inventory
    {
        public List<Product> Products { get; }

        public Inventory()
        {
            Products = new List<Product>();

        }
        public void AddProduct()
        {
            double price;
            int quantity;
            Console.Write("Enter the product name : ");
            string name = Console.ReadLine() ?? string.Empty;
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Please enter valid name : ");
                name = Console.ReadLine() ?? string.Empty;
            }

            Console.Write("Enter the product price : ");
            string inputPrice = Console.ReadLine() ?? string.Empty;
            while (!double.TryParse(inputPrice, out price))
            {
                Console.Write("Please enter valid price : ");
                inputPrice = Console.ReadLine() ?? string.Empty;
            }

            Console.Write("Enter the product quantity : ");
            string inputQuantity = Console.ReadLine() ?? string.Empty;
            while (!int.TryParse(inputQuantity, out quantity))
            {
                Console.Write("Please enter valid quantity : ");
                inputQuantity = Console.ReadLine() ?? string.Empty;
            }
            Product product = new Product(name, price, quantity);
            Products.Add(product);
        }

        public void ShowAllProducts()
        {
            StringBuilder allProducts = new StringBuilder();

            if (Products != null)
            {
                foreach (Product product in Products)
                {
                    allProducts.AppendLine(product.ToString());
                }
            }

            Console.WriteLine(allProducts.ToString());
        }

        public void EditProduct()
        {
            Console.Write("Enter the product name to edit: ");
            // ?? : i use it to be sure that if the user dosnt enter name, make it empty.
            string searchName = Console.ReadLine() ?? string.Empty;
            Product? product = Products.Find(p => p.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.WriteLine($"Editing Product: {product.Name}");
            Console.Write("Enter new name (or press Enter to keep it the same): ");
            // ! : (null-forgiving operator) i use it to tell the compiler that im sure its not nulli (gnore null warnings).
            string newName = Console.ReadLine()!;
            // if the string not null or "" or " "...
            if (!string.IsNullOrWhiteSpace(newName))
            {
                product.Name = newName;
            }

            Console.Write("Enter new price (or press Enter to keep it the same): ");
            string priceInput = Console.ReadLine()!;
            // TryParse : to be sure that convert string is safe.
            if (double.TryParse(priceInput, out double newPrice))
            {
                product.Price = newPrice;
            }

            Console.Write("Enter new quantity (or press Enter to keep it the same): ");
            string quantityInput = Console.ReadLine()!;
            if (int.TryParse(quantityInput, out int newQuantity))
            {
                product.Quantity = newQuantity;
            }

            Console.WriteLine("Product updated successfully!");
        }


    }
}
