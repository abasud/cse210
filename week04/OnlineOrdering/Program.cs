using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address();
        address1.SetAddress("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer(address1);
        customer1.SetCustomer("Martin", "Johnson");
        Product product1 = new Product();
        product1.SetProduct("Shampoo 300 ml", "8765", 15.30, 2);
        Product product2 = new Product();
        product2.SetProduct("Bath soap 200 gr", "8766", 5.50, 3);
        Product product3 = new Product();
        product3.SetProduct("Toothpaste 150 gr", "8767", 9.90, 2);
        Order order1 = new Order(customer1, address1);
        order1.SetProductList(product1);
        order1.SetProductList(product2);
        order1.SetProductList(product3);
        Console.WriteLine();
        order1.PackingLabel();
        Console.WriteLine();
        order1.ShippingLabel();
        Console.WriteLine();
        Console.WriteLine($"Total price: ${order1.TotalCost()}");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

        Address address2 = new Address();
        address2.SetAddress("456 Oak Ave", "Greenville", "TX", "Canada");
        Customer customer2 = new Customer(address2);
        customer2.SetCustomer("Laura", "Smith");
        Product productA = new Product();
        productA.SetProduct("Hair Conditioner 250 ml", "9001", 12.75, 1);
        Product productB = new Product();
        productB.SetProduct("Face Wash 150 ml", "9002", 8.20, 2);
        Product productC = new Product();
        productC.SetProduct("Hand Cream 100 ml", "9003", 6.40, 1);
        Order order2 = new Order(customer2, address2);
        order2.SetProductList(productA);
        order2.SetProductList(productB);
        order2.SetProductList(productC);
        Console.WriteLine();
        order2.PackingLabel();
        Console.WriteLine();
        order2.ShippingLabel();
        Console.WriteLine();
        Console.WriteLine($"Total price: ${order2.TotalCost()}");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

    }
}