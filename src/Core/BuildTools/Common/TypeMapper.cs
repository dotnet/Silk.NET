// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JetBrains.Annotations;
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
        public static void Map(Dictionary<string, string> map, IEnumerable<Function> functions)
        {
            foreach (var function in functions)
            {
                if (map.ContainsKey(function.ReturnType.ToString()))
                {
                    function.ReturnType = ParseTypeSignature
                    (
                        map[function.ReturnType.ToString()], function.ReturnType.OriginalName
                    );
                }
                else if (map.ContainsKey(function.ReturnType.Name))
                {
                    function.ReturnType.Name = map[function.ReturnType.Name];
                }

                foreach (var parameter in function.Parameters)
                {
                    if (map.ContainsKey(parameter.Type.ToString()))
                    {
                        parameter.Type = ParseTypeSignature
                        (
                            map[parameter.Type.ToString()], parameter.Type.OriginalName
                        );
                    }
                    else if (map.ContainsKey(parameter.Type.Name))
                    {
                        parameter.Type.Name = map[parameter.Type.Name];
                    }
                }
            }
        }

        /// <summary>
        /// Retrieve a type from a typemap.
        /// </summary>
        /// <param name="maps">The map to use.</param>
        /// <param name="og">The type to map.</param>
        /// <returns>The mapped type.</returns>
        public static Type MapOne(IEnumerable<Dictionary<string, string>> maps, Type og)
        {
            var type = og;
            foreach (var map in maps)
            {
                if (map.ContainsKey(type.ToString()))
                {
                    type = ParseTypeSignature
                    (
                        map[type.ToString()], type.OriginalName
                    );
                }
                else if (map.ContainsKey(type.Name))
                {
                    type.Name = map[type.Name];
                }
            }

            return type;
        }

        /// <summary>
        /// Replaces the type names of parameters and return types in the given functions using the given typemap.
        /// </summary>
        /// <param name="map">The typemap/dictionary to use.</param>
        /// <param name="structs">The functions to map.</param>
        public static void Map(Dictionary<string, string> map, IEnumerable<Struct> structs)
        {
            foreach (var @struct in structs)
            {
                foreach (var field in @struct.Fields)
                {
                    if (map.ContainsKey(field.Type.ToString()))
                    {
                        field.Type = ParseTypeSignature
                        (
                            map[field.Type.ToString()], field.Type.OriginalName
                        );
                    }
                    else if (map.ContainsKey(field.Type.Name))
                    {
                        field.Type.Name = map[field.Type.Name];
                    }
                }
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
                foreach (var @interface in project.Interfaces.Values)
                {
                    foreach (var function in @interface.Functions)
                    {
                        foreach (var parameter in function.Parameters)
                        {
                            if (parameter.Type.OriginalName == "GLenum" || parameter.Type.Name == "CLenum" || parameter.Type.Name == "EGLenum")
                            {
                                parameter.Type.Name = project.Enums.First(x => x.NativeName == "GLenum").Name;
                            }

                            foreach (var genericType in parameter.Type.GenericTypes)
                            {
                                if (genericType.OriginalName == "GLenum" || genericType.Name == "CLenum" || genericType.Name == "EGLenum")
                                {
                                    genericType.Name = project.Enums.First(x => x.NativeName == "GLenum").Name;
                                }
                            }
                        }

                        if (function.ReturnType.OriginalName == "GLenum" || function.ReturnType.Name == "CLenum" || function.ReturnType.Name == "EGLenum")
                        {
                            function.ReturnType.Name = project.Enums.First(x => x.NativeName == "GLenum").Name;
                        }

                        foreach (var genericType in function.ReturnType.GenericTypes)
                        {
                            if (genericType.OriginalName == "GLenum" || genericType.Name == "CLenum" || genericType.Name == "EGLenum")
                            {
                                genericType.Name = project.Enums.First(x => x.NativeName == "GLenum").Name;
                            }
                        }
                    }
                }
            }
        }

        private static Type ParseTypeSignature([NotNull] string type, string original = null)
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
    }
}
