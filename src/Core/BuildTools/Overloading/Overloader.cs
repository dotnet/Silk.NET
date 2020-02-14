// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Overloading.Prompt;

namespace Silk.NET.BuildTools.Overloading
{
    public class Overloader
    {
        public static IFunctionOverloader[] Pipeline { get; } =
        {
            // Early Overloaders in order of priority
            new StringOverloader(),
            new GroupOverloader(),
            
            // Prompt Overloaders
            new SpanAndRefOverloader(),
            new StaticCountOverloader(),

            // Late Overloaders
            new IntPtrOverloader(),
            new ArrayParameterOverloader(),
            new ReturnTypeOverloader(),
            new StringArrayOverloader(),
        };
        
        public static bool TryGetEarlyVariant(Function function, out Function finalVariant, Project core)
        {
            var parameters = new List<Parameter>();
            var returnType = function.ReturnType;
            parameters.AddRange(function.Parameters);
            var parametersVaried = false;
            var returnTypeVaried = false;
            for (var i = 0; i < parameters.Count; i++)
            {
                foreach (var earlyOverloader in Pipeline)
                {
                    if (earlyOverloader.TryCreateVariant(parameters[i], out var variant, core))
                    {
                        parametersVaried = true;
                        parameters[i] = variant;
                        break;
                    }
                }
            }
            
            foreach (var earlyOverloader in Pipeline)
            {
                if (earlyOverloader.TryCreateVariant(returnType, out var variant, core))
                {
                    returnTypeVaried = true;
                    returnType = variant;
                    break;
                }
            }

            if (returnTypeVaried || parametersVaried)
            {
                finalVariant = new FunctionSignatureBuilder(function)
                    .WithParameters(parameters)
                    .WithReturnType(returnType)
                    .WithName(returnTypeVaried && !parametersVaried ? function.Name + "S" : function.Name)
                    .Build();
                return true;
            }

            finalVariant = null;
            return false;
        }

        public static IEnumerable<Function> GetWithVariants(IEnumerable<Function> functions, Project core)
        {
            foreach (var function in functions)
            {
                yield return function;
                foreach (var overloader in Pipeline)
                {
                    if (overloader.TryCreateVariant(function, out var variant, core))
                    {
                        yield return variant;
                    }
                }
            }
        }

        public static IEnumerable<ImplementedFunction> GetOverloads(Project project, Project core)
        {
            var ret = new List<ImplementedFunction>();
            foreach (var @interface in project.Interfaces.Values)
            {
                ret.AddRange(GetOverloads(@interface, core).Where(x => !ret.Any(y => y.Signature.Equals(x.Signature))));
            }

            return ret;
        }

        public static IEnumerable<ImplementedFunction> GetOverloads(Interface @interface, Project core)
        {
            var ret = new List<ImplementedFunction>();
            foreach (var function in @interface.Functions)
            {
                foreach (var overload in GetOverloads(function, core))
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

        private static IEnumerable<ImplementedFunction> GetOverloads(Function function, Project core)
        {
            foreach (var overloader in Pipeline)
            {
                if (overloader.TryCreateOverload(function, out var overload, core))
                {
                    yield return overload;
                }
            }
        }
    }
}
