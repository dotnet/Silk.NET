using System;
using System.Xml.Linq;

namespace Vk.Generator
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
            Value = value;
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

            string name = xe.GetNameAttribute();
            string value = xe.Attribute("value").Value;
            string comment = xe.Attribute("comment")?.Value;

            return new ConstantDefinition(name, value, comment);
        }

        public enum ConstantType
        {
            UInt32,
            UInt64,
            Float32,
        }
    }
}
