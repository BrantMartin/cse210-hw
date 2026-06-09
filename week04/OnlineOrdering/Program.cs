using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressOne = new Address("555 Real Lane", "Realcity", "Realstate", "Realcountry");
        Customer customerOne = new Customer("John Doe", addressOne);
        Order orderOne = new Order(customerOne);
        orderOne.addProduct(new Product("Laptop", 1001, 1399.99, 20));
        orderOne.addProduct(new Product("Headphones", 1002, 299.99, 120));
        Address addressTwo = new Address("555 Fake Lane", "Fakecity", "Fakestate", "Fakecountry");
        Customer customerTwo = new Customer("Jane Doe", addressTwo);
        Order orderTwo = new Order(customerTwo);
        orderTwo.addProduct(new Product("Refrigerator", 1003, 1699.99, 10));
        orderTwo.addProduct(new Product("Watch", 1004, 199.99, 120));

        Console.WriteLine("First order: \n");
        Console.WriteLine($"Packing Label: {orderOne.getPackingLabel()}");
        Console.WriteLine($"Shipping Label: {orderOne.getShippingLabel()}");
        Console.WriteLine($"Total: ${Math.Round(orderOne.calcTotal(), 2)}\n");
        Console.WriteLine("Second order: \n");
        Console.WriteLine($"Packing Label: {orderTwo.getPackingLabel()}");
        Console.WriteLine($"Shipping Label: {orderTwo.getShippingLabel()}");
        Console.WriteLine($"Total: ${Math.Round(orderTwo.calcTotal(), 2)}");
    }
}