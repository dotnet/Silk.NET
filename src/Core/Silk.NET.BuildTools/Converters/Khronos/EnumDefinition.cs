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
        /// The number of bits this enum's values occupy.
        /// </summary>
        public int BitWidth { get; set; }
        
        /// <summary>
        /// The specific API this enum is applicable to.
        /// </summary>
        public string? Api { get; }

        /// <summary>
        /// The enum definition.
        /// </summary>
        /// <param name="name">The name of the enum.</param>
        /// <param name="type">The type of the enum.</param>
        /// <param name="values">The values of the enum.</param>
        /// <param name="bitWidth">The bit width of the enum.</param>
        public EnumDefinition(string name, EnumType type, EnumValue[] values, int bitWidth, string? api)
        {
            Require.NotNullOrEmpty(name);
            Require.NotNull(values);

            Name = name;
            Type = type;
            Values = values;
            BitWidth = bitWidth;
            Api = api;
        }
        
        /// <summary>
        /// Clone the enum, with a new name.
        /// </summary>
        /// <param name="newName">The new name.</param>
        /// <returns>A clone of the enum.</returns>
        public EnumDefinition Clone(string newName) => new(newName, Type, Values, BitWidth, Api);

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
                type = (EnumType)Enum.Parse(typeof(EnumType), typeString, true);
            }
            else
            {
                type = EnumType.Constants;
            }

            var name = xe.Attribute("name")?.Value;
            var values = xe.Elements("enum").Select(EnumValue.CreateFromXml).ToArray();
            var bitWidth = xe.Attribute("bitwidth")?.Value;
            var api = xe.Attribute("api")?.Value;
            return new(name, type, values, bitWidth is null ? 32 : int.Parse(bitWidth), api);
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
        public long Value { get; }
        
        /// <summary>
        /// The comment of the EnumValue.
        /// </summary>
        public string Comment { get; }
        
        /// <summary>
        /// The API for which this value is applicable.
        /// </summary>
        public string? Api { get; }

        /// <summary>
        /// Create a new EnumValue.
        /// </summary>
        /// <param name="name">The name of the value.</param>
        /// <param name="value">The value of the enum value.</param>
        /// <param name="comment">The comment of the EnumValue.</param>
        public EnumValue(string name, long value, string comment, string? api)
        {
            Name = name;
            Value = value;
            Comment = comment;
            Api = api;
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
                
                return new EnumValue(xe.Attribute("name")?.Value, ret.Value, ret.Comment, ret.Api);
            }

            var name = xe.Attribute("name")?.Value;

            long value;
            var valueStr = xe.Attribute("value")?.Value;
            if (valueStr != null)
            {
                if (valueStr.StartsWith("0x"))
                {
                    valueStr = valueStr.Substring(2);
                    value = long.Parse(valueStr, NumberStyles.HexNumber);
                }
                else
                {
                    value = long.Parse(valueStr);
                }
            }
            else
            {
                var bitposStr = xe.Attribute("bitpos")?.Value;
                value = 1L << int.Parse(bitposStr ?? throw new InvalidDataException());
            }

            var commentAttr = xe.Attribute("comment");
            var comment = commentAttr != null ? commentAttr.Value : string.Empty;
            var api = xe.Attribute("api")?.Value;
            return new EnumValue(name, value, comment, api);
        }
    }
}
