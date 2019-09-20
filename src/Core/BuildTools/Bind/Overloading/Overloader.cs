// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;

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
            new IntPtrOverloader(),
            new SpanOverloader(),
            new StringOverloader(),
            new FlowPointerOverloader(),
        };

        public static IEnumerable<Overload> GetOverloads(Project project)
        {
            var ret = new List<Overload>();
            foreach
            (
                var overload in project.Interfaces.Values
                    .SelectMany(GetOverloads, (@interface, overload) => new {@interface, overload})
                    .Where(t => ret.Any(x => x.Signature.Equals(t.overload.Signature)))
                    .Select(t => t.overload)
            )
            {
                ret.Add(overload);
            }

            return ret;
        }

        public static IEnumerable<Overload> GetOverloads(Interface @interface)
        {
            var ret = new List<Overload>();
            foreach
            (
                var overload in @interface.Functions
                    .SelectMany(GetOverloads, (function, overload) => new {function, overload})
                    .Where(t => !@interface.Functions.Any(x => x.Equals(t.overload.Signature)))
                    .Where(t => !ret.Any(x => x.Signature.Equals(t.overload.Signature)))
                    .Select(t => t.overload)
            )
            {
                ret.Add(overload);
            }

            return ret;
        }

        private static IEnumerable<Overload> GetOverloads(Function function)
        {
            var overloads = new List<Overload>();
            var cachedLength = 0;
            foreach (var overloader in Pipeline)
            {
                overloads.AddRange(overloader.CreateOverloads(function));
            }

            do
            {
                cachedLength = overloads.Count;
                foreach (var overloader in Pipeline)
                {
                    IEnumerable<Overload> add = new Overload[0];
                    foreach (var overload in overloads)
                    {
                        add = overloader.CreateOverloads(overload.Signature);
                    }

                    overloads.AddRange(add);
                }
            } while (overloads.Count > cachedLength);

            return overloads;
        }
    }
}
