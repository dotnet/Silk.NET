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
    ColorBufferBit0QCOM = unchecked((uint)0x00000001),

    [NativeName("GL_COLOR_BUFFER_BIT1_QCOM")]
    ColorBufferBit1QCOM = unchecked((uint)0x00000002),

    [NativeName("GL_COLOR_BUFFER_BIT2_QCOM")]
    ColorBufferBit2QCOM = unchecked((uint)0x00000004),

    [NativeName("GL_COLOR_BUFFER_BIT3_QCOM")]
    ColorBufferBit3QCOM = unchecked((uint)0x00000008),

    [NativeName("GL_COLOR_BUFFER_BIT4_QCOM")]
    ColorBufferBit4QCOM = unchecked((uint)0x00000010),

    [NativeName("GL_COLOR_BUFFER_BIT5_QCOM")]
    ColorBufferBit5QCOM = unchecked((uint)0x00000020),

    [NativeName("GL_COLOR_BUFFER_BIT6_QCOM")]
    ColorBufferBit6QCOM = unchecked((uint)0x00000040),

    [NativeName("GL_COLOR_BUFFER_BIT7_QCOM")]
    ColorBufferBit7QCOM = unchecked((uint)0x00000080),

    [NativeName("GL_DEPTH_BUFFER_BIT0_QCOM")]
    DepthBufferBit0QCOM = unchecked((uint)0x00000100),

    [NativeName("GL_DEPTH_BUFFER_BIT1_QCOM")]
    DepthBufferBit1QCOM = unchecked((uint)0x00000200),

    [NativeName("GL_DEPTH_BUFFER_BIT2_QCOM")]
    DepthBufferBit2QCOM = unchecked((uint)0x00000400),

    [NativeName("GL_DEPTH_BUFFER_BIT3_QCOM")]
    DepthBufferBit3QCOM = unchecked((uint)0x00000800),

    [NativeName("GL_DEPTH_BUFFER_BIT4_QCOM")]
    DepthBufferBit4QCOM = unchecked((uint)0x00001000),

    [NativeName("GL_DEPTH_BUFFER_BIT5_QCOM")]
    DepthBufferBit5QCOM = unchecked((uint)0x00002000),

    [NativeName("GL_DEPTH_BUFFER_BIT6_QCOM")]
    DepthBufferBit6QCOM = unchecked((uint)0x00004000),

    [NativeName("GL_DEPTH_BUFFER_BIT7_QCOM")]
    DepthBufferBit7QCOM = unchecked((uint)0x00008000),

    [NativeName("GL_STENCIL_BUFFER_BIT0_QCOM")]
    StencilBufferBit0QCOM = unchecked((uint)0x00010000),

    [NativeName("GL_STENCIL_BUFFER_BIT1_QCOM")]
    StencilBufferBit1QCOM = unchecked((uint)0x00020000),

    [NativeName("GL_STENCIL_BUFFER_BIT2_QCOM")]
    StencilBufferBit2QCOM = unchecked((uint)0x00040000),

    [NativeName("GL_STENCIL_BUFFER_BIT3_QCOM")]
    StencilBufferBit3QCOM = unchecked((uint)0x00080000),

    [NativeName("GL_STENCIL_BUFFER_BIT4_QCOM")]
    StencilBufferBit4QCOM = unchecked((uint)0x00100000),

    [NativeName("GL_STENCIL_BUFFER_BIT5_QCOM")]
    StencilBufferBit5QCOM = unchecked((uint)0x00200000),

    [NativeName("GL_STENCIL_BUFFER_BIT6_QCOM")]
    StencilBufferBit6QCOM = unchecked((uint)0x00400000),

    [NativeName("GL_STENCIL_BUFFER_BIT7_QCOM")]
    StencilBufferBit7QCOM = unchecked((uint)0x00800000),

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT0_QCOM")]
    MultisampleBufferBit0QCOM = unchecked((uint)0x01000000),

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT1_QCOM")]
    MultisampleBufferBit1QCOM = unchecked((uint)0x02000000),

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT2_QCOM")]
    MultisampleBufferBit2QCOM = unchecked((uint)0x04000000),

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT3_QCOM")]
    MultisampleBufferBit3QCOM = unchecked((uint)0x08000000),

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT4_QCOM")]
    MultisampleBufferBit4QCOM = unchecked((uint)0x10000000),

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT5_QCOM")]
    MultisampleBufferBit5QCOM = unchecked((uint)0x20000000),

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT6_QCOM")]
    MultisampleBufferBit6QCOM = unchecked((uint)0x40000000),

    [NativeName("GL_MULTISAMPLE_BUFFER_BIT7_QCOM")]
    MultisampleBufferBit7QCOM = unchecked((uint)0x80000000),
}
