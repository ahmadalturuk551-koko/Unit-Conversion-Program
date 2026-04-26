using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;

namespace Homewrok2.Classes.TimeConvertingClasses
{
    public class TimeConverter : IConverter
    {
        IConverter _converter;  

        public TimeConverter(IConverter converter)
        {
            _converter = converter;
        }

        public double Convert(double value)
        {
            return _converter.Convert(value);
        }
    }
}
