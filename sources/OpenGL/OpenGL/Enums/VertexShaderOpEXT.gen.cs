// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum VertexShaderOpEXT : uint
{
    Index = unchecked((uint)0x8782),
    Negate = unchecked((uint)0x8783),
    Dot3 = unchecked((uint)0x8784),
    Dot4 = unchecked((uint)0x8785),
    Mul = unchecked((uint)0x8786),
    Add = unchecked((uint)0x8787),
    Madd = unchecked((uint)0x8788),
    Frac = unchecked((uint)0x8789),
    Max = unchecked((uint)0x878A),
    Min = unchecked((uint)0x878B),
    SetGe = unchecked((uint)0x878C),
    SetLt = unchecked((uint)0x878D),
    Clamp = unchecked((uint)0x878E),
    Floor = unchecked((uint)0x878F),
    Round = unchecked((uint)0x8790),
    ExpBase2 = unchecked((uint)0x8791),
    LogBase2 = unchecked((uint)0x8792),
    Power = unchecked((uint)0x8793),
    Recip = unchecked((uint)0x8794),
    RecipSqrt = unchecked((uint)0x8795),
    Sub = unchecked((uint)0x8796),
    CrossProduct = unchecked((uint)0x8797),
    MultiplyMatrix = unchecked((uint)0x8798),
    Mov = unchecked((uint)0x8799),
}
