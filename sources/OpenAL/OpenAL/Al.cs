// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.OpenAL;

public partial class Al
{
    static Al() =>
        LoaderInterface.RegisterAlternativeName(
            "openal",
            "/System/Library/Frameworks/OpenAL.framework/OpenAL"
        );

    public partial class ThisThread
    {
        private static partial IAl ContextFactory() =>
            throw new InvalidOperationException(
                "An IAL context has not been made current on this thread - use ALContext.MakeContextCurrent (or "
                    + "AL.ThisThread.MakeCurrent for advanced use cases). For more info, see "
                    + "https://dotnet.github.io/Silk.NET/docs/v3/silk.net/static-vs-instance-bindings"
            );
    }

    internal INativeContext Context => nativeContext;
}
