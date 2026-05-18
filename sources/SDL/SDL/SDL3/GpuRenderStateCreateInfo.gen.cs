// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPURenderStateCreateInfo")]
public unsafe partial struct GpuRenderStateCreateInfo
{
    [NativeName("fragment_shader")]
    public GpuShaderHandle FragmentShader;

    [NativeName("num_sampler_bindings")]
    public int NumSamplerBindings;

    [NativeName("sampler_bindings")]
    public GpuTextureSamplerBinding* SamplerBindings;

    [NativeName("num_storage_textures")]
    public int NumStorageTextures;

    [NativeName("storage_textures")]
    public GpuTextureHandle* StorageTextures;

    [NativeName("num_storage_buffers")]
    public int NumStorageBuffers;

    [NativeName("storage_buffers")]
    public GpuBufferHandle* StorageBuffers;

    [NativeName("props")]
    public uint Props;
}
