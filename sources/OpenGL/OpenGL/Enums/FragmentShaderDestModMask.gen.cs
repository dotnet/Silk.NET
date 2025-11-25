// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FragmentShaderDestModMask : uint
{
    None = unchecked((uint)0),
    X2XBitATI = unchecked((uint)0x00000001),
    X4XBitATI = unchecked((uint)0x00000002),
    X8XBitATI = unchecked((uint)0x00000004),
    HalfBitATI = unchecked((uint)0x00000008),
    QuarterBitATI = unchecked((uint)0x00000010),
    EighthBitATI = unchecked((uint)0x00000020),
    SaturateBitATI = unchecked((uint)0x00000040),
}
