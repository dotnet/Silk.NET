// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUVertexAttribute")]
public partial struct GpuVertexAttribute
{
    [NativeName("location")]
    public uint Location;

    [NativeName("buffer_slot")]
    public uint BufferSlot;

    [NativeName("format")]
    public GpuVertexElementFormat Format;

    [NativeName("offset")]
    public uint Offset;
}
