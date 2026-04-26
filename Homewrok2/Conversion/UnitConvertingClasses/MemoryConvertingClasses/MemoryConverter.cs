using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;
namespace Homewrok2.Classes.MemoryConvertingClasses
{
    public class MemoryConverter : IConverter
    {
        IConverter _Converter;

        public MemoryConverter(IConverter Converter)
        {
            _Converter = Converter;
        }

        public double Convert(double value)
        {
            return _Converter.Convert(value);
        }
    }
}
