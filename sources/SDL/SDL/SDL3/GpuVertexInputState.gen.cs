// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUVertexInputState")]
public unsafe partial struct GpuVertexInputState
{
    [NativeName("vertex_buffer_descriptions")]
    public GpuVertexBufferDescription* VertexBufferDescriptions;

    [NativeName("num_vertex_buffers")]
    public uint NumVertexBuffers;

    [NativeName("vertex_attributes")]
    public GpuVertexAttribute* VertexAttributes;

    [NativeName("num_vertex_attributes")]
    public uint NumVertexAttributes;
}
