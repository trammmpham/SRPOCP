using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPOCP.Shape
{
    public class Square : IShape
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }
        public double Area()
        {
            return Side * Side;
        }
    }
}
