// Customer.cs

using System;

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Customer ID: {CustomerId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
    }
}
