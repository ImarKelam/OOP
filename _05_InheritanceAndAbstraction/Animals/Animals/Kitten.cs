namespace Animals
{
    using System;

    class Kitten : Cat
    {
        public Kitten(string name, int age) 
            : base(name, "female", age)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Mau, mau!");
        }
    }
}
