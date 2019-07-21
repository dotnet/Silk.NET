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
        private bool IsApplicable(Parameter x)
        {
            return (x.Count?.IsStatic ?? false) &&
                   x.Type.IndirectionLevels == 1 &&
                   !x.Type.IsVoidPointer();
        }
        public IEnumerable<Overload> CreateOverloads(Function function)
        {
            if (!function.Parameters.Any(IsApplicable))
            {
                yield break;
            }

            var newParameters = new List<Parameter>(function.Parameters);
            var sb = new StringBuilder();

            for (var i = 0; i < newParameters.Count; i++)
            {
                var param = newParameters[i];
                if (IsApplicable(param))
                {
                    var t = new TypeSignatureBuilder(param.Type).WithIndirectionLevel(0).WithArrayDimensions(1).Build();
                    sb.AppendLine("// StaticCountOverloader");
                    sb.Append("var " + param.Name + " = stackalloc " + param.Type.Name);
                    sb.AppendLine("[" + param.Count.StaticCount + "];");
                    for (var j = 0; j < param.Count.StaticCount; j++)
                    {
                        if (j == 0)
                        {
                            newParameters[i + j] = new ParameterSignatureBuilder(param)
                                .WithName(param.Name + j)
                                .WithType(new TypeSignatureBuilder(param.Type).WithIndirectionLevel(0).Build())
                                .WithCount(null)
                                .Build();
                        }
                        else
                        {
                            newParameters.Insert(i + (j - 1), new ParameterSignatureBuilder(param)
                                .WithName(param.Name + j)
                                .WithCount(null)
                                .WithType(new TypeSignatureBuilder(param.Type).WithIndirectionLevel(0).Build())
                                .Build());
                        }

                        sb.AppendLine(param.Name + "[" + j + "] = " + param.Name + j + ";");
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
            
            yield return new Overload
            (
                new FunctionSignatureBuilder(function).WithParameters(newParameters).Build(),
                sb,
                true
            );

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
