namespace Animals
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, string gender, int age) 
            : base(name, gender, age)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("KRA, KRAAAAAAAAAAAAAAAAAAAA!");        
        }
    }
}
