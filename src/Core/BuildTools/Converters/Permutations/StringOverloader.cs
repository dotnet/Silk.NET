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
    public class StringOverloader : IParameterOverloader
    {
        public bool IsApplicable
            (ParameterOverloadContext parameter) => parameter.Parameter.Type.ToString() == "char*" ||
                                                    parameter.Parameter.Type.ToString() == "byte*";

        public bool IsApplicable(Type type) => type.ToString() == "char*" || type.ToString() == "byte*";

        public IEnumerable<Parameter> GetParameterPermutations(ParameterOverloadContext parameter)
        {
            yield return new Parameter
            {
                Attributes = new List<Attribute>(),
                Count = null,
                Flow = FlowDirection.Undefined,
                Name = parameter.Parameter.Name,
                Type = new TypeSignatureBuilder(parameter.Parameter.Type).WithName
                        ("string")
                    .WithIndirectionLevel(0)
                    .Build()
            };
        }

        public IEnumerable<Type> GetReturnTypePermutations
            (Type type)
        {
            yield return new TypeSignatureBuilder(type).WithName("string").WithIndirectionLevel(0).Build();
        }
    }
}
