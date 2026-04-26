using System;
using System.Collections.Generic;

namespace Homewrok2
{
    public static class Menu
    {
        public static void PrintCategories(List<ConversionCategory> categories)
        {
            PrintHeader("Unit Conversion Program");

            foreach (ConversionCategory category in categories)
            {
                Console.WriteLine(category.Id + ". " + category.Name);
            }

            Console.WriteLine("0. Exit");
            PrintLine();
        }

        public static void PrintOptions(ConversionCategory category)
        {
            PrintHeader(category.Name);

            foreach (ConversionOption option in category.Options)
            {
                Console.WriteLine(option.Id + ". " + option.Name);
            }

            Console.WriteLine("0. Back");
            PrintLine();
        }

        public static void PrintLine(char LineChar = '=', int length = 46)
        {
            Console.WriteLine(new string(LineChar, length));
        }

        public static void PrintHeader(string title)
        {
            PrintLine();
            Console.WriteLine("          " + title);
            PrintLine();
        }


        public static void PrintResult(double result)
        {
            PrintLine('-',23);
            Console.WriteLine("Result: " + result);
            PrintLine('-',23);
        }

        public static void Wait()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}