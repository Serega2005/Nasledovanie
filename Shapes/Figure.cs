using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Figure
    {
        public int Corner { get; set; } 

        protected Figure() { }

        protected Figure(int corner) 
        {
            Corner = corner;
        }
    }
}
