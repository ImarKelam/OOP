namespace StringDisperser
{
    using System;

    public class MainClass
    {
        public static void Main()
        {
            StringDisperser str1 = new StringDisperser("gosho", "pesho", "tanio");

            foreach (var ch in str1)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine();

            StringDisperser str2 = (StringDisperser)str1.Clone();
            StringDisperser str3 = new StringDisperser("gosho", "pesho", "tania");

            Console.WriteLine(str1.CompareTo(str2));
            Console.WriteLine(str1.CompareTo(str3));
        }
    }
}
