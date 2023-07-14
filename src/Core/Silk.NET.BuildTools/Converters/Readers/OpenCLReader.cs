// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;

using Microsoft.CodeAnalysis.CSharp;
using MoreLinq.Extensions;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Common.Structs;
using Silk.NET.BuildTools.Converters.Khronos;
using Attribute = Silk.NET.BuildTools.Common.Attribute;
using Enum = Silk.NET.BuildTools.Common.Enums.Enum;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

// Lots of string literals that don't follow the normal style here
// ReSharper disable StringLiteralTypo

namespace Silk.NET.BuildTools.Converters.Readers
{
    /// <summary>
    /// API reader for OpenCL.
    /// </summary>
    public class OpenCLReader : IReader
    {
        private static readonly Dictionary<string, (string value, string type)> Constants = new Dictionary<string, (string, string)>
        {
            {"CL_NAN", ("float.NaN", "float")},
            {"CL_HUGE_VALF", ("float.PositiveInfinity", "float")},
            {"CL_HUGE_VAL", ("double.PositiveInfinity", "double")},
            {"CL_MAXFLOAT", ("float.MaxValue", "float")},
            {"CL_INFINITY", ("float.PositiveInfinity", "float")},
            {"CL_IMPORT_MEMORY_WHOLE_ALLOCATION_ARM", ("ulong.MaxValue", "ulong")},
            {"CL_PARTITION_BY_COUNTS_LIST_END_EXT", ("0", "uint")},
            {"CL_PARTITION_BY_NAMES_LIST_END_EXT", ("ulong.MaxValue", "ulong")},
            {"CL_PARTITION_BY_NAMES_LIST_END_INTEL", ("ulong.MaxValue", "ulong")},
            {"CL_PROPERTIES_LIST_END_EXT", ("0", "uint")},

        };
        
        /// <inheritdoc />
        public object Load(Stream stream)
        {
            return XDocument.Load(stream);
        }
        
        /// <inheritdoc />
        public IEnumerable<Struct> ReadStructs(object obj, BindTask task)
        {
            var xd = (XDocument) obj;

            var registry = xd.Element("registry");

            Debug.Assert(registry != null, nameof(registry) + " != null");

            var rawStructs = registry.Elements("types")
                .Elements("type")
                .Where(type => type.HasCategoryAttribute("struct"))
                .Select(StructureDefinition.CreateFromXml)
                .ToArray();

            var structs = ConvertStructs(rawStructs, task);

            var apis = registry.Elements("feature").Concat
            (
                registry.Elements("extensions").Elements("extension")
                ?? throw new InvalidDataException()
            );
            Debug.Assert(apis != null, nameof(apis) + " != null");

            foreach (var api in apis)
            {
                foreach (var requirement in api.Elements("require"))
                {
                    var apiName = requirement.Attribute("api")?.Value ??
                                  api.Attribute("api")?.Value ??
                                  api.Attribute("supported")?.Value ??
                                  "opencl";
                    var apiVersion = api.Attribute("number") != null
                        ? Version.Parse(api.Attribute("number")?.Value ?? throw new InvalidDataException())
                        : null;
                    foreach (var s in requirement
                        .Elements("type")
                        .Attributes("name")
                        .Select(x => Rename(x.Value, task))
                        .Where(x => structs.ContainsKey(x))
                        .Select(x => structs[x]))
                    {
                        yield return new Struct
                        {
                            Attributes = s.Attributes,
                            ExtensionName = api.Name == "feature"
                                           ? "Core"
                                           : ExtensionName(api.Attribute("name")?.Value, task),
                            Fields = s.Fields,
                            Functions = s.Functions,
                            Name = s.Name,
                            NativeName = s.NativeName,
                            ProfileName = apiName,
                            ProfileVersion = apiVersion,
                        };
                    }
                }
            }

            task.TypeMaps.Add(structs.ToDictionary(x => x.Key.Renamed, x => x.Value.Name));
        }

        private static Dictionary<RenamedEntry, Struct> ConvertStructs(IEnumerable<StructureDefinition> spec, BindTask task)
        {
            var prefix = task.FunctionPrefix;
            var ret = new Dictionary<RenamedEntry, Struct>();
            foreach (var s in spec)
            {
                var renamedStruct = Rename(s.Name, task);
                ret.Add
                (
                    renamedStruct, new Struct
                    {
                        Fields = s.Members.Select
                        (
                            x =>
                            {
                                var renamedField = Rename(x.Name, task);
                                var fieldType = ConvertType(x.Type, task);
                                return new Field
                                {
                                    Count = string.IsNullOrEmpty(x.ElementCountSymbolic)
                                                                    ? x.ElementCount != 1 ? new Count(x.ElementCount) : null
                                                                    : new Count(x.ElementCountSymbolic, false),
                                    Name = Naming.Translate(TrimName(renamedField.Renamed, task), prefix),
                                    Doc = $"/// <summary>{x.Comment}</summary>",
                                    NativeName = renamedField.Original,
                                    NativeType = x.Type.ToString(),
                                    Type = fieldType
                                }.WithFixedFieldFixup09072020();
                            })
                        .ToList(),
                        Name = Naming.TranslateLite(TrimName(renamedStruct.Renamed, task), prefix),
                        NativeName = renamedStruct.Original
                    }
                );
            }

            return ret;
        }

