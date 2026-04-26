using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;
namespace Homewrok2.Classes.HeatConvertingClasses
{
    public class KilocalorieToJouleConverter : IConverter
    {
        public double Convert(double Kilocalorie)
        {
            return Kilocalorie * 4184;
        }
    
    }
}
