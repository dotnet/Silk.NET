// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ListNameType")]
public enum ListNameType : uint
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

    [NativeName("GL_UNSIGNED_INT")]
    UnsignedInt = 5125,

    [NativeName("GL_INT")]
    Int = 5124,

    [NativeName("GL_2_BYTES")]
    X2Bytes = 5127,

    [NativeName("GL_3_BYTES")]
    X3Bytes = 5128,

    [NativeName("GL_4_BYTES")]
    X4Bytes = 5129,
}
