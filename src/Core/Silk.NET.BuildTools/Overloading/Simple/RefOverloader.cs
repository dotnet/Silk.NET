// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    public class RefOverloader : ISimpleParameterOverloader
    {
        public bool TryGetParameterVariant(Parameter parameter, out Parameter varied, Project core)
        {
            if (parameter.Type.IsPointer)
            {
                varied = new ParameterSignatureBuilder(parameter).WithType
                    (
                        new TypeSignatureBuilder(parameter.Type)
                            .WithIndirectionLevel(parameter.Type.IndirectionLevels - 1)
                            .WithByRef(parameter.Flow != FlowDirection.In && parameter.Flow != FlowDirection.Out)
                            .WithIsIn(parameter.Flow == FlowDirection.In)
                            .WithIsOut(parameter.Flow == FlowDirection.Out)
                            .WithIsGenericType(parameter.Type.IndirectionLevels == 1 && parameter.Type.Name == "void")
                            .Build()
                    )
                    .Build();
                return true;
            }

            varied = null;
            return false;
        }
        
        // TODO ref returns once we know they work
    }
}
