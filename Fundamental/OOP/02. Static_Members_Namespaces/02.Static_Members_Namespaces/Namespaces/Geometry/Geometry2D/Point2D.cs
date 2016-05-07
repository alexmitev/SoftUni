using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Geometry2D
{
  public class Point2D
    {
        
        public double X { get; set; }
        public double Y { get; set; }

        public Point2D(double x, double y)
        {
            this.X = x;
            this.Y = y;

        }

        public override string ToString()
        {
            return string.Format("X coordinate = {0} \n\rY coordinate = {1}", this.X, this.Y);

    }
}
