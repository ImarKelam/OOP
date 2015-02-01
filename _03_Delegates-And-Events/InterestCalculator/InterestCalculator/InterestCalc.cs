using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    class InterestCalc
    {
        public delegate decimal CalculateInterest(decimal sum, decimal interest, int years);

        static void Main(string[] args)
        {
            CalculateInterest simple = new CalculateInterest(GetSimpleInterest);
            CalculateInterest compound = new CalculateInterest(GetCompoundInterest);

            Console.WriteLine("{0:F4}", compound(500m, 5.6m, 10));
            Console.WriteLine("{0:F4}", simple(2500m, 7.2m, 15));
        }

        public static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            decimal result = sum * (1 + (interest / 100) * years);

            return result;
        }

        public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            decimal result = sum * (decimal)Math.Pow((double)(1 + (interest / 100) / 12), years * 12);

            return result;
        }
    }
}
