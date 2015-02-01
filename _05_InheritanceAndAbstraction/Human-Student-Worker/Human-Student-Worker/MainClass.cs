namespace Human_Student_Worker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MainClass
    {
        public static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Urko", "Avramov", "00005"),
                new Student("Kiril", "Ivanov", "00003"),
                new Student("Peter", "Georgiev", "00002"),
                new Student("Stamat", "Apostolov", "00006"),
                new Student("Zahari", "Stoyanov", "00001"),
                new Student("Parvan", "Parvanov", "00009"),
                new Student("Penka", "Jordanova", "00010"),
                new Student("Mara", "Zaharieva", "00004"),
                new Student("Stanka", "Kalpazanka", "00008"),
                new Student("Izabela", "Letisieva", "00007")
            };

            List<Worker> workers = new List<Worker>
            {
                new Worker("Angel", "Bojinov", 100m, 10),
                new Worker("Zlatka", "Atanasova", 200m, 8),
                new Worker("Antonia", "Pavlova", 300m, 8),
                new Worker("Kiril", "Zlatanov", 150m, 6),
                new Worker("Stamat", "Stankov", 150m, 8),
                new Worker("Blagoy", "Bakalov", 250m, 12),
                new Worker("Evstasii", "Papadopolus", 500m, 4),
                new Worker("Genadii", "Genadiev", 1500m, 4),
                new Worker("Daniela", "Sotirova", 2000m, 8),
                new Worker("Peter", "Petrov", 80m, 8)
            };


            var studentsSortedByFacNum = students.OrderBy(st => st.FacultyNumber);
            foreach (var st in studentsSortedByFacNum)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine("\n\n");

            var workersSortedByHourPay = workers.OrderBy(st => st.MoneyPerHour());
            foreach (var w in workersSortedByHourPay)
            {
                Console.WriteLine(w);
            }

            Console.WriteLine("\n\n");


            var studentsList = students.Select(st => new { FirstName = st.FirstName, LastName = st.LastName });
            var workersList = workers.Select(w => new {FirstName = w.FirstName, LastName = w.LastName });

            var merged = studentsList
                            .Union(workersList)
                            .OrderBy(p => p.FirstName)
                            .ThenBy(p => p.LastName);

            foreach (var person in merged)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }

            Console.WriteLine();
             
        }
    }
}
