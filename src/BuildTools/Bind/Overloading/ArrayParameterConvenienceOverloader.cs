//
// ArrayParameterConvenienceOverloader.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generator.Bind.Overloading;
using Generator.Common.Builders;
using Generator.Common.Functions;
using Humanizer;
using MoreLinq.Extensions;

namespace Bind.Overloaders
{
    /// <summary>
    /// Creates array parameter convenience overloads for functions.
    /// </summary>
    public class ArrayParameterConvenienceOverloader : IFunctionOverloader
    {
        /// <summary>
        /// Determines whether or not the overloader is applicable for the given function.
        /// </summary>
        /// <param name="function">The function.</param>
        /// <returns>true if the overloader is applicable; otherwise, false.</returns>
        public static bool IsApplicable(Function function)
        {
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
        public IEnumerable<Overload> CreateOverloads(Function function)
        {
            if (!IsApplicable(function))
            {
                yield break;
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

            sb.AppendLine(function.Name + "(1, &" + newArrayParameter.Name + ");");

            yield return new Overload(new FunctionSignatureBuilder(function)
                .WithName(newName)
                .WithParameters(newParameters)
                .Build(), sb);
        }
    }
}
