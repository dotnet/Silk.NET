// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUIndirectDrawCommand")]
public partial struct GpuIndirectDrawCommand
{
    [NativeName("num_vertices")]
    public uint NumVertices;

    [NativeName("num_instances")]
    public uint NumInstances;

    [NativeName("first_vertex")]
    public uint FirstVertex;

    [NativeName("first_instance")]
    public uint FirstInstance;
}
