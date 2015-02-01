namespace Company
{
    using System;
    using System.Collections.Generic;

    public class MainClass
    {
        public static void Main()
        {
            IList<Person> people = new List<Person>();

            SalesEmployee ivan = new SalesEmployee("007", "Ivan", "Hristov", 1000m, Departments.Sales);
            ivan.AddSale(new Sale("Kartofi", new DateTime(2014, 06, 28), 100m));
            ivan.AddSale(new Sale("Lutenitza", new DateTime(2014, 08, 15), 500m));
            people.Add(ivan);

            SalesEmployee pesho = new SalesEmployee("001", "Peter", "Petrov", 1500m, Departments.Sales);
            pesho.AddSale(new Sale("Sirene", new DateTime(2014, 02, 08), 5000m));
            people.Add(pesho);

            Developer kiro = new Developer("002", "Kiril", "Stamatov", 3000m, Departments.Production);
            kiro.AddProject(new Project("OOP", new DateTime(2015, 1, 20), "Learn how to OOP"));
            people.Add(kiro);

            Manager varban = new Manager("100", "Varban", "Varbanov", 10000m, Departments.Marketing);
            varban.AddEmployee(ivan);
            varban.AddEmployee(pesho);
            varban.AddEmployee(kiro);
            people.Add(varban);

            Customer maglaOOD = new Customer("500", "Krajbi", "Prodajbi", 5000m);
            people.Add(maglaOOD);

            foreach (var p in people)
            {
                Console.WriteLine(p + "\n");
            }

        }
    }
}
