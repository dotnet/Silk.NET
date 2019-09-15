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
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Common.Structs;
using Attribute = Silk.NET.BuildTools.Common.Attribute;
using Enum = Silk.NET.BuildTools.Common.Enums.Enum;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.VKXmlConvert
{
    public class VulkanReader
    {
        public const string EnumPrefix = "Vk"; // TODO make a command line option for enum prefix
        public const string StructPrefix = "Vk"; // TODO make a command line option for struct prefix
        public const string FunctionPrefix = "vk"; // TODO make a command line option for enum prefix
        public IEnumerable<Struct> ReadStructs(XDocument document)
        {
            foreach (var xml in document.Elements("types").Elements("type").Where(x => x.Attribute("category")?.Value == "struct"))
            {
                var @struct = new Struct();
                @struct.NativeName = xml.Attribute("name")?.Value ?? throw new DataException("No name attribute");
                @struct.Name = Naming.Translate
                (
                    @struct.NativeName.Remove(0, StructPrefix.Length), FunctionPrefix
                );
                @struct.Fields = ReadFields(xml).ToList();
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
                    if (xe.Value.Contains($"{name}[{i}]"))
                    {
                        count = new Count(i);
                        break;
                    }
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

        public IEnumerable<Enum> ReadEnums(XDocument document)
        {
            foreach (var xml in document.Elements("enums"))
            {
                var @enum = new Enum();
                var enumType = xml.Attribute("type")?.Value;
                if (enumType == "bitmask" || enumType == "enum")
                {
                    @enum.NativeName = xml.Attribute("name")?.Value ?? throw new DataException("No name attribute");
                    @enum.Name = Naming.Translate
                    (
                        @enum.NativeName.Remove(0, EnumPrefix.Length), FunctionPrefix
                    );
                }
                else
                {
                    @enum.NativeName = string.Empty;
                    @enum.Name = FunctionPrefix.ToUpper() + "Constants";
                }

                @enum.Tokens = ReadTokens(xml).ToList();
                // todo: deprecation detection -> @enum.Attributes

                yield return @enum;
            }
        }

        private IEnumerable<Token> ReadTokens(XElement @enum)
        {
            foreach (var xml in @enum.Elements("enum"))
            {
                var bitpos = xml.Attribute("bitpos");
                var value = xml.Attribute("value");
                var comment = xml.Attribute("comment");
                var doc = comment != null
                    ? "///<summary>" + comment + "</summary>"
                    : "///<summary>To be added.</summary>";
                var name = xml.Attribute("name");
                if (name == null)
                {
                    throw new DataException("No name.");
                }

                var val = 0;
                if (bitpos != null)
                {
                    if (int.TryParse(bitpos.Value, out var pos))
                    {
                        val = 1 << pos;
                    }
                }

                if (value != null)
                {
                    if (int.TryParse(value.Value, out var intVal))
                    {
                        val = intVal;
                    }
                }

                yield return new Token
                {
                    Attributes = bitpos != null
                        ? new List<Attribute> {new Attribute {Name = "System.Flags"}}
                        : new List<Attribute>(),
                    Doc = doc,
                    Name = Naming.Translate(name.Value, FunctionPrefix),
                    NativeName = name.Value,
                    Value = val.ToString()
                };
            }
        }

        public IEnumerable<Function> ReadFunctions(XDocument document, IEnumerable<Enum> enums)
        {
            yield break; // todo
        }

        public IEnumerable<Project> ReadProjects(XDocument document, IEnumerable<Enum> enums, IEnumerable<Struct> structs, IEnumerable<Function> functions)
        {
            yield break; // todo
        }
    }
}
