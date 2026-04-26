using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;

namespace Homewrok2.Classes.TempratureConvertingClasses
{
    public class FahrenheitToCelsiusConverter : IConverter
    {
        public double Convert(double Fahrenheit)
        {
            return (Fahrenheit - 32) * 5 / 9;
        }
    }
}
