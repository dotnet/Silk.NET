// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.OpenAL;

public partial class AL
{
    static AL() =>
        LoaderInterface.RegisterAlternativeName(
            "openal",
            "/System/Library/Frameworks/OpenAL.framework/OpenAL"
        );

    internal INativeContext Context => nativeContext;
}
