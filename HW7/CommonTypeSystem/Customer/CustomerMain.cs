namespace Customers
{
    using System;
    using Enumerations;
    using System.Collections.Generic;

    class CustomerMain
    {
        static void Main()
        {
            Customer customer1 = new Customer("Test", "Person", "Person", 9408157645, "Sofia", "+359288906", "person@abv.bg", CustomerTypes.Onetime,
                new List<Payment>(){new Payment("Shampoo", 10m)});
            Customer customer2 = new Customer("Test2", "Person2", "Person2", 9405117555, "Sofia", "+359227396", "person2@abv.bg", CustomerTypes.Regular,
                new List<Payment>() { new Payment("SmartTv", 1000m), new Payment("Laptop", 2000.54m) });
            Console.WriteLine(customer1);
            Console.WriteLine(customer2);

            Console.WriteLine(customer2.CompareTo(customer1));
        }
    }
}
