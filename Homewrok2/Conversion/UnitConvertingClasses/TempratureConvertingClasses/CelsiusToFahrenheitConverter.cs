using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;

namespace Homewrok2.Classes.TempratureConvertingClasses
{
    public class CelsiusToFahrenheitConverter : IConverter
    {
        public double Convert(double Celsius)
        {
            return (Celsius * 9 / 5) + 32;
        }
    }
}
