using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            int start = 1;
            bool programComplete = true;

            while (nums.Count() < 10)
            {
                int num = ReadNumbers(start, 100);

                if (100 - num < 10 - nums.Count())
                {
                    programComplete = false;
                    break;
                }
                else if (num > start)
                {
                    nums.Add(num);
                    start = num;
                }
            }

            switch (programComplete)
            {
                case (false):
                    Console.WriteLine();
                    Console.WriteLine("You will not be able to enter 10 consecutive numbers in the range [1..100] with this input.\nThe program will now terminate!");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    foreach (var n in nums)
                    {
                        Console.Write(n + " ");
                    }
                    Console.WriteLine();
                    break;
            }
        }

        public static int ReadNumbers(int start, int end)
        {
            int n = 1;

            try
            {
                Console.Write("Enter an integer number: ");
                int num = Int32.Parse(Console.ReadLine());
                if (num > start && num < end)
                {
                    return n = num;
                }
                else if (num <= start || num >= end)
                    throw new ArgumentOutOfRangeException();
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid input! Try again with I-N-T-E-G-E-R NUMBER!!!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("The number must be in the range [" + (start + 1) + "..99] ");
            }

            return n;
        }

    }
}
