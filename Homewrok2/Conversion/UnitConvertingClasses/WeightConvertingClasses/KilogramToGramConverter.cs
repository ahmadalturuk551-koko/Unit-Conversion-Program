using Homewrok2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewrok2.Classes.WeightConvertingClasses
{
    public class KilogramToGramConverter : IConverter
    {
        public double Convert(double kilogram)
        {
            return kilogram * 1000;
        }

    }
}
