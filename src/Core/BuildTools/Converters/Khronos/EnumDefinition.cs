using System;
using System.Linq;
using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    public class EnumDefinition
    {
        public string Name { get; }
        public EnumType Type { get; }
        public EnumValue[] Values { get; set;  }

        public EnumDefinition(string name, EnumType type, EnumValue[] values)
        {
            Require.NotNullOrEmpty(name);
            Require.NotNull(values);

            Name = name;
            Type = type;
            Values = values;
        }

        public static EnumDefinition CreateFromXml(XElement xe)
        {
            Require.NotNull(xe);

            EnumType type;
            var typeAttr = xe.Attribute("type");
            if (typeAttr != null)
            {
                string typeString = xe.Attribute("type").Value;
                type = (EnumType)Enum.Parse(typeof(EnumType), typeString, true);
            }
            else
            {
                type = EnumType.Constants;
            }

            string name = xe.Attribute("name").Value;
            EnumValue[] values = xe.Elements("enum").Select(valuesx => EnumValue.CreateFromXml(valuesx)).ToArray();
            return new EnumDefinition(name, type, values);
        }

        public override string ToString()
        {
            return $"Enum: {Name} ({Type})[{Values.Length}]";
        }
    }

    public enum EnumType
    {
        Bitmask,
        Enum,
        Constants,
    }

    public class EnumValue
    {
        public string Name { get; }
        public int Value { get; }
        public string Comment { get; }

        public EnumValue(string name, int value, string comment)
        {
            Name = name;
            Value = value;
            Comment = comment;
        }

        public static EnumValue CreateFromXml(XElement xe)
        {
            Require.NotNull(xe);

            if (!(xe.Attribute("alias") is null))
            {
                var ret = CreateFromXml
                (xe.Document.Element("registry")
                    .Elements("enums")
                    .Where
                    (
                        enumx => enumx.GetTypeAttributeOrNull() == "enum" || enumx.GetTypeAttributeOrNull() == "bitmask"
                    )
                    .Elements("enum")
                    .FirstOrDefault(x => x.Attribute("name")?.Value == xe.Attribute("alias").Value));
                
                return new EnumValue(xe.Attribute("name").Value, ret.Value, ret.Comment);
            }

            string name = xe.Attribute("name").Value;

            int value;
            string valueStr = xe.Attribute("value")?.Value;
            if (valueStr != null)
            {
                if (valueStr.StartsWith("0x"))
                {
                    valueStr = valueStr.Substring(2);
                    value = int.Parse(valueStr, System.Globalization.NumberStyles.HexNumber);
                }
                else
                {
                    value = int.Parse(valueStr);
                }
            }
            else
            {
                string bitposStr = xe.Attribute("bitpos").Value;
                value = 1 << int.Parse(bitposStr);
            }

            var commentAttr = xe.Attribute("comment");
            string comment = commentAttr != null ? commentAttr.Value : string.Empty;
            return new EnumValue(name, value, comment);
        }
    }
}