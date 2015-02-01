namespace Shapes
{
    using System;

    public abstract class BasicShape : IShape
    {
        private double a;
        private double b;

        public BasicShape(double a, double b)
        {
            this.A = a;
            this.B = b;
        }

        public double A
        {
            get { return this.a; }
            set
            {
                if(value < 0)
                    throw new ArgumentOutOfRangeException("The width can't be < 0 ");
                this.a = value;
            }
        }

        public double B
        {
            get { return this.b; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("The height can't be < 0 ");
                this.b = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
