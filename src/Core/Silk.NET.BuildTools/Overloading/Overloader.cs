// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;

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
                new OpenCLUngroupCompatOverloader()
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
