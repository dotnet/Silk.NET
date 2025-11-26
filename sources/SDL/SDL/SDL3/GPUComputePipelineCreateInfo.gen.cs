// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

public unsafe partial struct GPUComputePipelineCreateInfo
{
    [NativeTypeName("size_t")]
    public nuint CodeSize;

    [NativeTypeName("const Uint8 *")]
    public byte* Code;

    [NativeTypeName("const char *")]
    public sbyte* Entrypoint;

    [NativeTypeName("SDL_GPUShaderFormat")]
    public uint Format;

    [NativeTypeName("Uint32")]
    public uint NumSamplers;

    [NativeTypeName("Uint32")]
    public uint NumReadonlyStorageTextures;

    [NativeTypeName("Uint32")]
    public uint NumReadonlyStorageBuffers;

    [NativeTypeName("Uint32")]
    public uint NumReadwriteStorageTextures;

    [NativeTypeName("Uint32")]
    public uint NumReadwriteStorageBuffers;

    [NativeTypeName("Uint32")]
    public uint NumUniformBuffers;

    [NativeTypeName("Uint32")]
    public uint ThreadcountX;

    [NativeTypeName("Uint32")]
    public uint ThreadcountY;

    [NativeTypeName("Uint32")]
    public uint ThreadcountZ;

    [NativeTypeName("SDL_PropertiesID")]
    public uint Props;
}
