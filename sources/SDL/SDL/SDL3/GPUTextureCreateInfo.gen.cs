// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
namespace Silk.NET.SDL;

public partial struct GPUTextureCreateInfo
{
    public GPUTextureType Type;
    public GPUTextureFormat Format;

    [NativeTypeName("SDL_GPUTextureUsageFlags")]
    public uint Usage;

    [NativeTypeName("Uint32")]
    public uint Width;

    [NativeTypeName("Uint32")]
    public uint Height;

    [NativeTypeName("Uint32")]
    public uint LayerCountOrDepth;

    [NativeTypeName("Uint32")]
    public uint NumLevels;
    public GPUSampleCount SampleCount;

    [NativeTypeName("SDL_PropertiesID")]
    public uint Props;
}
