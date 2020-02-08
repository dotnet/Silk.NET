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
        public static readonly IFunctionOverloader[][] Pipeline =
        {
            new IFunctionOverloader[]
            {
                new StringOverloader(),
                new StringReturnOverloader(),
                new FlowPointerOverloader(),
                new SpanOverloader(),
            },
            new IFunctionOverloader[]
            {
                new PointerParameterOverloader(),
                new PointerReturnValueOverloader(),
                new StaticCountOverloader(),
                new IntPtrOverloader(),
                new ArrayParameterOverloader(),
                new ReturnTypeOverloader(),
            },
        };

        public static IEnumerable<ImplementedFunction> GetOverloads(Project project)
        {
            var ret = new List<ImplementedFunction>();
            foreach (var @interface in project.Interfaces.Values)
            {
                ret.AddRange(GetOverloads(@interface).Where(x => !ret.Any(y => y.Signature.Equals(x.Signature))));
            }

            return ret;
        }

        public static IEnumerable<ImplementedFunction> GetOverloads(Interface @interface)
        {
            var ret = new List<ImplementedFunction>();
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

        private static IEnumerable<ImplementedFunction> GetOverloads(Function function)
        {
            var ret = new List<ImplementedFunction>();
            var add = new List<ImplementedFunction>();
            foreach (var stage in Pipeline)
            {
                foreach (var overloader in stage)
                {
                    if (ret.Count != 0)
                    {
                        foreach (var overload in ret)
                        {
                            add.AddRange(overloader.CreateOverloads(overload.Signature));
                        }
                        ret.AddRange(add);
                        add.Clear();
                    }
                    
                    ret.AddRange(overloader.CreateOverloads(function));
                }
            }

            return ret;
        }

        private static IEnumerable<ImplementedFunction> GetOverloads(Function function, IEnumerable<IFunctionOverloader> stage)
        {
            return stage.SelectMany(overloader => overloader.CreateOverloads(function));
        }
    }
}
