// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FragmentShaderDestModMaskATI")]
public enum FragmentShaderDestModMaskATI : uint
{
    [NativeName("GL_NONE")]
    None = unchecked((uint)0),

    [NativeName("GL_2X_BIT_ATI")]
    X2XBitATI = unchecked((uint)0x00000001),

    [NativeName("GL_4X_BIT_ATI")]
    X4XBitATI = unchecked((uint)0x00000002),

    [NativeName("GL_8X_BIT_ATI")]
    X8XBitATI = unchecked((uint)0x00000004),

    [NativeName("GL_HALF_BIT_ATI")]
    HalfBitATI = unchecked((uint)0x00000008),

    [NativeName("GL_QUARTER_BIT_ATI")]
    QuarterBitATI = unchecked((uint)0x00000010),

    [NativeName("GL_EIGHTH_BIT_ATI")]
    EighthBitATI = unchecked((uint)0x00000020),

    [NativeName("GL_SATURATE_BIT_ATI")]
    SaturateBitATI = unchecked((uint)0x00000040),
}
