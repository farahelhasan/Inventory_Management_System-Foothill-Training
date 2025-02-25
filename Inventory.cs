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
        
    }
}
