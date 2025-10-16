using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPOCP.Shape
{
    public  class triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public triangle(double bas, double height)
        {
            Base = bas;
            Height = height;
        }
        public double Area()
        {
            return 0.5 * Base * Height;
        }
    }
}
