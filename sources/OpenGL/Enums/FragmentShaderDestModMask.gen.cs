// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum FragmentShaderDestModMask
{
    NONE = 0,
    X2XBitATI = 0x00000001,
    X4XBitATI = 0x00000002,
    X8XBitATI = 0x00000004,
    HalfBitATI = 0x00000008,
    QuarterBitATI = 0x00000010,
    EighthBitATI = 0x00000020,
    SaturateBitATI = 0x00000040
}
