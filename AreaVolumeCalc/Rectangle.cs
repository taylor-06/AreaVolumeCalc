using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaVolumeCalc
{
    internal class Rectangle : Shape2D, IArea
    {
        public Rectangle(double width, double height)
        {

        }
        public double Area()
        {
            return width * height;
        }
    }
}
