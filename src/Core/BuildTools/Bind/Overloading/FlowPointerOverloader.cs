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
                    newParameterType = param.Flow switch
                    {
                        FlowDirection.Undefined => newParameterType.WithByRef(true),
                        FlowDirection.In => newParameterType.WithIsIn(true),
                        FlowDirection.Out => newParameterType.WithIsOut(true),
                        _ => throw new ArgumentOutOfRangeException()
                    };

                    var newParameter = new ParameterSignatureBuilder(param).WithType(newParameterType.Build());
                    var ptrName = (param.Name + "Ptr").Replace("@", "");

                    parameters.Add(ptrName);
                    sb.AppendLine(ind + $"fixed ({param.Type} {ptrName} = &{param.Name})");
                    sb.AppendLine(ind + "{");
                    
                    ind += "    ";
                    newParameters[i] = newParameter.Build();
                }
                else
                {
                    parameters.Add
                    (
                        (param.Type.IsOut ? "out " : string.Empty) + (Utilities.CSharpKeywords.Contains
                            (param.Name)
                            ? "@"
                            : string.Empty) + param.Name
                    );
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
