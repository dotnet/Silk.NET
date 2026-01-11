// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUBlitRegion")]
public unsafe partial struct GPUBlitRegion
{
    [NativeName("texture")]
    public GPUTextureHandle Texture;

    [NativeName("mip_level")]
    public uint MipLevel;

    [NativeName("layer_or_depth_plane")]
    public uint LayerOrDepthPlane;

    [NativeName("x")]
    public uint X;

    [NativeName("y")]
    public uint Y;

    [NativeName("w")]
    public uint W;

    [NativeName("h")]
    public uint H;
}
