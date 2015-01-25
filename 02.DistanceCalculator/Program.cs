using System;
using _01Point3D;

namespace _02.DistanceCalculator
{
    class Program
    {
        static void Main()
        {
            Point3D a = new Point3D(12.3, 33.1, 1);
            Point3D b = new Point3D(3, -1.4, -22.13);

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(DistanceCalculator.CalculateDistance(a, b));

            // distance from Point a, to the zero Point
            Console.WriteLine(DistanceCalculator.CalculateDistance(a, Point3D.StartingPoint));

            Console.ReadKey();
        }
    }
}
