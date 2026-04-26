using Homewrok2.Interfaces;

namespace Homewrok2
{
    public class ConversionOption
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public IConverter Converter { get; private set; }

        public ConversionOption(int id, string name, IConverter converter)
        {
            Id = id;
            Name = name;
            Converter = converter;
        }
    }
}