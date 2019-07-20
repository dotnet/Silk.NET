// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Silk.NET.BuildTools.Common;

namespace Silk.NET.BuildTools.Bind.Overloading
{
    public static class Overloader
    {
        public static readonly IFunctionOverloader[] Pipeline = 
        {
            new ArrayParameterOverloader(),
            new PointerParameterOverloader(),
            new ReturnTypeOverloader(),
            new PointerReturnValueOverloader(),
            new StaticCountOverloader(),
        };

        public static IEnumerable<Overload> GetOverloads(Project project)
        {
            foreach (var @interface in project.Interfaces.Values)
            {
                foreach (var function in @interface.Functions)
                {
                    foreach (var overloader in Pipeline)
                    {
                        foreach (var overload in overloader.CreateOverloads(function))
                        {
                            yield return overload;
                        }
                    }
                }
            }
        }

        public static IEnumerable<Overload> GetOverloads(Interface @interface)
        {
            foreach (var function in @interface.Functions)
            {
                foreach (var overloader in Pipeline)
                {
                    foreach (var overload in overloader.CreateOverloads(function))
                    {
                        yield return overload;
                    }
                }
            }
        }
    }
}
