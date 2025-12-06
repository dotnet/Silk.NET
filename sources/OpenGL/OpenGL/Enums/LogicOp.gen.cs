// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum LogicOp : uint
{
    Clear = unchecked((uint)0x1500),
    And = unchecked((uint)0x1501),
    AndReverse = unchecked((uint)0x1502),
    Copy = unchecked((uint)0x1503),
    AndInverted = unchecked((uint)0x1504),
    Noop = unchecked((uint)0x1505),
    Xor = unchecked((uint)0x1506),
    Or = unchecked((uint)0x1507),
    Nor = unchecked((uint)0x1508),
    Equiv = unchecked((uint)0x1509),
    Invert = unchecked((uint)0x150A),
    OrReverse = unchecked((uint)0x150B),
    CopyInverted = unchecked((uint)0x150C),
    OrInverted = unchecked((uint)0x150D),
    Nand = unchecked((uint)0x150E),
    Set = unchecked((uint)0x150F),
}
