using System;
using System.Collections.Generic;

namespace DefiningClassesPart2
{
    class Test  
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DistanceBetweenPoints.Distance(new Point3D(-7, -4, 3), new Point3D(17, 6, 2.5)));
            Path path = new Path();
            path.Add(new Point3D(1, 1, 1));
            path.Add(new Point3D(2, 2, 2));
            Console.WriteLine(path[0].ToString());
            foreach (var item in path)
            {
                Console.WriteLine(item);
            }
            Path test = PathStorage.GetFile(@"..\..\TextFile1.txt");
            Console.WriteLine(test.ToString());
        }
    }
}
