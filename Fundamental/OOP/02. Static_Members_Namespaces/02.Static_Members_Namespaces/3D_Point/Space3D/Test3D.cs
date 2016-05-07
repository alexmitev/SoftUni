using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space3D
{
    class Tester3D

    {
        static void Main(string[] args)
        {
            Point3D point_1 = new Point3D(3, 2, 1);
            Point3D point_2 = new Point3D(0, -1, 4);

            Console.WriteLine(point_1.ToString() + "\n" + point_2.ToString());
            Console.WriteLine(Point3D.StartingPoint + "\n");
            Console.WriteLine(Point3D.StartingPoint);



        }
    }
}


