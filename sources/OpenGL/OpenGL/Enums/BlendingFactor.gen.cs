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
    Zero = 0,

    [NativeName("GL_ONE")]
    One = 1,

    [NativeName("GL_SRC_COLOR")]
    SrcColor = 768,

    [NativeName("GL_ONE_MINUS_SRC_COLOR")]
    OneMinusSrcColor = 769,

    [NativeName("GL_SRC_ALPHA")]
    SrcAlpha = 770,

    [NativeName("GL_ONE_MINUS_SRC_ALPHA")]
    OneMinusSrcAlpha = 771,

    [NativeName("GL_DST_ALPHA")]
    DstAlpha = 772,

    [NativeName("GL_ONE_MINUS_DST_ALPHA")]
    OneMinusDstAlpha = 773,

    [NativeName("GL_DST_COLOR")]
    DstColor = 774,

    [NativeName("GL_ONE_MINUS_DST_COLOR")]
    OneMinusDstColor = 775,

    [NativeName("GL_SRC_ALPHA_SATURATE")]
    SrcAlphaSaturate = 776,

    [NativeName("GL_SRC1_ALPHA")]
    Src1Alpha = 34185,

    [NativeName("GL_CONSTANT_COLOR")]
    ConstantColor = 32769,

    [NativeName("GL_ONE_MINUS_CONSTANT_COLOR")]
    OneMinusConstantColor = 32770,

    [NativeName("GL_CONSTANT_ALPHA")]
    ConstantAlpha = 32771,

    [NativeName("GL_ONE_MINUS_CONSTANT_ALPHA")]
    OneMinusConstantAlpha = 32772,

    [NativeName("GL_SRC1_COLOR")]
    Src1Color = 35065,

    [NativeName("GL_ONE_MINUS_SRC1_COLOR")]
    OneMinusSrc1Color = 35066,

    [NativeName("GL_ONE_MINUS_SRC1_ALPHA")]
    OneMinusSrc1Alpha = 35067,
}
