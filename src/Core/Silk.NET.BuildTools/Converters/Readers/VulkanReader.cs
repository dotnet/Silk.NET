// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Common.Structs;
using Silk.NET.BuildTools.Converters.Khronos;
using Attribute = Silk.NET.BuildTools.Common.Attribute;
using Enum = Silk.NET.BuildTools.Common.Enums.Enum;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Converters.Readers
{
    /// <summary>
    /// API reader for Vulkan.
    /// </summary>
    public class VulkanReader : IReader
    {
        /// <inheritdoc />
        public object Load(Stream stream)
        {
            return VulkanSpecification.LoadFromXmlStream(stream);
        }

        /// <inheritdoc />
        public IEnumerable<Struct> ReadStructs(object obj, BindTask task)
        {
            var spec = (VulkanSpecification) obj;
            var structs = ConvertStructs(spec, task);
            foreach (var feature in spec.Features.Select(x => x.Api).RemoveDuplicates())
            {
                foreach (var (_, s) in structs)
                {
                    yield return new Struct
                    {
                        Attributes = s.Attributes,
                        ExtensionName = "Core",
                        Fields = s.Fields,
                        Functions = s.Functions,
                        Name = s.Name,
                        NativeName = s.NativeName,
                        ProfileName = feature,
                        ProfileVersion = null
                    };
                }
            }
        }

        private Dictionary<string, Struct> ConvertStructs(VulkanSpecification spec, BindTask task)
        {
            var prefix = task.FunctionPrefix;
            var ret = new Dictionary<string, Struct>();

            // Gets all aliases of a struct, no matter where in an alias chain we start
            // Note this could be simpler if we just assume we only need to check $VKALIASES, but this 
            // version is bombproof.
            IReadOnlyList<Struct> GetAllAliasesFromName(string structName)
            {
                var todo = new Queue<string>();
                todo.Enqueue(structName);
                var result = new Dictionary<string, Struct>();

                while (todo.Any())
                {
                    structName = todo.Dequeue();
                    if (!ret.TryGetValue(structName, out var s))
                    {
                        result[structName] = null;
                        continue;
                    }

                    result[structName] = s;

                    // Get any aliases
                    var aliasOf = s.Attributes
                        .FirstOrDefault
                        (
                            a => a.Arguments.Count > 1 && a.Name == "BuildToolsIntrinsic" &&
                                 a.Arguments[0] == "$VKALIASOF"
                        )
                        ?.Arguments[1];
                    if (!string.IsNullOrWhiteSpace(aliasOf) && !result.ContainsKey(aliasOf))
                    {
                        todo.Enqueue(aliasOf);
                    }

                    // Check other way as well
                    foreach (var a in s.Attributes
                                          .FirstOrDefault
                                          (
                                              a => a.Arguments.Count > 1 && a.Name == "BuildToolsIntrinsic" &&
                                                   a.Arguments[0] == "$VKALIASES"
                                          )
                                          ?.Arguments
                                          .Skip(1)
                                          .Where(a => !string.IsNullOrWhiteSpace(a) && !result.ContainsKey(a))
                                          .ToArray()
                                      ?? Array.Empty<string>())
                    {
                        todo.Enqueue(a);
                    }
                }

                return result.Values.Where(s => s is not null).ToList();
            }

            // Opposite way round lookup of what aliases exist for this key-struct
            // i.e. if VkB is an alias of VkA, and VkC is an alias of VkA, then aliases has [VkA]={VkB,VkC}
            var aliases = new Dictionary<string, List<string>>();
            // Holds any chain starts for chains we haven't seen yet (should rarely be needed).
            var chainExtensions = new List<(Struct, IReadOnlyList<string>)>();
            foreach (var s in spec.Structures)
            {
                // Build aliases dictionary
                if (!string.IsNullOrWhiteSpace(s.Alias))
                {
                    if (!aliases.TryGetValue(s.Alias, out var aList))
                    {
                        aList = new();
                        aliases[s.Alias] = aList;
                    }

                    aList.Add(s.Name);
                    continue;
                }

                var @struct = new Struct
                {
                    Fields = s.Members.Select
                        (
                            x => new Field
                            {
                                Count = string.IsNullOrEmpty(x.ElementCountSymbolic)
                                    ? x.ElementCount != 1 ? new Count(x.ElementCount) : null
                                    : new Count(x.ElementCountSymbolic, false),
                                Name = Naming.Translate(TrimName(x.Name, task), prefix),
                                Doc = $"/// <summary>{x.Comment}</summary>",
                                NativeName = x.Name,
                                NativeType = x.Type.ToString(),
                                Type = ConvertType(x.Type),
                                DefaultAssignment =
                                    (x.Type.Name == "VkStructureType" || x.Type.Name == "XrStructureType")
                                    && !string.IsNullOrWhiteSpace(x.LegalValues)
                                        ? "StructureType." + TryTrim
                                        (
                                            Naming.Translate
                                            (
                                                TrimName(x.LegalValues.Split(',').FirstOrDefault(), task),
                                                task.FunctionPrefix
                                            ),
                                            Naming.TranslateLite(TrimName("VkStructureType", task), task.FunctionPrefix)
                                        )
                                        : null,
                                NumBits = x.NumBits
                            }.WithFixedFieldFixup09072020()
                        )
                        .ToList(),
                    Name = Naming.TranslateLite(TrimName(s.Name, task), prefix),
                    NativeName = s.Name
                };

                // Find the STYpe field (and it's position, which is required for IChainable
                var (sTypeField, sTypeFieldIndex) = @struct.Fields.Select((f, i) => (Field: f, Index: i))
                    .FirstOrDefault(f => f.Field.Name == "SType" && f.Field.Type.Name == "VkStructureType");
                if (sTypeField is not null)
                {
                    @struct.Attributes.Add
                    (
                        new()
                        {
                            Name = "BuildToolsIntrinsic",
                            Arguments = new() {"$VKSTRUCTUREDTYPE", sTypeField.DefaultAssignment ?? string.Empty}
                        }
                    );

                    // Ensure SType was in position 0, and we have a pointer called PNext in position 1.
                    Field pNextField;
                    if (sTypeFieldIndex == 0 &&
                        @struct.Fields.Count > 1 &&
                        (pNextField = @struct.Fields[1]).Name == "PNext" &&
                        pNextField.Type.IsPointer)
                    {
                        // The type is at least chainable.
                        @struct.Attributes.Add
                        (
                            new()
                            {
                                Name = "BuildToolsIntrinsic",
                                Arguments = new() {"$VKCHAINABLE"}
                            }
                        );

                        if (s.Extends.Any())
                        {
                            chainExtensions.Add((@struct, s.Extends));
                        }
                    }
                }

                ret.Add(s.Name, @struct);
            }

            // Create Aliases
            foreach (var (structName, aList) in aliases)
            {
                if (!ret.TryGetValue(structName, out var @struct))
                {
                    continue;
                }

                foreach (var alias in aList)
                {
                    var aliasStruct = @struct.Clone(Naming.TranslateLite(TrimName(alias, task), prefix), alias);
                    aliasStruct.Attributes.Add
                    (
                        new()
                        {
                            Name = "BuildToolsIntrinsic",
                            Arguments = new() {"$VKALIASOF", @struct.NativeName}
                        }
                    );
                    // Create a clone for the alias
                    ret.Add(alias, aliasStruct);
                }

                // Now that we've finished cloning we can add the build intrinsic to the root struct.
                @struct.Attributes.Add
                (
                    new()
                    {
                        Name = "BuildToolsIntrinsic",
                        Arguments = new[] {"$VKALIASES"}.Concat(aList).ToList()
                    }
                );
            }

            // Add chain extensions, we have to do this now to account for aliases, we
            if (chainExtensions.Any())
            {
                foreach (var (@struct, chainNames) in chainExtensions)
                {
                    // Get all the aliases of this struct (including this one)
                    var allStructs = GetAllAliasesFromName(@struct.NativeName);
                    // Get all the chains this struct extends (including their aliases)
                    var chains = chainNames.SelectMany(n => GetAllAliasesFromName(n)).ToArray();

                    // Add $VKEXTENDSCHAIN build tools intrinsic attribute to all versions of this struct
                    Attribute attribute = null;
                    foreach (var s in allStructs)
                    {
                        if (attribute is null)
                        {
                            // Create $VKEXTENDSCHAIN build tools intrinsic attribute
                            attribute = new()
                            {
                                Name = "BuildToolsIntrinsic",
                                Arguments = new[] {"$VKEXTENDSCHAIN"}.Concat(chains.Select(c => c.Name)).ToList()
                            };
                        }
                        else
                        {
                            // Clone existing attribute.
                            attribute = attribute.Clone();
                        }

                        s.Attributes.Add(attribute);
                    }

                    // Add chain starts to all chains and their aliases
                    attribute = null;
                    foreach (var c in chains)
                    {
                        if (attribute is null)
                        {
                            // Create $VKEXTENDSCHAIN build tools intrinsic attribute
                            attribute = new()
                            {
                                Name = "BuildToolsIntrinsic",
                                Arguments = new[] {"$VKCHAINSTART"}.Concat(allStructs.Select(s => s.Name)).ToList()
                            };
                        }
                        else
                        {
                            // Clone existing attribute.
                            attribute = attribute.Clone();
                        }

                        c.Attributes.Add(attribute);
                    }
                }
            }

            foreach (var h in spec.Handles)
            {
                ret.Add
                (
                    h.Name, new Struct
                    {
                        Fields = new List<Field>
                        {
                            new Field {Name = "Handle", Type = new Type {Name = h.CanBeDispatched ? "nint" : "ulong"}}
                        },
                        Name = Naming.TranslateLite(TrimName(h.Name, task), prefix),
                        NativeName = h.Name
                    }
                );
            }

            foreach (var u in spec.Unions)
            {
                ret.Add
                (
                    u.Name, new Struct
                    {
                        Attributes = new List<Attribute>
                        {
                            new Attribute {Name = "StructLayout", Arguments = new List<string> {"LayoutKind.Explicit"}}
                        },
                        Fields = GetFields(u, task).ToList(),
                        Name = Naming.TranslateLite(TrimName(u.Name, task), prefix),
                        NativeName = u.Name
                    }
                );
            }

            return ret;
        }

        private IEnumerable<Field> GetFields(StructureDefinition union, BindTask task)
        {
            foreach (var x in union.Members)
            {
                if (x.ElementCount > 1)
                {
                    for (var i = 0; i < x.ElementCount; i++)
                    {
                        var fieldSize = GetTypeSize(x.Type.Name, task.TypeMaps);
                        yield return new Field
                        {
                            Name = $"{Naming.Translate(x.Name, task.FunctionPrefix)}_{i}",
                            Attributes = new List<Attribute>
                            {
                                new Attribute {Name = "FieldOffset", Arguments = new List<string> {$"{i * fieldSize}"}}
                            },
                            Doc = $"/// <summary>{x.Comment}</summary>",
                            NativeName = x.Name,
                            NativeType = x.Type.ToString(),
                            Type = ConvertType(x.Type),
                            NumBits = x.NumBits
                        };
                    }
                }
                else
                {
                    yield return new Field
                    {
                        Name = $"{Naming.Translate(x.Name, task.FunctionPrefix)}",
                        Attributes = new List<Attribute>
                        {
                            new Attribute {Name = "FieldOffset", Arguments = new List<string> {"0"}}
                        },
                        Doc = $"/// <summary>{x.Comment}</summary>",
                        NativeName = x.Name,
                        NativeType = x.Type.ToString(),
                        Type = ConvertType(x.Type),
                        NumBits = x.NumBits
                    };
                }
            }
        }

        private int GetTypeSize(string type, IEnumerable<Dictionary<string, string>> maps)
        {
            var at = type;
            foreach (var map in maps)
            {
                if (map.ContainsKey(at))
                {
                    at = map[at];
                }
            }

            var size = at switch
            {
                "byte" => 1,
                "uint" => 4,
                "ulong" => 8,
                "int" => 4,
                "long" => 8,
                "float" => 4,
                "double" => 8,
                _ => -1
            };

            size = size switch
            {
                -1 when at.StartsWith("Vk") => 4,
                -1 => throw new InvalidOperationException(),
                _ => size,
            };

            return size;
        }

        private Type ConvertType(TypeSpec type)
        {
            return new Type
            {
                ArrayDimensions = type.ArrayDimensions,
                IndirectionLevels = type.PointerIndirection,
                Name = type.Name,
                OriginalName = type.Name
            };
        }

        /// <inheritdoc />
        public IEnumerable<Function> ReadFunctions(object obj, BindTask task)
        {
            var spec = (VulkanSpecification) obj;
            var functions = ConvertFunctions(spec, task);
            foreach (var feature in spec.Features)
            {
                foreach (var name in feature.CommandNames)
                {
                    if (functions.ContainsKey(name))
                    {
                        var function = functions[name];
                        yield return new Function
                        {
                            ExtensionName = "Core",
                            Categories = new List<string> {TrimName(feature.Name, task)},
                            Name = function.Name,
                            NativeName = function.NativeName,
                            Parameters = function.Parameters,
                            ReturnType = function.ReturnType,
                            ProfileName = feature.Api,
                            ProfileVersion = feature.Number
                        };
                    }
                }
            }

            foreach (var extension in spec.Extensions)
            {
                foreach (var name in extension.CommandNames)
                {
                    foreach (var api in extension.Supported)
                    {
                        if (functions.ContainsKey(name))
                        {
                            var function = functions[name];
                            yield return new Function
                            {
                                ExtensionName = TrimName(extension.Name, task),
                                Categories = new List<string> {TrimName(extension.Name, task)},
                                Name = function.Name,
                                NativeName = function.NativeName,
                                Parameters = function.Parameters,
                                ReturnType = function.ReturnType,
                                ProfileName = api,
                                ProfileVersion = null
                            };
                        }
                    }
                }
            }
        }

        private Dictionary<string, Function> ConvertFunctions(VulkanSpecification spec, BindTask task)
        {
            var ret = new Dictionary<string, Function>();
            foreach (var function in spec.Commands)
            {
                ret.Add
                (
                    function.Name, new Function
                    {
                        Name = Naming.Translate
                            (NameTrimmer.Trim(TrimName(function.Name, task), task.FunctionPrefix), task.FunctionPrefix),
                        Parameters = function.Parameters.Select
                            (
                                x => new Parameter
                                {
                                    Count = x.IsNullTerminated ? null :
                                        x.ElementCountSymbolic != null ? function.Parameters.Any
                                            (y => y.Name == x.ElementCountSymbolic)
                                            ? new(x.ElementCountSymbolic)
                                            : new(x.ElementCountSymbolic.Split(',')) :
                                        new(x.ElementCount),
                                    Flow = ConvertFlow(x.Modifier), Name = x.Name, Type = ConvertType(x.Type)
                                }
                            )
                            .ToList(),
                        NativeName = function.Name,
                        ReturnType = ConvertType(function.ReturnType)
                    }
                );
            }

            return ret;
        }

        /// <inheritdoc />
        public IEnumerable<Enum> ReadEnums(object obj, BindTask task)
        {
            var spec = (VulkanSpecification) obj;
            task.InjectTypeMap(spec.BaseTypes);
            var enums = ConvertEnums(spec, task);
            var tm = new Dictionary<string, string>();
            foreach (var feature in spec.Features.Select(x => x.Api).RemoveDuplicates())
            {
                foreach (var (_, e) in enums)
                {
                    tm.Add(e.NativeName, e.Name.Replace("FlagBits", "Flags"));
                    yield return new Enum
                    {
                        Attributes = e.Attributes,
                        ExtensionName = "Core",
                        Name = e.Name.Replace("FlagBits", "Flags"),
                        NativeName = e.NativeName.Replace("FlagBits", "Flags"),
                        ProfileName = feature,
                        ProfileVersion = null,
                        Tokens = e.Tokens,
                        EnumBaseType = e.EnumBaseType
                    };
                }
            }

            task.InjectTypeMap(tm);
        }

        /// <inheritdoc />
        public IEnumerable<Constant> ReadConstants(object obj, BindTask task)
        {
            var spec = (VulkanSpecification) obj;
            return spec.Constants.Select
                (
                    x => new Constant
                    {
                        Name = Naming.Translate(TrimName(x.Name, task), task.FunctionPrefix),
                        NativeName = x.Name,
                        Value = x.Value,
                        Type = x.Type switch
                        {
                            ConstantType.Float32 => new Type {Name = "float"},
                            ConstantType.UInt32 => new Type {Name = "uint"},
                            ConstantType.UInt64 => new Type {Name = "ulong"},
                            _ => new Type {Name = "ulong"}
                        },
                        ExtensionName = "Core"
                    }
                )
                .Concat
                (
                    spec.Extensions.SelectMany
                    (
                        x => x.Constants.Select
                        (
                            y => new Constant
                            {
                                Name = Naming.Translate(TrimName(y.Name, task), task.FunctionPrefix),
                                NativeName = y.Name,
                                Value = y.Value,
                                Type = new Type {Name = "uint"},
                                ExtensionName = TrimName(x.Name, task)
                            }
                        )
                    )
                )
                .Concat
                (
                    spec.Extensions.SelectMany
                    (
                        x => x.EnumExtensions.Where(y => y.ExtendedType is null)
                            .Select
                            (
                                y => new Constant
                                {
                                    Name = Naming.Translate(TrimName(y.Name, task), task.FunctionPrefix),
                                    NativeName = y.Name,
                                    Value = y.Value,
                                    Type = new Type {Name = "uint"},
                                    ExtensionName = TrimName(x.Name, task)
                                }
                            )
                    )
                );
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

        private static FlowDirection ConvertFlow(ParameterModifier mod)
        {
            return mod switch
            {
                ParameterModifier.None => FlowDirection.Undefined,
                ParameterModifier.Ref => FlowDirection.Ref,
                ParameterModifier.Out => FlowDirection.Out,
                _ => FlowDirection.In
            };
        }

        private Dictionary<string, Enum> ConvertEnums(VulkanSpecification spec, BindTask task)
        {
            var ret = new Dictionary<string, Enum>();
            foreach (var e in spec.Enums)
            {
                ret.Add
                (
                    e.Name,
                    new Enum
                    {
                        Name = Naming.TranslateLite(TrimName(e.Name, task), task.FunctionPrefix), NativeName = e.Name,
                        Tokens = e.Values.Select
                            (
                                x => new Token
                                {
                                    Doc = $"/// <summary>{x.Comment}</summary>",
                                    Name = TryTrim
                                    (
                                        Naming.Translate(TrimName(x.Name, task), task.FunctionPrefix),
                                        Naming.TranslateLite(TrimName(e.Name, task), task.FunctionPrefix)
                                    ),
                                    Value = x.Value.ToString(),
                                    NativeName = x.Name
                                }
                            )
                            .ToList(),
                        Attributes = e.Type == EnumType.Bitmask
                            ? new List<Attribute> {new Attribute {Name = "Flags"}}
                            : new List<Attribute>(),
                        EnumBaseType = e.BitWidth switch
                        {
                            64 => new() {Name = "long"},
                            _ => new() {Name = "int"}
                        }
                    }
                );
            }

            task.InjectTypeMap
            (
                spec.Typedefs.Where
                        (typedef => typedef.Type == "VkFlags" && !ret.ContainsKey(typedef.Requires ?? "__SilkNetNull"))
                    .ToDictionary(typedef => typedef.Name, typedef => typedef.Type)
            );

            return ret;
        }

        private static readonly char[] Digits = "1234567890".ToCharArray();

        private static string TryTrim(string token, string @enum)
        {
            var trimmed = token.StartsWith(@enum) ? token.Substring(@enum.Length) : token;
            return Digits.Contains(trimmed[0]) ? token : trimmed;
        }
    }
}
