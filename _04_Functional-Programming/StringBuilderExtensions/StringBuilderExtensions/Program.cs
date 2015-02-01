using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder tmp = new StringBuilder("Pesho, Kiro, kiro, Stamat");

            int[] nums = new int[5]{1, 2, 3, 4, 5};
            List<string> names = new List<string> { "Evgeni", "Lora", "Bai Ivan" };

            String subStr = tmp.SubString(7, 4);
            Console.WriteLine(subStr);
            Console.WriteLine();

            Console.WriteLine(tmp.RemoveText(" kiro,"));
            Console.WriteLine();

            tmp.AppendAll<int>(nums);
            tmp.AppendAll<string>(names);
            Console.WriteLine(tmp);
        }
    }
}
