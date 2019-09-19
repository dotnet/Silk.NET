// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Text;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Bind.Overloading
{
    public class StringOverloader : IFunctionOverloader
    {
        public IEnumerable<Overload> CreateOverloads(Function function)
        {
            var o = new StringBuilder();
            var parameters = new List<Parameter>(function.Parameters);
            var pInv = new List<string>();
            var ind = "";
            var c = false;
            o.AppendLine("// StringOverloader");
            for (var i = 0; i < function.Parameters.Count; i++)
            {
                var param = function.Parameters[i];
                if (param.Type.ToString() == "char**" && !param.Type.IsOut)
                {
                    parameters[i] = new ParameterSignatureBuilder(param).WithType
                    (
                        new Type
                        {
                            GenericTypes = new List<Type> {new Type {Name = "string"}},
                            Name = "System.Collections.Generic.IReadOnlyList"
                        }
                    )
                    .Build();
                    o.AppendLine($"{ind}var {param.Name}_o = stackalloc char*[{ConvertName(param.Name)}.Count];");
                    o.AppendLine
                    (
                        $"{ind}for (var {param.Name}_i = 0;" +
                        $"{param.Name}_i < {ConvertName(param.Name)}.Count; {param.Name}_i++)"
                    );
                    o.AppendLine($"{ind}{{");
                    o.AppendLine($"{ind}    fixed (char* str = {ConvertName(param.Name)}[{param.Name}_i])");
                    o.AppendLine($"{ind}    {{");
                    o.AppendLine($"{ind}        {param.Name}_o[{param.Name}_i] = str;");
                    o.AppendLine($"{ind}    }}");
                    o.AppendLine($"{ind}}}");
                    o.AppendLine();
                    pInv.Add($"{param.Name}_o");
                    c = true;
                }
                else if ((param.Type.ToString() == "char*" || param.Type.ToString() == "byte*") && !param.Type.IsOut)
                {
                    o.AppendLine($"{ind}fixed (char* {param.Name}_s = {ConvertName(param.Name)})");
                    o.AppendLine($"{ind}{{");
                    ind += "    ";
                    pInv.Add($"{param.Name}_s");
                    parameters[i] = new ParameterSignatureBuilder(param).WithType(new Type(){Name = "string"}).Build();
                    c = true;
                }
                else
                {
                    var prefix = param.Type.IsOut ? "out " : string.Empty;
                    pInv.Add(prefix + ConvertName(param.Name));
                }
            }

            o.Append(ind);
            if (function.ReturnType.ToString() != "void")
            {
                o.Append("return ");
            }

            o.AppendLine($"{function.Name}({string.Join(", ", pInv)});");

            while (!string.IsNullOrEmpty(ind))
            {
                ind = ind.Remove(ind.Length - 4, 4);
                o.AppendLine($"{ind}}}");
            }

            if (c)
            {
                yield return new Overload
                (
                    new FunctionSignatureBuilder(function).WithParameters(parameters).Build(),
                    o,
                    true
                );
            }
        }

        private static string ConvertName(string argName)
        {
            return Utilities.CSharpKeywords.Contains(argName) ? $"@{argName}" : argName;
        }
    }
}
