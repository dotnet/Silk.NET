// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Convert.Construction
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
                    function.ReturnType = ParsingHelpers.ParseTypeSignature(map[function.ReturnType.ToString()]);
                }
                else if (map.ContainsKey(function.ReturnType.Name))
                {
                    function.ReturnType.Name = map[function.ReturnType.Name];
                }

                foreach (var parameter in function.Parameters)
                {
                    if (map.ContainsKey(parameter.Type.ToString()))
                    {
                        parameter.Type = ParsingHelpers.ParseTypeSignature(map[parameter.Type.ToString()]);
                    }
                    else if (map.ContainsKey(parameter.Type.Name))
                    {
                        parameter.Type.Name = map[parameter.Type.Name];
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
                            if (parameter.Type.OriginalName == "GLenum")
                            {
                                parameter.Type.Name = project.Enums.First().Name;
                            }
                        }

                        if (function.ReturnType.OriginalName == "GLenum")
                        {
                            function.ReturnType.Name = project.Enums.First().Name;
                        }
                    }
                }
            }
        }
    }
}
