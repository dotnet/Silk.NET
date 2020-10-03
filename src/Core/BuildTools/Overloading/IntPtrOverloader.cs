// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Text;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    public class IntPtrOverloader : IFunctionOverloader
    {
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

        public bool TryCreateOverload(Function function, out ImplementedFunction overload, Project core)
        {
            if (function.NativeName == "clEnqueueSVMMigrateMem" || function.NativeName == "clEnqueueNativeKernel")
            {
                // BUG these functions think a span variant exists where one doesnt, was unable to filter out.
                overload = null;
                return false;
            }

            var @params = new List<Parameter>(function.Parameters);
            var sb = new StringBuilder();
            sb.AppendLine("// IntPtrOverloader");
            if (function.ReturnType.ToString() != "void")
            {
                sb.Append("return ");
            }

            sb.Append($"{function.Name}(");
            var ret = false;
            for (var i = 0; i < function.Parameters.Count; i++)
            {
                var parameter = function.Parameters[i];
                var parameterName = Utilities.CSharpKeywords.Contains(parameter.Name)
                    ? $"@{parameter.Name}"
                    : parameter.Name;
                if (parameter.Type.IsIntPtr() && !(parameter.Type.IsOut))
                {
                    @params[i] = new ParameterSignatureBuilder(parameter)
                        .WithType(new TypeSignatureBuilder(parameter.Type).WithName("int").Build())
                        .Build();
                    sb.Append($"new IntPtr({parameterName})");
                    ret = true;
                }
                else if (parameter.Type.IsUIntPtr() && !(parameter.Type.IsOut))
                {
                    @params[i] = new ParameterSignatureBuilder(parameter)
                        .WithType(new TypeSignatureBuilder(parameter.Type).WithName("uint").Build())
                        .Build();
                    sb.Append($"new UIntPtr({parameterName})");
                    ret = true;
                }
                else
                {
                    var prefix = parameter.Type.IsOut ? "out " : parameter.Type.IsByRef ? "ref " : string.Empty;
                    sb.Append($"{prefix}{parameterName}");
                }

                if (i != function.Parameters.Count - 1)
                {
                    sb.Append(", ");
                }
            }

            sb.AppendLine(");");

            if (ret)
            {
                overload = new ImplementedFunction(new FunctionSignatureBuilder(function).WithParameters(@params).Build(), sb, function);
                return true;
            }

            overload = null;
            return false;
        }
    }
}
