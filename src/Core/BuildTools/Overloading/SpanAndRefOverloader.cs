// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading.Prompt
{
    public class SpanAndRefOverloader : IFunctionOverloader
    {
        public bool TryCreateVariant(Parameter parameter, out Parameter variant, Project core)
        {
            variant = null;
            return false;
        }

        public bool TryCreateVariant(Type returnType, out Type variant, Project core)
        {
            variant = null;
            return false;
        }

        public bool TryCreateVariant(Function function, out Function variant, Project core)
        {
            var varied = false;
            var parameters = new List<Parameter>();
            parameters.AddRange(function.Parameters);
            var genericParams = new List<GenericTypeParameter>();
            for (var i = 0; i < parameters.Count; i++)
            {
                var param = parameters[i];
                var typeName = param.Type.Name == "void" ? $"T{genericParams.Count}" : param.Type.Name;
                if (param.Type.Name == "void")
                {
                    genericParams.Add
                    (
                        new GenericTypeParameter
                        { Name = $"T{genericParams.Count}", Constraints = new List<string> { "unmanaged" } }
                    );
                }

                if (param.Type.IndirectionLevels == 1 && (param.Count?.IsMultiple ?? true))
                {
                    varied = true;
                    parameters[i] = new ParameterSignatureBuilder(param).WithType
                    (
                        new Type
                        {
                            GenericTypes = new List<Type>
                                {new TypeSignatureBuilder(param.Type).WithName(typeName).WithIndirectionLevel(0).Build()},
                            Name = "Span"
                        }
                    )
                    .Build();
                    continue;
                }

                if (param.Type.IsPointer && !(param.Count?.IsMultiple ?? true))
                {
                    varied = true;
                    parameters[i] = new ParameterSignatureBuilder(param).WithType
                    (
                        new TypeSignatureBuilder(param.Type)
                            .WithIndirectionLevel(param.Type.IndirectionLevels - 1)
                            .WithName(typeName)
                            .WithByRef(param.Flow != FlowDirection.Out)
                            .WithIsOut(param.Flow == FlowDirection.Out)
                            .Build()
                    )
                    .Build();
                }
            }

            if (varied)
            {
                variant = new FunctionSignatureBuilder(function).WithParameters
                        (parameters)
                    .WithGenericTypeParameters(genericParams)
                    .Build();
                return true;
            }

            variant = null;
            return false;
        }

        public bool TryCreateOverload(Function function, out ImplementedFunction overload, Project core)
        {
            overload = null;
            return false;
        }
    }
}
