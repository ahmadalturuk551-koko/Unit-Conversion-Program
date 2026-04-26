using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;
namespace Homewrok2.Classes.LengthConvertingClasses
{
    public class MeterToKilometerConverter : IConverter
    {
        public double Convert(double Meter)
        {
            return Meter / 1000;
        }
    }
}
