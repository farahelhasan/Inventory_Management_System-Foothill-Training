using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_Product
{
    class Product
    {
        //  name, price, quantity
        private string name = string.Empty;
        private double price = 0;
        private int quantity = 1;

        public string Name
        {
            get { return name; }
            set
            {
                name = value.Length > 50 ? value[..50] : value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                price = value < 0 ? 0 : value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value <= 0 ? 1 : value; 
            }
        }

        public Product()
        {
        }
        public Product(string name) : this(name, 0, 1)
        {
        }
        public Product(string name, double price) : this(name, price, 1)
        {
        }
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price} - Quantity: {Quantity}";
        }
    }
}
