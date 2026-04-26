using Homewrok2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewrok2.Classes.VolumeConvertingClasses
{
    public class LiterToMilliliterConverter : IConverter
    {
       
        public double Convert(double Liter)
        {
            return Liter * 1000;
        }
    }
}
