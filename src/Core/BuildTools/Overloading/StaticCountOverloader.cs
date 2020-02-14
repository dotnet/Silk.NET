// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    public class StaticCountOverloader : IFunctionOverloader
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
            var staticCountIndices = new List<int>();
            staticCountIndices.AddRange(function.Parameters.Where(x => x.Count.IsStatic).Select((x, i) => i));
            if (staticCountIndices.Count == 0)
            {
                variant = null;
                return false;
            }

            var parameters = new List<Parameter>();
            parameters.AddRange(function.Parameters);

            foreach (var index in staticCountIndices)
            {
                var param = parameters[index];
                var newParam = parameters[index] = new ParameterSignatureBuilder(param).WithType
                (
                    new TypeSignatureBuilder(param.Type)
                        .WithIndirectionLevel(param.Type.IndirectionLevels - 1)
                        .Build()
                )
                .Build();
                newParam.Attributes.Clear();
                newParam.Attributes.Add
                (
                    new Attribute
                    {
                        Name = "Ultz.SuperInvoke.InteropServices.MergeNextAttribute",
                        Arguments = new List<string> {(param.Count.StaticCount - 1).ToString()}
                    }
                );

                for (var i = 0; i < param.Count.StaticCount - 1; i++)
                {
                    parameters.Insert
                    (
                        index + 1, new ParameterSignatureBuilder(param).WithType
                         (
                             new TypeSignatureBuilder(param.Type)
                                 .WithIndirectionLevel(param.Type.IndirectionLevels - 1)
                                 .Build()
                         )
                         .Build()
                    );
                }
            }
            
            variant = new FunctionSignatureBuilder(function).WithParameters(parameters).Build();
            return true;
        }

        public bool TryCreateOverload(Function function, out ImplementedFunction overload, Project core)
        {
            overload = null;
            return false;
        }
    }
}
