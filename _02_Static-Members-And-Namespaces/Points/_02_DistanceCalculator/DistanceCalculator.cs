using System;
using _02_Static_Members_And_Namespaces._01_Point3D;

namespace _02_Static_Members_And_Namespaces._02_DistanceCalculator
{
    static class DistanceCalculator
    {
        public static void CalculateDistance(Point3D p1, Point3D p2)
        {
            double deltaX = p2.PointX - p1.PointX;
            double deltaY = p2.PointY - p1.PointY;
            double deltaZ = p2.PointZ - p1.PointZ;

            double distance = (double)Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

            Console.WriteLine("The Distance between the 2 points is {0}", distance);
        }
    }
}
