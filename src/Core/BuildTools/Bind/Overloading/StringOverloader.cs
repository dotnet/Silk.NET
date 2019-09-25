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
                            Name = "string",
                            ArrayDimensions = 1
                        }
                    )
                    .Build();
                    o.AppendLine
                        ($"var {param.Name}_o = SilkMarshal.MarshalStringArrayToPtr({ConvertName(param.Name)});");
                    pInv.Add($"(char**) {param.Name}_o");
                    c = true;
                }
                else if ((param.Type.ToString() == "char*" || param.Type.ToString() == "byte*") && !param.Type.IsOut)
                {
                    o.AppendLine($"var {param.Name}_s = SilkMarshal.MarshalStringToPtr({ConvertName(param.Name)});");
                    pInv.Add($"({param.Type}) {param.Name}_s");
                    parameters[i] = new ParameterSignatureBuilder(param).WithType(new Type(){Name = "string"}).Build();
                    c = true;
                }
                else
                {
                    var prefix = param.Type.IsOut ? "out " : string.Empty;
                    pInv.Add(prefix + ConvertName(param.Name));
                }
            }

            if (function.ReturnType.ToString() != "void")
            {
                o.Append("var silkReturn = ");
            }

            o.AppendLine($"{function.Name}({string.Join(", ", pInv)});");

            for (var i = 0; i < pInv.Count; i++)
            {
                var parameter = pInv[i];
                if (parameter.EndsWith("_s"))
                {
                    o.AppendLine($"SilkMarshal.FreeStringPtr((IntPtr) {parameter});");
                }
                else if (parameter.EndsWith("_o"))
                {
                    o.AppendLine($"SilkMarshal.FreeStringArrayPtr((IntPtr) {parameter}, {ConvertName(parameters[i].Name)}.Length);");
                }
            }

            if (function.ReturnType.ToString() != "void")
            {
                o.Append("return silkReturn;");
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
