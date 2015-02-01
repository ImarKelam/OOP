using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncTimer timer1 = new AsyncTimer(SayHello, 10, 1000);
            timer1.Start();

            AsyncTimer timer2 = new AsyncTimer(PointlessMethod, 5, 2000);
            timer2.Start();
        }


        public static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        public static void PointlessMethod()
        {
            Console.WriteLine("I am a pointless method for illustration purposes...");
        }
    }
}
