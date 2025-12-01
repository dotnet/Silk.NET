// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUVertexElementFormat")]
public enum GpuVertexElementFormat : uint
{
    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_INVALID")]
    Invalid,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_INT")]
    Int,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_INT2")]
    Int2,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_INT3")]
    Int3,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_INT4")]
    Int4,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_UINT")]
    Uint,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_UINT2")]
    Uint2,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_UINT3")]
    Uint3,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_UINT4")]
    Uint4,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_FLOAT")]
    Float,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_FLOAT2")]
    Float2,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_FLOAT3")]
    Float3,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_FLOAT4")]
    Float4,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_BYTE2")]
    Byte2,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_BYTE4")]
    Byte4,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_UBYTE2")]
    Ubyte2,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_UBYTE4")]
    Ubyte4,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_BYTE2_NORM")]
    Byte2Norm,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_BYTE4_NORM")]
    Byte4Norm,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_UBYTE2_NORM")]
    Ubyte2Norm,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_UBYTE4_NORM")]
    Ubyte4Norm,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_SHORT2")]
    Short2,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_SHORT4")]
    Short4,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_USHORT2")]
    Ushort2,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_USHORT4")]
    Ushort4,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_SHORT2_NORM")]
    Short2Norm,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_SHORT4_NORM")]
    Short4Norm,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_USHORT2_NORM")]
    Ushort2Norm,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_USHORT4_NORM")]
    Ushort4Norm,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_HALF2")]
    Half2,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_HALF4")]
    Half4,
}
