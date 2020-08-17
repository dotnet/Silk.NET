// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections;
using System.Collections.Generic;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    public static class Overloader
    {
        public static ISimpleParameterOverloader[] ParameterOverloaders { get; }
        public static IComplexFunctionOverloader[] FunctionOverloaders { get; }

        public static IEnumerable<Function> GetWithVariants(IEnumerable<Function> functions, Project core)
        {
            foreach (var function in functions)
            {
                foreach (var overload in SimpleParameterOverloader.GetWithOverloads
                    (function, core, ParameterOverloaders))
                {
                    yield return overload;
                }
            }
        }

        public static IEnumerable<ImplementedFunction> GetOverloads(IEnumerable<Function> allFunctions, Project core)
        {
            foreach (var function in allFunctions)
            {
                foreach (var overload in ComplexFunctionOverloader.GetOverloads(function, core, FunctionOverloaders))
                {
                    yield return overload;
                }
            }
        }
    }
}
