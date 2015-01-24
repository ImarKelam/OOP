using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_SULS
{
   public class SULSTest
    {
        public static void Main()
        {
            List<Student> students = new List<Student>
            {
                new OnsiteStudent("Peter", "Petrov", 25, "000001", 3.4m, "OOP"),
                new OnsiteStudent("Anna", "Kirova", 27, "000002", 5.8m, "OOP"),
                new OnlineStudent("Kiril", "Hristov", 30, "000006", 4.65m, "OOP"),
                new GraduateStudent("Ivan", "Ivanov", 29, "000005", 5.17m),
                new DropoutStudent("Ceco", "Avramov", 22, "000015", "Playing CounterStrike during lectures", 2.89m)
            };

            //sorting current students by average grade
            var currentStudents = students
                                    .Where(st => st is CurrentStudent)
                                    .OrderBy(st => st.AverageGrade)
                                    .Select(st => new
                                        {
                                            Name = st.FirstName + " " + st.LastName,
                                            Age = st.Age,
                                            ID = st.StudentNumber,
                                            AvrGrade = st.AverageGrade
                                        });

            foreach (var st in currentStudents)
            {
                Console.WriteLine(st);
            }


            Console.WriteLine();

            //printing the Reapply() method of a dropout student
            DropoutStudent ceco = new DropoutStudent("Ceco", "Avramov", 22, "000015", "Playing CounterStrike during lectures", 2.89m);
            ceco.Reapply();

            Console.WriteLine();

            //adding and deleting courses for junior and senior trainers
            JuniorTrainer acho = new JuniorTrainer("Angel", "Georgiev", 28);
            SeniorTrainer nakov = new SeniorTrainer("Svetlin", "Nakov", 35);

            acho.CreateCourse("JS Apps");
            acho.CreateCourse("Java Basics");
            Console.WriteLine("Courses that Angel is training: " + String.Join(", ", acho.Courses) + "\n");

            nakov.CreateCourse("OOP");
            nakov.CreateCourse("Advanced Java");
            Console.WriteLine("Courses that Nakov is training: " + String.Join(", ", nakov.Courses) + "\n");
            nakov.DeleteCourse("OOP");
            Console.WriteLine("Courses that Nakov is training: " + String.Join(", ", nakov.Courses));
        }
    }
}
