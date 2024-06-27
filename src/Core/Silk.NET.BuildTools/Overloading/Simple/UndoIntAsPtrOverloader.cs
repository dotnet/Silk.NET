// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading;

public class UndoIntAsPtrOverloader : ISimpleParameterOverloader
{
    public bool TryGetParameterVariant(Parameter parameter, out Parameter varied, Profile profile)
    {
        if (!parameter.Type.IsIntAsPtr || parameter.Type.IndirectionLevels == 0)
        {
            varied = null;
            return false;
        }

        varied = new ParameterSignatureBuilder(parameter)
            .WithType
            (
                new TypeSignatureBuilder(parameter.Type)
                    .WithIndirectionLevel(parameter.Type.IndirectionLevels - 1)
                    .WithName("nint")
                    .WithIsIntAsPtr(false)
                    .Build()
            )
            .Build();
        return true;
    }
}
