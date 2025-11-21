// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum SamplePatternSGIS : uint
{
    X1PassEXT = unchecked((uint)0x80A1),
    X2Pass0EXT = unchecked((uint)0x80A2),
    X2Pass1EXT = unchecked((uint)0x80A3),
    X4Pass0EXT = unchecked((uint)0x80A4),
    X4Pass1EXT = unchecked((uint)0x80A5),
    X4Pass2EXT = unchecked((uint)0x80A6),
    X4Pass3EXT = unchecked((uint)0x80A7),
    X1PassSGIS = unchecked((uint)0x80A1),
    X2Pass0Sgis = unchecked((uint)0x80A2),
    X2Pass1Sgis = unchecked((uint)0x80A3),
    X4Pass0Sgis = unchecked((uint)0x80A4),
    X4Pass1Sgis = unchecked((uint)0x80A5),
    X4Pass2Sgis = unchecked((uint)0x80A6),
    X4Pass3Sgis = unchecked((uint)0x80A7),
}
