// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Overloading
{
    public class ImplicitCountSpanOverloader : IComplexFunctionOverloader
    {
        private const string Ops = "/*+-";
        private static readonly HashSet<string> ApplicableTypes = new()
        {
            "byte",
            "sbyte",
            "Byte",
            "SBbyte",
            "short",
            "ushort",
            "Int16",
            "UInt16",
            "int",
            "uint",
            "Int32",
            "UInt32",
            "nint",
            "nuint",
            "IntPtr",
            "UIntPtr",
            "long",
            "ulong",
            "Int64",
            "UInt64"
        };

        public bool TryGetFunctionVariant(Function original, out ImplementedFunction varied, Project core)
        {
            varied = null;

            // use the ref overload for simplicity
            if (original.Kind != SignatureKind.SimpleOverload)
            {
                return false;
            }

            var applicable = false;
            var invocationParameters = new List<string>();
            var parameters = new List<Parameter>(original.Parameters);
            var counts = new Dictionary<int, int>();
            for (var i = 0; i < original.Parameters.Count; i++)
            {
                var parameter = original.Parameters[i];
                var name = (Utilities.CSharpKeywords.Contains(parameter.Name)
                    ? "@"
                    : string.Empty) + parameter.Name;
                var indexOfCountParameter = original.Parameters.IndexOf
                (
                    original.Parameters
                        .FindLast(x => x.Name == parameter.Count?.ValueReference)
                );
                var paramApplicable = !parameter.Type.IsPointer &&
                                      indexOfCountParameter != -1 &&
                                      ApplicableTypes.Contains
                                          (original.Parameters[indexOfCountParameter].Type.ToString());
                if (parameter.Type.IsIn && paramApplicable)
                {
                    applicable = true;
                    parameters[i] = new ParameterSignatureBuilder(parameter).WithType
                        (
                            new Type
                            {
                                Name = "ReadOnlySpan",
                                GenericTypes = new List<Type>
                                    { new TypeSignatureBuilder(parameter.Type).WithIsIn(false).Build() },
                                IsGenericTypeParameterReference = parameter.Type.IsGenericTypeParameterReference,
                                OriginalName = parameter.Type.OriginalName
                            }
                        )
                        .Build();
                    invocationParameters.Add($"in {name}.GetPinnableReference()");
                    counts[i] = indexOfCountParameter;
                }
                else if (parameter.Type.IsOut && paramApplicable)
                {
                    applicable = true;
                    parameters[i] = new ParameterSignatureBuilder(parameter).WithType
                        (
                            new Type
                            {
                                Name = "Span",
                                GenericTypes = new List<Type>
                                    { new TypeSignatureBuilder(parameter.Type).WithIsOut(false).Build() },
                                IsGenericTypeParameterReference = parameter.Type.IsGenericTypeParameterReference,
                                OriginalName = parameter.Type.OriginalName
                            }
                        )
                        .Build();
                    invocationParameters.Add($"out {name}.GetPinnableReference()");
                    counts[i] = indexOfCountParameter;
                }
                else if (parameter.Type.IsByRef && paramApplicable)
                {
                    applicable = true;
                    parameters[i] = new ParameterSignatureBuilder(parameter).WithType
                        (
                            new Type
                            {
                                Name = "Span",
                                GenericTypes = new List<Type>
                                    { new TypeSignatureBuilder(parameter.Type).WithByRef(false).Build() },
                                IsGenericTypeParameterReference = parameter.Type.IsGenericTypeParameterReference,
                                OriginalName = parameter.Type.OriginalName
                            }
                        )
                        .Build();
                    invocationParameters.Add($"ref {name}.GetPinnableReference()");
                    counts[i] = indexOfCountParameter;
                }
                else
                {
                    invocationParameters.Add
                    (
                        (parameter.Type.IsIn ? "in " :
                            parameter.Type.IsOut ? "out " :
                            parameter.Type.IsByRef ? "ref " : string.Empty) + name
                    );
                }
            }

            if (applicable)
            {
                foreach (var (spanParamIndex, countParamIndex) in counts)
                {
                    var lengthExpr = RearrangeExpression
                    (
                        "$VAR$",
                        $"$VAR${original.Parameters[spanParamIndex].Count?.Expression}"
                    ).Replace("$VAR$", $"{original.Parameters[spanParamIndex].Name}.Length");
                    var lengthParam = $"({original.Parameters[countParamIndex].Type}) " + (
                        original.Parameters[spanParamIndex].Type.IsGenericTypeParameterReference
                            ? $"(({lengthExpr}) * Unsafe.SizeOf<{original.Parameters[spanParamIndex].Type.Name}>())"
                            : lengthExpr);
                    parameters[countParamIndex] = null;
                    invocationParameters[countParamIndex] = lengthParam;
                }

                for (var i = 0; i < parameters.Count; i++)
                {
                    if (parameters[i] is null)
                    {
                        parameters.RemoveAt(i--);
                    }
                }

                var sb = new StringBuilder();
                sb.AppendLine("// ImplicitCountSpanOverloader");
                if (original.ReturnType.ToString() != "void")
                {
                    sb.Append("return ");
                }

                sb.Append(original.InvocationPrefix);
                sb.Append(original.Name);
                sb.Append('(');
                sb.Append(string.Join(", ", invocationParameters));
                sb.Append(");");
                varied = new ImplementedFunction
                (
                    new FunctionSignatureBuilder(original)
                        .WithParameters(parameters)
                        .Build(), sb, original
                );
            }

            return applicable;
        }

        private static string Bodmas(string expression)
        {
            // Remove whitespace
            expression = expression.Replace(" ", "").Replace("\n", "").Replace("\r", "");

            // Scan for existing brackets
            var sb = new StringBuilder();
            var bracketLevel = 0;
            var firstBracketStart = -1;
            for (var i = 0; i < expression.Length; i++)
            {
                switch (expression[i])
                {
                    case '(':
                    {
                        if (bracketLevel == 0)
                        {
                            firstBracketStart = i;
                            sb.Append('(');
                        }

                        bracketLevel++;
                        break;
                    }
                    case ')':
                    {
                        bracketLevel--;
                        if (bracketLevel == 0)
                        {
                            sb.Append(Bodmas(expression[(firstBracketStart + 1)..i]));
                            sb.Append(')');
                        }

                        break;
                    }
                    default:
                    {
                        if (bracketLevel == 0)
                        {
                            sb.Append(expression[i]);
                        }

                        break;
                    }
                }
            }

            if (bracketLevel != 0)
            {
                throw new ArgumentException("Unbalanced brackets", nameof(expression));
            }

            var minLhs = int.MaxValue;
            var maxRhs = int.MinValue;
            foreach (var op in Ops)
            {
                var pass = true;
                var handled = new List<int>();
                while (pass)
                {
                    pass = false;
                    expression = sb.ToString();
                    var opBracketLevel = 0;
                    for (var i = 0; i < expression.Length; i++)
                    {
                        if (bracketLevel > 0)
                        {
                            if (expression[i] == ')')
                                bracketLevel--;
                        }
                        else if (expression[i] == '(')
                        {
                            bracketLevel++;
                        }
                        else if (expression[i] == op && !handled.Contains(i))
                        {
                            var lhs = i;
                            var rhs = i;
                            for (lhs--; lhs > 0; lhs--)
                            {
                                if (expression[lhs] == ')')
                                {
                                    opBracketLevel++;
                                }
                                else if (expression[lhs] == '(')
                                {
                                    opBracketLevel--;
                                }
                                else if (opBracketLevel == 0 && Ops.Contains(expression[lhs]))
                                {
                                    lhs++;
                                    break;
                                }
                            }

                            opBracketLevel = 0;
                            for (rhs++; rhs < expression.Length; rhs++)
                            {
                                if (expression[lhs] == '(')
                                {
                                    opBracketLevel++;
                                }
                                else if (expression[lhs] == ')')
                                {
                                    opBracketLevel--;
                                }
                                else if (opBracketLevel == 0 && Ops.Contains(expression[rhs]))
                                {
                                    break;
                                }
                            }

                            for (var hi = 0; hi < handled.Count; hi++)
                            {
                                handled[hi]++;
                            }

                            handled.Add(i + 1);
                            if (lhs < minLhs)
                            {
                                minLhs = lhs;
                            }

                            if (rhs > maxRhs)
                            {
                                maxRhs = rhs + 1;
                            }

                            sb.Insert(lhs, '(');
                            sb.Insert(rhs + 1, ')');
                            pass = true;
                            break;
                        }
                    }
                }
            }

            return minLhs == 0 && maxRhs == sb.Length - 1 ? sb.ToString()[1..^1] : sb.ToString();
        }

        private static string RearrangeExpression(string variable, string expression)
        {
            expression = Bodmas(expression);
            var bracketLevel = 0;
            var sb = new StringBuilder();
            sb.Append(variable);
            while (expression != variable)
            {
                var sbIdx = -1;
                for (var i = expression.Length - 1; i >= 0; i--)
                {
                    var doBreak = false;
                    switch (expression[i])
                    {
                        case ')':
                        {
                            bracketLevel++;
                            sbIdx = i;
                            break;
                        }
                        case '(':
                        {
                            bracketLevel--;
                            if (bracketLevel == 0 && sbIdx == expression.Length - 1 && i == 0)
                            {
                                expression = expression[1..^1];
                            }

                            sbIdx = -1;
                            break;
                        }
                        default:
                        {
                            if (bracketLevel != 0 || !Ops.Contains(expression[i]))
                            {
                                break;
                            }

                            var lhs = expression[..i];
                            var rhs = expression[(i + 1)..];
                            var lhsVar = lhs.Contains(variable);
                            var rhsVar = rhs.Contains(variable);
                            if (lhsVar && rhsVar)
                            {
                                throw new ArgumentException
                                (
                                    "Variable can't be in both LHS and RHS of expression.",
                                    nameof(expression)
                                );
                            }

                            sb.Insert(0, '(');
                            switch (expression[i])
                            {
                                case '+' when lhsVar:
                                {
                                    sb.Append('-');
                                    sb.Append(rhs);
                                    break;
                                }
                                case '+' when rhsVar:
                                {
                                    sb.Append('-');
                                    sb.Append(lhs);
                                    break;
                                }
                                case '-' when lhsVar:
                                {
                                    sb.Append('+');
                                    sb.Append(rhs);
                                    break;
                                }
                                case '-' when rhsVar:
                                {
                                    // left hand side should be constant so should be fine
                                    sb.Append('+');
                                    sb.Append(lhs);
                                    break;
                                }
                                case '*' when lhsVar:
                                {
                                    sb.Append('/');
                                    sb.Append(rhs);
                                    break;
                                }
                                case '*' when rhsVar:
                                {
                                    sb.Append('/');
                                    sb.Append(lhs);
                                    break;
                                }
                                case '/' when lhsVar:
                                {
                                    sb.Append('*');
                                    sb.Append(rhs);
                                    break;
                                }
                                case '/' when rhsVar:
                                {
                                    sb.Insert(1, "1/");
                                    rhs = $"{rhs}/{lhs}"; // so we replace expression
                                    break;
                                }
                            }

                            sb.Append(')');
                            expression = lhsVar ? lhs.StartsWith('(') ? lhs[1..^1] : lhs :
                                rhs.StartsWith('(') ? rhs[1..^1] : rhs;
                            doBreak = true;
                            break;
                        }
                    }

                    if (doBreak)
                    {
                        break;
                    }
                }
            }

            var ret = sb.ToString();
            return ret.StartsWith('(') ? ret[1..^1] : ret;
        }
    }
}
