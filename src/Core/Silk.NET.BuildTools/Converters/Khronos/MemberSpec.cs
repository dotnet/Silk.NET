using System;
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
        public int? NumBits { get; }
        public string? Api { get; }

        public MemberSpec(string name, TypeSpec type, bool isOptional, int elementCount, string elementCountSymbolic, string comment, string legalValues, int? numBits = null, string? api = null)
        {
            Name = name;
            Type = type;
            IsOptional = isOptional;
            ElementCount = elementCount;
            ElementCountSymbolic = elementCountSymbolic;
            Comment = comment;
            LegalValues = legalValues;
            NumBits = numBits;
            Api = api;
        }

        public static MemberSpec CreateFromXml(XElement xe)
        {
            Require.NotNull(xe);

            var xeValue = xe.Element("comment") is null ? xe.Value : xe.Value.Replace(xe.Element("comment").Value, "");
            var name = xe.GetNameElement();
            var isOptional = xe.GetOptionalAttributeOrFalse();
            var typeName = xe.Element("type").Value;
            var pointerLevel = xeValue.Contains($"{typeName}*") ? 1 : 0; // TODO: Make this better.
            if (xeValue.Contains($"{typeName}* const*"))
            {
                pointerLevel += 1;
            }

            bool foundConstantElementCount = false;
            int elementCount = 1;
            string elementCountSymbolic = null;
            for (var i = 2; i < 10; i++)
            {
                if (xeValue.Contains($"{name}[{i}]["))
                {
                    for (var j = 2; j < 10; j++)
                    {
                        // not future proof, but works fine for now. we'll have something more elegant in 3.0
                        if (xeValue.Contains($"{name}[{i}][{j}]"))
                        {
                            elementCount = i * j;
                            foundConstantElementCount = true;
                            break;
                        }
                    }
                }
                else if (xeValue.Contains($"{name}[{i}]"))
                {
                    elementCount = i;
                    foundConstantElementCount = true;
                    break;
                }
            }

            if (!foundConstantElementCount)
            {
                var m = Regex.Match(xeValue, @"\[(.*)\]");
                if (m.Captures.Count > 0)
                {
                    elementCountSymbolic = m.Groups[1].Value;
                }
            }

            if (int.TryParse(elementCountSymbolic, out var intVal))
            {
                elementCountSymbolic = null;
                elementCount = intVal;
                foundConstantElementCount = true;
            }

            if (foundConstantElementCount && typeName.Contains($"[{elementCount}]"))
            {
                typeName = typeName.Replace($"[{elementCount}]", string.Empty);
            }
            else if (!(elementCountSymbolic is null) && typeName.Contains($"[{elementCountSymbolic}]"))
            {
                typeName = typeName.Replace($"[{elementCountSymbolic}]", string.Empty);
            }

            TypeSpec type = new TypeSpec(typeName, pointerLevel);

            string value = xe.Attribute("values")?.Value;

            var sNumBits = xeValue.Contains(":") ? xeValue[xeValue.LastIndexOf(":", StringComparison.Ordinal)..] : null;
            for (var i = 1; i < (sNumBits?.Length ?? 0); i++)
            {
                if (!"0123456789 ".Contains(sNumBits![i]))
                {
                    sNumBits = sNumBits[..i];
                }
            }

            int? numBits = sNumBits is not null ? int.Parse(sNumBits[1..]) : null;
            var api = xe.Attribute("api")?.Value;

            return new MemberSpec(name, type, isOptional, elementCount, elementCountSymbolic, string.Empty, value, numBits, api);
        }

        public override string ToString()
        {
            var optionalPart = IsOptional ? "[opt] " : "";
            var countPart = ElementCount != 1 ? $" [{ElementCount}]" : ElementCountSymbolic != null ? $" [{ElementCountSymbolic}]" : "";
            return $"{optionalPart}{Type} {Name}";
        }
    }
}
