using System;

using System.Collections.Generic;
using System.Text;

namespace Geometry.Geometry3D
{

    [Serializable()]
    public class Path3D
    {

        private List<Point3D> path;

        public Path3D(List<Point3D> path)
        {
            this.Path = path;
        }
        public Path3D() : this(new List<Point3D>())
        {

        }

        public List<Point3D> Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value;
            }
        }

        public void AddPoint3D(Point3D pt)
        {
            this.path.Add(pt);
        }
        public override string ToString()
        {
            StringBuilder text = new StringBuilder();

            foreach (var point in this.path)
            {
                text.Append(point.ToString() + "\n\r");
            }
            return text.ToString();
        }

    }
}

