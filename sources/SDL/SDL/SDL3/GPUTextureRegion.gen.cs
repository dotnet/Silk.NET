// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public unsafe partial struct GPUTextureRegion
{
    public GPUTextureHandle Texture;

    [NativeTypeName("Uint32")]
    public uint MipLevel;

    [NativeTypeName("Uint32")]
    public uint Layer;

    [NativeTypeName("Uint32")]
    public uint X;

    [NativeTypeName("Uint32")]
    public uint Y;

    [NativeTypeName("Uint32")]
    public uint Z;

    [NativeTypeName("Uint32")]
    public uint W;

    [NativeTypeName("Uint32")]
    public uint H;

    [NativeTypeName("Uint32")]
    public uint D;
}
