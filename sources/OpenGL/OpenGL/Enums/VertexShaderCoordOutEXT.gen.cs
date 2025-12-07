// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum VertexShaderCoordOutEXT : uint
{
    X = unchecked((uint)0x87D5),
    Y = unchecked((uint)0x87D6),
    Z = unchecked((uint)0x87D7),
    W = unchecked((uint)0x87D8),
    NegativeX = unchecked((uint)0x87D9),
    NegativeY = unchecked((uint)0x87DA),
    NegativeZ = unchecked((uint)0x87DB),
    NegativeW = unchecked((uint)0x87DC),
    Zero = unchecked((uint)0x87DD),
    One = unchecked((uint)0x87DE),
    NegativeOne = unchecked((uint)0x87DF),
}
