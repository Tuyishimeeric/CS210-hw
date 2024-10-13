using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Alice Smith", address1);
        Customer customer2 = new Customer("Bob Johnson", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.99m, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "P003", 199.99m, 1));
        order2.AddProduct(new Product("USB-C Cable", "P004", 15.99m, 3));

        // Display order details for Order 1
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.TotalCost():F2}");
        Console.WriteLine();

        // Display order details for Order 2
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.TotalCost():F2}");
    }
}
