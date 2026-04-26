using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;
namespace Homewrok2.Classes.MemoryConvertingClasses
{
    public class BitToByteConverter : IConverter
    {
        public double Convert(double Bit)
        {
            return Bit / 8;
        }
    }
}
