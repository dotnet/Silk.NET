// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading.Final
{
    public class DelegateOverloader : ISimpleParameterOverloader
    {
        public bool TryGetParameterVariant(Parameter parameter, out Parameter varied, Project core)
        {
            if (parameter.Type.IsFunctionPointer)
            {
                // we don't need to use pfns in parameters, that'll just confuse people because IntelliSense won't tell
                // them how to make a pfn.
                varied = new ParameterSignatureBuilder(parameter)
                    .WithType
                    (
                        new TypeSignatureBuilder(parameter.Type)
                            .WithName(parameter.Type.FunctionPointerSignature.Name)
                            .Build()
                    )
                    .Build();
                return true;
            }

            varied = null;
            return false;
        }
    }
}
