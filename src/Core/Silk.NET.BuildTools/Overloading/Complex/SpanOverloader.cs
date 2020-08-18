// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
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
            for (var i = 0; i < original.Parameters.Count; i++)
            {
                var parameter = original.Parameters[i];
                var name = (Utilities.CSharpKeywords.Contains(parameter.Name)
                    ? "@"
                    : string.Empty) + parameter.Name;
                if (parameter.Type.IsIn)
                {
                    applicable = true;
                    parameters[i] = new ParameterSignatureBuilder(parameter).WithType
                        (
                            new Type
                            {
                                Name = "ReadOnlySpan",
                                GenericTypes = new List<Type>
                                    {new TypeSignatureBuilder(parameter.Type).WithIsIn(false).Build()},
                                IsGenericTypeParameterReference = parameter.Type.IsGenericTypeParameterReference
                            }
                        )
                        .Build();
                    invocationParameters.Add($"in {name}.GetPinnableReference()");
                }
                else if (parameter.Type.IsOut)
                {
                    applicable = true;
                    parameters[i] = new ParameterSignatureBuilder(parameter).WithType
                        (
                            new Type
                            {
                                Name = "Span",
                                GenericTypes = new List<Type>
                                    {new TypeSignatureBuilder(parameter.Type).WithIsOut(false).Build()},
                                IsGenericTypeParameterReference = parameter.Type.IsGenericTypeParameterReference
                            }
                        )
                        .Build();
                    invocationParameters.Add($"out {name}.GetPinnableReference()");
                }
                else if (parameter.Type.IsByRef)
                {
                    applicable = true;
                    parameters[i] = new ParameterSignatureBuilder(parameter).WithType
                        (
                            new Type
                            {
                                Name = "Span",
                                GenericTypes = new List<Type>
                                    {new TypeSignatureBuilder(parameter.Type).WithByRef(false).Build()},
                                IsGenericTypeParameterReference = parameter.Type.IsGenericTypeParameterReference
                            }
                        )
                        .Build();
                    invocationParameters.Add($"ref {name}.GetPinnableReference()");
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

            return applicable;
        }
    }
}
