namespace _04_SULS
{
    using System;

    public class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age) 
            : base(firstName, lastName, age)
        {

        }

        public void DeleteCourse(string course)
        {
            this.courses.Remove(course);
            Console.WriteLine("The course " + course + " has been deleted. ");
        }

    }
}
