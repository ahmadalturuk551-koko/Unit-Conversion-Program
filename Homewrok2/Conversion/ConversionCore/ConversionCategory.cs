using System.Collections.Generic;

namespace Homewrok2
{
    public class ConversionCategory
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public List<ConversionOption> Options { get; private set; }

        public ConversionCategory(int id, string name, List<ConversionOption> options)
        {
            Id = id;
            Name = name;
            Options = options;
        }
    }
}