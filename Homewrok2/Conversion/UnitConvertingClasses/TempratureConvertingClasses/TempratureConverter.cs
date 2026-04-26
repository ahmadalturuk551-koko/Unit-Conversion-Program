using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;
namespace Homewrok2.Classes.TempratureConvertingClasses
{
    public class TempratureConverter : IConverter
    {
        IConverter _Converter;
        public TempratureConverter(IConverter Converter)
        {
            _Converter = Converter;
        }

        public double Convert(double value)
        {
            return _Converter.Convert(value);
        }
    }
}
