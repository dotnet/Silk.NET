// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VertexShaderOpEXT")]
[Transformed]
public enum VertexShaderOpEXT : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_INDEX_EXT")]
    IndexEXT = unchecked((uint)0x8782),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_NEGATE_EXT")]
    NegateEXT = unchecked((uint)0x8783),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_DOT3_EXT")]
    Dot3EXT = unchecked((uint)0x8784),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_DOT4_EXT")]
    Dot4EXT = unchecked((uint)0x8785),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MUL_EXT")]
    MulEXT = unchecked((uint)0x8786),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_ADD_EXT")]
    AddEXT = unchecked((uint)0x8787),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MADD_EXT")]
    MaddEXT = unchecked((uint)0x8788),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_FRAC_EXT")]
    FracEXT = unchecked((uint)0x8789),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MAX_EXT")]
    MaxEXT = unchecked((uint)0x878A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MIN_EXT")]
    MinEXT = unchecked((uint)0x878B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_SET_GE_EXT")]
    SetGeEXT = unchecked((uint)0x878C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_SET_LT_EXT")]
    SetLtEXT = unchecked((uint)0x878D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_CLAMP_EXT")]
    ClampEXT = unchecked((uint)0x878E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_FLOOR_EXT")]
    FloorEXT = unchecked((uint)0x878F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_ROUND_EXT")]
    RoundEXT = unchecked((uint)0x8790),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_EXP_BASE_2_EXT")]
    ExpBase2EXT = unchecked((uint)0x8791),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_LOG_BASE_2_EXT")]
    LogBase2EXT = unchecked((uint)0x8792),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_POWER_EXT")]
    PowerEXT = unchecked((uint)0x8793),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_RECIP_EXT")]
    RecipEXT = unchecked((uint)0x8794),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_RECIP_SQRT_EXT")]
    RecipSqrtEXT = unchecked((uint)0x8795),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_SUB_EXT")]
    SubEXT = unchecked((uint)0x8796),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_CROSS_PRODUCT_EXT")]
    CrossProductEXT = unchecked((uint)0x8797),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MULTIPLY_MATRIX_EXT")]
    MultiplyMatrixEXT = unchecked((uint)0x8798),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MOV_EXT")]
    MovEXT = unchecked((uint)0x8799),
}
