// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
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
            new FlowPointerOverloader(),
            new IntPtrOverloader(),
            new SpanOverloader()
        };

        public static IEnumerable<Overload> GetOverloads(Project project)
        {
            var ret = new List<Overload>();
            foreach (var @interface in project.Interfaces.Values)
            {
                foreach (var function in @interface.Functions)
                {
                    foreach (var overloader in Pipeline)
                    {
                        foreach (var overload in overloader.CreateOverloads(function))
                        {
                            if (!@interface.Functions.Any(x => x.Equals(overload.Signature)))
                            {
                                if (!ret.Any(x => x.Signature.Equals(overload.Signature)))
                                {
                                    ret.Add(overload);
                                }
                            }
                        }
                    }
                }
            }

            return ret;
        }

        public static IEnumerable<Overload> GetOverloads(Interface @interface)
        {
            var ret = new List<Overload>();
            foreach (var function in @interface.Functions)
            {
                foreach (var overloader in Pipeline)
                {
                    foreach (var overload in overloader.CreateOverloads(function))
                    {
                        if (!@interface.Functions.Any(x => x.Equals(overload.Signature)))
                        {
                            if (!ret.Any(x => x.Signature.Equals(overload.Signature)))
                            {
                                ret.Add(overload);
                            }
                        }
                    }
                }
            }

            return ret;
        }
    }
}
