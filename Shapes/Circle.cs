using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Figure
    {
        public double Length { get; set; }
        public double Radius { get; set; }
        const double Pi = 3.14;

        protected Circle() { }

        protected Circle(int corner, double length, double radius) : base(corner)
        {
            Length = length;
            Radius = radius;
        }
        public double Perimeter(double radius, double Pi)
        {
            return 2*(radius * Pi);
        }
        public double Square(double radius)
        {
            return (radius*radius) * Pi;
        }
    }
}
