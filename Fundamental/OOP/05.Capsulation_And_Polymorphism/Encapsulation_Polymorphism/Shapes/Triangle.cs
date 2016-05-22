using System;


namespace Shapes
{
    class Triangle : BasicShape
    {
        public double SideA {get; set;}

        public double SideB { get; set; }

        public Triangle( double width, double sideA, double sideB, double height)
        {
            this.Width = width;
            this.SideA = sideA;
            this.SideB = sideB;
            this.Height = height;
        }
        
        public override double CalculateArea()
        {
            return (this.Width * this.Height) / 2;
        }

        public override double CalculatePerimeter()
        {
            return this.Width + this.SideA + this.SideB;
        }
    }
}
