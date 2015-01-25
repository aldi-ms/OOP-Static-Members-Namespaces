using System;

namespace _01Point3D
{
    class Program
    {
        static void Main()
        {
            Point3D p = new Point3D(4.3, 2, 0.23);

            Console.WriteLine(p.ToString());

            p = Point3D.StartingPoint;
            Console.WriteLine(p.ToString());

            Console.ReadKey();
        }
    }
}
