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
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Common.Structs;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Converters.CLXmlConvert
{
    public class CLReader
    {
        public IEnumerable<Struct> ReadStructs(XDocument document)
        {
            foreach (var xml in document.Elements("types").Elements("type").Where(x => x.Attribute("category")?.Value == "struct")) {
                var nativeName = xml.Attribute("name")?.Value ?? throw new DataException("No name attribute");
                
                var @struct = new Struct {
                    NativeName = nativeName,
                    Name = NativeIdentifierTranslator.TranslateIdentifierName(nativeName),
                    Fields = ReadFields(xml).ToList()
                };
                
                // todo: deprecation detection -> @struct.Attributes

                yield return @struct;
            }
        }

        public IEnumerable<Field> ReadFields(XElement element)
        {
            foreach (var xe in element.Elements("member"))
            {
                var name = xe.Element("name")?.Value ?? throw new NullReferenceException("name is null");
                var isOptional = bool.Parse(xe.Attribute("optional")?.Value ?? "false");
                var typeName = xe.Element("type")?.Value ?? throw new NullReferenceException("type is null");
                var pointerLevel = xe.Value.Contains($"{typeName}*") ? 1 : 0; // TODO: Make this better.
                if (xe.Value.Contains($"{typeName}* const*"))
                {
                    pointerLevel += 1;
                }

                var type = new Type {IndirectionLevels = pointerLevel, Name = typeName};

                Count count = null;
                for (var i = 2; i < 10; i++)
                {
                    if (!xe.Value.Contains($"{name}[{i}]")) {
                        continue;
                    }

                    count = new Count(i);
                    break;
                }

                if (count is null)
                {
                    var m = Regex.Match(xe.Value, @"\[(.*)\]");
                    if (m.Captures.Count > 0)
                    {
                        count = new Count(m.Groups[1].Value, false);
                    }
                }

                var value = xe.Attribute("values")?.Value;

                yield return new Field
                {
                    Count = count,
                    Doc = "/// <summary>To be added.</summary>",
                    Name = name,
                    NativeName = name,
                    NativeType = typeName,
                    Type = type
                };
            }
        }
    }
}
