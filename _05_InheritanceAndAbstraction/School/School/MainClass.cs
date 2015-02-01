namespace School
{
    using System;
    using System.Collections.Generic;

    public class MainClass
    {
        public static void Main()
        {
            Student st1 = new Student("Pesho", "0102030405");
            Student st2 = new Student("Kiro", "0102020304");
            Student st3 = new Student("Penka", "0102020304");

            st1.Details = "Golem pich";
            Console.WriteLine(st1);
            Console.WriteLine();


            Discipline oop = new Discipline("OOP", 12);
            oop.AddStudent(st1);
            oop.AddStudent(st2);
            oop.Students.Add(st3); //will not work - you have to use the method AddStudent 

            Discipline java = new Discipline("Java", 6);
            java.AddStudent(st3);

            //Console.WriteLine(st1.Details);
            Console.WriteLine(oop);
            Console.WriteLine(java);
            Console.WriteLine();


            Teacher t1 = new Teacher("Bai Ivan");
            t1.AddDiscipline(oop);
            t1.AddDiscipline(java);
            t1.Details = "Naj-dobriq daskal!";

            Console.WriteLine(t1);
            Console.WriteLine();

            Class cl1 = new Class("Alpha");
            cl1.AddTeacher(t1);
            cl1.AddStudent(st1);
            cl1.AddStudent(st2);
            cl1.AddStudent(st3);

            Console.WriteLine(cl1);
        }
    }
}
