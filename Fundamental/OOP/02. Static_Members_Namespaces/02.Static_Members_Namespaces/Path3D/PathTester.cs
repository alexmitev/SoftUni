using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Space3D;


    class PathTester

    {
        static void Main(string[] args)
        {
        Point3D point_1 = new Point3D(3, 2, 1);
        Point3D point_2 = new Point3D(0, -1, 4);
        Path3D collection = new Path3D(new List<Point3D> { point_1, point_2 });
        collection.AddPoint3D(new Point3D(-2, 3, 0));
        Console.WriteLine(collection.ToString());
        Console.WriteLine();

        Storage.StoreFiles(@"../../points.bin", collection);

        Path3D restoredFiles = Storage.RestoreFiles(@"../../points.bin");


        Console.WriteLine(restoredFiles);

    





    }
    }
