// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Overloading.Prompt;

namespace Silk.NET.BuildTools.Overloading
{
    /// <summary>
    /// Handles function overloading.
    /// </summary>
    public class Overloader
    {
        /// <summary>
        /// The pipeline used when overloading a function.
        /// </summary>
        // Making this IEnumerable causes it to not work because of the array syntax.
        // ReSharper disable ReturnTypeCanBeEnumerable.Global
        public static IFunctionOverloader[] Pipeline { get; } =
        // ReSharper restore ReturnTypeCanBeEnumerable.Global
        {
            // Early Overloaders in order of priority
            new StringOverloader(),
            new GroupOverloader(),
            
            // Prompt Overloaders
            new SpanAndRefOverloader(),

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
                    parameters[i].Origin = function;
                    if (earlyOverloader.TryCreateVariant(parameters[i], out var variant, core))
                    {
                        parametersVaried = true;
                        parameters[i] = variant;
                        break;
                    }

                    parameters[i].Origin = null;
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
            var ret = new List<Function>();
            foreach (var function in functions)
            {
                ret.Add(function);
                foreach (var overloader in Pipeline)
                {
                    if (overloader.TryCreateVariant(function, out var variant, core))
                    {
                        ret.Add(variant);
                    }
                }
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

        public static IEnumerable<ImplementedFunction> GetOverloads(IEnumerable<Function> functions, Project core)
        {
            var ret = new List<ImplementedFunction>();
            var removals = new List<Function>();
            var originalFunctions = functions as Function[] ?? functions.ToArray();
            foreach (var function in originalFunctions)
            {
                foreach (var overload in GetOverloads(function, core))
                {
                    if (!originalFunctions.Any(x => x.Equals(overload.Signature)))
                    {
                        if (!ret.Any(x => x.Signature.Equals(overload.Signature)))
                        {
                            ret.Add(overload);
                        }
                        else
                        {
                            removals.Add(overload.Signature);
                        }
                    }
                    else
                    {
                        removals.Add(overload.Signature);
                    }
                }
            }

            var removed = 0;
            for (var i = 0; i < ret.Count; i++)
            {
                var overload = ret[i - removed];
                if (removals.Any(x => x.Equals(overload.Base)))
                {
                    ret.Remove(overload);
                    removed++;
                }
            }

            Debug.WriteLine($"Removed {removed} duplicate overloads.");

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

        public static IEnumerable<Function> GetEarlyVariants(IEnumerable<Function> functions, Project core)
        {
            var ret = new List<Function>();
            foreach (var function in functions)
            {
                if (TryGetEarlyVariant(function, out var variant, core))
                {
                    ret.Add(variant);
                }
            }

            return ret;
        }
    }
}
