// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;
using Attribute = Silk.NET.BuildTools.Common.Attribute;

namespace Silk.NET.BuildTools.Overloading
{
    public static class Overloader
    {
        public static ISimpleParameterOverloader[][] ParameterOverloaders { get; } =
        {
            new ISimpleParameterOverloader[]
            {
                new GroupOverloader(),
                new ClassOverloader(),
                new OpenCLUngroupCompatOverloader(),
                new UndoIntAsPtrOverloader()
            },
            new ISimpleParameterOverloader[]
            {
                new RefOverloader(),
                new StringOverloader()
            }
        };

        public static ISimpleReturnOverloader[] ReturnOverloaders { get; } =
        {
            new StringOverloader()
        };

        // If the overloads you want aren't lighting up try playing around with the below.
        public static IComplexFunctionOverloader[][] FunctionOverloaders { get; } =
        {
            new IComplexFunctionOverloader[]
            {
                new ReturnTypeOverloader(),
                new ArrayParameterOverloader(),
                new StringArrayOverloader(),
                new SpanOverloader(),
                new ImplicitCountSpanOverloader(),
                new ComPtrOverloader()
            },
            new IComplexFunctionOverloader[]
            {
                new NonKhrReturnTypeOverloader()
            }
        };

        internal static IEnumerable<T> Filter<T>
        (
            this IEnumerable<T> elements,
            Function function,
            Dictionary<string, string[]>? overloadExcludedFunctions
        ) => elements.Where
        (
            x => !(overloadExcludedFunctions?.TryGetValue(x.GetType().Name, out var v) ?? false) ||
                 !v.Contains(function.NativeName)
        );

        public static IEnumerable<Function> GetWithVariants
        (
            IEnumerable<Function> functions,
            Profile profile,
            Dictionary<string, string[]>? overloadExcludedFunctions
        )
        {
            foreach (var overload in ParameterOverloaders.Aggregate(functions, Get))
            {
                foreach (var final in SimpleReturnOverloader.GetWithOverloads
                    (overload, profile, ReturnOverloaders.Filter(overload, overloadExcludedFunctions)))
                {
                    yield return final;
                }
            }

            IEnumerable<Function> Get(IEnumerable<Function> functions, ISimpleParameterOverloader[] overloaders)
            {
                foreach (var function in functions)
                {
                    foreach (var overload in SimpleParameterOverloader.GetWithOverloads
                        (function, profile, overloaders.Filter(function, overloadExcludedFunctions)))
                    {
                        if (!overload.Attributes.Any(x => x.Name.Contains("Obsolete")) &&
                            overload.Parameters
                                .Where(x => x.Type.IsIntAsPtr && (x.Type.IsByRef || x.Type.IsIn || x.Type.IsOut))
                                .Select(x => x.Name)
                                .ToArray() is { Length: > 0 } intAsPtrParams
                        )
                        {
                            var paramStr = string.Join(", ", intAsPtrParams);
                            overload.Attributes.Add
                            (
                                new Attribute
                                {
                                    Name = "Obsolete",
                                    Arguments = new List<string>
                                    {
                                        "\"This overload exposes native-sized integer parameters (which are " +
                                        "expressed as pointers in the original C function) as C# references due to a " +
                                        "historical error, please consider using overloads that expose the following " +
                                        $"parameters as raw pointers or native integers instead: {paramStr}\""
                                    }
                                }
                            );
                        }
                        
                        yield return overload;
                    }
                }
            }
        }

        public static IEnumerable<ImplementedFunction> GetOverloads
        (
            IEnumerable<Function> allFunctions,
            Project core,
            Dictionary<string, string[]>? overloadExcludedFunctions,
            bool fastCheck = false
        )
        {
            var ret = allFunctions.Select(x => ((ImplementedFunction?)null, x)).ToList();
            foreach (var pipe in FunctionOverloaders)
            {
                ret.AddRange(Get(ret.Select(x => x.x), pipe).ToList().Select(x => (x, x.Signature)));
            }

            var selector = ret.Where(pair => pair.Item1 is not null)
                .Select(x => x.Item1);
            
            return fastCheck
                ? selector.RemoveDuplicatesFast(CheckDuplicate, GetSignature)
                : selector.RemoveDuplicates(CheckDuplicate);

            static bool CheckDuplicate(ImplementedFunction left, ImplementedFunction right)
                => left.Signature.Equals(right.Signature);

            static string GetSignature(ImplementedFunction func)
                => func.Signature.ToString(null, returnType: false, appendAttributes: false);

            IEnumerable<ImplementedFunction> Get
            (
                IEnumerable<Function> functions,
                IComplexFunctionOverloader[] overloaders
            )
            {
                foreach (var function in functions)
                {
                    foreach (var overload in ComplexFunctionOverloader.GetOverloads
                                 (function, core, overloaders.Filter(function, overloadExcludedFunctions)))
                    {
                        yield return overload;
                    }
                }
            }
        }
    }
}
