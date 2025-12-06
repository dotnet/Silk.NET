// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum VertexAttribType : uint
{
    Byte = unchecked((uint)0x1400),
    UnsignedByte = unchecked((uint)0x1401),
    Short = unchecked((uint)0x1402),
    UnsignedShort = unchecked((uint)0x1403),
    Int = unchecked((uint)0x1404),
    UnsignedInt = unchecked((uint)0x1405),
    Float = unchecked((uint)0x1406),
    Double = unchecked((uint)0x140A),
    UnsignedInt2X10X10X10Rev = unchecked((uint)0x8368),
    UnsignedInt10F11F11FRev = unchecked((uint)0x8C3B),
    HalfFloat = unchecked((uint)0x140B),
    Int2X10X10X10Rev = unchecked((uint)0x8D9F),
    Fixed = unchecked((uint)0x140C),
    UnsignedInt2X10X10X10RevEXT = unchecked((uint)0x8368),
}
