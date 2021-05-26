using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Triangle : Figure
    {
        public double Size_side { get; set; }
        public double Visota { get; set; }
        public double Storona1 { get; set; }
        public double Osnovanie { get; set; }
        public double Storona3 { get; set; }
        protected Triangle() { }

        protected Triangle(int corner, int size_side) : base(corner)
        {
            Size_side = size_side;
        }

        public double IPerimeter(double Storona1, double Osnovanie, double Storona3)
        {
            return Storona1 + Osnovanie + Storona3;
        }

        public double ISquare(double Visota, double Osnovanie)
        {
            return (Visota * Osnovanie) / 2;
        }
    }
}
