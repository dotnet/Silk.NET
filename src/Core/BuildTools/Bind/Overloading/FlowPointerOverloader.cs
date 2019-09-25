// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Bind.Overloading
{
    public class FlowPointerOverloader : IFunctionOverloader
    {
        public IEnumerable<Overload> CreateOverloads(Function function)
        {
            for (var index = 0; index < function.Parameters.Count; index++)
            {
                if (!(function.Parameters[index].Type.IsPointer && !function.Parameters[index].Type.IsVoidPointer()))
                {
                    continue;
                }

                var sb = new StringBuilder();
                var sig = new FunctionSignatureBuilder(function);
                var parameters = function.Parameters.ToArray();
                sb.AppendLine("// FlowPointerOverloader");

                var type = new TypeSignatureBuilder(parameters[index].Type);

                type = parameters[index].Flow switch
                {
                    FlowDirection.In => type.WithIsIn(true),
                    FlowDirection.Out => type.WithIsOut(true),
                    FlowDirection.Undefined => type.WithByRef(true),
                    _ => type
                };

                type.WithIndirectionLevel(parameters[index].Type.IndirectionLevels - 1);

                sb.AppendLine
                (
                    $"fixed ({parameters[index].Type} {ConvertName(parameters[index].Name)} = &{parameters[index].Name}F)"
                );
                sb.AppendLine("{");
                sb.Append(function.ReturnType.ToString() != "void" ? "    return " : "    ");
                sb.Append(function.Name);
                sb.Append("(");
                sb.Append(string.Join(", ", function.Parameters.Select(x => GetPrefix(x.Type) + ConvertName(x.Name))));
                sb.AppendLine(");");
                sb.AppendLine("}");

                yield return new Overload
                (
                    sig.WithParameters
                        (
                            function.Parameters.Select
                                (
                                    (x, i) => i == index
                                        ? new ParameterSignatureBuilder(parameters[index]).WithType(type.Build())
                                            .WithName
                                            (
                                                $"{parameters[index].Name}F"
                                            )
                                            .Build()
                                        : x
                                )
                                .ToList()
                        )
                        .Build(),
                    sb,
                    true
                );
            }
        }

        private string GetPrefix(Type argType)
        {
            return argType.IsOut ? "out " : string.Empty;
        }

        private static string ConvertName(string argName)
        {
            return Utilities.CSharpKeywords.Contains(argName) ? $"@{argName}" : argName;
        }
    }
}
