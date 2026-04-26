using System.Collections.Generic;
using Homewrok2.Classes.ElectricConvertingClasses;
using Homewrok2.Classes.HeatConvertingClasses;
using Homewrok2.Classes.LengthConvertingClasses;
using Homewrok2.Classes.MemoryConvertingClasses;
using Homewrok2.Classes.TempratureConvertingClasses;
using Homewrok2.Classes.TimeConvertingClasses;
using Homewrok2.Classes.VolumeConvertingClasses;
using Homewrok2.Classes.WeightConvertingClasses;

namespace Homewrok2
{
    public static class ConversionCatalog
    {
        public static List<ConversionCategory> GetCategories()
        {
            return new List<ConversionCategory>
            {
                new ConversionCategory(
                    1,
                    "Electric Conversion",
                    new List<ConversionOption>
                    {
                        new ConversionOption(1, "Ampere To Milliampere", new ElectricConverter(new AmpereToMilliampereConverter())),
                        new ConversionOption(2, "Milliampere To Ampere", new ElectricConverter(new MilliampereToAmpereConverter())),
                        new ConversionOption(3, "Millivolt To Volt", new ElectricConverter(new MillivoltToVoltConverter())),
                        new ConversionOption(4, "Volt To Millivolt", new ElectricConverter(new VoltToMillivoltConverter()))
                    }
                ),

                new ConversionCategory(
                    2,
                    "Heat Conversion",
                    new List<ConversionOption>
                    {
                        new ConversionOption(1, "Calorie To Joule", new HeatConverter(new CalorieToJouleConverter())),
                        new ConversionOption(2, "Joule To Calorie", new HeatConverter(new JouleToCalorieConverter())),
                        new ConversionOption(3, "Kilocalorie To Joule", new HeatConverter(new KilocalorieToJouleConverter())),
                        new ConversionOption(4, "Joule To Kilocalorie", new HeatConverter(new JouleToKilocalorieConverter()))
                    }
                ),

                new ConversionCategory(
                    3,
                    "Length Conversion",
                    new List<ConversionOption>
                    {
                        new ConversionOption(1, "Meter To Kilometer", new LengthConverter(new MeterToKilometerConverter())),
                        new ConversionOption(2, "Kilometer To Meter", new LengthConverter(new KilometerToMeterConverter())),
                        new ConversionOption(3, "Meter To Centimeter", new LengthConverter(new MeterToCentimeterConverter())),
                        new ConversionOption(4, "Centimeter To Meter", new LengthConverter(new CentimeterToMeterConverter()))
                    }
                ),

                    new ConversionCategory(
                    4,
                    "Memory Conversion",
                    new List<ConversionOption>
                    {
                        new ConversionOption(1, "Bit To Byte", new MemoryConverter(new BitToByteConverter())),
                        new ConversionOption(2, "Byte To Bit", new MemoryConverter(new ByteToBitConverter())),
                        new ConversionOption(3, "Kilobyte To Byte", new MemoryConverter(new KilobyteToByteConverter())),
                        new ConversionOption(4, "Megabyte To Kilobyte", new MemoryConverter(new MegabyteToKilobyteConverter())),
                        new ConversionOption(5, "Gigabyte To Megabyte", new MemoryConverter(new GigabyteToMegabyteConverter()))
                    }
                ),

                new ConversionCategory(
                    5,
                    "Temperature Conversion",
                    new List<ConversionOption>
                    {
                        new ConversionOption(1, "Celsius To Fahrenheit", new TempratureConverter(new CelsiusToFahrenheitConverter())),
                        new ConversionOption(2, "Fahrenheit To Celsius", new TempratureConverter(new FahrenheitToCelsiusConverter())),
                        new ConversionOption(3, "Celsius To Kelvin", new TempratureConverter(new CelsiusToKelvinConverter())),
                        new ConversionOption(4, "Kelvin To Celsius", new TempratureConverter(new KelvinToCelsiusConverter()))
                    }
                ),

                new ConversionCategory(
                    6,
                    "Time Conversion",
                    new List<ConversionOption>
                    {
                        new ConversionOption(1, "Hour To Minute", new TimeConverter(new HourToMinuteConverter())),
                        new ConversionOption(2, "Minute To Second", new TimeConverter(new MinuteToSecondConverter())),
                        new ConversionOption(3, "Day To Hour", new TimeConverter(new DayToHourConverter())),
                        new ConversionOption(4, "Second To Minute To Day", new TimeConverter(new SecondToMinuteConverter()))
                    }
                ),

                new ConversionCategory(
                    7,
                    "Volume Conversion",
                    new List<ConversionOption>
                    {
                        new ConversionOption(1, "Liter To Milliliter", new VolumeConverter(new LiterToMilliliterConverter())),
                        new ConversionOption(2, "Milliliter To Liter", new VolumeConverter(new MilliliterToLiterConverter())),
                        new ConversionOption(3, "Liter To CubicMeter", new VolumeConverter(new LiterToCubicMeterConverter())),
                        new ConversionOption(4, "CubicMeter To Liter", new VolumeConverter(new CubicMeterToLiterConverter()))
                    }
                ),

                new ConversionCategory(
                    8,
                    "Weight Conversion",
                    new List<ConversionOption>
                    {
                        new ConversionOption(1, "Gram To Kilogram", new WeightConverter(new GramToKilogramConverter())),
                        new ConversionOption(2, "Kilogram To Gram", new WeightConverter(new KilogramToGramConverter())),
                        new ConversionOption(3, "Kilogram To Ton", new WeightConverter(new KilogramToTonConverter())),
                        new ConversionOption(4, "Ton To Kilogram", new WeightConverter(new TonToKilogramConverter()))
                    }
                )
            };
        }
    }
}