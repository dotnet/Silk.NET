// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Generator.Common.Functions;

namespace Generator.Convert.Construction
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
                if (map.ContainsKey(function.ReturnType.Name))
                {
                    function.ReturnType.Name = map[function.ReturnType.Name];
                }

                foreach (var parameter in function.Parameters)
                {
                    if (map.ContainsKey(parameter.Type.Name))
                    {
                        parameter.Type.Name = map[parameter.Type.Name];
                    }
                }
            }
        }
    }
}
