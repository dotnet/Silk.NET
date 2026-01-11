// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUShaderCreateInfo")]
public unsafe partial struct GpuShaderCreateInfo
{
    [NativeName("code_size")]
    public nuint CodeSize;

    [NativeName("code")]
    public byte* Code;

    [NativeName("entrypoint")]
    public sbyte* Entrypoint;

    [NativeName("format")]
    public uint Format;

    [NativeName("stage")]
    public GpuShaderStage Stage;

    [NativeName("num_samplers")]
    public uint NumSamplers;

    [NativeName("num_storage_textures")]
    public uint NumStorageTextures;

    [NativeName("num_storage_buffers")]
    public uint NumStorageBuffers;

    [NativeName("num_uniform_buffers")]
    public uint NumUniformBuffers;

    [NativeName("props")]
    public uint Props;
}
