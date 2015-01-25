using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using _01Point3D;
using Newtonsoft.Json;

namespace _03.Path3D
{
    public static class Storage
    {
        private const string SAVE_FILE = @"../../path.3d";
        private static readonly Encoding ENCODING = Encoding.ASCII;

        public static void SavePath(Path3D path, string filePathName = SAVE_FILE)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Point3D p in path.PointList)
            {
                sb.Append(JsonConvert.SerializeObject(p));
                sb.Append("\n");
            }

            using (StreamWriter sWriter = new StreamWriter(filePathName, false, ENCODING))
            {
                sWriter.Write(sb.ToString());
            }
        }

        public static Path3D LoadPath(string filePathName = SAVE_FILE)
        {
            string[] points;

            using (StreamReader sReader = new StreamReader(filePathName, ENCODING))
            {
                points = sReader.ReadToEnd().Split(
                    new char[] { '\n' },
                    StringSplitOptions.RemoveEmptyEntries);
            }

            List<Point3D> path = new List<Point3D>();

            foreach (string p in points)
            {
                path.Add(JsonConvert.DeserializeObject<Point3D>(p));
            }

            return new Path3D(path);
        }
    }
}
