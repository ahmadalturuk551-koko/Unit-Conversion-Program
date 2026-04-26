using Homewrok2;
using System;

namespace Homework2
{
    public class Program
    {
        public static void Main()
        {
            //WeightConverter weightConverter = new WeightConverter(new GramToKilogramConverter());
            //TimeConverter timeConverter = new TimeConverter(new HourToMinuteConverter());

            //double Kilogram = weightConverter.Convert(2000);
            //double Minute = timeConverter.Convert(2);
            //Console.WriteLine(Minute);
            //Console.WriteLine(Kilogram);

            Converter converter = new Converter();
            converter.StartConverting();
        }

    }
}
