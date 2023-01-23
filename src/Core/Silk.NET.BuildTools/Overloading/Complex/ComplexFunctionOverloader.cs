// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    /// <summary>
    /// Creates complex function overloads.
    /// </summary>
    ///<remarks>
    /// It is "complex" in the sense that:
    /// <list type="bullet">
    /// <item><description>The signatures it generates may not be SilkTouch compatible.</description></item>
    /// <item><description>Extra code is needed in order to make the function work.</description></item>
    /// </list>
    /// While this is the simplest overloading step, it is the one that has the most impact.
    /// </remarks>
    public static class ComplexFunctionOverloader
    {
        public static IEnumerable<ImplementedFunction> GetOverloads
        (
            Function original,
            Project core,
            IEnumerable<IComplexFunctionOverloader> overloaders
        )
        {
            foreach (var overloader in overloaders)
            {
                if (overloader.TryGetFunctionVariant(original, out var overload, core))
                {
                    yield return overload;
                }
            }
        }
    }
}
