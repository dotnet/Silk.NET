// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("BlendingFactor")]
public enum BlendingFactor : uint
{
    [NativeName("GL_ZERO")]
    Zero = unchecked((uint)0),

    [NativeName("GL_ONE")]
    One = unchecked((uint)1),

    [NativeName("GL_SRC_COLOR")]
    SrcColor = unchecked((uint)0x0300),

    [NativeName("GL_ONE_MINUS_SRC_COLOR")]
    OneMinusSrcColor = unchecked((uint)0x0301),

    [NativeName("GL_SRC_ALPHA")]
    SrcAlpha = unchecked((uint)0x0302),

    [NativeName("GL_ONE_MINUS_SRC_ALPHA")]
    OneMinusSrcAlpha = unchecked((uint)0x0303),

    [NativeName("GL_DST_ALPHA")]
    DstAlpha = unchecked((uint)0x0304),

    [NativeName("GL_ONE_MINUS_DST_ALPHA")]
    OneMinusDstAlpha = unchecked((uint)0x0305),

    [NativeName("GL_DST_COLOR")]
    DstColor = unchecked((uint)0x0306),

    [NativeName("GL_ONE_MINUS_DST_COLOR")]
    OneMinusDstColor = unchecked((uint)0x0307),

    [NativeName("GL_SRC_ALPHA_SATURATE")]
    SrcAlphaSaturate = unchecked((uint)0x0308),

    [NativeName("GL_SRC1_ALPHA")]
    Src1Alpha = unchecked((uint)0x8589),

    [NativeName("GL_CONSTANT_COLOR")]
    ConstantColor = unchecked((uint)0x8001),

    [NativeName("GL_ONE_MINUS_CONSTANT_COLOR")]
    OneMinusConstantColor = unchecked((uint)0x8002),

    [NativeName("GL_CONSTANT_ALPHA")]
    ConstantAlpha = unchecked((uint)0x8003),

    [NativeName("GL_ONE_MINUS_CONSTANT_ALPHA")]
    OneMinusConstantAlpha = unchecked((uint)0x8004),

    [NativeName("GL_SRC1_COLOR")]
    Src1Color = unchecked((uint)0x88F9),

    [NativeName("GL_ONE_MINUS_SRC1_COLOR")]
    OneMinusSrc1Color = unchecked((uint)0x88FA),

    [NativeName("GL_ONE_MINUS_SRC1_ALPHA")]
    OneMinusSrc1Alpha = unchecked((uint)0x88FB),
}
