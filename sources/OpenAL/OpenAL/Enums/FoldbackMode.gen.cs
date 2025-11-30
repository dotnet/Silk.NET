// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Generated using the OpenAL Soft headers and corresponding dependencies.
// Original source is licensed under the LGPL 2.0 license. Please note that while bindings are able to be MIT due to
// being header-derived only, implementations of the headers may have a less permissive license.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenAL;

[NativeName("FoldbackMode")]
[Transformed]
public enum FoldbackMode : uint
{
    [NativeName("AL_FOLDBACK_MODE_MONO")]
    Mono = unchecked((uint)0x4101),

    [NativeName("AL_FOLDBACK_MODE_STEREO")]
    Stereo = unchecked((uint)0x4102),
}
