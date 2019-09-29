// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
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
            for (var i = 0; i < function.Parameters.Count; i++)
            {
                var param = function.Parameters[i];
                if (param.Type.ToString() == "char**" && !param.Type.IsOut)
                {
                    var parameters = function.Parameters.ToArray();
                    var o = new StringBuilder();
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
                    if (function.ReturnType.ToString() != "void")
                    {
                        o.Append("var silkReturn = ");
                    }

                    o.Append(function.Name);
                    o.Append("(");
                    o.Append
                    (
                        string.Join
                        (
                            ", ", function.Parameters.Select((x, j) => j == i ? $"(char**){param.Name}_o" : Convert(x))
                        )
                    );
                    o.AppendLine(");");
                    o.AppendLine($"SilkMarshal.FreeStringArrayPtr({param.Name}_o, {ConvertName(param.Name)}.Length);");
                    if (function.ReturnType.ToString() != "void")
                    {
                        o.Append("return silkReturn;");
                    }

                    yield return new Overload
                        (new FunctionSignatureBuilder(function).WithParameters(parameters).Build(), o, true);
                }
                else if ((param.Type.ToString() == "char*" || param.Type.ToString() == "byte*") && !param.Type.IsOut)
                {
                    var parameters = function.Parameters.ToArray();
                    var o = new StringBuilder();
                    o.AppendLine($"var {param.Name}_s = SilkMarshal.MarshalStringToPtr({ConvertName(param.Name)});");
                    parameters[i] = new ParameterSignatureBuilder(param).WithType(new Type(){Name = "string"}).Build();
                    if (function.ReturnType.ToString() != "void")
                    {
                        o.Append("var silkReturn = ");
                    }

                    o.Append(function.Name);
                    o.Append("(");
                    o.Append
                    (
                        string.Join
                        (
                            ", ", function.Parameters.Select((x, j) => j == i ? $"({param.Type}){param.Name}_s" : Convert(x))
                        )
                    );
                    o.AppendLine(");");
                    o.AppendLine($"SilkMarshal.FreeStringPtr({param.Name}_s);");
                    if (function.ReturnType.ToString() != "void")
                    {
                        o.Append("return silkReturn;");
                    }

                    yield return new Overload
                        (new FunctionSignatureBuilder(function).WithParameters(parameters).Build(), o, true);
                }
            }
        }

        private static string Convert(Parameter param)
        {
            return param.Type.IsOut ? $"out {ConvertName(param.Name)}" : ConvertName(param.Name);
        }

        private static string ConvertName(string argName)
        {
            return Utilities.CSharpKeywords.Contains(argName) ? $"@{argName}" : argName;
        }
    }
}
