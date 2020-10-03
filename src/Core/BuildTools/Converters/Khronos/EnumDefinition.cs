using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    /// <summary>
    /// Defines an enum.
    /// </summary>
    public class EnumDefinition
    {
        /// <summary>
        /// The name of the enum.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The type of the enum.
        /// </summary>
        public EnumType Type { get; }

        /// <summary>
        /// The values of the enum.
        /// </summary>
        public EnumValue[] Values { get; set; }

        /// <summary>
        /// The enum definition.
        /// </summary>
        /// <param name="name">The name of the enum.</param>
        /// <param name="type">The type of the enum.</param>
        /// <param name="values">The values of the enum.</param>
        public EnumDefinition(string name, EnumType type, EnumValue[] values)
        {
            Require.NotNullOrEmpty(name);
            Require.NotNull(values);

            Name = name;
            Type = type;
            Values = values;
        }

        /// <summary>
        /// Clone the enum.
        /// </summary>
        /// <returns>A clone of the enum.</returns>
        public EnumDefinition Clone() => new EnumDefinition(Name, Type, Values);

        /// <summary>
        /// Clone the enum, with a new name.
        /// </summary>
        /// <param name="newName">The new name.</param>
        /// <returns>A clone of the enum.</returns>
        public EnumDefinition Clone(string newName) => new EnumDefinition(newName, Type, Values);

        /// <summary>
        /// Creates an EnumDefinition from an XML document.
        /// </summary>
        /// <param name="xe">The XML element to create from.</param>
        /// <returns>An EnumDefinition.</returns>
        public static EnumDefinition CreateFromXml(XElement xe)
        {
            Require.NotNull(xe);

            EnumType type;
            var typeAttr = xe.Attribute("type");
            if (typeAttr != null)
            {
                var typeString = xe.Attribute("type")?.Value ?? throw new InvalidDataException();
                type = (EnumType) Enum.Parse(typeof(EnumType), typeString, true);
            }
            else
            {
                type = EnumType.Constants;
            }

            var name = xe.Attribute("name")?.Value;
            var values = xe.Elements("enum").Select(EnumValue.CreateFromXml).ToArray();
            return new EnumDefinition(name, type, values);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"Enum: {Name} ({Type})[{Values.Length}]";
        }
    }

    /// <summary>
    /// The type of the defined enum.
    /// </summary>
    public enum EnumType
    {
        /// <summary>
        /// Enum is a bitmask.
        /// </summary>
        Bitmask,

        /// <summary>
        /// Enum is a regular enum.
        /// </summary>
        Enum,

        /// <summary>
        /// Enum defines a series of constants.
        /// </summary>
        Constants,
    }

    /// <summary>
    /// Defines the value of an <see cref="EnumDefinition"/>
    /// </summary>
    public class EnumValue
    {
        /// <summary>
        /// The name of the EnumValue.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The value of the EnumValue.
        /// </summary>
        public int Value { get; }

        /// <summary>
        /// The comment of the EnumValue.
        /// </summary>
        public string Comment { get; }

        /// <summary>
        /// Create a new EnumValue.
        /// </summary>
        /// <param name="name">The name of the value.</param>
        /// <param name="value">The value of the enum value.</param>
        /// <param name="comment">The comment of the EnumValue.</param>
        public EnumValue(string name, int value, string comment)
        {
            Name = name;
            Value = value;
            Comment = comment;
        }

        /// <summary>
        /// Creates an EnumValue from an XML document.
        /// </summary>
        /// <param name="xe">The XML element to create from.</param>
        /// <returns>An EnumValue.</returns>
        public static EnumValue CreateFromXml(XElement xe)
        {
            Require.NotNull(xe);

            if (!(xe.Attribute("alias") is null))
            {
                var ret = CreateFromXml
                (xe.Document?.Element("registry")
                    ?.Elements("enums")
                    .Where
                    (
                        x => x.GetTypeAttributeOrNull() == "enum" ||
                                 x.GetTypeAttributeOrNull() == "bitmask"
                    )
                    .Elements("enum")
                    .FirstOrDefault(x => x.Attribute("name")?.Value == xe.Attribute("alias")?.Value));

                return new EnumValue(xe.Attribute("name")?.Value, ret.Value, ret.Comment);
            }

            var name = xe.Attribute("name")?.Value;

            int value;
            var valueStr = xe.Attribute("value")?.Value;
            if (valueStr != null)
            {
                if (valueStr.StartsWith("0x"))
                {
                    valueStr = valueStr.Substring(2);
                    value = int.Parse(valueStr, NumberStyles.HexNumber);
                }
                else
                {
                    value = int.Parse(valueStr);
                }
            }
            else
            {
                var bitposStr = xe.Attribute("bitpos")?.Value;
                value = 1 << int.Parse(bitposStr ?? throw new InvalidDataException());
            }

            var commentAttr = xe.Attribute("comment");
            var comment = commentAttr != null ? commentAttr.Value : string.Empty;
            return new EnumValue(name, value, comment);
        }
    }
}
