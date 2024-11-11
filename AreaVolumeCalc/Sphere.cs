using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaVolumeCalc
{
    internal class Sphere : Shape3D, IVolume
    {
        public double Volume(double width, double height, double radius, double depth)
        {
            return 4 / 3 * pi * (radius * radius * radius);
        }
    }
}
