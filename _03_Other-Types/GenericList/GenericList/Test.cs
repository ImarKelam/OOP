using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Test
    {
        static void Main(string[] args)
        {
            GenericList<int> tmp = new GenericList<int>(4);

            tmp.Add(5);
            tmp.Add(2);
            tmp.Add(10);
            Console.WriteLine(tmp[1]);
            tmp.Insert(3, 2);

            tmp.Add(11);
            tmp.Add(-5);
            tmp.Insert(6, 22);
            tmp.Add(13);
            tmp.Add(14);
            tmp.Insert(5, 21);

            Console.WriteLine(tmp.ToString());
            
            //tmp.Clear();
            Console.WriteLine(tmp[3]);
            tmp.Find(2);

            bool contain = tmp.Contains(10);
            Console.WriteLine(contain);

            Console.WriteLine(tmp.ToString());

            
            tmp.Add(20);
            tmp.Insert(2, 25);
            tmp.Add(30);
            tmp.Insert(8, 26);
            tmp.Insert(12, 27);
            tmp.Add(40);
            
            Console.WriteLine(tmp.ToString());

            int min = tmp.Min();
            int max = tmp.Max();
            Console.WriteLine("The minimum value in the array is: {0}\nThe maximum value in the array is: {1}", min, max);
            /*
            tmp.Clear();
            Console.WriteLine(tmp.ToString());
             */
        }
    }
}
