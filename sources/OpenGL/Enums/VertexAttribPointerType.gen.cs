// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum VertexAttribPointerType : uint
{
    BYTE = 0x1400,
    UnsignedByte = 0x1401,
    Short = 0x1402,
    UnsignedShort = 0x1403,
    INT = 0x1404,
    UnsignedInt = 0x1405,
    Float = 0x1406,
    Double = 0x140A,
    UnsignedInt2X10X10X10Rev = 0x8368,
    UnsignedInt10F11F11FRev = 0x8C3B,
    HalfFloat = 0x140B,
    Int2X10X10X10Rev = 0x8D9F,
    Fixed = 0x140C,
    UnsignedInt64ARB = 0x140F,
    Int64ARB = 0x140E,
    Int64NV = 0x140E,
    UnsignedInt64NV = 0x140F,
    UnsignedInt2X10X10X10RevEXT = 0x8368
}
