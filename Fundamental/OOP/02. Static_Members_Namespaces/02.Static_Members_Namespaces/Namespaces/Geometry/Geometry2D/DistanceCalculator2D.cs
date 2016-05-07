using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Geometry2D
{
    public static class DistanceCalculator2D
    {

        public static double CalculateDistance2D (Point2D p1, Point2D p2)
        {
            return Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2) );
        }
    }
}
