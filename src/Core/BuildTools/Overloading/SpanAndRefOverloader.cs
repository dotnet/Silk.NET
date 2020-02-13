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
            for (var i = 0; i < parameters.Count; i++)
            {
                var param = parameters[i];
                if (param.Type.IndirectionLevels == 1 && param.Count.IsMultiple)
                {
                    varied = true;
                    parameters[i] = new ParameterSignatureBuilder(param).WithType
                    (
                        new Type
                        {
                            GenericTypes = new List<Type>
                                {new TypeSignatureBuilder(param.Type).WithIndirectionLevel(0).Build()},
                            Name = "Span"
                        }
                    )
                    .Build();
                    continue;
                }

                if (param.Type.IsPointer && !param.Count.IsMultiple)
                {
                    varied = true;
                    parameters[i] = new ParameterSignatureBuilder(param).WithType
                    (
                        new TypeSignatureBuilder(param.Type)
                            .WithIndirectionLevel(param.Type.IndirectionLevels - 1)
                            .WithByRef(true)
                            .Build()
                    )
                    .Build();
                }
            }

            if (varied)
            {
                variant = new FunctionSignatureBuilder(function).WithParameters(parameters).Build();
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
