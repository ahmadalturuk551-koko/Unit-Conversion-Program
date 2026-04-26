using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewrok2.EnumClasses
{
    public class EnumMenuHelper
    {
        public static TEnum ReadEnumChoice<TEnum>() where TEnum : struct, Enum
        {
            int choice;

            Array values = Enum.GetValues(typeof(TEnum));
            int minValue = Convert.ToInt32(values.GetValue(0));
            int maxValue = Convert.ToInt32(values.GetValue(values.Length - 1));

            while (true)
            {
                Console.Write($"Make your choice ({minValue}-{maxValue}): ");

                if (int.TryParse(Console.ReadLine(), out choice) &&
                    Enum.IsDefined(typeof(TEnum), choice))
                {
                    return (TEnum)Enum.ToObject(typeof(TEnum), choice);
                }

                Console.WriteLine($"Invalid choice. Please enter a number between {minValue} and {maxValue}.");
            }
        }

        public static void DisplayEnumChoices<TEnum>() where TEnum : Enum
        {
            foreach (TEnum type in Enum.GetValues(typeof(TEnum)))
            {
                Console.WriteLine($"{Convert.ToInt32(type)}. {type}");
            }
        }
    }
}
