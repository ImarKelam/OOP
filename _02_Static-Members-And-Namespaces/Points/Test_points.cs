using System;
using System.Collections.Generic;
using _02_Static_Members_And_Namespaces._01_Point3D;
using _02_Static_Members_And_Namespaces._02_DistanceCalculator;
using _02_Static_Members_And_Namespaces._03_Paths;

namespace Points
{
    class Test_points
    {
        static void Main(string[] args)
        {
            // For Problem 1
            Point3D one = new Point3D(3, 4, 5);
            Point3D two = new Point3D(6, 7, 8);

            Console.WriteLine(Point3D.StartPoint());
            Console.WriteLine(one.ToString());
            Console.WriteLine(two.ToString());
            Console.WriteLine();

            // For Problem 2
            DistanceCalculator.CalculateDistance(one, two);
            Console.WriteLine();


            // For Problem 3 (You have to create a file C:\temp\Input.txt to read the input data from or change the path in the Storage class)
            List<Point3D> path = Storage.ReadData();

            foreach (var point in path)
            {
                Console.WriteLine(point.ToString());
            }

            Storage.WriteData(path);
        }
    }
}
