namespace Shapes
{
    using System;

    public class Triangle : BasicShape
    {
        private double c;

        public Triangle(double a, double b, double c) : base(a, b)
        {
            this.C = c;
        }

        public double C
        {
            get { return this.c; }
            set 
            { 
                if(value < 0)
                    throw new ArgumentOutOfRangeException("The width can't be < 0 ");
                this.c = value; 
            }
        }

        public override double CalculateArea()
        {
            double p = this.CalculatePerimeter()/2;

            return Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));
        }

        public override double CalculatePerimeter()
        {
            return this.A + this.B + this.C;
        }
    }
}
