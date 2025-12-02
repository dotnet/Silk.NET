// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SamplePatternEXT")]
public enum SamplePatternEXT : uint
{
    [NativeName("GL_1PASS_EXT")]
    X1Pass = unchecked((uint)0x80A1),

    [NativeName("GL_2PASS_0_EXT")]
    X2Pass0 = unchecked((uint)0x80A2),

    [NativeName("GL_2PASS_1_EXT")]
    X2Pass1 = unchecked((uint)0x80A3),

    [NativeName("GL_4PASS_0_EXT")]
    X4Pass0 = unchecked((uint)0x80A4),

    [NativeName("GL_4PASS_1_EXT")]
    X4Pass1 = unchecked((uint)0x80A5),

    [NativeName("GL_4PASS_2_EXT")]
    X4Pass2 = unchecked((uint)0x80A6),

    [NativeName("GL_4PASS_3_EXT")]
    X4Pass3 = unchecked((uint)0x80A7),
}
