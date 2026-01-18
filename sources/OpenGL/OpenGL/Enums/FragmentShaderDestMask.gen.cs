// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FragmentShaderDestMaskATI")]
public enum FragmentShaderDestMask : uint
{
    [NativeName("GL_NONE")]
    None = 0,

    [NativeName("GL_RED_BIT_ATI")]
    RedBitATI = 1,

    [NativeName("GL_GREEN_BIT_ATI")]
    GreenBitATI = 2,

    [NativeName("GL_BLUE_BIT_ATI")]
    BlueBitATI = 4,
}
