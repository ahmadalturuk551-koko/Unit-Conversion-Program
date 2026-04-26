using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;
namespace Homewrok2.Classes.HeatConvertingClasses
{
    public class HeatConverter : IConverter
    {
        IConverter _converter;

        public HeatConverter(IConverter converter)
        {
            _converter = converter;
        }

        public double Convert(double value)
        {
           return _converter.Convert(value);
        }
    }
}