        private static Type ConvertType(TypeSpec type, BindTask task)
        {
            var renamed = Rename(type.Name, task);
            return new Type
            {
                ArrayDimensions = type.ArrayDimensions,
                IndirectionLevels = type.PointerIndirection,
                Name = renamed.Renamed,
                OriginalName = renamed.Original
            };
        }

        
        ////////////////////////////////////////////////////////////////////////////////////////
        // Function Parsing
        ////////////////////////////////////////////////////////////////////////////////////////

        /// <inheritdoc />
        public IEnumerable<Function> ReadFunctions(object obj, BindTask task)
        {
            var doc = obj as XDocument;
            Debug.Assert(doc != null, nameof(doc) + " != null");
            
            var registry = doc.Element("registry");
            Debug.Assert(registry != null, $"{nameof(registry)} != null");
            
            var allFunctions = registry
                .Elements("commands")
                .Elements("command")
                .Select(x => TranslateCommand(x, task))
                .ToDictionary(x => x.Attribute("name")?.Value, x => x);
            Debug.Assert(allFunctions != null, nameof(allFunctions) + " != null");
            
            var apis = registry.Elements("feature")
                .Concat(registry
                    .Elements("extensions")
                    .Elements("extension") ?? throw new InvalidDataException());
            
            Debug.Assert(apis != null, nameof(apis) + " != null");
            
            var removals = registry.Elements("feature")
                .Elements("remove")
                .Elements("command")
                .Attributes("name")
                .Select(x => x.Value)
                .ToList();
            
            Debug.Assert(removals != null, nameof(removals) + " != null");
            
            foreach (var api in apis)
            {
                foreach (var requirement in api.Elements("require"))
                {
                    var apiName = requirement.Attribute("api")?.Value ??
                                  api.Attribute("api")?.Value ??
                                  api.Attribute("supported")?.Value ??
                                  "opencl";
                    var apiVersion = api.Attribute("number") != null
                        ? Version.Parse(api.Attribute("number")?.Value ?? throw new InvalidDataException())
                        : null;
                    foreach (var name in apiName.Split('|'))
                    {
                        foreach (var function in requirement.Elements("command")
                            .Attributes("name")
                            .Select(x => x.Value))
                        {
                            var xf = allFunctions[TrimName(function, task)];
                            
                            var ret = new Function
                            {
                                Attributes = removals.Contains(function)
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
                                    : new List<Attribute>(),
                                Categories = new List<string>{ExtensionName(api.Attribute("name")?.Value, task)},
                                Doc = string.Empty,
                                ExtensionName = api.Name == "feature" ? "Core" : ExtensionName(api.Attribute("name")?.Value, task),
                                GenericTypeParameters = new List<GenericTypeParameter>(),
                                Name = Naming.Translate(NameTrimmer.Trim(TrimName(xf.Attribute("name")?.Value, task), task.FunctionPrefix), task.FunctionPrefix),
                                NativeName = function,
                                Parameters = ParseParameters(xf),
                                ProfileName = name,
                                ProfileVersion = apiVersion,
                                ReturnType = ParseTypeSignature(xf.Element("returns") ?? throw new InvalidDataException())
                            };

                            yield return ret;

                            allFunctions.Remove(function);
                        }
                    }
                }
            }
        }
        
        /// <summary>
        /// Parse the type signature of the provided element.
        /// </summary>
        /// <param name="typeElement">The element to parse.</param>
        /// <returns>The type signature.</returns>
        public static Type ParseTypeSignature(XElement typeElement)
        {
            var typeString = typeElement.Attribute("type")?.Value ?? throw new DataException("Couldn't find type.");
            var group = typeElement.Attribute("group")?.Value;

            var ret = ParseTypeSignature(typeString);

            if (!(group is null))
            {
                ret.OriginalGroup = group;
            }

            return ret;
        }
        
        /// <summary>
        /// Parse the type signature of the provided string.
        /// </summary>
        /// <param name="type">The type to parse.</param>
        /// <param name="original">The original type string. Can be omitted.</param>
        /// <returns>The parsed type.</returns>
        /// <exception cref="InvalidDataException">Thrown if type tries to be both a pointer and array.</exception>
        public static Type ParseTypeSignature(string type, string? original = null)
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
        
