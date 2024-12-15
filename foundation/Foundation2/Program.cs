using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("2281 E.Cedar Point Lane", "Idaho Falls", "ID", "USA");
        Customer customer = new Customer("Drew Stanley", address);


        Order order = new Order(customer);


        Product product1 = new Product("Laptop", "3678", 400f, 1);
        Product product2 = new Product("Phone", "3890", 300f, 2);


        order.AddItem(product1);
        order.AddItem(product2);
        Console.WriteLine("Order 1;");
        Console.WriteLine($"Total Price: ${order.TotalPrice()}");

        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.PackLabel());

    
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.ShipLabel());



        Address address2 = new Address("487 S 3rd W", "Rexburg", "ID", "USA");
        Customer customer2 = new Customer("Jonathan Marsh", address2);
        Order order2 = new Order(customer2);
        Product product3 = new Product("Music Stand", "2433", 20f, 3);
        Product product4 = new Product("Headphones", "6968", 10f, 2);
        order2.AddItem(product3);
        order2.AddItem(product4);

        Console.WriteLine("Order 2:");
        Console.WriteLine($"Total Price: ${order2.TotalPrice()}");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.PackLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ShipLabel());
    }
}