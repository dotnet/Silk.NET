// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum SamplePatternEXT : uint
{
    X1Pass = unchecked((uint)0x80A1),
    X2Pass0 = unchecked((uint)0x80A2),
    X2Pass1 = unchecked((uint)0x80A3),
    X4Pass0 = unchecked((uint)0x80A4),
    X4Pass1 = unchecked((uint)0x80A5),
    X4Pass2 = unchecked((uint)0x80A6),
    X4Pass3 = unchecked((uint)0x80A7),
}
