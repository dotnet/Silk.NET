// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Converters.Permutations
{
    public class SpanOverloader : IParameterOverloader
    {
        public bool IsApplicable
            (ParameterOverloadContext parameter) =>
            parameter.Parameter.Type.IndirectionLevels == 1 && parameter.Parameter.Count.IsMultiple;

        public bool IsApplicable(Type type) => false;

        public IEnumerable<Parameter> GetParameterPermutations(ParameterOverloadContext parameter)
        {
            yield return new Parameter
            {
                Attributes = new List<Attribute>(),
                Count = null,
                Flow = FlowDirection.Undefined,
                Name = parameter.Parameter.Name,
                Type = new Type
                {
                    ArrayDimensions = 0,
                    GenericTypes = new List<Type>
                    {
                        new TypeSignatureBuilder(parameter.Parameter.Type).WithIndirectionLevel
                                (0)
                            .WithByRef(false)
                            .WithIsIn(false)
                            .WithIsOut(false)
                            .WithName
                            (
                                parameter.Parameter.Type.Name == "void"
                                    ? parameter.AddGenericParameter(0, "unmanaged")
                                    : parameter.Parameter.Type.Name
                            )
                            .Build()
                    },
                    Group = null,
                    IndirectionLevels = 0,
                    OriginalName = parameter.Parameter.Type.OriginalName,
                    Name = "Span"
                }
            };
        }

        public IEnumerable<Type> GetReturnTypePermutations(Type type)
        {
            throw new System.InvalidOperationException();
        }
    }
}
