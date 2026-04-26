using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;
namespace Homewrok2.Classes.MemoryConvertingClasses
{
    public class KilobyteToByteConverter : IConverter
    {
        public double Convert(double Kilobyte)
        {
            return Kilobyte * 1024;
        }
    }
}
