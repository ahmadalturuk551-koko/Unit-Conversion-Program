using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;
namespace Homewrok2.Classes.ElectricConvertingClasses
{
    public class MilliampereToAmpereConverter : IConverter
    {
        public double Convert(double Milliampere)
        {
            return Milliampere / 1000;
        }
    
    }
}
