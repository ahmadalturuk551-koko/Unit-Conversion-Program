using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homewrok2.Interfaces;
namespace Homewrok2.Classes.HeatConvertingClasses
{
    public class CalorieToJouleConverter : IConverter
    {
        public double Convert(double Calorie)
        {
            return Calorie * 4.184;
        }
    }
}
