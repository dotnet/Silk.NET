using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    public class TypedefDefinition
    {
        public string Name { get; }
        public string Requires { get; }
        public string Type { get; }

        public TypedefDefinition(string name, string requires, string type)
        {
            Name = name;
            Requires = requires;
            Type = type;
        }

        public static TypedefDefinition CreateFromXml(XElement xe)
        {
            var name = xe.GetNameElement();
            var requires = xe.Attribute("requires")?.Value;
            var type = xe.GetTypeElement();
            return new TypedefDefinition(name, requires, type);
        }

        public override string ToString()
        {
            return $"{Name}, {Requires} -> {Type}";
        }
    }
}
