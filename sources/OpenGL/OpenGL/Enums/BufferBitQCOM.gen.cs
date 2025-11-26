// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
[Flags]
public enum BufferBitQCOM : uint
{
    ColorBufferBit0 = unchecked((uint)0x00000001),
    ColorBufferBit1 = unchecked((uint)0x00000002),
    ColorBufferBit2 = unchecked((uint)0x00000004),
    ColorBufferBit3 = unchecked((uint)0x00000008),
    ColorBufferBit4 = unchecked((uint)0x00000010),
    ColorBufferBit5 = unchecked((uint)0x00000020),
    ColorBufferBit6 = unchecked((uint)0x00000040),
    ColorBufferBit7 = unchecked((uint)0x00000080),
    DepthBufferBit0 = unchecked((uint)0x00000100),
    DepthBufferBit1 = unchecked((uint)0x00000200),
    DepthBufferBit2 = unchecked((uint)0x00000400),
    DepthBufferBit3 = unchecked((uint)0x00000800),
    DepthBufferBit4 = unchecked((uint)0x00001000),
    DepthBufferBit5 = unchecked((uint)0x00002000),
    DepthBufferBit6 = unchecked((uint)0x00004000),
    DepthBufferBit7 = unchecked((uint)0x00008000),
    StencilBufferBit0 = unchecked((uint)0x00010000),
    StencilBufferBit1 = unchecked((uint)0x00020000),
    StencilBufferBit2 = unchecked((uint)0x00040000),
    StencilBufferBit3 = unchecked((uint)0x00080000),
    StencilBufferBit4 = unchecked((uint)0x00100000),
    StencilBufferBit5 = unchecked((uint)0x00200000),
    StencilBufferBit6 = unchecked((uint)0x00400000),
    StencilBufferBit7 = unchecked((uint)0x00800000),
    MultisampleBufferBit0 = unchecked((uint)0x01000000),
    MultisampleBufferBit1 = unchecked((uint)0x02000000),
    MultisampleBufferBit2 = unchecked((uint)0x04000000),
    MultisampleBufferBit3 = unchecked((uint)0x08000000),
    MultisampleBufferBit4 = unchecked((uint)0x10000000),
    MultisampleBufferBit5 = unchecked((uint)0x20000000),
    MultisampleBufferBit6 = unchecked((uint)0x40000000),
    MultisampleBufferBit7 = unchecked((uint)0x80000000),
}
