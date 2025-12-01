// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SamplePatternSGIS")]
public enum SamplePatternSGIS : uint
{
    [NativeName("GL_1PASS_EXT")]
    X1PassEXT = unchecked((uint)0x80A1),

    [NativeName("GL_2PASS_0_EXT")]
    X2Pass0EXT = unchecked((uint)0x80A2),

    [NativeName("GL_2PASS_1_EXT")]
    X2Pass1EXT = unchecked((uint)0x80A3),

    [NativeName("GL_4PASS_0_EXT")]
    X4Pass0EXT = unchecked((uint)0x80A4),

    [NativeName("GL_4PASS_1_EXT")]
    X4Pass1EXT = unchecked((uint)0x80A5),

    [NativeName("GL_4PASS_2_EXT")]
    X4Pass2EXT = unchecked((uint)0x80A6),

    [NativeName("GL_4PASS_3_EXT")]
    X4Pass3EXT = unchecked((uint)0x80A7),

    [NativeName("GL_1PASS_SGIS")]
    X1PassSGIS = unchecked((uint)0x80A1),

    [NativeName("GL_2PASS_0_SGIS")]
    X2Pass0SGIS = unchecked((uint)0x80A2),

    [NativeName("GL_2PASS_1_SGIS")]
    X2Pass1SGIS = unchecked((uint)0x80A3),

    [NativeName("GL_4PASS_0_SGIS")]
    X4Pass0SGIS = unchecked((uint)0x80A4),

    [NativeName("GL_4PASS_1_SGIS")]
    X4Pass1SGIS = unchecked((uint)0x80A5),

    [NativeName("GL_4PASS_2_SGIS")]
    X4Pass2SGIS = unchecked((uint)0x80A6),

    [NativeName("GL_4PASS_3_SGIS")]
    X4Pass3SGIS = unchecked((uint)0x80A7),
}
