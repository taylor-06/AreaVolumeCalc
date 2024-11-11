using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaVolumeCalc
{
    internal class Cube : Shape3D, IVolume
    {
        public double Volume(double width, double height, double radius, double depth)
        {
            return width * height * depth;
        }
    }
}
