// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUBufferCreateInfo")]
public partial struct GPUBufferCreateInfo
{
    [NativeName("usage")]
    public uint Usage;

    [NativeName("size")]
    public uint Size;

    [NativeName("props")]
    public uint Props;
}
