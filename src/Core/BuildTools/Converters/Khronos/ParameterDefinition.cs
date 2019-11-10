using System.Globalization;
using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    public class ParameterDefinition
    {
        public string Name { get; }
        public TypeSpec Type { get;  }
        public ParameterModifier Modifier { get; }
        public bool IsOptional { get; }
        public int ElementCount { get; }
        public string ElementCountSymbolic { get; }
        public bool IsNullTerminted { get; }
        public bool IsConst { get; }

        public ParameterDefinition(string name, TypeSpec type, ParameterModifier modifier, bool isOptional, int count, string symbolicCount, bool isConst)
        {
            Name = name;
            Type = type;
            Modifier = modifier;
            IsOptional = isOptional;
            ElementCount = count;
            IsConst = isConst;
            ElementCountSymbolic = symbolicCount == "null-terminated" ? null : symbolicCount;
            IsNullTerminted = symbolicCount?.Contains("null-terminated") ?? false;
        }

        public static ParameterDefinition CreateFromXml(XElement xe)
        {
            string name = xe.Element("name").Value;
            var optionalAttr = xe.Attribute("optional");
            bool isOptional = optionalAttr != null && optionalAttr.Value == "true";
            string typeName = xe.Element("type").Value;
            bool isConst = xe.Value.Contains("const");
            int pointerLevel = 0;
            string countString = xe.Attribute("len")?.Value;
            if (xe.Value.Contains($"{typeName}**") || xe.Value.Contains($"{typeName}* const*"))
            {
                pointerLevel = 2;
            }
            else if(xe.Value.Contains($"{typeName}*"))
            {
                pointerLevel = 1;
            }

            string symbolic = null;
            int count = 0;
            if (!(countString is null))
            {
                if (!int.TryParse(countString, out count))
                {
                    symbolic = countString;
                }
            }

            TypeSpec type = new TypeSpec(typeName, pointerLevel);

            return new ParameterDefinition
            (
                name, type, ParameterModifier.None, isOptional,
                count, symbolic, isConst
            );
        }
    }

    public enum ParameterModifier
    {
        None = 0,
        Ref = 1,
        Out = 2,
        In = 3,
    }
}
