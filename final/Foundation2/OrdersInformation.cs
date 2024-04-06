using System;
using System.Collections.Generic;

public class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.GetTotalCost();
        }

        // Add shipping cost based on customer's location
        if (customer.IsInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }

        return Math.Round(totalPrice, 2); // Round to 2 decimal places
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in products)
        {
            packingLabel += $"{product.Name}, Price: ${product.Price:F2}, Quantity: {product.Quantity}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.Name}\n{customer.Address.ToString()}";
    }
}

public class Product
{
    private string name;
    private double price;
    private int quantity;

    public string Name { get => name; }
    public double Price { get => price; }
    public int Quantity { get => quantity; }

    public Product(string name, double price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    public double GetTotalCost()
    {
        return Math.Round(price * quantity, 2); // Round to 2 decimal places
    }
}

public class Customer
{
    private string name;
    private Address address;

    public string Name { get => name; }
    public Address Address { get => address; }

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}

public class Address
{
    private string streetAddress;
    private string city;
    private string stateProvince;
    private string country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country == "USA";
    }

    public override string ToString()
    {
        return $"{streetAddress}\n{city}, {stateProvince}\n{country}";
    }
}