// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis.CSharp;
using MoreLinq.Extensions;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Common.Structs;
using Attribute = Silk.NET.BuildTools.Common.Attribute;
using Enum = Silk.NET.BuildTools.Common.Enums.Enum;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Converters.Readers
{
    public class VulkanReader : IReader
    {
        public object Load(Stream stream)
        {
            return XDocument.Load(stream);
        }

        public IEnumerable<Struct> ReadStructs(object obj, ProfileConverterOptions opts)
        {
            var doc = obj as XDocument;
            var allStructs = doc.Element("registry")
                .Elements("types")
                .Elements("type")
                .Where(x => x.Attribute("category")?.Value == "struct")
                .ToDictionary
                (
                    x => x.Attribute("name")?.Value, x => x.Elements("member")
                        .Select
                        (
                            y => new Field
                            {
                                Count = ParseCountSignature
                                    (y.Attribute("len")?.Value, out _, out _, out _, out _, out _),
                                Name = Naming.Translate
                                (
                                    NameTrimmer.Trim(TrimName(y.Element("name")?.Value, opts), opts.Prefix),
                                    opts.Prefix
                                ),
                                NativeName = y.Attribute("name")?.Value,
                                NativeType = y.Element("type")?.Value,
                                Type = ParseTypeSignature(y.Element("type")?.Value),
                                Doc = y.Attribute("comment")?.Value
                            }
                        ).ToList()
                );
            var apis = doc.Element("registry")
                .Elements("feature")
                .Concat(doc.Element("registry").Elements("extensions").Elements("extension"));
            foreach (var api in apis)
            {
                foreach (var requirement in api.Elements("require"))
                {
                    var apiName = requirement.Attribute("api")?.Value ??
                                  api.Attribute("api")?.Value ??
                                  api.Attribute("supported")?.Value ??
                                  "vulkan";
                    var apiVersion = api.Attribute("number") != null
                        ? Version.Parse(api.Attribute("number").Value)
                        : null;
                    foreach (var name in apiName.Split('|'))
                    {
                        foreach (var @struct in requirement.Elements("type")
                            .Attributes("name")
                            .Select(x => x.Value))
                        {
                            if (allStructs.ContainsKey(@struct))
                            {
                                yield return new Struct
                                {
                                    Attributes = new List<Attribute>(), // TODO vulkan deprecation
                                    Fields = allStructs[@struct],
                                    Functions = new List<Function>(),
                                    Name = Naming.Translate
                                    (
                                        NameTrimmer.Trim(TrimName(@struct, opts), opts.Prefix),
                                        opts.Prefix
                                    ),
                                    NativeName = @struct,
                                    ProfileName = name,
                                    ProfileVersion = apiVersion,
                                    ExtensionName = api.Name == "feature" ? "Core" : TrimName(api.Attribute("name")?.Value, opts)
                                };
                            }
                        }
                    }
                }
            }

            foreach (var handle in doc.Element("registry")
                .Elements("types")
                .Elements("type")
                .Where(x => x.Attribute("category")?.Value == "handle")
                .Select(x => x.Element("name")?.Value))
            {
                yield return new Struct
                {
                    Attributes = new List<Attribute>(),
                    Fields = new List<Field>(), // opaque handle
                    Functions = new List<Function>(),
                    Name = Naming.Translate
                    (
                        NameTrimmer.Trim(TrimName(handle, opts), opts.Prefix),
                        opts.Prefix
                    ),
                    NativeName = handle,
                    ProfileName = "vulkan",
                    ProfileVersion = new Version(1, 0),
                };
            }
        }
        
        ////////////////////////////////////////////////////////////////////////////////////////
        // Function Parsing
        ////////////////////////////////////////////////////////////////////////////////////////

        public IEnumerable<Function> ReadFunctions(object obj, ProfileConverterOptions opts)
        {
            var doc = obj as XDocument;
            var allFunctions = doc.Element("registry").Elements("commands")
                .Elements("command")
                .Select(x => TranslateCommand(x, opts))
                .ToDictionary(x => x.Attribute("name")?.Value, x => x);
            var apis = doc.Element("registry").Elements("feature").Concat(doc.Element("registry").Elements("extensions").Elements("extension"));
            //var removals = doc.Element("registry").Elements("feature")
            //    .Elements("remove")
            //    .Elements("command")
            //    .Attributes("name")
            //    .Select(x => x.Value)
            //    .ToList();
            foreach (var api in apis)
            {
                foreach (var requirement in api.Elements("require"))
                {
                    var apiName = requirement.Attribute("api")?.Value ??
                                  api.Attribute("api")?.Value ??
                                  api.Attribute("supported")?.Value ??
                                  "vulkan";
                    var apiVersion = api.Attribute("number") != null && api.Name == "feature"
                        ? Version.Parse(api.Attribute("number").Value)
                        : null;
                    foreach (var name in apiName.Split('|'))
                    {
                        foreach (var function in requirement.Elements("command")
                            .Attributes("name")
                            .Select(x => x.Value))
                        {
                            var xf = allFunctions[TrimName(function, opts)];

                            var ret = new Function
                            {
                                Attributes = /*removals.Contains(function)
                                    ? new List<Attribute>
                                    {
                                        new Attribute
                                        {
                                            Name = "System.Obsolete",
                                            Arguments = new List<string>
                                            {
                                                $"\"Deprecated in version {apiVersion?.ToString(2)}\""
                                            }
                                        }
                                    }
                                    :*/ new List<Attribute>(),
                                Categories = new List<string>{TrimName(api.Attribute("name")?.Value, opts)},
                                Doc = string.Empty,
                                ExtensionName = api.Name == "feature" ? "Core" : TrimName(api.Attribute("name")?.Value, opts),
                                GenericTypeParameters = new List<GenericTypeParameter>(),
                                Name = Naming.Translate(NameTrimmer.Trim(TrimName(xf.Attribute("name")?.Value, opts), opts.Prefix), opts.Prefix),
                                NativeName = function,
                                Parameters = ParseParameters(xf),
                                ProfileName = name,
                                ProfileVersion = apiVersion,
                                ReturnType = ParseTypeSignature(xf.Element("returns"))
                            };

                            yield return ret;

                            allFunctions.Remove(function);
                        }
                    }
                }
            }
        }
        
        [NotNull]
        public static Type ParseTypeSignature([NotNull] XElement typeElement)
        {
            var typeString = typeElement.Attribute("type")?.Value ?? throw new DataException("Couldn't find type.");

            return ParseTypeSignature(typeString);
        }
        
        [NotNull]
        public static Type ParseTypeSignature([NotNull] string type, string original = null)
        {
            if (type.Contains('*') && (type.Contains('[') || type.Contains(']')))
            {
                throw new InvalidDataException("A type cannot be both a pointer and an array at the same time.");
            }

            const string constValueSpecifier = "const ";
            const string constPointerSpecifier = " const";
            const string structSpecifier = "struct ";

            // We'll ignore struct and const specifiers for the moment
            var isConstValue = type.StartsWith(constValueSpecifier);
            if (isConstValue)
            {
                type = type.Remove(0, constValueSpecifier.Length);
            }

            var isConstPointer = type.EndsWith(constPointerSpecifier);
            if (isConstPointer)
            {
                var specifierIndex = type.LastIndexOf(constPointerSpecifier, StringComparison.Ordinal);
                type = type.Remove(specifierIndex);
            }

            var isStruct = type.StartsWith(structSpecifier);
            if (isStruct)
            {
                type = type.Remove(0, structSpecifier.Length);
            }

            var typeName = new string(type.ToCharArray().Where(c => !char.IsWhiteSpace(c)).ToArray());

            var pointerLevel = 0;
            var isPointer = type.EndsWith("*");
            if (isPointer)
            {
                var firstPointerLevelIndex = typeName.IndexOf('*');
                var lastPointerLevelIndex = typeName.LastIndexOf('*');

                pointerLevel = Math.Abs(lastPointerLevelIndex - firstPointerLevelIndex) + 1;

                typeName = typeName.Remove(firstPointerLevelIndex);
            }

            var arrayLevel = 0;
            var isArray = typeName.EndsWith("]");
            if (isArray)
            {
                var firstArrayIndex = typeName.IndexOf('[');
                var lastArrayIndex = typeName.IndexOf(']');

                arrayLevel = Math.Abs(firstArrayIndex - lastArrayIndex);

                typeName = typeName.Remove(firstArrayIndex);
            }

            return new Type
            {
                Name = typeName,
                OriginalName = original ?? typeName,
                IndirectionLevels = pointerLevel,
                ArrayDimensions = arrayLevel
            };
        }
        
        /// </returns>
        [CanBeNull]
        [ContractAnnotation
        (
            "hasComputedCount : true => computedCountParameterNames : notnull; hasValueReference : true => valueReferenceName : notnull"
        )]
        public static Count ParseCountSignature
        (
            [CanBeNull] string countData,
            out bool hasComputedCount,
            [CanBeNull] out IReadOnlyList<string> computedCountParameterNames,
            out bool hasValueReference,
            [CanBeNull] out string valueReferenceName,
            [CanBeNull] out string valueReferenceExpression
        )
        {
            computedCountParameterNames = null;
            valueReferenceName = null;
            valueReferenceExpression = null;

            hasComputedCount = false;
            hasValueReference = false;

            if (string.IsNullOrWhiteSpace(countData))
            {
                return null;
            }

            if (int.TryParse(countData, out var staticCount))
            {
                return new Count(staticCount);
            }

            var countDataSpan = countData.AsSpan();
            if (countDataSpan.StartsWith("COMPSIZE"))
            {
                var slice = countDataSpan.Slice(countDataSpan.IndexOf('(') + 1);
                slice = slice.Slice(0, slice.IndexOf(')'));

                var countList = new List<string>();
                var record = string.Empty;
                foreach (var character in slice)
                {
                    if (character == ',')
                    {
                        countList.Add(record.Trim());
                        record = string.Empty;
                        continue;
                    }

                    record += character;
                }

                if (!string.IsNullOrWhiteSpace(record))
                {
                    countList.Add(record.Trim());
                }

                return new Count(countList);
            }

            if (SyntaxFacts.IsValidIdentifier(countData))
            {
                // It's a parameter value reference count (that is, taken from the value of another parameter)
                valueReferenceName = countData;

                hasValueReference = true;
                return new Count(valueReferenceName);
            }

            static bool IsMath(ReadOnlySpan<char> span)
            {
                for (var i = 0; i < span.Length; i++)
                {
                    if (span[i] != '+'
                        && span[i] != '-'
                        && span[i] != '*'
                        && span[i] != '/'
                        && span[i] != '^'
                        && span[i] != ' '
                        && !char.IsDigit(span[i]))
                    {
                        return false;
                    }
                }

                return true;
            }

            // check for count with expression.
            if (char.IsLetter(countDataSpan[0]))
            {
                var i = 1;
                while (char.IsLetterOrDigit(countDataSpan[i]))
                {
                    i++;
                } // at this point there HAS to be some invalid letter there, so no for needed.

                var identifier = new string(countDataSpan.Slice(0, i));
                var expression = countDataSpan.Slice(i);

                if (SyntaxFacts.IsValidIdentifier(identifier) && IsMath(expression))
                {
                    // the rest is likely a mathematical expression
                    valueReferenceName = identifier;
                    valueReferenceExpression = new string(expression);

                    hasValueReference = true;
                    return new Count(valueReferenceName);
                }
            }

            return null;
        }
        
        private static List<Parameter> ParseParameters([NotNull] XElement functionElement)
        {
            var parameterElements = functionElement.Elements().Where(e => e.Name == "param");
            var parametersWithComputedCounts =
                new List<(Parameter Parameter, IReadOnlyList<string> ComputedCountParameterNames)>();
            var parametersWithValueReferenceCounts =
                new List<(Parameter Parameter, string ParameterReferenceName)>();

            var resultParameters = new List<Parameter>();

            foreach (var parameterElement in parameterElements)
            {
                var parameter = ParseParameter
                (
                    parameterElement,
                    out var hasComputedCount,
                    out var computedCountParameterNames,
                    out var hasValueReference,
                    out var valueReferenceName,
                    out _
                );

                if (hasComputedCount)
                {
                    parametersWithComputedCounts.Add((parameter, computedCountParameterNames));
                }

                if (hasValueReference)
                {
                    parametersWithValueReferenceCounts.Add((parameter, valueReferenceName));

                    // TODO: Pass on the mathematical expression
                }

                resultParameters.Add(parameter);
            }

            return resultParameters;
        }
        
        private static Parameter ParseParameter
        (
            [NotNull] XElement paramElement,
            out bool hasComputedCount,
            [CanBeNull] out IReadOnlyList<string> computedCountParameterNames,
            out bool hasValueReference,
            [CanBeNull] out string valueReferenceName,
            [CanBeNull] out string valueReferenceExpression
        )
        {
            var paramName = paramElement.Attribute("name")?.Value ?? throw new DataException("Missing name attribute.");

            // A parameter is technically a type signature (think of it as Parameter : ITypeSignature)
            var paramType = ParseTypeSignature(paramElement);

            var paramFlowStr = paramElement.Attribute("flow").Value ?? throw new DataException("Missing flow attribute.");

            if (!System.Enum.TryParse<FlowDirection>(paramFlowStr, true, out var paramFlow))
            {
                throw new InvalidDataException("Could not parse the parameter flow.");
            }

            var paramCountStr = paramElement.Attribute("count")?.Value;
            var countSignature = ParseCountSignature
            (
                paramCountStr,
                out hasComputedCount,
                out computedCountParameterNames,
                out hasValueReference,
                out valueReferenceName,
                out valueReferenceExpression
            );

            return new Parameter
            {
                Name = Utilities.CSharpKeywords.Contains(paramName) ? $"@{paramName}" : paramName,
                Flow = paramFlow,
                Type = paramType,
                Count = countSignature
            };
        }

        private string FunctionName(XElement e, ProfileConverterOptions opts)
        {
            return TrimName(e.Element("proto")?.Element("name")?.Value ?? throw new ArgumentException("Element didn't have name within proto, or a proto element couldn't be found.", nameof(e)), opts);
        }

        public string TrimName(string name, ProfileConverterOptions opts)
        {
            if (name.StartsWith($"{opts.Prefix.ToUpper()}_"))
            {
                return name.Remove(0, opts.Prefix.Length + 1);
            }

            return name.ToLower().StartsWith(opts.Prefix.ToLower()) ? name.Remove(0, opts.Prefix.Length) : name;
        } 

        private static string FunctionParameterType(XElement e)
        {
            // Parse the C-like <proto> element. Possible instances:
            // Return types:
            // - <proto>void <name>glGetSharpenTexFuncSGIS</name></proto>
            //   -> <returns>void</returns>
            // - <proto group="String">const <ptype>GLubyte</ptype> *<name>glGetString</name></proto>
            //   -> <returns>String</returns>
            // Note: group attribute takes precedence if it exists. This matches the old .spec file format.
            // Parameter types:
            // - <param><ptype>GLenum</ptype> <name>shadertype</name></param>
            //   -> <param name="shadertype" type="GLenum" />
            // - <param len="1"><ptype>GLsizei</ptype> *<name>length</name></param>
            //   -> <param name="length" type="GLsizei" count="1" />
            var proto = e.Value;
            var name = e.Element("name");
            if (name == null) {
                throw new InvalidOperationException("Name is null");
            }

            var ret = proto.Remove(proto.LastIndexOf(name.Value, StringComparison.Ordinal)).Trim();

            return ret;
        }
        
        private XElement TranslateCommand(XElement command, ProfileConverterOptions opts)
        {
            if (command.Attribute("alias") != null)
            {
                var e = TranslateCommand
                (
                    command.Document.Element("registry")
                        .Elements("commands")
                        .Elements("command")
                        .FirstOrDefault(x => x.Element("proto")?.Element("name")?.Value == command.Attribute("alias")?.Value),
                    opts
                );
                e.SetAttributeValue("name", TrimName(command.Attribute("name")?.Value, opts));
                return e;
            }
            var function = new XElement("function");

            var cmdName = FunctionName(command, opts);
            var name = new XAttribute("name", cmdName);

            var returns = new XElement
            (
                "returns",
                new XAttribute
                (
                    "type",
                    FunctionParameterType(command.Element("proto"))
                        .Replace("const", string.Empty)
                        .Replace("struct", string.Empty)
                        .Replace("String *", "String")
                        .Trim()
                )
            );

            foreach (var parameter in command.Elements("param"))
            {
                var param = FunctionParameterType(parameter);

                var p = new XElement("param");
                var pname = new XAttribute("name", parameter.Element("name")?.Value ?? throw new NullReferenceException());
                var type = new XAttribute
                (
                    "type",
                    param
                        .Replace("const", string.Empty)
                        .Replace("struct", string.Empty)
                        .Trim()
                );

                var count = parameter.Attribute("len") != null
                    ? new XAttribute("count", parameter.Attribute("len")?.Value ?? throw new NullReferenceException())
                    : null;

                var flow = new XAttribute
                (
                    "flow",
                    param.Contains("*") && !param.Contains("const") ? "out" : "in"
                );

                p.Add(pname, type, flow);
                if (count != null)
                {
                    p.Add(count);
                }

                function.Add(p);
            }

            function.Add(name);
            function.Add(returns);
            return function;
        }
        
        ////////////////////////////////////////////////////////////////////////////////////////
        // Enum Parsing
        ////////////////////////////////////////////////////////////////////////////////////////

        public IEnumerable<Enum> ReadEnums(object obj, ProfileConverterOptions opts)
        {
            var doc = obj as XDocument;
            return doc?.Elements("enums")
                .Where(enumx => enumx.Attribute("type")?.Value == "enum" || enumx.Attribute("type")?.Value == "bitmask")
                .Select
                (
                    enumx =>
                    {
                        var typeAttr = enumx.Attribute("type");
                        var name = enumx.Attribute("name")?.Value;
                        var values = enumx.Elements("enum")
                            .Select
                            (
                                valuesx =>
                                {
                                    var tokenName = valuesx.Attribute("name")?.Value;

                                    string value;
                                    var valueStr = valuesx.Attribute("value")?.Value;
                                    if (valueStr != null)
                                    {
                                        value = FormatToken(valueStr);
                                    }
                                    else
                                    {
                                        var bitposStr = valuesx.Attribute("bitpos")?.Value;
                                        value = FormatToken((1 << int.Parse(bitposStr)).ToString());
                                    }

                                    return new Token
                                    {
                                        Attributes = new List<Attribute>(),
                                        Name = Naming.Translate
                                            (NameTrimmer.Trim(TrimName(tokenName, opts), opts.Prefix), opts.Prefix),
                                        NativeName = tokenName,
                                        Value = FormatToken(value)
                                    };
                                }
                            )
                            .ToList();

                        return new Enum
                        {
                            Name = Naming.Translate(NameTrimmer.Trim(TrimName(name, opts), opts.Prefix), opts.Prefix),
                            NativeName = name,
                            Attributes = new List<Attribute>(), // TODO: when the vk spec adds deprecation, add it here
                            ExtensionName = "Core", // can't determine this without faults.
                            ProfileName = "vulkan",
                            ProfileVersion = new Version(1, 0),
                            Tokens = values
                        };
                    }
                );
        }

        private static string FormatToken(string token)
        {
            if (token == null)
            {
                return null;
            }

            var tokenHex = token.StartsWith("0x") ? token.Substring(2) : token;

            if (!long.TryParse(tokenHex, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var value))
            {
                if (!long.TryParse(tokenHex, out value))
                {
                    throw new InvalidDataException("Token value was not in a valid format.");
                }
            }

            var valueString = $"0x{value:X}";
            var needsCasting = value > int.MaxValue || value < 0;
            if (needsCasting)
            {
                Debug.WriteLine($"Warning: casting overflowing enum value {token} from 64-bit to 32-bit.");
                valueString = $"unchecked((int){valueString})";
            }

            return valueString;
        }
    }
}
