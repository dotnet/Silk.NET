// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUMultisampleState")]
public partial struct GpuMultisampleState
{
    [NativeName("sample_count")]
    public GpuSampleCount SampleCount;

    [NativeName("sample_mask")]
    public uint SampleMask;

    [NativeName("enable_mask")]
    public byte EnableMask;

    [NativeName("padding1")]
    public byte Padding1;

    [NativeName("padding2")]
    public byte Padding2;

    [NativeName("padding3")]
    public byte Padding3;
}
