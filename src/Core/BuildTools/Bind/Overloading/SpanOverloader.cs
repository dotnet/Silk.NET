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

namespace Silk.NET.BuildTools.Bind.Overloading
{
    public class SpanOverloader : IFunctionOverloader
    {
        public IEnumerable<ImplementedFunction> CreateOverloads(Function function)
        {
            var returnTypeChanged = false;
            var parameterChanged = false;
            var sb = new StringBuilder();
            sb.AppendLine("// SpanOverloader");
            var parameters = function.Parameters.ToList();
            var fun = new FunctionSignatureBuilder(function);
            // TODO we need a length for span returns, so I've disabled them for now
            //if (function.ReturnType.IndirectionLevels == 1 && function.ReturnType.Name != "void")
            //{
            //    fun.WithReturnType
            //    (
            //        new Type
            //        {
            //            Name = "Span", OriginalName = "Span",
            //            GenericTypes = new List<Type> {new Type {Name = function.ReturnType.Name}}
            //        }
            //    );
            //    returnTypeChanged = true;
            //}

            var ind = string.Empty;
            var gen = 0;
            for (var i = 0; i < function.Parameters.Count; i++)
            {
                var param = function.Parameters[i];
                if (param.Type.IndirectionLevels == 1 && (param.Count?.IsMultiple ?? false) && !param.Type.IsOut && !param.Type.IsIn && !param.Type.IsByRef)
                {
                    parameterChanged = true;
                    parameters[i] = new ParameterSignatureBuilder(param).WithName($"{param.Name}Span")
                        .WithType
                        (
                            new Type
                            {
                                Name = "Span", OriginalName = "Span",
                                GenericTypes = new List<Type>
                                {
                                    param.Type.IsVoidPointer()
                                        ? new Type {Name = $"TSpanType{gen++}", OriginalName = param.Type.OriginalName}
                                        : new Type {Name = param.Type.Name, OriginalName = param.Type.OriginalName}
                                }
                            }
                        )
                        .Build();
                    sb.AppendLine($"{ind}fixed ({param.Type} {param.Name} = {param.Name}Span)");
                    sb.AppendLine($"{ind}{{");
                    ind += "    ";
                }
                else
                {
                    parameters[i] = param;
                }
            }

            if (returnTypeChanged)
            {
                sb.Append($"{ind}return (Span<{function.ReturnType.Name}>) ");
            }
            else if (function.ReturnType.ToString() != "void")
            {
                sb.Append($"{ind}return ");
            }
            else
            {
                sb.Append(ind);
            }

            sb.Append($"{function.Name}(");
            sb.Append(string.Join(", ", function.Parameters.Select(x => GetPrefix(x.Type) + Format(x.Name))));
            sb.AppendLine(");");
            
            while (!string.IsNullOrEmpty(ind))
            {
                ind = ind.Remove(ind.Length - 4, 4);
                sb.AppendLine($"{ind}}}");
            }

            fun.WithParameters(parameters);
            fun.WithGenericTypeParameters
            (
                Enumerable.Range(0, gen)
                    .Select(x => new GenericTypeParameter($"TSpanType{x}", new List<string> {"unmanaged"}))
                    .Concat(function.GenericTypeParameters)
                    .ToArray()
            );

            if (returnTypeChanged && !parameterChanged)
            {
                yield return new ImplementedFunction(fun.WithName($"{function.Name}AsSpan").Build(), sb, true);
            }
            else if (parameterChanged)
            {
                yield return new ImplementedFunction(fun.Build(), sb, true);
            }

            string GetPrefix(Type t)
            {
                return t.IsOut ? "out " : t.IsByRef ? "ref " : string.Empty;
            }

            string Format(string n)
            {
                if (Utilities.CSharpKeywords.Contains(n))
                {
                    return $"@{n}";
                }

                return n;
            }
        }
    }
}
