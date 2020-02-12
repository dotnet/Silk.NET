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
    public class StaticCountOverloader : IParameterOverloader
    {
        public bool IsApplicable(Parameter parameter) => parameter.Count.StaticCount > 1;

        public bool IsApplicable(Type type) => false;

        public IEnumerable<Parameter> GetParameterPermutations(ParameterOverloadContext parameter)
        {
            var amtNext = parameter.Parameter.Count.StaticCount - 1;
            yield return new Parameter
            {
                Attributes = new List<Attribute>
                {
                    new Attribute
                    {
                        Arguments = new List<string> {amtNext.ToString()},
                        Name = "Ultz.SuperInvoke.InteropServices.MergeNextAttribute"
                    }
                },
                Count = null,
                Flow = FlowDirection.Undefined,
                Name = parameter.Parameter.Name + "0",
                Type = new TypeSignatureBuilder(parameter.Parameter.Type).WithIndirectionLevel
                        (parameter.Parameter.Type.IndirectionLevels - 1)
                    .Build()
            };

            for (var i = 0; i < amtNext; i++)
            {
                parameter.DefineAfter(0, new Parameter
                {
                    Attributes = new List<Attribute>(),
                    Count = null,
                    Flow = FlowDirection.Undefined,
                    Name = parameter.Parameter.Name + (i + 1),
                    Type = new TypeSignatureBuilder(parameter.Parameter.Type).WithIndirectionLevel
                            (parameter.Parameter.Type.IndirectionLevels - 1)
                        .Build()
                });
            }
        }

        public IEnumerable<Type> GetReturnTypePermutations(Type type)
        {
            throw new System.InvalidOperationException();
        }
    }
}
