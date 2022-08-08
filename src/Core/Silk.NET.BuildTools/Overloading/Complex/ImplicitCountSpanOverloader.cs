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
                var indexOfCountParameter = original.Parameters.IndexOf(original.Parameters
                    .FindLast(x => x.Name == parameter.Count?.ValueReference));
                var paramApplicable = !parameter.Type.IsPointer &&
                    indexOfCountParameter != -1 &&
                    ApplicableTypes.Contains(original.Parameters[indexOfCountParameter].Type.ToString());
                if (parameter.Type.IsIn && paramApplicable)
                {
                    applicable = true;
                    parameters[i] = new ParameterSignatureBuilder(parameter).WithType
                        (
                            new Type
                            {
                                Name = "ReadOnlySpan",
                                GenericTypes = new List<Type>
                                    {new TypeSignatureBuilder(parameter.Type).WithIsIn(false).Build()},
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
                                    {new TypeSignatureBuilder(parameter.Type).WithIsOut(false).Build()},
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
                                    {new TypeSignatureBuilder(parameter.Type).WithByRef(false).Build()},
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
                    var lengthParam = $"({original.Parameters[countParamIndex].Type}) " + (
                        original.Parameters[spanParamIndex].Type.IsGenericTypeParameterReference
                            ? $"({original.Parameters[spanParamIndex].Name}.Length * " +
                              $"Unsafe.SizeOf<{original.Parameters[spanParamIndex].Type.Name}>())"
                            : $"{original.Parameters[spanParamIndex].Name}.Length");
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
    }
}
