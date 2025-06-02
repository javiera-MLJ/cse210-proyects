using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Philip Brown", new Address("456 Elm Street", "Los Angeles", "CA", "USA"));
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "A123", 500, 1));
        order1.AddProduct(new Product("Shirt", "C246", 19, 4));
        order1.AddProduct(new Product("Pants", "O475", 30, 4));
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine($"Total Price: {order1.TotalPrice()}\n");

        Console.WriteLine("-----------------------------\n");

        Customer customer2 = new Customer("Sam Stevenson", new Address("100 Main Street", "Toronto", "Ontario", "Canada"));
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Rings six pack", "T647", 12, 100));
        order2.AddProduct(new Product("Scrunchie", "B855", 1, 400));
        order2.AddProduct(new Product("Eyeliner", "U272", 6, 250));
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine($"Total Price: {order2.TotalPrice()}\n");

    }
}