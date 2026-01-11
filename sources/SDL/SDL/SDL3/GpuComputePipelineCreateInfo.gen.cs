// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUComputePipelineCreateInfo")]
public unsafe partial struct GpuComputePipelineCreateInfo
{
    [NativeName("code_size")]
    public nuint CodeSize;

    [NativeName("code")]
    public byte* Code;

    [NativeName("entrypoint")]
    public sbyte* Entrypoint;

    [NativeName("format")]
    public uint Format;

    [NativeName("num_samplers")]
    public uint NumSamplers;

    [NativeName("num_readonly_storage_textures")]
    public uint NumReadonlyStorageTextures;

    [NativeName("num_readonly_storage_buffers")]
    public uint NumReadonlyStorageBuffers;

    [NativeName("num_readwrite_storage_textures")]
    public uint NumReadwriteStorageTextures;

    [NativeName("num_readwrite_storage_buffers")]
    public uint NumReadwriteStorageBuffers;

    [NativeName("num_uniform_buffers")]
    public uint NumUniformBuffers;

    [NativeName("threadcount_x")]
    public uint ThreadcountX;

    [NativeName("threadcount_y")]
    public uint ThreadcountY;

    [NativeName("threadcount_z")]
    public uint ThreadcountZ;

    [NativeName("props")]
    public uint Props;
}
