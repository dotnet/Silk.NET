// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("BufferBitQCOM")]
[Flags]
public enum BufferBitQCOM : uint
{
    None = 0x0,

    [NativeName("GL_COLOR_BUFFER_BIT0_QCOM")]
    ColorBufferBit0 = 0x1,

    [NativeName("GL_COLOR_BUFFER_BIT1_QCOM")]
    ColorBufferBit1 = 0x2,

    [NativeName("GL_COLOR_BUFFER_BIT2_QCOM")]
    ColorBufferBit2 = 0x4,

    [NativeName("GL_COLOR_BUFFER_BIT3_QCOM")]
    ColorBufferBit3 = 0x8,

    [NativeName("GL_COLOR_BUFFER_BIT4_QCOM")]
    ColorBufferBit4 = 0x10,

    [NativeName("GL_COLOR_BUFFER_BIT5_QCOM")]
    ColorBufferBit5 = 0x20,

    [NativeName("GL_COLOR_BUFFER_BIT6_QCOM")]
    ColorBufferBit6 = 0x40,

    [NativeName("GL_COLOR_BUFFER_BIT7_QCOM")]
    ColorBufferBit7 = 0x80,

    [NativeName("GL_DEPTH_BUFFER_BIT0_QCOM")]
    DepthBufferBit0 = 0x100,

    [NativeName("GL_DEPTH_BUFFER_BIT1_QCOM")]
    DepthBufferBit1 = 0x200,

    [NativeName("GL_DEPTH_BUFFER_BIT2_QCOM")]
    DepthBufferBit2 = 0x400,

    [NativeName("GL_DEPTH_BUFFER_BIT3_QCOM")]
    DepthBufferBit3 = 0x800,

    [NativeName("GL_DEPTH_BUFFER_BIT4_QCOM")]
    DepthBufferBit4 = 0x1000,

    [NativeName("GL_DEPTH_BUFFER_BIT5_QCOM")]
    DepthBufferBit5 = 0x2000,

    [NativeName("GL_DEPTH_BUFFER_BIT6_QCOM")]
    DepthBufferBit6 = 0x4000,

    [NativeName("GL_DEPTH_BUFFER_BIT7_QCOM")]
    DepthBufferBit7 = 0x8000,

    [NativeName("GL_STENCIL_BUFFER_BIT0_QCOM")]
    StencilBufferBit0 = 0x10000,

    [NativeName("GL_STENCIL_BUFFER_BIT1_QCOM")]
    StencilBufferBit1 = 0x20000,

    [NativeName("GL_STENCIL_BUFFER_BIT2_QCOM")]
    StencilBufferBit2 = 0x40000,

    [NativeName("GL_STENCIL_BUFFER_BIT3_QCOM")]
    StencilBufferBit3 = 0x80000,

    [NativeName("GL_STENCIL_BUFFER_BIT4_QCOM")]
    StencilBufferBit4 = 0x100000,

    [NativeName("GL_STENCIL_BUFFER_BIT5_QCOM")]
    StencilBufferBit5 = 0x200000,

    [NativeName("GL_STENCIL_BUFFER_BIT6_QCOM")]
    StencilBufferBit6 = 0x400000,

    [NativeName("GL_STENCIL_BUFFER_BIT7_QCOM")]
    StencilBufferBit7 = 0x800000,

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT0_QCOM")]
    MultisampleBufferBit0 = 0x1000000,

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT1_QCOM")]
    MultisampleBufferBit1 = 0x2000000,

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT2_QCOM")]
    MultisampleBufferBit2 = 0x4000000,

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT3_QCOM")]
    MultisampleBufferBit3 = 0x8000000,

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT4_QCOM")]
    MultisampleBufferBit4 = 0x10000000,

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT5_QCOM")]
    MultisampleBufferBit5 = 0x20000000,

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT6_QCOM")]
    MultisampleBufferBit6 = 0x40000000,

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT7_QCOM")]
    MultisampleBufferBit7 = 0x80000000,
}
