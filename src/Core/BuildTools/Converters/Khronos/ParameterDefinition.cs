using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    /// <summary>
    /// A definition of a function parameter.
    /// </summary>
    public class ParameterDefinition
    {
        /// <summary>
        /// The parameter name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The parameter type.
        /// </summary>
        public TypeSpec Type { get; }

        /// <summary>
        /// The parameter's modifier.
        /// </summary>
        public ParameterModifier Modifier { get; }

        /// <summary>
        /// Whether or not the parameter is optional.
        /// </summary>
        public bool IsOptional { get; }

        /// <summary>
        /// The number of elements in this parameter.
        /// </summary>
        public int ElementCount { get; }

        /// <summary>
        /// The symbolic number of elements in this parameter.
        /// </summary>
        public string ElementCountSymbolic { get; }

        /// <summary>
        /// Is this null terminated?
        /// </summary>
        public bool IsNullTerminated { get; }

        /// <summary>
        /// Is this parameter a constant?
        /// </summary>
        public bool IsConst { get; }

        /// <summary>
        /// Define a new parameter.
        /// </summary>
        /// <param name="name">The parameter's name</param>
        /// <param name="type">The parameter's type.</param>
        /// <param name="modifier">The parameter's modifier.</param>
        /// <param name="isOptional">Is this parameter optional?</param>
        /// <param name="count">The element count of this parameter.</param>
        /// <param name="symbolicCount">The symbolic element count of this parameter.</param>
        /// <param name="isConst">Is this parameter a constant?</param>
        public ParameterDefinition(string name, TypeSpec type, ParameterModifier modifier, bool isOptional, int count, string symbolicCount, bool isConst)
        {
            Name = name;
            Type = type;
            Modifier = modifier;
            IsOptional = isOptional;
            ElementCount = count;
            IsConst = isConst;
            ElementCountSymbolic = symbolicCount == "null-terminated" ? null : symbolicCount;
            IsNullTerminated = symbolicCount?.Contains("null-terminated") ?? false;
        }

        /// <summary>
        /// Create a new ParameterDefinition from XML.
        /// </summary>
        /// <param name="xe">The XML element to create from.</param>
        /// <returns>A new ParameterDefinition.</returns>
        public static ParameterDefinition CreateFromXml(XElement xe)
        {
            var name = xe.Element("name")?.Value;
            var optionalAttr = xe.Attribute("optional");
            var isOptional = optionalAttr != null && optionalAttr.Value == "true";
            var typeName = xe.Element("type")?.Value;
            var isConst = xe.Value.Contains("const");
            var pointerLevel = 0;
            var countString = xe.Attribute("len")?.Value;
            if (xe.Value.Contains($"{typeName}**") || xe.Value.Contains($"{typeName}* const*"))
            {
                pointerLevel = 2;
            }
            else if (xe.Value.Contains($"{typeName}*"))
            {
                pointerLevel = 1;
            }

            string symbolic = null;
            var count = 0;
            if (!(countString is null))
            {
                if (!int.TryParse(countString, out count))
                {
                    symbolic = countString;
                }
            }

            var type = new TypeSpec(typeName, pointerLevel);

            return new ParameterDefinition
            (
                name, type, ParameterModifier.None, isOptional,
                count, symbolic, isConst
            );
        }
    }

    /// <summary>
    /// Parameter modifiers.
    /// </summary>
    public enum ParameterModifier
    {
        /// <summary>
        /// Parameter has no modifiers.
        /// </summary>
        None = 0,

        /// <summary>
        /// This is a ref parameter.
        /// </summary>
        Ref = 1,

        /// <summary>
        /// This is an out parameter.
        /// </summary>
        Out = 2,

        /// <summary>
        /// This is an in parameter.
        /// </summary>
        In = 3,
    }
}
