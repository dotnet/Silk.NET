using System.Linq;
using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    /// <summary>
    /// Defines a constant.
    /// </summary>
    public class ConstantDefinition
    {
        /// <summary>
        /// The name of the constant.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// The value of the constant.
        /// </summary>
        public string Value { get; }
        
        /// <summary>
        /// The type of the constant.
        /// </summary>
        public ConstantType Type { get; }
        
        /// <summary>
        /// The comment of the constant.
        /// </summary>
        public string Comment { get; }
        
        /// <summary>
        /// The specific API this constant is applicable to.
        /// </summary>
        public string? Api { get; }

        /// <summary>
        /// Creates a new constant definition.
        /// </summary>
        /// <param name="name">The name of the constant.</param>
        /// <param name="value">The value of the constant.</param>
        /// <param name="comment">The comment of the constant.</param>
        public ConstantDefinition(string name, string value, string comment, string api)
        {
            Name = name;
            Value = value.Replace("ULL", "ul").Replace("LL", "l");
            Type = ParseType(value);
            Comment = comment;
            Api = api;
        }

        /// <summary>
        /// Parse the type of the constant from its value.
        /// </summary>
        /// <param name="value">The value to parse.</param>
        /// <returns>The constant's type.</returns>
        private static ConstantType ParseType(string value)
        {
            if (value.EndsWith("f"))
            {
                return ConstantType.Float32;
            }

            return value.EndsWith("ULL)") ? ConstantType.UInt64 : ConstantType.UInt32;
        }

        /// <summary>
        /// Create a constant from XML.
        /// </summary>
        /// <param name="xe">The XML element to use.</param>
        /// <returns>A constant definition.</returns>
        public static ConstantDefinition CreateFromXml(XElement xe)
        {
            Require.NotNull(xe);

            if (!(xe.Attribute("alias") is null))
            {
                var ret = CreateFromXml
                (
                    xe.Document?.Element("registry")?
                        .Elements("enums")
                        .Where(x => x.Attribute("name")?.Value == "API Constants")
                        .SelectMany(x => x.Elements("enum"))
                        .FirstOrDefault(x => x.Attribute("name")?.Value == xe.Attribute("alias")?.Value)
                );

                return new ConstantDefinition(xe.Attribute("name")?.Value, ret.Value, ret.Comment, ret.Api);
            }

            var name = xe.GetNameAttribute();
            var value = xe.Attribute("value")?.Value;
            var comment = xe.Attribute("comment")?.Value;
            var api = xe.Attribute("api")?.Value;

            return new ConstantDefinition(name, value, comment, api);
        }
    }

    /// <summary>
    /// The type of a constant.
    /// </summary>
    public enum ConstantType
    {
        /// <summary>
        /// Constant is a UInt32.
        /// </summary>
        UInt32,
        
        /// <summary>
        /// Constant is a UInt64.
        /// </summary>
        UInt64,
        
        /// <summary>
        /// Constant is a 32-bit float.
        /// </summary>
        Float32,
    }
}
