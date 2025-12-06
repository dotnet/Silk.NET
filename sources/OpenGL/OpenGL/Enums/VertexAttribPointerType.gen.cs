// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("VertexAttribPointerType")]
public enum VertexAttribPointerType : uint
{
    [NativeName("GL_BYTE")]
    Byte = 5120,

    [NativeName("GL_UNSIGNED_BYTE")]
    UnsignedByte = 5121,

    [NativeName("GL_SHORT")]
    Short = 5122,

    [NativeName("GL_UNSIGNED_SHORT")]
    UnsignedShort = 5123,

    [NativeName("GL_FLOAT")]
    Float = 5126,

    [NativeName("GL_FIXED")]
    Fixed = 5132,

    [NativeName("GL_UNSIGNED_INT")]
    UnsignedInt = 5125,

    [NativeName("GL_INT")]
    Int = 5124,

    [NativeName("GL_DOUBLE")]
    Double = 5130,

    [NativeName("GL_UNSIGNED_INT_2_10_10_10_REV")]
    UnsignedInt2X10X10X10Rev = 33640,

    [NativeName("GL_UNSIGNED_INT_10F_11F_11F_REV")]
    UnsignedInt10F11F11FRev = 35899,

    [NativeName("GL_HALF_FLOAT")]
    HalfFloat = 5131,

    [NativeName("GL_INT_2_10_10_10_REV")]
    Int2X10X10X10Rev = 36255,

    [NativeName("GL_UNSIGNED_INT64_ARB")]
    UnsignedInt64ARB = 5135,

    [NativeName("GL_INT64_ARB")]
    Int64ARB = 5134,

    [NativeName("GL_INT64_NV")]
    Int64NV = 5134,

    [NativeName("GL_UNSIGNED_INT64_NV")]
    UnsignedInt64NV = 5135,

    [NativeName("GL_UNSIGNED_INT_2_10_10_10_REV_EXT")]
    UnsignedInt2X10X10X10RevEXT = 33640,
}
