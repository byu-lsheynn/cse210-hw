using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        // ---- INITIALIZE ORDERS -----
        // Order 1: USA Order
        Address add1 = new Address("1600 Pennsylvania Ave NW", "Washington", "DC", "USA");
        Customer cust1 = new Customer("Jane Doe", add1);
        Order order1 = new Order(cust1);

        order1.AddProduct(new Product("Laptop Stand", "LPT-55", 45.00, 1));
        order1.AddProduct(new Product("Wireless Mouse", "MS-02", 25.50, 2));

        // Order 2: Non-USA Order
        Address add2 = new Address("456 Rue de Rivoli", "Paris", "Île-de-France", "France");
        Customer cust2 = new Customer("Jean-Luc Picard", add2);
        Order order2 = new Order(cust2);

        order2.AddProduct(new Product("Earl Grey Tea Box", "TEA-01", 12.00, 5));
        order2.AddProduct(new Product("Porcelain Teacup", "CUP-09", 18.50, 2));
        order2.AddProduct(new Product("Sugar Cubes Pack", "SGR-12", 4.00, 1));

        Console.WriteLine("\n==== ONLINE ORDERDING ====");
        Console.WriteLine(new string('-', 40));
        PrintOrderDetails(order1, "$5.00");
        PrintOrderDetails(order2, "$35.00");
    }

    private static void PrintOrderDetails(Order order, string shippinRate)
    {
        Console.WriteLine("            ORDER DETIALS            ");
        Console.WriteLine(new string('-', 40));
        Console.Write(order.GetPackingLabel());
        Console.WriteLine();
        Console.Write(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Shipping Applied: {shippinRate}");
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():N2}\n");
        Console.WriteLine(new string('-', 40));
    }
}