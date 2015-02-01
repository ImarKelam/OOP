using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalc
{
    class FractionCalculator
    {
        static void Main(string[] args)
        {
            Fraction frac1 = new Fraction(22, 7);
            Fraction frac2 = new Fraction(40, 4);
            Fraction result = frac1 + frac2;
            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);
        }
    }
}
