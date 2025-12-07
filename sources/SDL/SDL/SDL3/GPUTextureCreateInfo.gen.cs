// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
namespace Silk.NET.SDL;

[NativeName("SDL_GPUTextureCreateInfo")]
public partial struct GPUTextureCreateInfo
{
    [NativeName("type")]
    public GPUTextureType Type;

    [NativeName("format")]
    public GPUTextureFormat Format;

    [NativeName("usage")]
    public uint Usage;

    [NativeName("width")]
    public uint Width;

    [NativeName("height")]
    public uint Height;

    [NativeName("layer_count_or_depth")]
    public uint LayerCountOrDepth;

    [NativeName("num_levels")]
    public uint NumLevels;

    [NativeName("sample_count")]
    public GPUSampleCount SampleCount;

    [NativeName("props")]
    public uint Props;
}