        /// <summary>
        /// Deduce a parameter's Count from an XML signature.
        /// </summary>
        /// <param name="countData">The count data.</param>
        /// <param name="hasComputedCount">Have we successfully computed the count?</param>
        /// <param name="computedCountParameterNames">The names of all computed count parameters.
        /// If <paramref name="hasComputedCount"/> is false, this is null.</param>
        /// <param name="hasValueReference">Does this have a value reference?</param>
        /// <param name="valueReferenceName">The value reference name.
        /// if <paramref name="hasValueReference"/> is false, this is null.</param>
        /// <param name="valueReferenceExpression">The value reference expression.
        /// if <paramref name="hasValueReference"/> is false, this is null.</param>
        /// <returns>The computed Count.</returns>
        /// <exception cref="InvalidDataException">Thrown if no valid count could be deduced.</exception>
        public static Count? ParseCountSignature
        (
            string? countData,
            out bool hasComputedCount,
            out IReadOnlyList<string>? computedCountParameterNames,
            out bool hasValueReference,
            out string? valueReferenceName,
            out string? valueReferenceExpression
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
                foreach (var t in span)
                {
                    if (t != '+'
                        && t != '-'
                        && t != '*'
                        && t != '/'
                        && t != '^'
                        && t != ' '
                        && !char.IsDigit(t))
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
                    return new Count(valueReferenceName) { Expression = valueReferenceExpression };
                }
            }
            
            throw new InvalidDataException("No valid count could be parsed from the input.");
        }
        
        private static List<Parameter> ParseParameters(XElement functionElement)
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

                if (parameter.Type.Name.Contains("CL_CALLBACK"))
                {
                    resultParameters.Add
                    (
                        new Parameter
                        {
                            Name = parameter.Name,
                            Attributes = new List<Attribute>
                            {
                                new()
                                {
                                    Name = "PinObjectAttribute",
                                    Arguments = new List<string> { "PinMode.UntilNextCall" }
                                }
                            },
                            Count = null,
                            Flow = FlowDirection.In,
                            Type = new Type
                            {
                                Name = $"CL_CALLBACK_{functionElement.Attribute("name")?.Value}_{parameter.Name}",
                                OriginalName = parameterElement.Value,
                                OriginalGroup = parameterElement.Value,
                                IndirectionLevels = 1
                            }
                        }
                    );
                    continue;
                }

                if (hasComputedCount)
                {
                    parametersWithComputedCounts.Add((parameter, computedCountParameterNames));
                }

                if (hasValueReference)
                {
                    parametersWithValueReferenceCounts.Add((parameter, valueReferenceName));

                    // TODO: Pass on the mathematical expression
                }

                if (parameter.Type.ToString() == "void")
                {
                    // uh-oh, bad parameter alert. Add a pointer to hopefully make it better.
                    parameter.Type.IndirectionLevels++;
                }

