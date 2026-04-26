using Homewrok2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewrok2.Classes.TimeConvertingClasses
{
    public class MinuteToSecondConverter : IConverter
    {
        public double Convert(double Minute)
        {
            return Minute * 60;
        }
    }
}
