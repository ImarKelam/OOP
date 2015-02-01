namespace LINQExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> nums = new List<int> { 1, 3, 5, 3, 8 };
            Console.WriteLine(string.Join(", ", nums.WhereNot(a => a == 3)));
            Console.WriteLine();

            List<string> names = new List<string> { "Pesho", "Kiro", "Gosho", "Peter" };
            Console.WriteLine(string.Join(", ", names.Repeat(3)));
            Console.WriteLine();

            List<string> suffixes = new List<string> { "sho" , "er"};
            Console.WriteLine(string.Join(", ", names.WhereEndsWith(suffixes)));

        }
    }
}
