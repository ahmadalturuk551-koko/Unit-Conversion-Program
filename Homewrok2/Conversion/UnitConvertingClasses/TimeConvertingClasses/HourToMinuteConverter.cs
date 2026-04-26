using Homewrok2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewrok2.Classes.TimeConvertingClasses
{
    public class HourToMinuteConverter : IConverter
    {
        public double Convert(double Hour)
        {
           return Hour * 60;
        }
    }
}
