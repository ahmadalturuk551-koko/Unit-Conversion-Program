using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;

namespace Homewrok2.Classes.TempratureConvertingClasses
{
    public class CelsiusToKelvinConverter : IConverter
    {
        public double Convert(double Celsius)
        {
            return Celsius + 273.15;
        }
    }
}
