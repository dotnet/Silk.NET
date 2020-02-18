using System.Linq;
using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    public class ConstantDefinition
    {
        public string Name { get; }
        public string Value { get; }
        public ConstantType Type { get; }
        public string Comment { get; }

        public ConstantDefinition(string name, string value, string comment)
        {
            Name = name;
            Value = value.Replace("ULL", "ul").Replace("LL", "l");
            Type = ParseType(value);
            Comment = comment;
        }

        private ConstantType ParseType(string value)
        {
            if (value.EndsWith("f"))
            {
                return ConstantType.Float32;
            }
            else if (value.EndsWith("ULL)"))
            {
                return ConstantType.UInt64;
            }
            else
            {
                return ConstantType.UInt32;
            }
        }

        public static ConstantDefinition CreateFromXml(XElement xe)
        {
            Require.NotNull(xe);

            if (!(xe.Attribute("alias") is null))
            {
                var ret = CreateFromXml
                (
                    xe.Document.Element("registry")
                        .Elements("enums")
                        .Where(enumx => enumx.Attribute("name").Value == "API Constants")
                        .SelectMany(enumx => enumx.Elements("enum"))
                        .FirstOrDefault(x => x.Attribute("name").Value == xe.Attribute("alias").Value)
                );

                return new ConstantDefinition(xe.Attribute("name")?.Value, ret.Value, ret.Comment);
            }

            string name = xe.GetNameAttribute();
            string value = xe.Attribute("value").Value;
            string comment = xe.Attribute("comment")?.Value;

            return new ConstantDefinition(name, value, comment);
        }
    }

    public enum ConstantType
    {
        UInt32,
        UInt64,
        Float32,
    }
}
