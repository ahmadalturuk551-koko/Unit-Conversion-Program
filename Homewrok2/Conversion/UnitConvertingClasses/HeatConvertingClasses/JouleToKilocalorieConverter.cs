using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;
namespace Homewrok2.Classes.HeatConvertingClasses
{
    public class JouleToKilocalorieConverter : IConverter
    {
        public double Convert(double Joule)
        {
            return Joule / 4184;
        }
    }
}
