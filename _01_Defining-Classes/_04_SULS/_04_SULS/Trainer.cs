namespace _04_SULS
{
    using System;
    using System.Collections.Generic;

    public abstract class Trainer : Person
    {
        protected IList<string> courses = new List<string>();

        public Trainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
            
        }

        public IList<string> Courses
        {
            get {return this.courses; }
        }

        public void CreateCourse(string course)
        {
            this.courses.Add(course);
            Console.WriteLine("A course " + course + " has been created. ");
        }
    }
}
