// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Silk.NET.BuildTools.Common.Functions;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// A collection of methods for replacing type names using a dictionary.
    /// </summary>
    public static class TypeMapper
    {
        /// <summary>
        /// Replaces the type names of parameters and return types in the given functions using the given typemap.
        /// </summary>
        /// <param name="map">The typemap/dictionary to use.</param>
        /// <param name="functions">The functions to map.</param>
        public static void Map(Dictionary<string, string> map, IEnumerable<Function> functions, bool mapNative)
        {
            foreach (var function in functions)
            {
                Map(map, function, mapNative);
            }
        }

        /// <summary>
        /// Retrieve a type from a typemap.
        /// </summary>
        /// <param name="maps">The map to use.</param>
        /// <param name="og">The type to map.</param>
        /// <returns>The mapped type.</returns>
        public static Type MapOne(IEnumerable<Dictionary<string, string>> maps, Type og, bool mapNative, string ogN = null)
        {
            var type = og;
            foreach (var map in maps)
            {
                type = MapOne(map, type, mapNative, ogN);
            }

            return type;
        }

        /// <summary>
        /// Retrieve a type from a typemap.
        /// </summary>
        /// <param name="map">The map to use.</param>
        /// <param name="og">The type to map.</param>
        /// <returns>The mapped type.</returns>
        public static Type MapOne(Dictionary<string, string> map, Type og, bool mapNative, string ogN = null)
        {
            var type = og;
            if (map.TryGetValue(type.ToString(), out var mapped))
            {
                type = ParseTypeSignature
                (
                    mapped, type.OriginalName, type.OriginalGroup
                );
            }
            else if (map.TryGetValue(type.Name, out mapped))
            {
                type.Name = mapped;
            }
            else if (mapNative && ogN != null && map.TryGetValue(ogN, out mapped)) 
            {
                type.Name = mapped;
            }

            if (og.FunctionPointerSignature is not null)
            {
                type.FunctionPointerSignature = og.FunctionPointerSignature;
                Map(map, type.FunctionPointerSignature, mapNative);
            }

            return type;
        }

        /// <summary>
        /// Merges several typemaps into one, recursively
        /// </summary>
        /// <param name="typeMaps">Maps to merge</param>
        /// <returns>Marged map</returns>
        internal static Dictionary<string, string> MergeMaps(List<Dictionary<string, string>> typeMaps)
        {
            var result = new Dictionary<string, string>(typeMaps.Sum(t => t.Count));

            foreach (var map in typeMaps)
            {
                foreach (var kv in map)
                {
                    result[kv.Key] = kv.Value;
                }
            }

            foreach (var kv in result)
            {
                var value = kv.Value;
                while (result.TryGetValue(value, out var value2))
                {
                    if(string.Equals(value, value2))
                    {
                        break;
                    }
                    value = value2;
                }
                result[kv.Key] = value;
            }

            return result;
        }

        /// <summary>
        /// Replaces the type names of parameters and return types in the given functions using the given typemap.
        /// </summary>
        /// <param name="map">The typemap/dictionary to use.</param>
        /// <param name="structs">The functions to map.</param>
        public static void Map(Dictionary<string, string> map, IEnumerable<Struct> structs, bool mapNative)
        {
            foreach (var @struct in structs)
            {
                foreach (var field in @struct.Fields)
                {
                    field.Type = MapOne(map, field.Type, mapNative, field.NativeType);
                }

                for (var i = 0; i < @struct.ComBases.Count; i++)
                {
                    if (map.TryGetValue(@struct.ComBases[i], out var val))
                    {
                        @struct.ComBases[i] = val;
                    }
                }

                foreach (var function in @struct.Vtbl)
                {
                    Map(map, function, mapNative);
                }

                foreach (var function in @struct.Functions)
                {
                    Map(map, function.Signature, mapNative);
                }
            }
        }

        /// <summary>
        /// Replaces the type names in the given constants.
        /// </summary>
        /// <param name="map">The typemap/dictionary to use.</param>
        /// <param name="constants">The constants to map.</param>
        public static void Map(Dictionary<string, string> map, IEnumerable<Constant> constants, bool mapNative)
        {
            foreach (var constant in constants)
            {
                constant.Type = MapOne(map, constant.Type, mapNative, constant.Type.OriginalName);
            }
        }

        public static void Map(Dictionary<string, string> map, Function function, bool mapNative)
        {
            function.ReturnType = MapOne(map, function.ReturnType, mapNative, function.ReturnType.OriginalName);

            foreach (var parameter in function.Parameters)
            {
                parameter.Type = MapOne(map, parameter.Type, mapNative, parameter.Type.OriginalName);
            }
        }

        /// <summary>
        /// Replaces the type names of GLenum parameters with their associated enums.
        /// </summary>
        /// <param name="profile">The profile to map.</param>
        public static void MapEnums(Profile profile)
        {
            foreach (var project in profile.Projects.Values)
            {
                var glEnum = project.Enums.FirstOrDefault(x => x.NativeName == "GLenum" && x.Tokens.Any())?.Name ??
                             profile.Projects["Core"].Enums.FirstOrDefault(x => x.NativeName == "GLenum")?.Name;

                if(glEnum == null)
                {
                    continue;
                }

                foreach (var @interface in project.Classes.SelectMany(x => x.NativeApis.Values))
                {
                    foreach (var function in @interface.Functions)
                    {
                        foreach (var parameter in function.Parameters)
                        {
                            if (parameter.Type.OriginalName == "GLenum" || parameter.Type.Name == "EGLenum")
                            {
                                parameter.Type.Name = glEnum;
                            }

                            foreach (var genericType in parameter.Type.GenericTypes)
                            {
                                if (genericType.OriginalName == "GLenum")
                                {
                                    genericType.Name = glEnum;
                                }
                            }
                        }

                        if (function.ReturnType.OriginalName == "GLenum" || function.ReturnType.Name == "EGLenum")
                        {
                            function.ReturnType.Name = glEnum;
                        }

                        foreach (var genericType in function.ReturnType.GenericTypes)
                        {
                            if (genericType.OriginalName == "GLenum" || genericType.Name == "CLenum")
                            {
                                genericType.Name = glEnum;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Creates a typemap mapping the native name of structs and enums alike to their new name.
        /// </summary>
        /// <returns>A map mapping those two things I just said.</returns>
        public static Dictionary<string, string> CreateVariedNameMap(Project project)
            => project.Structs.DistinctBy(x => x.NativeName)
                .ToDictionary(x => x.NativeName, x => x.Name)
                .Concat(project.Enums.ToDictionary(x => x.NativeName, x => x.Name))
                .ToDictionary(x => x.Key, x => x.Value);

        private static Type ParseTypeSignature(string type, string original = null, string group = null)
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
                OriginalGroup = group,
                IndirectionLevels = pointerLevel,
                ArrayDimensions = arrayLevel
            };
        }
    }
}
