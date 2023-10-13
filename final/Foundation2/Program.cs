class Program
{
    static void Main()
    {
        Address address1 = new Address("4110 Kingston Dr", "Anchorage", "AK", "USA", "93423");
        Customer customer1 = new Customer("Mandy Chadwick", address1);

        Address address2 = new Address("4110 Hobson Street", "Turnington", "VN", "New Zealand", "43235");
        Customer customer2 = new Customer("Anna Fry", address2);

        Product product1 = new Product("Cheese Grater", "D743", 3.00, 2);
        Product product2 = new Product("Makeup Remover", "B333", 4.00, 1);
        Product product3 = new Product("Rake", "W1653", 3.00, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine($"{customer1.GetName()}");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("Order 1 Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine();

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine($"{customer2.GetName()}");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("Order 2 Total Cost: $" + order2.CalculateTotalCost());
    }
}