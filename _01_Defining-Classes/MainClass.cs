using System;

namespace _02_Laptop
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Laptop temp1 = new Laptop("Lenovo Whatever", 2999, new Battery("smotana", 1), "Lenovo", "Intel", 4, "Ati", "", "Full HD");

            Laptop temp2 = new Laptop("HP", 899.99);
            Battery batt = new Battery("Li-ION", 4);
            temp2.AddBattery(batt);

            Laptop temp3 = new Laptop("HP 500", 1499.99, new Battery("nqkakva bateriq", 2), "Hewlett-Packard");

            Console.WriteLine(temp1);
            Console.WriteLine(temp2);
            Console.WriteLine(temp3);
        }
    }
}

