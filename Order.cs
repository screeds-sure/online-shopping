// Order.cs

using System;
using System.Collections.Generic;

public class Order
{
    public int OrderId { get; set; }
    public Customer Customer { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Order ID: {OrderId}");
        Customer.DisplayInfo();

        Console.WriteLine("Products in the order:");
        foreach (var product in Products)
        {
            product.DisplayInfo();
        }
    }
}
