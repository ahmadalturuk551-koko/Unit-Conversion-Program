using Homewrok2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewrok2.Classes.VolumeConvertingClasses
{
    public class CubicMeterToLiterConverter : IConverter
    {
        public double Convert(double CubicMeter)
        {
            return CubicMeter * 1000;
        }
    }
}
