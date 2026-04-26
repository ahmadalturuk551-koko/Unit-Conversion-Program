using System;
using System.Collections.Generic;
using System.Linq;

namespace Homewrok2
{
    public class Converter
    {
        private readonly List<ConversionCategory> _categories;

        public Converter()
        {
            _categories = ConversionCatalog.GetCategories();
        }

        public void StartConverting()
        {
            while (true)
            {
                Console.Clear();
                Menu.PrintCategories(_categories);

                int categoryChoice = ReadInt("Choose category: ");

                if (categoryChoice == 0)
                    break;
                ConversionCategory selectedCategory = _categories.FirstOrDefault(c => c.Id == categoryChoice);
              

                if (selectedCategory == null)
                {
                    Console.WriteLine("Invalid category choice.");
                    Menu.Wait();
                    continue;
                }
              
                RunCategory(selectedCategory);
            }
        }

        private void RunCategory(ConversionCategory category)
        {
            while (true)
            {
                Console.Clear();
                Menu.PrintOptions(category);

                int optionChoice = ReadInt("Choose conversion type: ");

                if (optionChoice == 0)
                    return;

                ConversionOption selectedOption =
                    category.Options.FirstOrDefault(o => o.Id == optionChoice);

                Console.Clear();
                Menu.PrintHeader(selectedOption.Name);
          
                if (selectedOption == null)
                {
                    Console.WriteLine("Invalid conversion choice.");
                    Menu.Wait();
                    continue;
                }
             
                double value = ReadDouble("Enter value: ");

                double result = selectedOption.Converter.Convert(value);

                Menu.PrintResult(result);
                Menu.Wait();
              
            }
        }

        private int ReadInt(string message)
        {
            int value;

            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out value))
                    return value;

                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        private double ReadDouble(string message)
        {
            double value;

            while (true)
            {
                Console.Write(message);

                if (double.TryParse(Console.ReadLine(), out value))
                    return value;

                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}