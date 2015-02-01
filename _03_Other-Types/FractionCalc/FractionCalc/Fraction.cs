using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalc
{
    struct Fraction
    {
        public long numenator;
        public long denominator;

        public Fraction (long num, long denom) : this()
        {
            this.Numerator = num;
            this.Denominator = denom;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            long num = f1.numenator * f2.denominator + f2.numenator * f1.denominator;
            long denom = f1.denominator * f2.denominator;

            return new Fraction(num, denom);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            long num = f1.numenator * f2.denominator - f2.numenator * f1.denominator;
            long denom = f1.denominator * f2.denominator;

            return new Fraction(num, denom);
        }

        public long Numerator
        {
            get { return this.numenator; }
            set { this.numenator = value; }
        }

        public long Denominator
        {
            get { return this.denominator; }
            set 
            {
                if (value == 0)
                    throw new ArgumentNullException("The denominator can't be 0 ");
                this.denominator = value;
            }
        }

        public override string ToString()
        {
            double result = (double)this.numenator / this.denominator;

            return result.ToString();
        }
    }
}
