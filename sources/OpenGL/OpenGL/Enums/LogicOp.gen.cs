// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("LogicOp")]
public enum LogicOp : uint
{
    [NativeName("GL_CLEAR")]
    Clear = unchecked((uint)0x1500),

    [NativeName("GL_AND")]
    And = unchecked((uint)0x1501),

    [NativeName("GL_AND_REVERSE")]
    AndReverse = unchecked((uint)0x1502),

    [NativeName("GL_COPY")]
    Copy = unchecked((uint)0x1503),

    [NativeName("GL_AND_INVERTED")]
    AndInverted = unchecked((uint)0x1504),

    [NativeName("GL_NOOP")]
    Noop = unchecked((uint)0x1505),

    [NativeName("GL_XOR")]
    Xor = unchecked((uint)0x1506),

    [NativeName("GL_OR")]
    Or = unchecked((uint)0x1507),

    [NativeName("GL_NOR")]
    Nor = unchecked((uint)0x1508),

    [NativeName("GL_EQUIV")]
    Equiv = unchecked((uint)0x1509),

    [NativeName("GL_INVERT")]
    Invert = unchecked((uint)0x150A),

    [NativeName("GL_OR_REVERSE")]
    OrReverse = unchecked((uint)0x150B),

    [NativeName("GL_COPY_INVERTED")]
    CopyInverted = unchecked((uint)0x150C),

    [NativeName("GL_OR_INVERTED")]
    OrInverted = unchecked((uint)0x150D),

    [NativeName("GL_NAND")]
    Nand = unchecked((uint)0x150E),

    [NativeName("GL_SET")]
    Set = unchecked((uint)0x150F),
}
