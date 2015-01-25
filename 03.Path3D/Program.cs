using System;
using System.Collections.Generic;
using _01Point3D;

namespace _03.Path3D
{
    class Program
    {

        static void Main()
        {
            Path3D path = new Path3D(12, -50, 50);

            Console.WriteLine("Generated path:");
            Console.WriteLine(path.ToString());

            Storage.SavePath(path);

            Path3D loadedPath = Storage.LoadPath();

            Console.WriteLine("Loaded path:");
            Console.WriteLine(loadedPath.ToString());

            Console.ReadKey();
        }
    }
}
