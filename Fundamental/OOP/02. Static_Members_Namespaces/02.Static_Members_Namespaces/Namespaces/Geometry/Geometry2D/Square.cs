using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Geometry2D
{
   public class Square : Figure2D
    {
        public double Side { get; set; }

        public Square ( double side)
        {
            this.Side = side;
        }

        
    }
}
