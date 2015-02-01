using System.Collections.Generic;

namespace Customer
{
    using System;

    public class MainClass
    {
        public static void Main()
        {
            Customer pesho1 = new Customer("Peter", "Ivanov", "Petrov", "8010201020", "AAA 5", "0888 123 456", "pesho@gmail.com",
                new List<Payment>{new Payment("Vnoska", 150.99)}, CustomerType.OneTime);

            Customer pesho2 = (Customer) pesho1.Clone();

            Console.WriteLine(pesho1.Equals(pesho2));
            Console.WriteLine(pesho1.CompareTo(pesho2) + "\n");

            pesho2.Id = "8010201021";

            Console.WriteLine(pesho1.Equals(pesho2));
            Console.WriteLine(pesho1.CompareTo(pesho2) + "\n");

        }
    }
}
