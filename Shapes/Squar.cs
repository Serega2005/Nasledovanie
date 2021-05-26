using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Squar : Figure
    {
        public double Size_side { get; set; }

        protected Squar() { }

        protected Squar(int corner, int size_side) : base(corner)
        {
            Size_side = size_side;
        }

        public double Perimeter(int size_side)
        {
            return 4 * size_side;
        }

        public double Square(int size_side)
        {
            return size_side * size_side;
        }
    }
}
