using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                string num = Console.ReadLine();
                int n = Int32.Parse(num);

                if (n <= 0)
                    throw new ArgumentOutOfRangeException();
                if (n > Int32.MaxValue || n < Int32.MinValue)
                    throw new OverflowException();

                Console.WriteLine(Math.Sqrt(n));
            }
            catch (FormatException fe)
            {
                Console.Error.WriteLine("The number must be an integer " + fe.Message);
            }
            catch (ArgumentOutOfRangeException are)
            {
                Console.Error.WriteLine("The number must be > 0 " + are.Message);
            }
            catch (OverflowException oe)
            {
                Console.Error.WriteLine("The number is too big to fit in Int32 " + oe.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
            
        }
    }
}
