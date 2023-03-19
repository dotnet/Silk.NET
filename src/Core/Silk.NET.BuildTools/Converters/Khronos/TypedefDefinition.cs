using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    public class TypedefDefinition
    {
        public string Name { get; }
        public string Requires { get; }
        public string BitValues { get; }
        public string Type { get; }
        public string? Api { get; }

        public TypedefDefinition(string name, string requires, string type, string bitValues = null, string? api = null)
        {
            Name = name;
            Requires = requires;
            Type = type;
            BitValues = bitValues;
            Api = api;
        }

        public static TypedefDefinition CreateFromXml(XElement xe)
        {
            var name = xe.GetNameElement();
            var requires = xe.Attribute("requires")?.Value;
            var type = xe.GetTypeElement();
            var bitValues = xe.Attribute("bitvalues")?.Value;
            var api = xe.Attribute("api")?.Value;
            return new(name, requires, type, bitValues, api);
        }

        public override string ToString()
        {
            return $"{Name}, {Requires} -> {Type}";
        }
    }
}
