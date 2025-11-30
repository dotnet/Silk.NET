// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeTypeName("unsigned int")]
public enum GpuVertexElementFormat : uint
{
    Invalid,
    Int,
    Int2,
    Int3,
    Int4,
    Uint,
    Uint2,
    Uint3,
    Uint4,
    Float,
    Float2,
    Float3,
    Float4,
    Byte2,
    Byte4,
    Ubyte2,
    Ubyte4,
    Byte2Norm,
    Byte4Norm,
    Ubyte2Norm,
    Ubyte4Norm,
    Short2,
    Short4,
    Ushort2,
    Ushort4,
    Short2Norm,
    Short4Norm,
    Ushort2Norm,
    Ushort4Norm,
    Half2,
    Half4,
}
