// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Humanizer;
using MoreLinq.Extensions;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Overloading
{
    public class ArrayParameterOverloader : IComplexFunctionOverloader
    {
        /// <summary>
        /// Determines whether or not the overloader is applicable for the given function.
        /// </summary>
        /// <param name="function">The function.</param>
        /// <returns>true if the overloader is applicable; otherwise, false.</returns>
        public static bool IsApplicable(Function function)
        {
            // function is in its original form
            if (function.Kind != SignatureKind.Normal)
            {
                return false;
            }
            
            // function has exactly two parameters
            var parameterCount = function.Parameters.Count;
            if (parameterCount != 2)
            {
                return false;
            }

            // function's name starts with Get, Gen, or New
            var hasCorrectPrefix = function.Name.StartsWith("Delete");
            if (!hasCorrectPrefix)
            {
                return false;
            }

            var returnType = function.ReturnType;
            if (!returnType.Name.Equals(typeof(void).Name, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            if (returnType.IsPointer)
            {
                return false;
            }

            var lastParameter = function.Parameters.Last();

            if (!lastParameter.Type.IsPointer)
            {
                return false;
            }

            // the final parameter's flow is not out
            if (lastParameter.Flow == FlowDirection.Out)
            {
                return false;
            }

            // the last parameter does not have a specific count set
            if (!(lastParameter.Count is null) && lastParameter.Count.IsStatic)
            {
                if (lastParameter.Count.StaticCount > 1)
                {
                    return false;
                }
            }

            return true;
        }

        /// <inheritdoc/>
        public bool TryGetFunctionVariant(Function function, out ImplementedFunction overload, Project core)
        {
            if (!IsApplicable(function))
            {
                overload = null;
                return false;
            }

            var arrayParameter = function.Parameters.Last();
            var arrayParameterType = arrayParameter.Type;

            var newName = function.Name.Singularize(false);
            var newParameters = SkipLastExtension.SkipLast(new List<Parameter>(function.Parameters), 2).ToList();

            var newArrayParameterType = new TypeSignatureBuilder(arrayParameterType)
                .WithArrayDimensions(0)
                .WithIndirectionLevel(0)
                .Build();

            var newArrayParameter = new ParameterSignatureBuilder(arrayParameter)
                .WithType(newArrayParameterType)
                .Build();

            newParameters.Add(newArrayParameter);

            var sb = new StringBuilder();

            sb.AppendLine("// ArrayParameterOverloader");
            sb.AppendLine($"{function.InvocationPrefix}{function.Name}(1, &{newArrayParameter.Name});");

            overload = new ImplementedFunction(new FunctionSignatureBuilder(function)
                .WithName(newName)
                .WithParameters(newParameters)
                .Build(), sb, function, true);
            return true;
        }
    }
}
