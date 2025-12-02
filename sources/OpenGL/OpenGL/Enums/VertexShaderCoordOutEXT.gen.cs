// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VertexShaderCoordOutEXT")]
public enum VertexShaderCoordOutEXT : uint
{
    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_X_EXT")]
    X = unchecked((uint)0x87D5),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_Y_EXT")]
    Y = unchecked((uint)0x87D6),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_Z_EXT")]
    Z = unchecked((uint)0x87D7),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_W_EXT")]
    W = unchecked((uint)0x87D8),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_NEGATIVE_X_EXT")]
    NegativeX = unchecked((uint)0x87D9),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_NEGATIVE_Y_EXT")]
    NegativeY = unchecked((uint)0x87DA),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_NEGATIVE_Z_EXT")]
    NegativeZ = unchecked((uint)0x87DB),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_NEGATIVE_W_EXT")]
    NegativeW = unchecked((uint)0x87DC),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_ZERO_EXT")]
    Zero = unchecked((uint)0x87DD),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_ONE_EXT")]
    One = unchecked((uint)0x87DE),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_NEGATIVE_ONE_EXT")]
    NegativeOne = unchecked((uint)0x87DF),
}
