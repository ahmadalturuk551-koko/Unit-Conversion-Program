using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;
namespace Homewrok2.Classes.LengthConvertingClasses
{
    public class LengthConverter : IConverter
    {
        IConverter _Converter;

        public LengthConverter(IConverter Converter)
        {
            _Converter = Converter;
        }

        public double Convert(double Value)
        {
            return _Converter.Convert(Value);
        }
    }
}
