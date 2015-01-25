using _01Point3D;

namespace _02.DistanceCalculator
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D a, Point3D b)
        {
            double xPow = (a.X - b.X) * (a.X - b.X);
            double yPow = (a.Y - b.Y) * (a.Y - b.Y);
            double zPow = (a.Z - b.Z) * (a.Z - b.Z);

            return System.Math.Sqrt(xPow + yPow + zPow);
        }
    }
}
