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

namespace Silk.NET.BuildTools.Bind.Overloading
{
    public class FlowPointerOverloader : IFunctionOverloader
    {
        public IEnumerable<Overload> CreateOverloads(Function function)
        {
            if (!function.Parameters.Any(x => x.Type.IsPointer && !x.Type.IsVoidPointer()))
            {
                yield break;
            }

            var sb = new StringBuilder();
            var parameters = new List<string>();
            var ind = string.Empty;
            var sig = new FunctionSignatureBuilder(function);
            var newParameters = new Parameter[function.Parameters.Count];
            sb.AppendLine("// FlowPointerOverloader");

            for (var i = 0; i < function.Parameters.Count; i++)
            {
                var param = function.Parameters[i];
                if (param.Type.IsPointer && !param.Type.IsVoidPointer())
                {
                    var newParameterType = new TypeSignatureBuilder(param.Type)
                        .WithIndirectionLevel(param.Type.IndirectionLevels - 1);
                    switch (param.Flow)
                    {
                        case FlowDirection.Undefined:
                            newParameterType = newParameterType.WithByRef(true);
                            break;
                        case FlowDirection.In:
                            newParameterType = newParameterType.WithIsIn(true);
                            break;
                        case FlowDirection.Out:
                            newParameterType = newParameterType.WithIsOut(true);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    var newParameter = new ParameterSignatureBuilder(param).WithType(newParameterType.Build());
                    parameters.Add(param.Name + "Ptr");
                    var safeName = (Utilities.CSharpKeywords.Contains(param.Name) ? "@" : string.Empty) + param.Name;
                    sb.AppendLine(ind + $"fixed ({param.Type} {param.Name}Ptr = &{safeName})");
                    sb.AppendLine(ind + "{");
                    ind += "    ";
                    newParameters[i] = newParameter.Build();
                }
                else
                {
                    parameters.Add((Utilities.CSharpKeywords.Contains(param.Name) ? "@" : string.Empty) + param.Name);
                    newParameters[i] = param;
                }
            }

            sb.Append(ind);
            if (function.ReturnType.ToString() != "void")
            {
                sb.Append("return ");
            }

            sb.AppendLine(function.Name + "(" + string.Join(", ", parameters) + ");");

            while (!string.IsNullOrEmpty(ind))
            {
                ind = ind.Remove(ind.Length - 4, 4);
                sb.AppendLine(ind + "}");
            }
            
            yield return new Overload(sig.WithParameters(newParameters).Build(), sb, true);
        }
    }
}
