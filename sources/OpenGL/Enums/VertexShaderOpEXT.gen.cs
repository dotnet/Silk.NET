// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum VertexShaderOpEXT : uint
{
    Index = 0x8782,
    Negate = 0x8783,
    Dot3 = 0x8784,
    Dot4 = 0x8785,
    Mul = 0x8786,
    Add = 0x8787,
    Madd = 0x8788,
    Frac = 0x8789,
    Max = 0x878A,
    Min = 0x878B,
    SetGe = 0x878C,
    SetLt = 0x878D,
    Clamp = 0x878E,
    Floor = 0x878F,
    Round = 0x8790,
    ExpBase2 = 0x8791,
    LogBase2 = 0x8792,
    Power = 0x8793,
    Recip = 0x8794,
    RecipSqrt = 0x8795,
    Sub = 0x8796,
    CrossProduct = 0x8797,
    MultiplyMatrix = 0x8798,
    Mov = 0x8799
}
