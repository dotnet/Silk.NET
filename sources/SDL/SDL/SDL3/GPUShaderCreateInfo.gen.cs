// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public unsafe partial struct GPUShaderCreateInfo
{
    [NativeTypeName("size_t")]
    public nuint CodeSize;

    [NativeTypeName("const Uint8 *")]
    public byte* Code;

    [NativeTypeName("const char *")]
    public sbyte* Entrypoint;

    [NativeTypeName("SDL_GPUShaderFormat")]
    public uint Format;
    public GPUShaderStage Stage;

    [NativeTypeName("Uint32")]
    public uint NumSamplers;

    [NativeTypeName("Uint32")]
    public uint NumStorageTextures;

    [NativeTypeName("Uint32")]
    public uint NumStorageBuffers;

    [NativeTypeName("Uint32")]
    public uint NumUniformBuffers;

    [NativeTypeName("SDL_PropertiesID")]
    public uint Props;
}
