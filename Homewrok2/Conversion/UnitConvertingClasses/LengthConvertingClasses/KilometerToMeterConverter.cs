using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;
namespace Homewrok2.Classes.LengthConvertingClasses
{
    public class KilometerToMeterConverter: IConverter
    {
        public double Convert(double Kilometer)
        {
            return Kilometer * 1000;
        }
    }
}
