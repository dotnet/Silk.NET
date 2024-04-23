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
using Humanizer;
using Microsoft.CodeAnalysis.CSharp;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Common.Structs;
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
    public class OpenGLReader : IReader
    {
        private class State
        {
            public XDocument Document { get; set; }
            public IEnumerable<Function>? Functions { get; set; }
        }
        
        /// <inheritdoc />
        public object Load(Stream stream)
        {
            return new State {Document = XDocument.Load(stream)};
        }

        /// <inheritdoc />
        public IEnumerable<Struct> ReadStructs(object obj, BindTask task)
            => ReadFunctions(obj, task)
                .SelectMany(x => x.Parameters.Select(y => y.Type).Concat(x.ReturnType))
                .Select(x => x.OriginalClass)
                .Where(x => x is not null)
                .Distinct()
                .Select
                (
                    x => new Struct
                    {
                        Fields = new List<Field>
                            {new Field {Name = "Handle", Type = new Type {Name = "uint"}}},
                        Name = task.RenamedNativeNames.TryGetValue(x, out var name) ? name : x.Pascalize(),
                        NativeName = x
                    }
                );
        
        ////////////////////////////////////////////////////////////////////////////////////////
        // Function Parsing
        ////////////////////////////////////////////////////////////////////////////////////////

        /// <inheritdoc />
        public IEnumerable<Function> ReadFunctions(object obj, BindTask task)
        {
            var state = (State) obj;
            return state.Functions ??= CoreReadFunctions();

            IEnumerable<Function> CoreReadFunctions()
            {
                var doc = state.Document;
                Debug.Assert(doc != null, $"{nameof(doc)} != null");

                var registry = doc.Element("registry");
                Debug.Assert(registry != null, $"{nameof(registry)} != null");

                var allFunctions = registry.Elements("commands")
                    .Elements("command")
                    .Select(x => TranslateCommand(x, task))
                    .ToDictionary(x => x.Attribute("name")?.Value, x => x);
                Debug.Assert(allFunctions != null, $"{nameof(allFunctions) != null}");

                var apis = registry.Elements("feature")
                    .Concat
                    (
                        registry.Elements("extensions").Elements("extension")
                        ?? throw new InvalidDataException()
                    );
                Debug.Assert(apis != null, $"{nameof(apis)} != null");

                var removals = registry
                    .Elements("feature")
                    .Select
                    (
                        x => (x, x.Elements("remove")
                            .Elements("command")
                            .Attributes("name")
                            .Select(y => y.Value))
                    )
                    .SelectMany
                    (
                        x => x.Item2.Select
                        (
                            y => (y,
                                Version.Parse
                                (
                                    x.x.Attribute("number")?.Value ?? throw new DataException
                                        ("Removal does not have associated version")
                                ))
                        )
                    )
                    .ToDictionary(x => x.y, x => x.Item2);

                Debug.Assert(removals != null, $"{nameof(removals) != null}");

                foreach (var api in apis)
                {
                    foreach (var requirement in api.Elements("require"))
                    {
                        var apiName = requirement.Attribute("api")?.Value ??
                                      api.Attribute("api")?.Value ??
                                      api.Attribute("supported")?.Value ??
                                      "gl";
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
                                    Attributes = removals.TryGetValue(function, out var ver) && ver > apiVersion
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
                                    Categories = new List<string> {TrimName(api.Attribute("name")?.Value, task)},
                                    Doc = string.Empty,
                                    ExtensionName = api.Name == "feature"
                                        ? "Core"
                                        : TrimName(api.Attribute("name")?.Value, task),
                                    GenericTypeParameters = new List<GenericTypeParameter>(),
                                    Name = task.RenamedNativeNames.TryGetValue(xf.Attribute("name")!.Value, out var n)
                                        ? n
                                        : Naming.Translate
                                        (
                                            NameTrimmer
                                                .Trim
                                                (
                                                    TrimName(xf.Attribute("name")?.Value, task),
                                                    task.FunctionPrefix
                                                ), task.FunctionPrefix
                                        ),
                                    NativeName = function,
                                    Parameters = ParseParameters(xf, task.IntAsPtr),
                                    ProfileName = name,
                                    ProfileVersion = apiVersion,
                                    ReturnType = ParseTypeSignature
                                    (
                                        xf.Element("returns")
                                        ?? throw new InvalidDataException()
                                    )
                                };
                                
                                foreach (var param in ret.Parameters)
                                {
                                    Rename(task.RenamedNativeNames, param.Type);
                                }
                                
                                Rename(task.RenamedNativeNames, ret.ReturnType);

                                yield return ret;

                                if (api.Name == "feature" && name == "gl" && ret.Attributes.Count == 0)
                                {
                                    yield return new Function
                                    {
                                        Attributes = new List<Attribute>(),
                                        Categories = ret.Categories,
                                        Doc = ret.Doc,
                                        ExtensionName = ret.ExtensionName,
                                        GenericTypeParameters = new List<GenericTypeParameter>(),
                                        Name = ret.Name,
                                        NativeName = ret.NativeName,
                                        Parameters = ret.Parameters,
                                        ProfileName = "glcore",
                                        ProfileVersion = apiVersion,
                                        ReturnType = ret.ReturnType
                                    };
                                }

                                allFunctions.Remove(function);
                            }
                        }
                    }
                }
            }
        }

        private static void Rename(IReadOnlyDictionary<string, string> renames, Type type)
        {
            if (type.OriginalGroup is not null && renames.TryGetValue(type.OriginalGroup, out var s))
            {
                type.OriginalGroup = s;
            }
                                    
            if (type.OriginalClass is not null && renames.TryGetValue(type.OriginalClass, out var c))
            {
                type.OriginalClass = c;
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
            var @class = typeElement.Attribute("class")?.Value;

            var ret = ParseTypeSignature(typeString);

            if (!(group is null))
            {
                ret.OriginalGroup = group;
            }

            if (!(@class is null))
            {
                ret.OriginalClass = @class;
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
        
        private static List<Parameter> ParseParameters(XElement functionElement, Dictionary<string, string[]>? intAsPtr)
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

                if ((intAsPtr?.TryGetValue(
                        functionElement.Attribute("name")!.Value,
                        out var intAsPtrParams
                    ) ?? false) &&
                    intAsPtrParams.Contains(parameter.Name)
                )
                {
                    parameter.Type.IsIntAsPtr = true;
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
                    ("GLDEBUGPROC")
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

        private string FunctionName(XContainer e, BindTask task)
        {
            return TrimName(e.Element("proto")?.Element("name")?.Value, task);
        }
        
        /// <summary>
        /// Trims the prefix off a name.
        /// </summary>
        /// <param name="name">The name to trim.</param>
        /// <param name="opts">The profile options containing the prefix.</param>
        /// <returns>The name, trimmed.</returns>
        public string TrimName(string name, BindTask task)
        {
            if (name.StartsWith($"{task.FunctionPrefix.ToUpper()}_"))
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
            // ReSharper restore CommentTypo
            var proto = e.Value;
            
            var name = e.Element("name");
            if (name == null) {
                throw new InvalidOperationException("Name is null");
            }

            var ret = proto.Remove(proto.LastIndexOf(name.Value, StringComparison.Ordinal)).Trim();

            return ret;
        }
        
        private XElement TranslateCommand(XContainer command, BindTask task)
        {
            var function = new XElement("function");

            var cmdName = FunctionName(command, task);
            var name = new XAttribute("name", cmdName);

            var returnsAttributes = new List<XAttribute>();
            returnsAttributes.Add(new XAttribute
            (
                "type",
                FunctionParameterType(command.Element("proto"))
                    .Replace("const", string.Empty)
                    .Replace("struct", string.Empty)
                    .Replace("String *", "String")
                    .Trim()
            ));

            if (command.Element("proto")?.Attribute("group") is not null)
            {
                returnsAttributes.Add
                (
                    new XAttribute
                    (
                        "group", command.Element("proto")?.Attribute("group")?.Value
                                 ?? throw new InvalidDataException()
                    )
                );
            }

            if (command.Element("proto")?.Attribute("class") is not null)
            {
                returnsAttributes.Add
                (
                    new XAttribute
                    (
                        "class", command.Element("proto")?.Attribute("class")?.Value
                                 ?? throw new InvalidDataException()
                    )
                );
            }
            
            var returns = new XElement
            (
                "returns",
                returnsAttributes.Cast<object>().ToArray()
            );

            foreach (var parameter in command.Elements("param"))
            {
                var param = FunctionParameterType(parameter);

                var p = new XElement("param");
                var paramName = new XAttribute("name", parameter.Element("name")?.Value
                                                       ?? throw new NullReferenceException());
                
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

                if (!(parameter.Attribute("class") is null))
                {
                    p.Add(new XAttribute("class", parameter.Attribute("class")?.Value
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
            var state = (State) obj;
            var doc = state.Document;
            Debug.Assert(doc != null, nameof(doc) + " != null");

            var registry = doc.Element("registry");
            Debug.Assert(registry != null, nameof(registry) + " != null");
            
            var allEnums = registry.Elements("enums")
                .Elements("enum")
                .DistinctBy(x => x.Attribute("name")?.Value)
                .ToDictionary
                (
                    x => x.Attribute("name")?.Value,
                    x => (FormatToken(x.Attribute("value")?.Value), x.Attribute("group")?.Value.Split(','))
                );
            
            var apis = registry.Elements("feature").Concat(registry.Elements("extensions").Elements("extension"));

            var removals = registry
                .Elements("feature")
                .Select
                (
                    x => (x, x.Elements("remove")
                        .Elements("enum")
                        .Attributes("name")
                        .Select(y => y.Value))
                )
                .SelectMany
                (
                    x => x.Item2.Select
                    (
                        y => (y,
                            Version.Parse
                            (
                                x.x.Attribute("number")?.Value ?? throw new DataException
                                    ("Removal does not have associated version")
                            ))
                    )
                )
                .ToDictionary(x => x.y, x => x.Item2);

            var revivals = new Dictionary<string, Version>();
            foreach (var api in apis)
            {
                foreach (var requirement in api.Elements("require"))
                {
                    var apiName = requirement.Attribute("api")?.Value ??
                                  api.Attribute("api")?.Value ??
                                  api.Attribute("supported")?.Value ??
                                  "gl";
                    var apiVersion = api.Attribute("number") != null
                        ? Version.Parse(api.Attribute("number")?.Value ?? throw new InvalidDataException())
                        : null;
                    var tokens = requirement.Elements("enum")
                        .Attributes("name")
                        .Select
                        (
                            token =>
                            {
                                if (removals.TryGetValue(token.Value, out var ver))
                                {
                                    if (ver <= apiVersion)
                                    {
                                        if (!revivals.ContainsKey(token.Value) || ver > revivals[token.Value])
                                        {
                                            revivals[token.Value] = ver;
                                        }
                                    }
                                    else if (revivals.TryGetValue(token.Value, out var revVer) && ver > revVer)
                                    {
                                        revivals.Remove(token.Value);
                                    }
                                }
                                
                                return new Token
                                {
                                    Attributes = removals.TryGetValue(token.Value, out ver) && ver > apiVersion
                                        ? new List<Attribute>
                                        {
                                            new Attribute
                                            {
                                                Arguments = new List<string>
                                                    {$"\"Deprecated in version {apiVersion?.ToString(2)}\""},
                                                Name = "System.Obsolete"
                                            }
                                        }
                                        : new List<Attribute>(),
                                    Doc = string.Empty,
                                    Name = task.RenamedNativeNames.TryGetValue(token.Value, out var n)
                                        ? n
                                        : Naming.Translate(TrimName(token.Value, task), task.FunctionPrefix),
                                    NativeName = token.Value,
                                    Value = allEnums[token.Value].Item1
                                };
                            }
                        )
                        .ToList();
                    foreach (var name in apiName.Split('|'))
                    {
                        var ret = new Enum
                        {
                            Attributes = new List<Attribute>(),
                            ExtensionName = api.Name == "feature"
                                ? "Core"
                                : TrimName(api.Attribute("name")?.Value, task),
                            Name = task.RenamedNativeNames.TryGetValue(api.Attribute("name")!.Value, out var n)
                                ? n
                                : Naming.Translate(TrimName(api.Attribute("name")?.Value, task), task.FunctionPrefix),
                            NativeName = api.Attribute("name")?.Value,
                            ProfileName = name,
                            ProfileVersion = apiVersion,
                            Tokens = tokens
                        };

                        yield return ret;

                        if (api.Name == "feature" && name == "gl")
                        {
                            yield return new Enum
                            {
                                Attributes = ret.Attributes,
                                ExtensionName = ret.ExtensionName,
                                Name = ret.Name,
                                NativeName = ret.NativeName,
                                ProfileName = "glcore",
                                ProfileVersion = apiVersion,
                                Tokens = tokens.Where(x => x.Attributes.Count == 0).ToList()
                            };
                        }
                    }
                }
            }

            var groups = new Dictionary<string, List<Token>>();
            foreach (var @enum in allEnums)
            {
                if (@enum.Value.Item2 is null)
                {
                    continue;
                }

                foreach (var group in @enum.Value.Item2)
                {
                    if (groups.ContainsKey(group))
                    {
                        groups[group].Add
                        (
                            new Token
                            {
                                Attributes = removals.TryGetValue(@enum.Key, out var ver) &&
                                             !revivals.ContainsKey(@enum.Key)
                                    ? new List<Attribute>
                                    {
                                        new Attribute
                                        {
                                            Name = "System.Obsolete",
                                            Arguments = new List<string>
                                            {
                                                $"\"Deprecated in version {ver?.ToString(2)}\""
                                            }
                                        }
                                    }
                                    : new List<Attribute>(),
                                Doc = string.Empty,
                                Name = task.RenamedNativeNames.TryGetValue(@enum.Key, out var n)
                                    ? n
                                    : Naming.Translate(TrimName(@enum.Key, task), task.FunctionPrefix),
                                NativeName = @enum.Key,
                                Value = @enum.Value.Item1
                            }
                        );
                    }
                    else
                    {
                        groups.Add
                        (
                            group, new List<Token>
                            {
                                new Token
                                {
                                    Attributes = removals.TryGetValue(@enum.Key, out var ver) &&
                                                 !revivals.ContainsKey(@enum.Key)
                                        ? new List<Attribute>
                                        {
                                            new Attribute
                                            {
                                                Name = "System.Obsolete",
                                                Arguments = new List<string>
                                                {
                                                    $"\"Deprecated in version {ver?.ToString(2)}\""
                                                }
                                            }
                                        }
                                        : new List<Attribute>(),
                                    Doc = string.Empty,
                                    Name = task.RenamedNativeNames.TryGetValue(@enum.Key, out var n)
                                        ? n
                                        : Naming.Translate(TrimName(@enum.Key, task), task.FunctionPrefix),
                                    NativeName = @enum.Key,
                                    Value = @enum.Value.Item1
                                }
                            }
                        );
                    }
                }
            }

            foreach (var group in groups)
            {
                foreach (var (apiName, apiVersion) in registry
                    .Elements("feature")
                    .Select(x => (x.Attribute("api")?.Value, x.Attribute("number")?.Value))
                    .Distinct())
                {
                    var ret = new Enum
                    {
                        Name = task.RenamedNativeNames.TryGetValue(group.Key, out var n) ? n : group.Key,
                        NativeName = group.Key,
                        Attributes = new List<Attribute>(),
                        ExtensionName = "Core (Grouped)",
                        ProfileName = apiName,
                        ProfileVersion = Version.Parse(apiVersion),
                        Tokens = group.Value
                    };

                    yield return ret;

                    if (apiName == "gl")
                    {
                        yield return new Enum
                        {
                            Name = ret.Name,
                            NativeName = ret.NativeName,
                            Attributes = new List<Attribute>(),
                            ExtensionName = "Core (Grouped)",
                            ProfileName = "glcore",
                            ProfileVersion = Version.Parse(apiVersion),
                            Tokens = group.Value.Where(x => x.Attributes.Count == 0).ToList()
                        };
                    }
                }
            }
        }

        /// <inheritdoc />
        public IEnumerable<Constant> ReadConstants(object obj, BindTask task)
        {
            return new Constant[0];
        }

        private static string FormatToken(string token)
        {
            if (token == null)
            {
                return null;
            }

            if (token.StartsWith("EGL_CAST("))
            {
                // ReSharper disable once TailRecursiveCall
                return FormatToken(token.Remove(0, 8).TrimStart('(').TrimEnd(')').Split(',')[1]);
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
                Console.WriteLine($"Warning: casting overflowing enum value {token} from 64-bit to 32-bit.");
                valueString = $"unchecked((int){valueString})";
            }

            return valueString;
        }
    }
}
