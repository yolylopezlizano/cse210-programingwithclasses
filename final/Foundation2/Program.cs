using System;
using System.Collections.Generic;


public class Program
{
    public static void Main(string[] args)
    {
        // Creating addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "NY", "Canada");

        // Creating customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Creating products
        Product product1 = new Product("Product A", 10.99, 2);
        Product product2 = new Product("Product B", 5.99, 3);
        Product product3 = new Product("Product C", 7.49, 1);

        // Creating orders
        Order order1 = new Order(customer1, new List<Product> { product1, product2, product3 });
        Order order2 = new Order(customer2, new List<Product> { product2, product3 });

        // Displaying results
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}

