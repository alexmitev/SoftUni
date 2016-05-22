﻿using System;


namespace Shapes
{
    class Rectangle : BasicShape
    {

        public Rectangle (double width, double height)
        {
            this.Width = width;
            this.Height = height;

        }

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * this.Height + 2 * this.Width;
        }
    }
}
