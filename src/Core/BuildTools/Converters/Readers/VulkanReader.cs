// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Dynamic;
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
using Silk.NET.BuildTools.Converters.Khronos;
using Attribute = Silk.NET.BuildTools.Common.Attribute;
using Enum = Silk.NET.BuildTools.Common.Enums.Enum;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Converters.Readers
{
    public class VulkanReader : IReader
    {
        public object Load(Stream stream)
        {
            return VulkanSpecification.LoadFromXmlStream(stream);
        }

        public IEnumerable<Struct> ReadStructs(object obj, ProfileConverterOptions opts)
        {
            var spec = (VulkanSpecification) obj;
            var structs = ConvertStructs(spec, opts);
            foreach (var feature in spec.Features)
            {
                foreach (var type in feature.TypeNames)
                {
                    if (structs.ContainsKey(type))
                    {
                        var s = structs[type];
                        yield return new Struct
                        {
                            Attributes = s.Attributes,
                            ExtensionName = "Core",
                            Fields = s.Fields,
                            Functions = s.Functions,
                            Name = s.Name,
                            NativeName = s.NativeName,
                            ProfileName = feature.Api,
                            ProfileVersion = feature.Number
                        };
                    }
                }
            }

            foreach (var extension in spec.Extensions)
            {
                foreach (var type in extension.TypeNames)
                {
                    if (structs.ContainsKey(type))
                    {
                        var s = structs[type];
                        foreach (var api in extension.Supported)
                        {
                            yield return new Struct
                            {
                                Attributes = s.Attributes,
                                ExtensionName = extension.Name,
                                Fields = s.Fields,
                                Functions = s.Functions,
                                Name = s.Name,
                                NativeName = s.NativeName,
                                ProfileName = api,
                                ProfileVersion = null
                            };
                        }
                    }
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
                                    : new Count(x.ElementCountSymbolic),
                                Name = Naming.Translate(x.Name, prefix),
                                Doc = $"/// <summary>{x.Comment}</summary>",
                                NativeName = x.Name,
                                NativeType = x.Type.ToString(),
                                Type = ConvertType(x.Type)
                            }
                        )
                        .ToList(),
                        Name = Naming.TranslateLite(s.Name, prefix),
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
                            {new Field {Name = "Handle", Type = new Type {Name = h.Dispatchable ? "IntPtr" : "ulong"}}},
                        Name = Naming.TranslateLite(h.Name, prefix),
                        NativeName = h.Name
                    }
                );
            }

            foreach (var u in spec.Unions)
            {
                ret.Add(u.Name, new Struct
                {
                    Attributes = new List<Attribute>{new Attribute{Name = "StructLayout", Arguments = new List<string>{"LayoutKind.Explicit"}}},
                    Fields = GetFields(u, opts).ToList(),
                    Name = Naming.TranslateLite(u.Name, prefix),
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
                            Categories = new List<string> {feature.Name},
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
                                ExtensionName = "Core",
                                Categories = new List<string> {extension.Name},
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
                        Name = Naming.Translate(function.Name, opts.Prefix),
                        Parameters = function.Parameters.Select
                            (
                                x => new Parameter
                                {
                                    Count = x.IsNullTerminted ? null :
                                        x.ElementCountSymbolic != null ? new Count(x.ElementCountSymbolic.Split(',')) :
                                        new Count(x.ElementCount),
                                    Flow = (FlowDirection) x.Modifier, Name = x.Name, Type = ConvertType(x.Type)
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

        public IEnumerable<Enum> ReadEnums(object obj, ProfileConverterOptions opts)
        {
            var spec = (VulkanSpecification) obj;
            var enums = ConvertEnums(spec, opts);
            foreach (var feature in spec.Features)
            {
                foreach (var type in feature.TypeNames)
                {
                    if (enums.ContainsKey(type))
                    {
                        var e = enums[type];
                        yield return new Enum
                        {
                            Attributes = e.Attributes,
                            ExtensionName = "Core",
                            Name = e.Name,
                            NativeName = e.NativeName,
                            ProfileName = feature.Api,
                            ProfileVersion = feature.Number,
                            Tokens = e.Tokens
                        };
                    }
                }
            }
            
            foreach (var extension in spec.Extensions)
            {
                foreach (var type in extension.TypeNames)
                {
                    if (enums.ContainsKey(type))
                    {
                        var e = enums[type];
                        foreach (var api in extension.Supported)
                        {
                            yield return new Enum
                            {
                                Attributes = e.Attributes,
                                ExtensionName = extension.Name,
                                Name = e.Name,
                                NativeName = e.NativeName,
                                ProfileName = api,
                                ProfileVersion = null,
                                Tokens = e.Tokens
                            };
                        }
                    }
                }
            }
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
                        Name = Naming.TranslateLite(e.Name, opts.Prefix), NativeName = e.Name,
                        Tokens = e.Values.Select
                            (
                                x => new Token
                                {
                                    Doc = $"/// <summary>{x.Comment}</summary>",
                                    Name = Naming.Translate(x.Name, opts.Prefix), Value = x.Value.ToString(),
                                    NativeName = x.Name
                                }
                            )
                            .ToList(),
                        Attributes = e.Type == EnumType.Bitmask
                            ? new List<Attribute> {new Attribute {Name = "Flags"}}
                            : new List<Attribute>()
                    }
                );
            }

            return ret;
        }
    }
}
