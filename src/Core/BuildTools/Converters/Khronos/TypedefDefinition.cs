using System.Xml.Linq;

namespace Vk.Generator
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
            string name = xe.GetNameElement();
            string requires = xe.Attribute("requires")?.Value;
            string type = xe.GetTypeElement();
            return new TypedefDefinition(name, requires, type);
        }

        public override string ToString()
        {
            return $"{Name}, {Requires} -> {Type}";
        }
    }
}
