// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [Flags]
    [NativeName("Name", "BufferBitQCOM")]
    public enum BufferBitQCOM : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT0_QCOM")]
        ColorBufferBit0QCom = 0x1,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT1_QCOM")]
        ColorBufferBit1QCom = 0x2,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT2_QCOM")]
        ColorBufferBit2QCom = 0x4,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT3_QCOM")]
        ColorBufferBit3QCom = 0x8,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT4_QCOM")]
        ColorBufferBit4QCom = 0x10,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT5_QCOM")]
        ColorBufferBit5QCom = 0x20,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT6_QCOM")]
        ColorBufferBit6QCom = 0x40,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT7_QCOM")]
        ColorBufferBit7QCom = 0x80,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT0_QCOM")]
        DepthBufferBit0QCom = 0x100,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT1_QCOM")]
        DepthBufferBit1QCom = 0x200,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT2_QCOM")]
        DepthBufferBit2QCom = 0x400,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT3_QCOM")]
        DepthBufferBit3QCom = 0x800,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT4_QCOM")]
        DepthBufferBit4QCom = 0x1000,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT5_QCOM")]
        DepthBufferBit5QCom = 0x2000,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT6_QCOM")]
        DepthBufferBit6QCom = 0x4000,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT7_QCOM")]
        DepthBufferBit7QCom = 0x8000,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT0_QCOM")]
        StencilBufferBit0QCom = 0x10000,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT1_QCOM")]
        StencilBufferBit1QCom = 0x20000,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT2_QCOM")]
        StencilBufferBit2QCom = 0x40000,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT3_QCOM")]
        StencilBufferBit3QCom = 0x80000,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT4_QCOM")]
        StencilBufferBit4QCom = 0x100000,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT5_QCOM")]
        StencilBufferBit5QCom = 0x200000,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT6_QCOM")]
        StencilBufferBit6QCom = 0x400000,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT7_QCOM")]
        StencilBufferBit7QCom = 0x800000,
        [NativeName("Name", "GL_MULTISAMPLE_BUFFER_BIT0_QCOM")]
        MultisampleBufferBit0QCom = 0x1000000,
        [NativeName("Name", "GL_MULTISAMPLE_BUFFER_BIT1_QCOM")]
        MultisampleBufferBit1QCom = 0x2000000,
        [NativeName("Name", "GL_MULTISAMPLE_BUFFER_BIT2_QCOM")]
        MultisampleBufferBit2QCom = 0x4000000,
        [NativeName("Name", "GL_MULTISAMPLE_BUFFER_BIT3_QCOM")]
        MultisampleBufferBit3QCom = 0x8000000,
        [NativeName("Name", "GL_MULTISAMPLE_BUFFER_BIT4_QCOM")]
        MultisampleBufferBit4QCom = 0x10000000,
        [NativeName("Name", "GL_MULTISAMPLE_BUFFER_BIT5_QCOM")]
        MultisampleBufferBit5QCom = 0x20000000,
        [NativeName("Name", "GL_MULTISAMPLE_BUFFER_BIT6_QCOM")]
        MultisampleBufferBit6QCom = 0x40000000,
        [NativeName("Name", "GL_MULTISAMPLE_BUFFER_BIT7_QCOM")]
        MultisampleBufferBit7QCom = unchecked((int)0x80000000),
    }
}
