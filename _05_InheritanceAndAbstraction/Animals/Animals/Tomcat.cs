namespace Animals
{
    using System;

    class Tomcat : Cat
    {
        public Tomcat(string name, int age) 
            : base(name, "male", age)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("MAAAAAAAAAAAAAAAAAUUUUUUUUUUUUUUUUUUU!");
        }
    }
}
