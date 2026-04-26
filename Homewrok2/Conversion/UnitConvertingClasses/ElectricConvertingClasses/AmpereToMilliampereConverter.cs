using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;
namespace Homewrok2.Classes.ElectricConvertingClasses
{
    public class AmpereToMilliampereConverter : IConverter
    {
        public double Convert(double Ampere)
        {
            return Ampere * 1000;
        }
    }
}
