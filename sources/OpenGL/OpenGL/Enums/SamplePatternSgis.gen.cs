// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "SGIS", 0)]
[NativeName("SamplePatternSGIS")]
[Transformed]
public enum SamplePatternSgis : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_1PASS_EXT")]
    X1Passext = unchecked((uint)0x80A1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_2PASS_0_EXT")]
    X2Pass0Ext = unchecked((uint)0x80A2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_2PASS_1_EXT")]
    X2Pass1Ext = unchecked((uint)0x80A3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_4PASS_0_EXT")]
    X4Pass0Ext = unchecked((uint)0x80A4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_4PASS_1_EXT")]
    X4Pass1Ext = unchecked((uint)0x80A5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_4PASS_2_EXT")]
    X4Pass2Ext = unchecked((uint)0x80A6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_4PASS_3_EXT")]
    X4Pass3Ext = unchecked((uint)0x80A7),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_1PASS_SGIS")]
    X1Passsgis = unchecked((uint)0x80A1),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_2PASS_0_SGIS")]
    X2Pass0Sgis = unchecked((uint)0x80A2),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_2PASS_1_SGIS")]
    X2Pass1Sgis = unchecked((uint)0x80A3),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_4PASS_0_SGIS")]
    X4Pass0Sgis = unchecked((uint)0x80A4),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_4PASS_1_SGIS")]
    X4Pass1Sgis = unchecked((uint)0x80A5),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_4PASS_2_SGIS")]
    X4Pass2Sgis = unchecked((uint)0x80A6),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_4PASS_3_SGIS")]
    X4Pass3Sgis = unchecked((uint)0x80A7),
}
