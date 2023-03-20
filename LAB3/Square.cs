using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Square : Rectangle
    {
        public Square(int x, int y, int sideLength, string color) : base(x, y, sideLength, sideLength, color)
        {
        }
    }
}