                resultParameters.Add(parameter);
            }

            return resultParameters;
        }
        
        private static Parameter ParseParameter
        (
            XElement paramElement,
            out bool hasComputedCount,
            out IReadOnlyList<string>? computedCountParameterNames,
            out bool hasValueReference,
            out string? valueReferenceName,
            out string? valueReferenceExpression
        )
        {
            var paramName = paramElement.Attribute("name")?.Value ?? throw new DataException("Missing name attribute.");

            // A parameter is technically a type signature (think of it as Parameter : ITypeSignature)
            var paramType = ParseTypeSignature(paramElement);

            var paramFlowStr = paramElement.Attribute("flow")?.Value ?? throw new DataException("Missing flow attribute.");

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
                Count = countSignature,
                Attributes = paramType.Name.StartsWith
                    ("CL_CALLBACK")
                    ? new List<Attribute>
                    {
                        new Attribute
                        {
                            Arguments = new List<string> {"PinMode.UntilNextCall"},
                            Name = "PinObjectAttribute"
                        }
                    }
                    : new List<Attribute>()
            };
        }

        private static string FunctionName(XContainer e, BindTask task)
        {
            return TrimName(e.Element("proto")?.Element("name")?.Value, task);
        }

        /// <summary>
        /// Trims the prefix off a name.
        /// </summary>
        /// <param name="name">The name to trim.</param>
        /// <param name="opts">The profile options containing the prefix.</param>
        /// <returns>The name, trimmed.</returns>
        public static string TrimName(string name, BindTask task)
        {
            if (name.ToUpper().StartsWith($"{task.FunctionPrefix.ToUpper()}_"))
            {
                return name.Remove(0, task.FunctionPrefix.Length + 1);
            }

            return name.ToLower().StartsWith(task.FunctionPrefix.ToLower())
                ? name.Remove(0, task.FunctionPrefix.Length)
                : name;
        }
        
        private static string FunctionParameterType(XElement e)
        {
            // ReSharper disable CommentTypo
            // Parse the C-like <proto> element. Possible instances:
            // Return types:
            // - <proto>void <name>clGetSharpenTexFuncSGIS</name></proto>
            //   -> <returns>void</returns>
            // - <proto group="String">const <ptype>clubyte</ptype> *<name>clGetString</name></proto>
            //   -> <returns>String</returns>
            // Note: group attribute takes precedence if it exists. This matches the old .spec file format.
            // Parameter types:
            // - <param><ptype>clenum</ptype> <name>shadertype</name></param>
            //   -> <param name="shadertype" type="clenum" />
            // - <param len="1"><ptype>clsizei</ptype> *<name>length</name></param>
            //   -> <param name="length" type="clsizei" count="1" />
            // ReSharper restore CommentTypo
            var proto = e.Value;
            var name = e.Element("name");
            if (name == null) {
                Console.WriteLine($"Warning: Parameter name is null. Element: {e}.");
            }

            var ret = name is null
                ? proto
                : proto.Remove(proto.LastIndexOf(name.Value, StringComparison.Ordinal)).Trim();

            return ret;
        }

        private int _unnamedParameters;
        private XElement TranslateCommand(XContainer command, BindTask task)
        {
            var function = new XElement("function");

            var cmdName = FunctionName(command, task);
            var name = new XAttribute("name", cmdName);

            var returns = new XElement
            (
                "returns",
                command.Element("proto")?.Attribute("group") is null ? new object[]{new XAttribute
                (
                    "type",
                    FunctionParameterType(command.Element("proto"))
                        .Replace("const", string.Empty)
                        .Replace("struct", string.Empty)
                        .Replace("String *", "String")
                        .Trim()
                )} : new object[]{new XAttribute
                (
                    "type",
                    FunctionParameterType(command.Element("proto"))
                        .Replace("const", string.Empty)
                        .Replace("struct", string.Empty)
                        .Replace("String *", "String")
                        .Trim()
                ), new XAttribute("group", command.Element("proto")?.Attribute("group")?.Value ?? throw new InvalidDataException())}
            );

            foreach (var parameter in command.Elements("param"))
            {
                var param = FunctionParameterType(parameter);

                var p = new XElement("param");
                string randomName = null;
                if (parameter.Element("name") is null)
                {
                    Console.WriteLine($"Warning: Parameter name is null. Element: {parameter}.");
                    randomName = "unnamedParameter" + _unnamedParameters++;
                    Console.WriteLine($"Giving it name {randomName}");
                }

                var paramName = new XAttribute("name", (parameter.Element("name")?.Value ?? randomName)
                                                       ?? throw new InvalidDataException());
                
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

                p.Add(paramName, type, flow);
                if (count != null)
                {
                    p.Add(count);
                }

                if (!(parameter.Attribute("group") is null))
                {
                    p.Add(new XAttribute("group", parameter.Attribute("group")?.Value
                                                  ?? throw new InvalidDataException()));
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

        /// <inheritdoc />
        public IEnumerable<Enum> ReadEnums(object obj, BindTask task)
        {
            var doc = obj as XDocument;
            Debug.Assert(doc != null, $"{nameof(doc)} != null");

            var registry = doc.Element("registry");
            Debug.Assert(registry != null, $"{nameof(registry)} != null");

            string ProcessTypedef(XElement element)
            {
                if (element.Value.Contains('*'))
                {
                    if (element.Value.StartsWith("typedef struct") || element.Element("type")?.Value == "void")
                    {
                        return "intptr_t";
                    }

                    throw new InvalidDataException("Unable to process a typedef");
                }

                return element.Element("type")?.Value;
            }

            var typemap = registry
                .Elements("types")
                .Elements("type")
                .Where(x => x.Attribute("category")?.Value == "define" && x.Value.StartsWith("typedef"))
                .Select(x => (x.Element("name").Value, ProcessTypedef(x)))
                .Where(x => x.Item2 != null)
                .ToDictionary(x => x.Item1, x => x.Item2);

            var nulls = typemap.Where(x => x.Value == null).ToArray();

            task.TypeMaps.Add(typemap);

            var apis = registry.Elements("feature").Concat
            (
                registry.Elements("extensions").Elements("extension")
                ?? throw new InvalidDataException()
            );
            Debug.Assert(apis != null, nameof(apis) + " != null");

            var ulongEnums = new HashSet<string>(registry
                .Elements("types")
                .Elements("type")
                .Where(e => e.Elements("type").SingleOrDefault()?.Value == "cl_bitfield" ||
                            e.Elements("type").SingleOrDefault()?.Value == "cl_properties" ||
                            e.Elements("type").SingleOrDefault()?.Value == "cl_ulong"
                      )
                .Select(e => Rename(e.Element("name").Value, task).Renamed));

            var nintEnums = new HashSet<string>(registry
                .Elements("types")
                .Elements("type")
                .Where(e => e.Elements("type").SingleOrDefault()?.Value == "intptr_t")
                .Select(e => Rename(e.Element("name").Value, task).Renamed));

            var flagEnums = new HashSet<string>(registry
                .Elements("enums")
                .Where(e => e.Attribute("type")?.Value == "bitmask")
                .Select(e => Rename(e.Attribute("name").Value, task).Renamed)
                .Concat(registry
                .Elements("types")
                .Elements("type")
                .Where(e => e.Elements("type").SingleOrDefault()?.Value == "cl_bitfield")
                .Select(e => Rename(e.Element("name").Value, task).Renamed)));

            var enumEntries = new Dictionary<RenamedEntry, HashSet<RenamedEntry>>();
            var enumTypes = new Dictionary<RenamedEntry, HashSet<RenamedEntry>>();

            void AddEntry(RenamedEntry key, RenamedEntry value, Dictionary<RenamedEntry, HashSet<RenamedEntry>> dict)
            {
                if (dict.TryGetValue(key, out var list))
                {
                    list.Add(value);
                }
                else
                {
                    dict.Add(key, new HashSet<RenamedEntry> { value });
                }
            }

            var constants = new HashSet<RenamedEntry>(registry
                .Elements("enums")
                .Where(x => x.Attribute("name").Value.StartsWith("Constants") || 
                            x.Attribute("name").Value == "MiscNumbers")
                .Elements("enum")
                .Select(x => Rename(x.Attribute("name").Value, task))
                .Concat(Constants.Keys.Select(c => Rename(c, task))));

            // Mark enums based on "enums" tags
            var enumsPass1 = registry
                .Elements("enums")
                .Elements("enum")
                .Where
                (
                    x => !x.Parent.Attribute("name").Value.StartsWith("Constants") &&
                         !x.Parent.Attribute("name").Value.StartsWith("enums") && // these are unnamed
                         x.Parent.Attribute("name").Value != "MiscNumbers" &&     // these are constants
                         x.Parent.Attribute("name").Value != "cl_device_info"     // bug in XML spec - see https://github.com/KhronosGroup/OpenCL-Docs/pull/779
                )
                .ToDictionary
                (
                    x => Rename(x.Attribute("name").Value, task),
                    x =>
                    {
                        var type = Rename(x.Parent.Attribute("name").Value, task);
                        string newName = "";
                        var typeStr = type.Renamed;
                        if (typeStr.StartsWith("ErrorCodes"))
                        {
                            return new RenamedEntry(type.Original, "ErrorCodes");
                        }
                        if (typeStr.EndsWith(".flags"))
                        {
                            newName = typeStr.Substring(0, typeStr.Length - ".flags".Length);
                            flagEnums.Add(newName);
                            return new RenamedEntry(type.Original, newName);
                        }
                        newName = typeStr.Replace('.', '_');
                        if (flagEnums.Contains(typeStr))
                        {
                            flagEnums.Add(newName);
                        }
                        return new RenamedEntry(type.Original, newName);
                    }
                );

            // Mark enums based on "require" tags
            apis.Elements("require")
                .Elements("enum").ForEach(x =>
                {
                    var name = Rename(x.Attribute("name").Value, task);

                    if (constants.Contains(name)) return;

                    var type = Rename(x.Parent.Attribute("comment")?.Value, task);

                    var typeStr = type?.Renamed;

                    if (typeStr == null || typeStr.Contains(' '))
                    {
                        if (enumsPass1.TryGetValue(name, out var pass1type))
                        {
                            type = pass1type;
                        }
                        else if (typeStr != null)
                        {
                            if (typeStr == "Error codes") type = new RenamedEntry(type.Original, "ErrorCodes");
                            else if (typeStr?.StartsWith("OpenCL ") ?? false && typeStr.Contains("deprecated"))
                            {
                                // Core spec deprecation notices
                                var typeNameStart = typeStr.IndexOf(' ', "OpenCL ".Length) + 1;
                                var typeNameEnd = typeStr.IndexOf(' ', typeNameStart + 1);
                                type = new RenamedEntry(type.Original, typeStr.Substring(typeNameStart, typeNameEnd - typeNameStart));
                            }
                            else if (typeStr?.StartsWith("cl_uint ") ?? false) type = new RenamedEntry(type.Original, typeStr.Substring("cl_uint ".Length)); // QCOM extensions
                            else type = null;
                        }
                    }

                    if(type != null)
                    {
                        AddEntry(type, name, enumEntries);
                        AddEntry(name, type, enumTypes);
                    }
                });

            // Add empty enums that are defined in spec but have no members (yet)
            registry
                .Elements("types")
                .Elements("type")
                .Where(e => e.Elements("type").SingleOrDefault()?.Value == "cl_bitfield" ||
                            e.Elements("type").SingleOrDefault()?.Value == "cl_properties"
                      )
                .Select(e => Rename(e.Element("name").Value, task))
                .Where(x => !enumEntries.ContainsKey(x))
                .ForEach(x => enumEntries.Add(x, new HashSet<RenamedEntry>()));

            // Read actual enum values
            var enumValues = registry
                .Elements("enums")
                .Elements("enum")
                .Where
                (
                    x => !x.Parent.Attribute("name").Value.StartsWith("Constants") &&
                          x.Parent.Attribute("name").Value != "MiscNumbers"
                )
                .ToDictionary
                (
                    x => Rename(x.Attribute("name").Value, task).Renamed,
                    x => FormatToken
                            (x.Attribute("value")?.Value ?? (x.Attribute("bitpos") is null
                                ? null
                                : (1L << int.Parse(x.Attribute("bitpos")?.Value ?? throw new InvalidDataException())).ToString("X")))
                );
            Debug.Assert(enumValues != null, nameof(enumValues) + " != null");

            var removals =
                registry
                .Elements("feature")
                .Elements("require")
                .Where(x => x.Attribute("comment")?.Value.Contains("deprecated") ?? false)
                .Elements("enum")
                .ToDictionary(x => x.Attribute("name").Value, x => GetDeprecatedIn(x.Parent.Attribute("comment").Value));

            List<Attribute> GetTokenAttributes(string name)
            {
                if (!removals.TryGetValue(name, out var version))
                {
                    return new List<Attribute>();
                }

                return new List<Attribute>
                {
                    new Attribute
                    {
                        Arguments = new List<string>
                        {$"\"Deprecated in version {version}\""},
                        Name = "System.Obsolete"
                    }
                };
            }
            
            foreach (var api in apis)
            {
                foreach (var requirement in api.Elements("require"))
                {
                    var apiName = requirement.Attribute("api")?.Value ??
                                  api.Attribute("api")?.Value ??
                                  api.Attribute("supported")?.Value ??
                                  "opencl";
                    var apiVersion = api.Attribute("number") != null
                        ? Version.Parse(api.Attribute("number")?.Value ?? throw new InvalidDataException())
                        : null;
                    var tokens = requirement
                        .Elements("enum")
                        .Attributes("name")
                        .Select(x => Rename(x.Value, task))
                        .Where(x => !constants.Contains(x))
                        .Select
                        (
                            token => new Token
                            {
                                Attributes = GetTokenAttributes(token.Renamed),
                                Doc = string.Empty,
                                Name = Naming.Translate(TrimName(token.Renamed, task), task.FunctionPrefix),
                                NativeName = token.Original,
                                Value = enumValues[token.Renamed]
                            }
                        ).ToList();

                    Debug.Assert(!apiName.Contains('|'));

                    var ret = new Enum
                    {
                        Attributes = new List<Attribute>(),
                        ExtensionName = api.Name == "feature"
                                           ? "Core"
                                           : ExtensionName(api.Attribute("name")?.Value, task),
                        Name = "Globals",
                        NativeName = api.Attribute("name")?.Value,
                        ProfileName = apiName,
                        ProfileVersion = apiVersion,
                        Tokens = tokens
                    };

                    yield return ret;
                }
            }

            List<Attribute> GetEnumAttributes(string name)
            {
                if (!flagEnums.Contains(name))
                {
                    return new List<Attribute>();
                }

                return new List<Attribute>
                {
                    new Attribute
                    {
                        Name = "System.Flags"
                    }
                };
            }

            var coreEnums = new HashSet<RenamedEntry>(registry
                .Elements("feature")
                .Elements("require")
                .Elements("enum")
                .Attributes("name")
                .Select(x => Rename(x.Value, task))
                .Where(x => !constants.Contains(x))
                .SelectMany(name => enumTypes[name])
                .Concat(registry
                .Elements("feature")
                .Elements("require")
                .Elements("type")
                .Attributes("name")
                .Select(x => Rename(x.Value, task))
                ));

            var enumExtensionsByType = registry
                .Elements("extensions")
                .Elements("extension")
                .Select(e => (e, ExtensionName(e.Attribute("name")?.Value, task)))
                .SelectMany(e => e.Item1
                    .Elements("require")
                    .Elements("type")
                    .Attributes("name")
                    .Select(x => Rename(x.Value, task))
                    .Where(x => enumEntries.ContainsKey(x))
                    .Where(x => !coreEnums.Contains(x))
                    .Select(type => (type, e.Item2)))
                .ToList();

            var enumExtensionsInferred = registry
                .Elements("extensions")
                .Elements("extension")
                .Select(e => (e, ExtensionName(e.Attribute("name")?.Value, task)))
                .SelectMany(e => e.Item1
                    .Elements("require")
                    .Elements("enum")
                    .Attributes("name")
                    .Select(x => Rename(x.Value, task))
                    .Where(x => !constants.Contains(x))
                    .Where(x => enumTypes.ContainsKey(x))
                    .SelectMany(x => enumTypes[x])
                    .Where(x => !coreEnums.Contains(x))
                    .Distinct()
                    .Select(type => (type, e.Item2)))
                .ToList();

            var enumExtensions = new Dictionary<RenamedEntry, RenamedEntry>();

            foreach (var enumExt in enumExtensionsByType.Concat(enumExtensionsInferred))
            {
                enumExtensions.TryAdd(enumExt.Item1, Rename(enumExt.Item2, task));
            }

            var enumTypemap = new Dictionary<string, string>();

            foreach (var group in enumEntries)
            {
                var tokens = group.Value.Select(name =>
                {
                    var value = enumValues[name.Renamed];
                    return new Token
                    {
                        Attributes = GetTokenAttributes(name.Renamed),
                        Doc = string.Empty,
                        Name = Naming.Translate(TrimName(name.Renamed, task), task.FunctionPrefix),
                        NativeName = name.Original,
                        Value = value
                    };
                }).ToList();

                string baseName = "";
                string rawName = "";
                if (enumExtensions.TryGetValue(group.Key, out var extName))
                {
                    baseName = extName.Renamed.Substring(0, extName.Renamed.IndexOf('_'));
                    var groupNoTag = group.Key.Renamed.Replace($"_{baseName}", "", StringComparison.OrdinalIgnoreCase);
                    rawName = groupNoTag;

                    if (tokens.Count == 0 && enumEntries.ContainsKey(new RenamedEntry(group.Key.Original, groupNoTag)))
                    {
                        continue;
                    }
                }
                else
                {
                    extName = new RenamedEntry("Core (Grouped)", "Core (Grouped)");
                    rawName = group.Key.Renamed;
                    baseName = "CLEnum";
                }

                var groupName = Naming.Translate(TrimName(rawName, task), task.FunctionPrefix);
                var is64bit = ulongEnums.Contains(group.Key.Renamed);
                var isNint = nintEnums.Contains(group.Key.Renamed);

                RenameTokens(tokens, group.Key.Renamed, baseName, task);

                // Allow intptr_t based enums to fall through to the nint base type
                if (!isNint)
                {
                    enumTypemap[group.Key.Original] = groupName;
                    enumTypemap[group.Key.Renamed] = groupName;
                }

                foreach (var (apiName, apiVersion) in registry
                    .Elements("feature")
                    .Select(x => (x.Attribute("api")?.Value, x.Attribute("number")?.Value))
                    .Distinct())
                {
                    var ret = new Enum
                    {
                        Name = groupName,
                        NativeName = group.Key.Original,
                        Attributes = GetEnumAttributes(group.Key.Renamed),
                        ExtensionName = extName.Renamed,
                        ProfileName = apiName,
                        ProfileVersion = Version.Parse(apiVersion),
                        Tokens = tokens,
                        EnumBaseType = (is64bit || isNint) ? new Type { Name = "ulong" } : new Type { Name = "int" }
                    };
            
                    yield return ret;
                }
            }

            task.TypeMaps.Add(enumTypemap);
        }

        private void RenameTokens(List<Token> list, string groupName, string extTag, BindTask task)
        {
            if (list.Count == 0) return;

            var prefix = "";
            if (list.Count == 1)
            {
                prefix = Utilities.FindCommonPrefix(new List<string> { Rename(list[0].NativeName, task).Renamed, groupName }, true, false);
            }
            else
            {
                prefix = Utilities.FindCommonPrefix(list.Select(x => Rename(x.NativeName, task).Renamed).ToList(), false, false);
            }

            string suffix = "";
            if (extTag != "")
            {
                suffix = $"_{extTag}";
            }

            string TrimTag(string name)
            {
                if (suffix.Length == 0)
                {
                    return name;
                }
                if (name.EndsWith(suffix, StringComparison.OrdinalIgnoreCase))
                {
                    return name.Substring(0, name.Length - suffix.Length);
                }
                return name;
            }

            foreach (var token in list)
            {
                token.Name = Naming.Translate(TrimTag(Rename(token.NativeName, task).Renamed.Substring(prefix.Length)), task.FunctionPrefix);
            }
        }

        private static RenamedEntry Rename(string origName, BindTask task)
        {
            if (origName == null)
            {
                return null;
            }

            if (task.RenamedNativeNames.TryGetValue(origName, out var renamed))
            {
                return new RenamedEntry(origName, renamed);
            }
            return new RenamedEntry(origName, origName);
        }

        private string GetDeprecatedIn(string msg)
        {
            return msg.Substring(msg.LastIndexOf(' ') + 1);
        }

        private static string ExtensionName(string ext, BindTask task)
        {
            ext = Rename(ext, task).Renamed;

            var trimmedExt = TrimName(ext, task);
            var splitTrimmed = trimmedExt.Split('_');
            return splitTrimmed[0].ToUpper() + "_" + string.Join
                       ("_", new ArraySegment<string>(splitTrimmed, 1, splitTrimmed.Length - 1));
        }

        /// <inheritdoc />
        public IEnumerable<Constant> ReadConstants(object obj, BindTask task)
        {
            var doc = obj as XDocument;
            Debug.Assert(doc != null, $"{nameof(doc)} != null");

            var registry = doc.Element("registry");
            Debug.Assert(registry != null, $"{nameof(registry)} != null");

            var constants = new List<(RenamedEntry, string)>(registry
                .Elements("enums")
                .Where(x => x.Attribute("name").Value.StartsWith("Constants") || 
                            x.Attribute("name").Value == "MiscNumbers")
                .Elements("enum")
                .Select(x => (Rename(x.Attribute("name").Value, task), x.Attribute("value").Value)));

            return constants.Select
            (
                x =>
                {
                    var type = GetConstType(x.Item1.Renamed);
                    var value = GetConstValue(x.Item1.Renamed, x.Item2, type);
                    if (Constants.TryGetValue(x.Item1.Renamed, out var t))
                    {
                        value = t.value;
                        type = t.type;
                    }

                    return new Constant
                    {
                        Name = Naming.Translate(TrimName(x.Item1.Renamed, task), task.FunctionPrefix),
                        NativeName = x.Item1.Original,
                        Type = new Type { Name = type },
                        Value = value
                    };
                });
        }

        private string GetConstValue(string name, string origValue, string type)
        {
            if (name.StartsWith("CL_HALF")) return origValue;

            if (name.EndsWith("_MIN")) return $"{type}.MinValue";
            if (name.EndsWith("_MAX")) return $"{type}.MaxValue";

            return origValue;
        }

        private string GetConstType(string name)
        {
            if (name.StartsWith("CL_CHAR")) return "sbyte";
            if (name.StartsWith("CL_UCHAR")) return "byte";
            if (name.StartsWith("CL_SCHAR")) return "sbyte";
            if (name.StartsWith("CL_SHRT")) return "short";
            if (name.StartsWith("CL_USHRT")) return "ushort";
            if (name.StartsWith("CL_USHRT")) return "ushort";
            if (name.StartsWith("CL_UINT")) return "uint";
            if (name.StartsWith("CL_INT")) return "int";
            if (name.StartsWith("CL_ULONG")) return "ulong";
            if (name.StartsWith("CL_LONG")) return "long";
            if (name.StartsWith("CL_HALF")) return "float";
            if (name.StartsWith("CL_FLT")) return "float";
            if (name.StartsWith("CL_DBL")) return "double";
            if (name.StartsWith("CL_M") && name.EndsWith("_F")) return "float";
            if (name.StartsWith("CL_M")) return "double";
            return "int";
        }

        private static string FormatToken(string token)
        {
            if (token == null) return null;

            token = token switch
            {
                "CL_TRUE" => "1",
                "CL_FALSE" => "0",
                _ => token,
            };

            if (token.Contains("<<"))
            {
                token = token.Trim('(', ')');
                var idx = token.IndexOf("<<");
                var val1 = ulong.Parse(token.Substring(2, idx - 2), NumberStyles.HexNumber | NumberStyles.AllowTrailingWhite);
                var val2 = int.Parse(token.Substring(idx + 2), NumberStyles.AllowLeadingWhite);
                return $"0x{(val1 << val2):X}";
            }

            var tokenHex = token.StartsWith("0x") ? token.Substring(2) : token;

            if (!long.TryParse(tokenHex, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var value))
            {
                if (!long.TryParse(tokenHex, out value))
                {
                    if (!ulong.TryParse(tokenHex, out var uValue))
                    {
                        throw new InvalidDataException("Token value was not in a valid format.");
                    }

                    value = unchecked((long) uValue);
                }
            }

            var valueString = $"0x{value:X}";

            return valueString;
        }

        sealed record RenamedEntry(string Original, string Renamed)
        {
            public bool Equals(RenamedEntry other)
            {
                return string.Equals(Renamed, other?.Renamed);
            }

            public override int GetHashCode()
            {
                return Renamed.GetHashCode();
            }

            public override string ToString()
            {
                if (string.Equals(Original, Renamed))
                    return Renamed;

                return $"{Renamed} (renamed from {Original})";
            }
        }
    }
}
