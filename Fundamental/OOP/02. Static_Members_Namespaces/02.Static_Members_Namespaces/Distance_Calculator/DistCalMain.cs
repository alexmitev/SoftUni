using System;
using Space3D;


    class DistCalMain

    {
        static void Main(string[] args)
        {
        Point3D point_1 = new Point3D(-7, -4, 3);
        Point3D point_2 = new Point3D(17, 6, 2.5);

        Console.WriteLine(DistanceCalculator.CalcDistance3D(point_1, point_2));
        }
    }
