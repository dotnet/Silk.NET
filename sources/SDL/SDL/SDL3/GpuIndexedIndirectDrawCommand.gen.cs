// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUIndexedIndirectDrawCommand")]
public partial struct GpuIndexedIndirectDrawCommand
{
    [NativeName("num_indices")]
    public uint NumIndices;

    [NativeName("num_instances")]
    public uint NumInstances;

    [NativeName("first_index")]
    public uint FirstIndex;

    [NativeName("vertex_offset")]
    public int VertexOffset;

    [NativeName("first_instance")]
    public uint FirstInstance;
}
