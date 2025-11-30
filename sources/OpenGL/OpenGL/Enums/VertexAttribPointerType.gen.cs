// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("VertexAttribPointerType")]
[Transformed]
public enum VertexAttribPointerType : uint
{
    [NativeName("GL_BYTE")]
    Byte = unchecked((uint)0x1400),

    [NativeName("GL_UNSIGNED_BYTE")]
    UnsignedByte = unchecked((uint)0x1401),

    [NativeName("GL_SHORT")]
    Short = unchecked((uint)0x1402),

    [NativeName("GL_UNSIGNED_SHORT")]
    UnsignedShort = unchecked((uint)0x1403),

    [NativeName("GL_FLOAT")]
    Float = unchecked((uint)0x1406),

    [NativeName("GL_FIXED")]
    Fixed = unchecked((uint)0x140C),

    [NativeName("GL_UNSIGNED_INT")]
    UnsignedInt = unchecked((uint)0x1405),

    [NativeName("GL_INT")]
    Int = unchecked((uint)0x1404),

    [NativeName("GL_DOUBLE")]
    Double = unchecked((uint)0x140A),

    [NativeName("GL_UNSIGNED_INT_2_10_10_10_REV")]
    UnsignedInt2X10X10X10Rev = unchecked((uint)0x8368),

    [NativeName("GL_UNSIGNED_INT_10F_11F_11F_REV")]
    UnsignedInt10F11F11FRev = unchecked((uint)0x8C3B),

    [NativeName("GL_HALF_FLOAT")]
    HalfFloat = unchecked((uint)0x140B),

    [NativeName("GL_INT_2_10_10_10_REV")]
    Int2X10X10X10Rev = unchecked((uint)0x8D9F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_UNSIGNED_INT64_ARB")]
    UnsignedInt64Arb = unchecked((uint)0x140F),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INT64_ARB")]
    Int64Arb = unchecked((uint)0x140E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_INT64_NV")]
    Int64Nv = unchecked((uint)0x140E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT64_NV")]
    UnsignedInt64Nv = unchecked((uint)0x140F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_2_10_10_10_REV_EXT")]
    UnsignedInt2X10X10X10Revext = unchecked((uint)0x8368),
}
