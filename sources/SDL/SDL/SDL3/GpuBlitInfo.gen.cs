// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUBlitInfo")]
public partial struct GpuBlitInfo
{
    [NativeName("source")]
    public GpuBlitRegion Source;

    [NativeName("destination")]
    public GpuBlitRegion Destination;

    [NativeName("load_op")]
    public GpuLoadOp LoadOp;

    [NativeName("clear_color")]
    public FColor ClearColor;

    [NativeName("flip_mode")]
    public FlipMode FlipMode;

    [NativeName("filter")]
    public GpuFilter Filter;

    [NativeName("cycle")]
    public byte Cycle;

    [NativeName("padding1")]
    public byte Padding1;

    [NativeName("padding2")]
    public byte Padding2;

    [NativeName("padding3")]
    public byte Padding3;
}
