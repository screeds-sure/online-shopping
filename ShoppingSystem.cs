// ShoppingSystem.cs

using System;

class ShoppingSystem
{
    static void Main()
    {
        // Create products
        Product product1 = new Product { ProductId = 1, Name = "Laptop", Price = 999.99m };
        Product product2 = new Product { ProductId = 2, Name = "Smartphone", Price = 499.99m };

        // Create customers
        Customer customer1 = new Customer { CustomerId = 101, Name = "Alice", Email = "alice@example.com" };
        Customer customer2 = new Customer { CustomerId = 102, Name = "Bob", Email = "bob@example.com" };

        // Create orders
        Order order1 = new Order { OrderId = 1001, Customer = customer1 };
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order { OrderId = 1002, Customer = customer2 };
        order2.AddProduct(product2);

        // Display information
        Console.WriteLine("Order Information:");
        order1.DisplayInfo();
        Console.WriteLine();
        order2.DisplayInfo();
    }
}
