using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;
namespace Homewrok2.Classes.TempratureConvertingClasses
{
    public class KelvinToCelsiusConverter : IConverter
    {
        public double Convert(double Kelvin)
        {
            return Kelvin - 273.15;
        }
    }
}
