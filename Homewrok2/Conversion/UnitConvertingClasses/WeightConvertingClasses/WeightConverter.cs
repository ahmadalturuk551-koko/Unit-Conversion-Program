using Homewrok2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewrok2.Classes.WeightConvertingClasses
{
    public class WeightConverter : IConverter
    {
        IConverter _Converter;

        public WeightConverter(IConverter Converter)
        {
            _Converter = Converter;
        }

        public double Convert(double value)
        {
            return _Converter.Convert(value);
        }
    }
}
