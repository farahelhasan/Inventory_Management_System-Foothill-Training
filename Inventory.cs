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


    }
}
