// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Structs;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.VKXmlConvert
{
    public class VulkanReader
    {
        public IEnumerable<Struct> ReadStructs(XDocument document)
        {
            foreach (var xml in document.Elements("types").Elements("type").Where(x => x.Attribute("category")?.Value == "struct"))
            {
                var @struct = new Struct();
                @struct.NativeName = xml.Attribute("name")?.Value ?? throw new DataException("No name attribute");
                @struct.Name = NativeIdentifierTranslator.TranslateIdentifierName(@struct.NativeName);
                
                yield return null; //todo
            }
        }

        public IEnumerable<Field> ReadFields(XElement element)
        {
            foreach (var xe in element.Elements("member"))
            {
                string name = xe.Element("name")?.Value ?? throw new NullReferenceException("name is null");
                bool isOptional = bool.Parse(xe.Attribute("optional")?.Value ?? "false");
                string typeName = xe.Element("type")?.Value ?? throw new NullReferenceException("type is null");
                int pointerLevel = xe.Value.Contains($"{typeName}*") ? 1 : 0; // TODO: Make this better.
                if (xe.Value.Contains($"{typeName}* const*"))
                {
                    pointerLevel += 1;
                }

                var type = new Type() {IndirectionLevels = pointerLevel, Name = typeName};

                bool foundConstantElementCount = false;
                int elementCount = 1;
                string elementCountSymbolic = null;
                for (int i = 2; i < 10; i++)
                {
                    if (xe.Value.Contains($"{name}[{i}]"))
                    {
                        elementCount = i;
                        foundConstantElementCount = true;
                        break;
                    }
                }

                if (!foundConstantElementCount)
                {
                    Match m = Regex.Match(xe.Value, @"\[(.*)\]");
                    if (m.Captures.Count > 0)
                    {
                        elementCountSymbolic = m.Groups[1].Value;
                    }
                }

                string value = xe.Attribute("values")?.Value;

                return new MemberSpec(name, type, isOptional, elementCount, elementCountSymbolic, string.Empty, value);
            }
        }
    }
}
