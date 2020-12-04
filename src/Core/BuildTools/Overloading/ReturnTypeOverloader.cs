// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
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
    public class ReturnTypeOverloader : IFunctionOverloader
    {
        private static bool IsApplicable(Function function)
        {
            // function has 1 - 2 parameters
            var parameterCount = function.Parameters.Count;
            if (parameterCount == 0 || parameterCount > 2)
            {
                return false;
            }

            // function's name starts with Get, Gen, New, or Create
            var hasCorrectPrefix = function.Name.StartsWith("Get") ||
                                   function.Name.StartsWith("Gen") ||
                                   function.Name.StartsWith("New") ||
                                   function.Name.StartsWith("Create");
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
            if (!(lastParameter.Count is null) && lastParameter.Count.IsStatic)
            {
                if (lastParameter.Count.StaticCount > 1)
                {
                    return false;
                }
            }

            return true;
        }

        public bool TryCreateVariant(Parameter parameter, out Parameter variant, Project core)
        {
            variant = null;
            return false;
        }

        public bool TryCreateVariant(Type returnType, out Type variant, Project core)
        {
            variant = null;
            return false;
        }

        public bool TryCreateVariant(Function function, out Function variant, Project core)
        {
            variant = null;
            return false;
        }

        /// <inheritdoc/>
        public bool TryCreateOverload(Function function, out ImplementedFunction overload, Project core)
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
            var strParams = newParameters.Select(Convert).Concat(new[] { "&ret" });

            sb.AppendLine("// ReturnTypeOverloader");
            sb.AppendLine($"{newReturnType} ret = default;");
            sb.Append($"{function.Name}(");
            sb.Append(string.Join(", ", strParams));
            sb.AppendLine(");");
            sb.AppendLine("return ret;");

            if (!newParameters.Any())
            {
                overload = new ImplementedFunction(functionBuilder
                    .WithParameters(newParameters)
                    .Build(), sb, function, true);

                return true;
            }

            var sizeParameterType = newParameters.Last().Type;
            if ((sizeParameterType.Name != "int" && sizeParameterType.Name != "uint") || sizeParameterType.IsPointer)
            {
                overload = new ImplementedFunction(functionBuilder
                    .WithParameters(newParameters)
                    .Build(), sb, function, true);

                return true;
            }

            var n = newParameters.Last().Name;

            sb.Insert(0,
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
