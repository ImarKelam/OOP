namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentTests
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Kiril", "Petrov", 25, "010201340506", "+359 888 123456", "kiro@abv.bg", new List<int> {4, 6, 4}, 3),
                new Student("Peter", "Nikolov", 30, "010131440424", "+359 2 111222", "pesho@gmail.com", new List<int> {3, 4, 3}, 3),
                new Student("Cecka", "Atanasova", 22, "010201440774", "+359 888 564789", "ceca@planeta.bg", new List<int> {5, 5, 6}, 2),
                new Student("Bobby", "Turboto", 37, "010201540222", "+359 888 456713", "bobby@yahoo.co.uk", new List<int> {6, 6, 6}, 1),
                new Student("Anna", "Colova", 40, "010201440676", "+359 888 222333", "anna@btv.bg", new List<int> {2, 2, 3}, 2),
            };

            //problem 4
            Console.WriteLine("Problem 4 - students from group 2\n");
            //variant 1
            //var groupTwoStudents = students.Where(student => student.GroupNumber == 2)
            //                                .OrderBy(student => student.FirstName)
            //                                .Select(student => student);
            //variant 2
            var groupTwoStudents =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            foreach (var student in groupTwoStudents)
            {
                Console.WriteLine(student);
            }
                 

            //problem 5
            Console.WriteLine("\n\nProblem 5 - students by first and last name\n");
            //variant 1
            //var groupFirstLastName = students.Where(student => student.FirstName[0] < student.LastName[0])
            //                                .OrderBy(student => student.FirstName);
            //variant2
            var groupFirstLastName =
                from student in students
                where student.FirstName[0] < student.LastName[0]
                orderby student.FirstName
                select student;

            foreach (var student in groupFirstLastName)
            {
                Console.WriteLine(student);
            }

            //problem 6
            Console.WriteLine("\n\nProblem 6 - students by age\n");
            //variant 1
            //var namesAndAge = students.Where(student => (student.Age >= 18 && student.Age <= 24))
            //                        .Select(student => new { firstName = student.FirstName, lastName = student.LastName, age = student.Age });
            //variant 2
            var namesAndAge =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                orderby student.FirstName
                select new { firstName = student.FirstName, lastName = student.LastName, age = student.Age };

            foreach (var student in namesAndAge)
            {
                Console.WriteLine(student.ToString());
            }

            //problem 7
            Console.WriteLine("\n\nProblem 7 - Sort students\n");
            //variant 1
            var namesInDescendingOrder = students.OrderByDescending(student => student.FirstName)
                                                   .ThenByDescending(student => student.LastName);
            //variant 2
            //var namesInDescendingOrder =
            //    from student in students
            //    orderby student.FirstName descending
            //    select student;

            foreach (var student in namesInDescendingOrder)
            {
                Console.WriteLine(student);
            }

            //problem 8
            Console.WriteLine("\n\nProblem 8 - Sort students by email\n");
            var emailOrder =
                from student in students
                where student.Email.EndsWith("@abv.bg")
                select student;

            foreach (var student in emailOrder)
            {
                Console.WriteLine(student);
            }

            //problem 9
            Console.WriteLine("\n\nProblem 9 - Sort students by 02 phone\n");
            var phoneOrder =
                from student in students
                where student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") || student.Phone.StartsWith("+359 2")
                select student;

            foreach (var student in phoneOrder)
            {
                Console.WriteLine(student);
            }

            //problem 10
            Console.WriteLine("\n\nProblem 10 - Sort excellent students\n");
            var excelentStudents =
                from student in students
                where student.Marks.Contains(6)
                select new { Name = student.FirstName + " " + student.LastName, Grades = student.Marks };


            foreach (var student in excelentStudents)
            {
                string output = student.Name + " Marks: " + string.Join(", ", student.Grades);
                Console.WriteLine(output);
            }

            //problem 11
            Console.WriteLine("\n\nProblem 11 - Sort weak students\n");
            var weakStudents =
                from student in students
                where student.Marks.Count(grade => grade == 2) == 2
                select new { Name = student.FirstName + " " + student.LastName, Grades = student.Marks };

            foreach (var student in weakStudents)
            {
                string output = student.Name + " Marks: " + string.Join(", ", student.Grades);
                Console.WriteLine(output);
            }

            //problem 12
            Console.WriteLine("\n\nProblem 12 - Students Enrolled in 2014\n");
            var enroledIn2014 = students.Where(student => student.FacultyNumber[5].Equals('1') && student.FacultyNumber[6].Equals('4'))
                                        .Select(student => new { Grades = student.Marks });

            foreach (var student in enroledIn2014)
            {
                Console.WriteLine(string.Join(", ", student.Grades));
            }

            //problem 13
            Console.WriteLine("\n\nProblem 13 - Students by groups\n");

            students[0].GroupName = "Alpha";
            students[1].GroupName = "Beta";
            students[2].GroupName = "Beta";
            students[3].GroupName = "Alpha";
            students[4].GroupName = "Alpha";

            var sortedByGroupName =
                from st in students
                group st by st.GroupName
                into gr
                orderby gr.Key
                select gr;

            foreach (var student in sortedByGroupName)
            {
                var temp = student.Where(s => s.GroupName == student.Key);

                Console.WriteLine(student.Key + "\n");

                foreach (var st in temp)
                {
                    Console.WriteLine(st);
                }
            }

            //problem 14
            Console.WriteLine("\n\nProblem 14");

            List<StudentSpecialty> specialities = new List<StudentSpecialty>
                {
                    new StudentSpecialty("Web Developer", "010201440676"),
                    new StudentSpecialty("PHP Developer", "010201540222"),
                    new StudentSpecialty("Web Developer", "010201440774"),
                    new StudentSpecialty("QA Engineer", "010131440424"),
                    new StudentSpecialty("PHP Developer", "010201340506")
                };

            var specialitiesWithStudents =
                from sp in specialities
                join st in students on sp.FacNumber equals st.FacultyNumber
                select new {Name = st.FirstName + " " + st.LastName, FactNum = st.FacultyNumber, Speciality = sp.SpecialityName};

            foreach (var st in specialitiesWithStudents)
            {
                Console.WriteLine(st);
            }

        }
    }
}
