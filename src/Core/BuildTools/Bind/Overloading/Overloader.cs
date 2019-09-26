// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Bind.Overloading
{
    public static class Overloader
    {
        public static readonly IFunctionOverloader[] Pipeline =
        {
            new ReturnTypeOverloader(),
            new ArrayParameterOverloader(),
            new PointerParameterOverloader(),
            new StringOverloader(),
            new PointerReturnValueOverloader(),
            new StaticCountOverloader(),
            new IntPtrOverloader(),
            new SpanOverloader(),
            new FlowPointerOverloader(),
        };

        public static IEnumerable<Overload> GetOverloads(Project project)
        {
            var ret = new List<Overload>();
            foreach (var @interface in project.Interfaces.Values)
            {
                ret.AddRange(GetOverloads(@interface).Where(x => !ret.Any(y => y.Signature.Equals(x.Signature))));
            }

            return ret;
        }

        public static IEnumerable<Overload> GetOverloads(Interface @interface)
        {
            var ret = new List<Overload>();
            foreach (var function in @interface.Functions)
            {
                foreach (var overload in GetOverloads(function))
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

            return ret;
        }

        private static IEnumerable<Overload> GetOverloads(Function function)
        {
            foreach (var overloader in Pipeline)
            {
                foreach (var overload in overloader.CreateOverloads(function))
                {
                    yield return overload;
                    foreach (var anotherOverload in GetOverloads(overload.Signature))
                    {
                        //Debug.WriteLine("B:" + overload.Signature);
                        //Debug.WriteLine("A:" + anotherOverload.Signature + " (" + overloader.GetType().Name + ")");
                        yield return anotherOverload;
                    }
                }
            }
        }
    }
}
