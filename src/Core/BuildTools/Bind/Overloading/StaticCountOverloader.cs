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
    public class StaticCountOverloader : IFunctionOverloader
    {
        public IEnumerable<Overload> CreateOverloads(Function function)
        {
            if (!function.Parameters.Any(x => x.Count.IsStatic && x.Type.IndirectionLevels == 1))
            {
                yield break;
            }

            var newParameters = new List<Parameter>(function.Parameters);
            var indent = string.Empty;
            var sb = new StringBuilder();

            for (var i = 0; i < function.Parameters.Count; i++)
            {
                var param = function.Parameters[i];
                if (param.Count.IsStatic && param.Type.IndirectionLevels == 1)
                {
                    var t = new TypeSignatureBuilder(param.Type).WithIndirectionLevel(0).WithArrayDimensions(1).Build();
                    sb.Append(param.Type + " " + param.Name + " = stackalloc " + param.Type.Name);
                    sb.AppendLine("[" + param.Count.StaticCount + "];");
                    for (var j = 0; j < param.Count.StaticCount; j++)
                    {
                        if (j == 0)
                        {
                            newParameters[i + j] = new ParameterSignatureBuilder(param)
                                .WithName(param.Name + "_" + j)
                                .WithType(new TypeSignatureBuilder(param.Type).WithIndirectionLevel(0).Build())
                                .Build();
                        }
                        else
                        {
                            newParameters.Insert(i + (j - 1), new ParameterSignatureBuilder(param)
                                .WithName(param.Name + "_" + j)
                                .WithType(new TypeSignatureBuilder(param.Type).WithIndirectionLevel(0).Build())
                                .Build());
                        }

                        sb.AppendLine(param.Name + "[" + j + "] = " + param.Name + "_" + j + ";");
                    }
                }
            }

            if (function.ReturnType.ToString() != "void")
            {
                sb.Append("return ");
            }

            sb.Append(function.Name + "(");
            sb.Append(string.Join(", ", function.Parameters.Select(x => Format(x.Name))));
            sb.Append(");");
            sb.AppendLine();

            string Format(string n)
            {
                if (Utilities.CSharpKeywords.Contains(n))
                {
                    return "@" + n;
                }

                return n;
            }
        }
    }
}
