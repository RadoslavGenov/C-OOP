using System;
using System.IO;
using System.Linq;

namespace DefiningClassesPart2
{
    static class PathStorage
    {
        public static Path GetFile(string path)
        {
            Path myPath = new Path();
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string[] arrPoints = reader.ReadToEnd().Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var point in arrPoints)
                    {
                        double[] coordinates = point.Trim('>').Trim('-')
                            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => double.Parse(x))
                            .ToArray();

                        myPath.AddPoints(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return myPath;
        }
    }
}
