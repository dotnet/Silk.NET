// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "QCOM", 0)]
[NativeName("BufferBitQCOM")]
[Flags]
public enum BufferBitQCOM : uint
{
    None = 0x0,

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_COLOR_BUFFER_BIT0_QCOM")]
    ColorBufferBit0 = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_COLOR_BUFFER_BIT1_QCOM")]
    ColorBufferBit1 = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_COLOR_BUFFER_BIT2_QCOM")]
    ColorBufferBit2 = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_COLOR_BUFFER_BIT3_QCOM")]
    ColorBufferBit3 = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_COLOR_BUFFER_BIT4_QCOM")]
    ColorBufferBit4 = unchecked((uint)0x00000010),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_COLOR_BUFFER_BIT5_QCOM")]
    ColorBufferBit5 = unchecked((uint)0x00000020),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_COLOR_BUFFER_BIT6_QCOM")]
    ColorBufferBit6 = unchecked((uint)0x00000040),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_COLOR_BUFFER_BIT7_QCOM")]
    ColorBufferBit7 = unchecked((uint)0x00000080),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_DEPTH_BUFFER_BIT0_QCOM")]
    DepthBufferBit0 = unchecked((uint)0x00000100),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_DEPTH_BUFFER_BIT1_QCOM")]
    DepthBufferBit1 = unchecked((uint)0x00000200),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_DEPTH_BUFFER_BIT2_QCOM")]
    DepthBufferBit2 = unchecked((uint)0x00000400),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_DEPTH_BUFFER_BIT3_QCOM")]
    DepthBufferBit3 = unchecked((uint)0x00000800),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_DEPTH_BUFFER_BIT4_QCOM")]
    DepthBufferBit4 = unchecked((uint)0x00001000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_DEPTH_BUFFER_BIT5_QCOM")]
    DepthBufferBit5 = unchecked((uint)0x00002000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_DEPTH_BUFFER_BIT6_QCOM")]
    DepthBufferBit6 = unchecked((uint)0x00004000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_DEPTH_BUFFER_BIT7_QCOM")]
    DepthBufferBit7 = unchecked((uint)0x00008000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_STENCIL_BUFFER_BIT0_QCOM")]
    StencilBufferBit0 = unchecked((uint)0x00010000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_STENCIL_BUFFER_BIT1_QCOM")]
    StencilBufferBit1 = unchecked((uint)0x00020000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_STENCIL_BUFFER_BIT2_QCOM")]
    StencilBufferBit2 = unchecked((uint)0x00040000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_STENCIL_BUFFER_BIT3_QCOM")]
    StencilBufferBit3 = unchecked((uint)0x00080000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_STENCIL_BUFFER_BIT4_QCOM")]
    StencilBufferBit4 = unchecked((uint)0x00100000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_STENCIL_BUFFER_BIT5_QCOM")]
    StencilBufferBit5 = unchecked((uint)0x00200000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_STENCIL_BUFFER_BIT6_QCOM")]
    StencilBufferBit6 = unchecked((uint)0x00400000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_STENCIL_BUFFER_BIT7_QCOM")]
    StencilBufferBit7 = unchecked((uint)0x00800000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_MULTISAMPLE_BUFFER_BIT0_QCOM")]
    MultisampleBufferBit0 = unchecked((uint)0x01000000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_MULTISAMPLE_BUFFER_BIT1_QCOM")]
    MultisampleBufferBit1 = unchecked((uint)0x02000000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_MULTISAMPLE_BUFFER_BIT2_QCOM")]
    MultisampleBufferBit2 = unchecked((uint)0x04000000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_MULTISAMPLE_BUFFER_BIT3_QCOM")]
    MultisampleBufferBit3 = unchecked((uint)0x08000000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_MULTISAMPLE_BUFFER_BIT4_QCOM")]
    MultisampleBufferBit4 = unchecked((uint)0x10000000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_MULTISAMPLE_BUFFER_BIT5_QCOM")]
    MultisampleBufferBit5 = unchecked((uint)0x20000000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_MULTISAMPLE_BUFFER_BIT6_QCOM")]
    MultisampleBufferBit6 = unchecked((uint)0x40000000),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_MULTISAMPLE_BUFFER_BIT7_QCOM")]
    MultisampleBufferBit7 = unchecked((uint)0x80000000),
}
