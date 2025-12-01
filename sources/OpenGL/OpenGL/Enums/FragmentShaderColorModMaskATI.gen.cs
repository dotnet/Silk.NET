// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FragmentShaderColorModMaskATI")]
[Flags]
public enum FragmentShaderColorModMaskATI : uint
{
    None = 0x0,

    [NativeName("GL_2X_BIT_ATI")]
    X2XBitATI = unchecked((uint)0x00000001),

    [NativeName("GL_COMP_BIT_ATI")]
    CompBitATI = unchecked((uint)0x00000002),

    [NativeName("GL_NEGATE_BIT_ATI")]
    NegateBitATI = unchecked((uint)0x00000004),

    [NativeName("GL_BIAS_BIT_ATI")]
    BiasBitATI = unchecked((uint)0x00000008),
}
