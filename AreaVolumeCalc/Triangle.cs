using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaVolumeCalc
{
    internal class Triangle : Shape2D, IArea
    {
        public double Area(double width, double height, double radius)
        {
            return (width * height) * 0.5;
        }
    }
}
