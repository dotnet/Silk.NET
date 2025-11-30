// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("BinormalPointerTypeEXT")]
[Transformed]
public enum BinormalPointerTypeEXT : uint
{
    [NativeName("GL_BYTE")]
    Byte = unchecked((uint)0x1400),

    [NativeName("GL_SHORT")]
    Short = unchecked((uint)0x1402),

    [NativeName("GL_FLOAT")]
    Float = unchecked((uint)0x1406),

    [NativeName("GL_INT")]
    Int = unchecked((uint)0x1404),

    [NativeName("GL_DOUBLE")]
    Double = unchecked((uint)0x140A),
}
