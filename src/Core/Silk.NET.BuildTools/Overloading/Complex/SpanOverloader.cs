// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Overloading
{
    // This has to be a complex overloader because it needs to be in an extension method (otherwise it'd conflict with
    // the native pointer signatures)
    public class SpanOverloader : IComplexFunctionOverloader
    {
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
            var @fixed = new List<string>();
            for (var i = 0; i < original.Parameters.Count; i++)
            {
                var parameter = original.Parameters[i];
                var name = (Utilities.CSharpKeywords.Contains(parameter.Name)
                    ? "@"
                    : string.Empty) + parameter.Name;
                if (parameter.Type.IsIn && !parameter.Type.IsPointer)
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
                }
                else if (parameter.Type.IsOut && !parameter.Type.IsPointer)
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
                }
                else if (parameter.Type.IsByRef && !parameter.Type.IsPointer)
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
                }
                else if (parameter.Type.ToString() == "void*")
                {
                    applicable = true;
                    parameters[i] = new ParameterSignatureBuilder(parameter).WithType
                        (
                            new Type
                            {
                                Name = "Span",
                                GenericTypes = new List<Type>
                                {
                                    new Type
                                    {
                                        Name = $"T{@fixed.Count + original.GenericTypeParameters.Count}",
                                        IsGenericTypeParameterReference = true
                                    }
                                },
                                IsGenericTypeParameterReference = true,
                                OriginalName = parameter.Type.OriginalName
                            }
                        )
                        .Build();
                    @fixed.Add($"fixed (void* {name}Spp = {name})");
                    invocationParameters.Add($"{name}Spp");
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
                var sb = new StringBuilder();
                sb.AppendLine("// SpanOverloader");
                foreach (var fix in @fixed)
                {
                    sb.AppendLine(fix);
                }

                if (@fixed.Count > 0)
                {
                    sb.Append("    ");
                }

                if (original.ReturnType.ToString() != "void")
                {
                    sb.Append("return ");
                }

                sb.Append((original.InvocationPrefix ?? "thisApi.") + original.Name);
                sb.Append("(");
                sb.Append(string.Join(", ", invocationParameters));
                sb.Append(");");
                varied = new ImplementedFunction
                (
                    new FunctionSignatureBuilder(original)
                        .WithParameters(parameters)
                        .WithKind(SignatureKind.PotentiallyConflictingOverload)
                        .Build(),
                    sb,
                    original
                );
            }

            return applicable;
        }
    }
}
