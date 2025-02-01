using System;


    public class Program  
{  
    public static void Main(string[] args)  
    {  
        // Create addresses  
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");  
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");  

        // Create customers  
        Customer customer1 = new Customer("John Doe", address1);  
        Customer customer2 = new Customer("Jane Smith", address2);  

        // Create orders  
        Order order1 = new Order(customer1);  
        order1.AddProduct(new Product("Widget", 1, 3.00, 5));  
        order1.AddProduct(new Product("Gadget", 2, 10.00, 2));  

        Order order2 = new Order(customer2);  
        order2.AddProduct(new Product("Thingamajig", 3, 7.50, 3));  
        order2.AddProduct(new Product("Doohickey", 4, 15.00, 1));  

        // Display order details  
        Console.WriteLine(order1.GetPackingLabel());  
        Console.WriteLine(order1.GetShippingLabel());  
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}\n");  

        Console.WriteLine(order2.GetPackingLabel());  
        Console.WriteLine(order2.GetShippingLabel());  
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");  
    }  
}
