// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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
        public IEnumerable<Struct> ReadStructs(object obj, ProfileConverterOptions opts)
        {
            var spec = (VulkanSpecification) obj;
            var structs = ConvertStructs(spec, opts);
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

        private Dictionary<string, Struct> ConvertStructs(VulkanSpecification spec, ProfileConverterOptions opts)
        {
            var prefix = opts.Prefix;
            var ret = new Dictionary<string, Struct>();
            foreach (var s in spec.Structures)
            {
                ret.Add
                (
                    s.Name, new Struct
                    {
                        Fields = s.Members.Select
                            (
                                x => new Field
                                {
                                    Count = string.IsNullOrEmpty(x.ElementCountSymbolic)
                                        ? x.ElementCount != 1 ? new Count(x.ElementCount) : null
                                        : new Count(x.ElementCountSymbolic, false),
                                    Name = Naming.Translate(TrimName(x.Name, opts), prefix),
                                    Doc = $"/// <summary>{x.Comment}</summary>",
                                    NativeName = x.Name,
                                    NativeType = x.Type.ToString(),
                                    Type = ConvertType(x.Type),
                                    DefaultAssignment =
                                        x.Type.Name == "VkStructureType" && !string.IsNullOrWhiteSpace(x.LegalValues)
                                            ? "StructureType." + TryTrim
                                            (
                                                Naming.Translate
                                                (
                                                    TrimName(x.LegalValues.Split(',').FirstOrDefault(), opts),
                                                    opts.Prefix
                                                ),
                                                Naming.TranslateLite(TrimName("VkStructureType", opts), opts.Prefix)
                                            )
                                            : null
                                }
                            )
                            .ToList(),
                        Name = Naming.TranslateLite(TrimName(s.Name, opts), prefix),
                        NativeName = s.Name
                    }
                );
            }

            foreach (var h in spec.Handles)
            {
                ret.Add
                (
                    h.Name, new Struct
                    {
                        Fields = new List<Field>
                            {new Field {Name = "Handle", Type = new Type {Name = h.CanBeDispatched ? "IntPtr" : "ulong"}}},
                        Name = Naming.TranslateLite(TrimName(h.Name, opts), prefix),
                        NativeName = h.Name
                    }
                );
            }

            foreach (var u in spec.Unions)
            {
                ret.Add(u.Name, new Struct
                {
                    Attributes = new List<Attribute> { new Attribute { Name = "StructLayout", Arguments = new List<string> { "LayoutKind.Explicit" } } },
                    Fields = GetFields(u, opts).ToList(),
                    Name = Naming.TranslateLite(TrimName(u.Name, opts), prefix),
                    NativeName = u.Name
                });
            }

            return ret;
        }

        private IEnumerable<Field> GetFields(StructureDefinition union, ProfileConverterOptions opts)
        {
            foreach (var x in union.Members)
            {
                if (x.ElementCount > 1)
                {
                    for (var i = 0; i < x.ElementCount; i++)
                    {
                        var fieldSize = GetTypeSize(x.Type.Name, opts.TypeMaps);
                        yield return new Field
                        {
                            Name = $"{Naming.Translate(x.Name, opts.Prefix)}_{i}",
                            Attributes = new List<Attribute>
                            {
                                new Attribute{Name = "FieldOffset", Arguments = new List<string> {$"{i * fieldSize}"}}
                            },
                            Doc = $"/// <summary>{x.Comment}</summary>",
                            NativeName = x.Name,
                            NativeType = x.Type.ToString(),
                            Type = ConvertType(x.Type),
                        };
                    }
                }
                else
                {
                    yield return new Field
                    {
                        Name = $"{Naming.Translate(x.Name, opts.Prefix)}",
                        Attributes = new List<Attribute>
                        {
                            new Attribute{Name = "FieldOffset", Arguments = new List<string> {"0"}}
                        },
                        Doc = $"/// <summary>{x.Comment}</summary>",
                        NativeName = x.Name,
                        NativeType = x.Type.ToString(),
                        Type = ConvertType(x.Type)
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
        public IEnumerable<Function> ReadFunctions(object obj, ProfileConverterOptions opts)
        {
            var spec = (VulkanSpecification) obj;
            var functions = ConvertFunctions(spec, opts);
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
                            Categories = new List<string> { TrimName(feature.Name, opts) },
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
                                ExtensionName = TrimName(extension.Name, opts),
                                Categories = new List<string> { TrimName(extension.Name, opts) },
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

        private Dictionary<string, Function> ConvertFunctions(VulkanSpecification spec, ProfileConverterOptions opts)
        {
            var ret = new Dictionary<string, Function>();
            foreach (var function in spec.Commands)
            {
                ret.Add
                (
                    function.Name, new Function
                    {
                        Name = Naming.Translate(NameTrimmer.Trim(TrimName(function.Name, opts), opts.Prefix), opts.Prefix),
                        Parameters = function.Parameters.Select
                            (
                                x => new Parameter
                                {
                                    Count = x.IsNullTerminated ? null :
                                        x.ElementCountSymbolic != null ? new Count(x.ElementCountSymbolic.Split(',')) :
                                        new Count(x.ElementCount),
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
        public IEnumerable<Enum> ReadEnums(object obj, ProfileConverterOptions opts)
        {
            var spec = (VulkanSpecification) obj;
            opts.TypeMaps.Insert(0, spec.BaseTypes);
            var enums = ConvertEnums(spec, opts);
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
                        Tokens = e.Tokens
                    };
                }
            }

            opts.TypeMaps.Insert(0, tm);
        }

        /// <inheritdoc />
        public IEnumerable<Constant> ReadConstants(object obj, ProfileConverterOptions opts)
        {
            var spec = (VulkanSpecification) obj;
            return spec.Constants.Select
            (
                x => new Constant
                {
                    Name = Naming.Translate(TrimName(x.Name, opts), opts.Prefix), NativeName = x.Name, Value = x.Value,
                    Type = x.Type switch
                    {
                        ConstantType.Float32 => new Type { Name = "float" },
                        ConstantType.UInt32 => new Type { Name = "uint" },
                        ConstantType.UInt64 => new Type { Name = "ulong" },
                        _ => new Type { Name = "ulong" }
                    }
                }
            );
        }

        /// <summary>
        /// Trims the prefix off a name.
        /// </summary>
        /// <param name="name">The name to trim.</param>
        /// <param name="opts">The profile options containing the prefix.</param>
        /// <returns>The name, trimmed.</returns>
        public string TrimName(string name, ProfileConverterOptions opts)
        {
            if (name.StartsWith($"{opts.Prefix.ToUpper()}_"))
            {
                return name.Remove(0, opts.Prefix.Length + 1);
            }

            return name.ToLower().StartsWith(opts.Prefix.ToLower()) ? name.Remove(0, opts.Prefix.Length) : name;
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

        private Dictionary<string, Enum> ConvertEnums(VulkanSpecification spec, ProfileConverterOptions opts)
        {
            var ret = new Dictionary<string, Enum>();
            foreach (var e in spec.Enums)
            {
                ret.Add
                (
                    e.Name,
                    new Enum
                    {
                        Name = Naming.TranslateLite(TrimName(e.Name, opts), opts.Prefix), NativeName = e.Name,
                        Tokens = e.Values.Select
                            (
                                x => new Token
                                {
                                    Doc = $"/// <summary>{x.Comment}</summary>",
                                    Name = TryTrim
                                    (
                                        Naming.Translate(TrimName(x.Name, opts), opts.Prefix),
                                        Naming.TranslateLite(TrimName(e.Name, opts), opts.Prefix)
                                    ),
                                    Value = x.Value.ToString(),
                                    NativeName = x.Name
                                }
                            )
                            .ToList(),
                        Attributes = e.Type == EnumType.Bitmask
                            ? new List<Attribute> { new Attribute { Name = "Flags" } }
                            : new List<Attribute>()
                    }
                );
            }

            opts.TypeMaps.Insert
            (
                0,
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
