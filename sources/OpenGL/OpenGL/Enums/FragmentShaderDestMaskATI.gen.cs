// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FragmentShaderDestMaskATI")]
public enum FragmentShaderDestMaskATI : uint
{
    [NativeName("GL_NONE")]
    None = unchecked((uint)0),

    [NativeName("GL_RED_BIT_ATI")]
    RedBitATI = unchecked((uint)0x00000001),

    [NativeName("GL_GREEN_BIT_ATI")]
    GreenBitATI = unchecked((uint)0x00000002),

    [NativeName("GL_BLUE_BIT_ATI")]
    BlueBitATI = unchecked((uint)0x00000004),
}
