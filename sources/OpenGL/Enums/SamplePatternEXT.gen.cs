// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum SamplePatternEXT : uint
{
    Pass = 0x80A1,
    Gl2Pass0 = 0x80A2,
    Gl2Pass1 = 0x80A3,
    Gl4Pass0 = 0x80A4,
    Gl4Pass1 = 0x80A5,
    Gl4Pass2 = 0x80A6,
    Gl4Pass3 = 0x80A7
}
