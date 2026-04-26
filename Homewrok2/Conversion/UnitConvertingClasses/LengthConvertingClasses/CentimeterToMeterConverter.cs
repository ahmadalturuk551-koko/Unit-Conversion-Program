using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;
namespace Homewrok2.Classes.LengthConvertingClasses
{
    public class CentimeterToMeterConverter : IConverter
    {
        public double Convert(double Centimeter)
        {
            return Centimeter / 100;
        }
    }
}
