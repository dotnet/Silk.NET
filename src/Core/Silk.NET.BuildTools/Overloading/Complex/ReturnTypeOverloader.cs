// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics;
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
    public class ReturnTypeOverloader : IComplexFunctionOverloader
    {
        internal static bool IsApplicable(Function function)
        {
            // function's name starts with Get, Gen, New, or Create
            var hasCorrectPrefix = function.Name.StartsWith("Get") ||
                                   function.Name.StartsWith("Gen") ||
                                   function.Name.StartsWith("New") ||
                                   function.Name.StartsWith("Create");

            if (!hasCorrectPrefix)
            {
                return false;
            }

            var hasCorrectDsaSignature = function.Parameters.Count >= 2 &&
                                         function.Parameters[^1].Count?.ValueReference ==
                                         function.Parameters[^2].Name &&
                                         function.Parameters[^1].Type is not { Name: "void", IndirectionLevels: 1 } &&
                                         function.NativeName.StartsWith("gl");
            
            // function has 1 - 2 parameters (backcompat assumption for functions that are not count annotated properly)
            var parameterCount = function.Parameters.Count;
            if (parameterCount is 0 or > 2 && !hasCorrectDsaSignature)
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

            // the final parameter's flow is out
            if (lastParameter.Flow != FlowDirection.Out)
            {
                return false;
            }

            if (function.Parameters.Any(x => x.Type.IsOut || x.Type.IsByRef || x.Type.IsIn))
            {
                return false;
            }

            // the last parameter does not have a specific count set
            if (lastParameter.Count is not null && lastParameter.Count.IsStatic)
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

            var lastParameterType = function.Parameters.Last().Type;
            var newReturnType = new TypeSignatureBuilder(lastParameterType)
                .WithIndirectionLevel(lastParameterType.IndirectionLevels - 1)
                .WithArrayDimensions(0)
                .Build();

            var newParameters = SkipLastExtension.SkipLast(function.Parameters, 1).ToList();
            var newName = function.Name.Singularize(false);

            var functionBuilder = new FunctionSignatureBuilder(function)
                .WithName(newName)
                .WithReturnType(newReturnType);

            var sb = new StringBuilder();
            var strParams = newParameters.Select(Convert).Concat(new[] {"&ret"});

            sb.AppendLine("// ReturnTypeOverloader");
            sb.AppendLine($"{newReturnType} ret = default;");
            sb.Append($"{function.InvocationPrefix}{function.Name}(");
            sb.Append(string.Join(", ", strParams));
            sb.AppendLine(");");
            sb.AppendLine("return ret;");

            if (!newParameters.Any())
            {
                overload = new ImplementedFunction
                (
                    functionBuilder
                        .WithParameters(newParameters)
                        .Build(), sb, function, true
                );

                return true;
            }

            var sizeParameterType = newParameters.Last().Type;
            if (sizeParameterType.Name is not ("nint" or "nuint" or "int" or "uint") || sizeParameterType.IsPointer)
            {
                overload = new ImplementedFunction
                (
                    functionBuilder
                        .WithParameters(newParameters)
                        .Build(), sb, function, true
                );

                return true;
            }

            var n = newParameters.Last().Name;

            sb.Insert
            (
                0,
                $"const {(sizeParameterType.Name == "uint" ? "uint " : "int ")}{(Utilities.CSharpKeywords.Contains(n) ? "@" : "")}{n} = 1;\n"
            );
            newParameters = SkipLastExtension.SkipLast(newParameters, 1).ToList();
            overload = new ImplementedFunction
            (
                functionBuilder
                    .WithParameters(newParameters)
                    .Build(), sb, function, true
            );
            return true;

            string Convert(Parameter x)
            {
                var pre = x.Type.IsOut ? "out " : string.Empty;
                return pre + (Utilities.CSharpKeywords.Contains(x.Name) ? $"@{x.Name}" : x.Name);
            }
        }
    }
}
