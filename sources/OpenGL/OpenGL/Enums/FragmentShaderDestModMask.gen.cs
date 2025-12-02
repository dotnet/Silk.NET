// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ATI", -1)]
[NativeName("FragmentShaderDestModMaskATI")]
public enum FragmentShaderDestModMask : uint
{
    [NativeName("GL_NONE")]
    None = 0,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_2X_BIT_ATI")]
    X2XBitATI = 1,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_4X_BIT_ATI")]
    X4XBitATI = 2,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_8X_BIT_ATI")]
    X8XBitATI = 4,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_HALF_BIT_ATI")]
    HalfBitATI = 8,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_QUARTER_BIT_ATI")]
    QuarterBitATI = 16,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_EIGHTH_BIT_ATI")]
    EighthBitATI = 32,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_SATURATE_BIT_ATI")]
    SaturateBitATI = 64,
}
