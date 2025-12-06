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
    Clear = 5376,

    [NativeName("GL_AND")]
    And = 5377,

    [NativeName("GL_AND_REVERSE")]
    AndReverse = 5378,

    [NativeName("GL_COPY")]
    Copy = 5379,

    [NativeName("GL_AND_INVERTED")]
    AndInverted = 5380,

    [NativeName("GL_NOOP")]
    Noop = 5381,

    [NativeName("GL_XOR")]
    Xor = 5382,

    [NativeName("GL_OR")]
    Or = 5383,

    [NativeName("GL_NOR")]
    Nor = 5384,

    [NativeName("GL_EQUIV")]
    Equiv = 5385,

    [NativeName("GL_INVERT")]
    Invert = 5386,

    [NativeName("GL_OR_REVERSE")]
    OrReverse = 5387,

    [NativeName("GL_COPY_INVERTED")]
    CopyInverted = 5388,

    [NativeName("GL_OR_INVERTED")]
    OrInverted = 5389,

    [NativeName("GL_NAND")]
    Nand = 5390,

    [NativeName("GL_SET")]
    Set = 5391,
}
