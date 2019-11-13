using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    public class MemberSpec
    {
        public string Name { get; }
        public TypeSpec Type { get; }
        public bool IsOptional { get; }
        public int ElementCount { get; }
        public string ElementCountSymbolic { get; }
        public string Comment { get; }
        public string LegalValues { get; }

        public MemberSpec(string name, TypeSpec type, bool isOptional, int elementCount, string elementCountSymbolic, string comment, string legalValues)
        {
            Name = name;
            Type = type;
            IsOptional = isOptional;
            ElementCount = elementCount;
            ElementCountSymbolic = elementCountSymbolic;
            Comment = comment;
            LegalValues = legalValues;
        }

        public static MemberSpec CreateFromXml(XElement xe)
        {
            Require.NotNull(xe);

            var xeValue = xe.Element("comment") is null ? xe.Value : xe.Value.Replace(xe.Element("comment").Value, "");
            string name = xe.GetNameElement();
            bool isOptional = xe.GetOptionalAttributeOrFalse();
            string typeName = xe.Element("type").Value;
            int pointerLevel = xeValue.Contains($"{typeName}*") ? 1 : 0; // TODO: Make this better.
            if (xeValue.Contains($"{typeName}* const*"))
            {
                pointerLevel += 1;
            }

            TypeSpec type = new TypeSpec(typeName, pointerLevel);

            bool foundConstantElementCount = false;
            int elementCount = 1;
            string elementCountSymbolic = null;
            for (int i = 2; i < 10; i++)
            {
                if (xeValue.Contains($"{name}[{i}]"))
                {
                    elementCount = i;
                    foundConstantElementCount = true;
                    break;
                }
            }

            if (!foundConstantElementCount)
            {
                Match m = Regex.Match(xeValue, @"\[(.*)\]");
                if (m.Captures.Count > 0)
                {
                    elementCountSymbolic = m.Groups[1].Value;
                }
            }

            string value = xe.Attribute("values")?.Value;

            return new MemberSpec(name, type, isOptional, elementCount, elementCountSymbolic, string.Empty, value);
        }

        public override string ToString()
        {
            string optionalPart = IsOptional ? "[opt] " : "";
            string countPart = ElementCount != 1 ? $" [{ElementCount}]" : ElementCountSymbolic != null ? $" [{ElementCountSymbolic}]" : "";
            return $"{optionalPart}{Type} {Name}";
        }
    }
}
