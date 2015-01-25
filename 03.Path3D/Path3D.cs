using System;
using _01Point3D;
using System.Collections.Generic;

namespace _03.Path3D
{
    public class Path3D
    {
        private static Random RNG = new Random();
        private List<Point3D> path3d;

        /// <summary>
        /// Create a 3D path composed of random 3D Points.
        /// </summary>
        /// <param name="pointsInPath">Points in the path to generate.</param>
        /// <param name="pointLowBound">Inclusive low bound for point's location.</param>
        /// <param name="pointHighBound">Inclusive high bound for point's location.</param>
        public Path3D(int pointsInPath, int pointLowBound, int pointHighBound)
        {
            this.path3d = new List<Point3D>();

            for (int i = 0; i < pointsInPath; i++)
            {
                this.path3d.Add(
                    new Point3D(
                        RNG.Next(pointLowBound, pointHighBound + 1),
                        RNG.Next(pointLowBound, pointHighBound + 1),
                        RNG.Next(pointLowBound, pointHighBound + 1)
                        ));
            }
        }

        public Path3D(List<Point3D> path)
        {
            this.path3d = path;
        }

        public List<Point3D> PointList
        {
            get { return this.path3d; }
        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach (Point3D p in path3d)
            {
                sb.Append(p.ToString());
                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}
