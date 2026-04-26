using Homewrok2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewrok2.Classes.TimeConvertingClasses
{
    public class DayToHourConverter : IConverter
    {
        public double Convert(double Day)
        {
          return Day * 24;
        }
    }
}
