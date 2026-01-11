// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUVertexElementFormat")]
public enum GPUVertexElementFormat
{
    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_INVALID")]
    Invalid = 0,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_INT")]
    Int = 1,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_INT2")]
    Int2 = 2,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_INT3")]
    Int3 = 3,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_INT4")]
    Int4 = 4,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_UINT")]
    Uint = 5,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_UINT2")]
    Uint2 = 6,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_UINT3")]
    Uint3 = 7,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_UINT4")]
    Uint4 = 8,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_FLOAT")]
    Float = 9,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_FLOAT2")]
    Float2 = 10,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_FLOAT3")]
    Float3 = 11,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_FLOAT4")]
    Float4 = 12,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_BYTE2")]
    Byte2 = 13,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_BYTE4")]
    Byte4 = 14,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_UBYTE2")]
    Ubyte2 = 15,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_UBYTE4")]
    Ubyte4 = 16,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_BYTE2_NORM")]
    Byte2Norm = 17,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_BYTE4_NORM")]
    Byte4Norm = 18,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_UBYTE2_NORM")]
    Ubyte2Norm = 19,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_UBYTE4_NORM")]
    Ubyte4Norm = 20,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_SHORT2")]
    Short2 = 21,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_SHORT4")]
    Short4 = 22,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_USHORT2")]
    Ushort2 = 23,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_USHORT4")]
    Ushort4 = 24,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_SHORT2_NORM")]
    Short2Norm = 25,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_SHORT4_NORM")]
    Short4Norm = 26,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_USHORT2_NORM")]
    Ushort2Norm = 27,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_USHORT4_NORM")]
    Ushort4Norm = 28,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_HALF2")]
    Half2 = 29,

    [NativeName("SDL_GPU_VERTEXELEMENTFORMAT_HALF4")]
    Half4 = 30,
}
