using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Static_Members_And_Namespaces._01_Point3D
{
    class Point3D
    {
        private double pointX;
        private double pointY;
        private double pointZ;

        private static readonly Point3D startPoint = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            this.PointX = x;
            this.PointY = y;
            this.PointZ = z;
        }

        public double PointX
        {
            get { return this.pointX; }
            set { this.pointX = value; }
        }

        public double PointY
        {
            get { return this.pointY; }
            set { this.pointY = value; }
        }

        public double PointZ
        {
            get { return this.pointZ; }
            set { this.pointZ = value; }
        }

        public override string ToString()
        {
            string point = "X: " + this.pointX + "  Y: " + this.pointY + "  Z: " + this.pointZ;
            return point;
        }

        public static string StartPoint()
        {
            return startPoint.ToString();
        }
        
    }
}
