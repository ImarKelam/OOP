namespace Animals
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, string gender, int age) 
            : base(name, gender, age)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("BAU, BAU!");
        }
    }
}
