// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum CombinerVariableNV : uint
{
    A = unchecked((uint)0x8523),
    B = unchecked((uint)0x8524),
    C = unchecked((uint)0x8525),
    D = unchecked((uint)0x8526),
    E = unchecked((uint)0x8527),
    F = unchecked((uint)0x8528),
    G = unchecked((uint)0x8529),
}
