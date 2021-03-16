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
                new ClassOverloader()
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

        public static IComplexFunctionOverloader[] FunctionOverloaders { get; } =
        {
            new ReturnTypeOverloader(),
            new ArrayParameterOverloader(),
            new StringArrayOverloader(),
            new SpanOverloader()
        };


        public static IEnumerable<Function> GetWithVariants(IEnumerable<Function> functions, Project core)
        {
            var enumerable = functions;
            foreach (var overloaders in ParameterOverloaders)
            {
                enumerable = Get(enumerable, overloaders);
            }

            foreach (var overload in enumerable)
            {
                foreach (var final in SimpleReturnOverloader.GetWithOverloads(overload, core, ReturnOverloaders))
                {
                    yield return final;
                }
            }

            IEnumerable<Function> Get(IEnumerable<Function> functions, ISimpleParameterOverloader[] overloaders)
            {
                foreach (var function in functions)
                {
                    foreach (var overload in SimpleParameterOverloader.GetWithOverloads(function, core, overloaders))
                    {
                        yield return overload;
                    }
                }
            }
        }

        public static IEnumerable<ImplementedFunction> GetOverloads(IEnumerable<Function> allFunctions, Project core)
        {
            return Get().RemoveDuplicates(CheckDuplicate);

            static bool CheckDuplicate(ImplementedFunction left, ImplementedFunction right)
                => left.Signature.Equals(right.Signature);

            IEnumerable<ImplementedFunction> Get()
            {
                foreach (var function in allFunctions)
                {
                    foreach (var overload in ComplexFunctionOverloader.GetOverloads
                        (function, core, FunctionOverloaders))
                    {
                        yield return overload;
                    }
                }
            }
        }
    }
}
