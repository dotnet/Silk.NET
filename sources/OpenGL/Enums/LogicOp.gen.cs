// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum LogicOp : uint
{
    Clear = 0x1500,
    AND = 0x1501,
    AndReverse = 0x1502,
    COPY = 0x1503,
    AndInverted = 0x1504,
    NOOP = 0x1505,
    XOR = 0x1506,
    OR = 0x1507,
    NOR = 0x1508,
    Equiv = 0x1509,
    Invert = 0x150A,
    OrReverse = 0x150B,
    CopyInverted = 0x150C,
    OrInverted = 0x150D,
    NAND = 0x150E,
    SET = 0x150F
}
