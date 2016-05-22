using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Shapes_Test
    {
        static void Main(string[] args)
        {

            IList<IShape> shapes = new List<IShape>()
            {
                new Circle(2.8),
                new Circle(4.2),
                new Rectangle(3, 2.2),
                new Triangle(3,2.4,2.5,1.2),
                new Rectangle(12, 20.3),
                new Triangle(9, 2, 3, 1.4)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(String.Format("Shape: {0}, Area: {1}, Perimeter: {2}", shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter()));
            }
        }
    }
}
