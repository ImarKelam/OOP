namespace Shapes
{
    public class Rectangle : BasicShape
    {
        public Rectangle(double a, double b) : base(a, b)
        {
        }

        public override double CalculateArea()
        {
            return (this.A * this.B) / 2;
        }

        public override double CalculatePerimeter()
        {
            return 2 * this.A + 2 * this.B;
        }
    }
}
