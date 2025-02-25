
using Inventory_Management_System_Inventory;
using Inventory_Management_System_Product;

Inventory inventory = new Inventory();
bool exit = false;

while (!exit)
{
    Console.WriteLine("\n=== Inventory Management System ===");
    Console.WriteLine("1. Add Product");
    Console.WriteLine("2. Edit Product");
    Console.WriteLine("3. Search Product");
    Console.WriteLine("4. List All Products");
    Console.WriteLine("5. Remove Product");
    Console.WriteLine("6. Exit");
    Console.Write("Choose an option: ");

    string choice = Console.ReadLine() ?? string.Empty;
    switch (choice)
    {
        case "1":
            inventory.AddProduct();
            break;
        case "2":
            inventory.EditProduct();
            break;
        case "3":
            inventory.SearchForProduct();
            break;
        case "4":
            inventory.ShowAllProducts();
            break;
        case "5":
            inventory.DeleteProduct();
            break;
        case "6":
            exit = true;
            Console.WriteLine("Exiting the program...");
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}