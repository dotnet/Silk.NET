// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VertexShaderOpEXT")]
public enum VertexShaderOpEXT : uint
{
    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_INDEX_EXT")]
    Index = unchecked((uint)0x8782),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_NEGATE_EXT")]
    Negate = unchecked((uint)0x8783),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_DOT3_EXT")]
    Dot3 = unchecked((uint)0x8784),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_DOT4_EXT")]
    Dot4 = unchecked((uint)0x8785),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_MUL_EXT")]
    Mul = unchecked((uint)0x8786),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_ADD_EXT")]
    Add = unchecked((uint)0x8787),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_MADD_EXT")]
    Madd = unchecked((uint)0x8788),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_FRAC_EXT")]
    Frac = unchecked((uint)0x8789),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_MAX_EXT")]
    Max = unchecked((uint)0x878A),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_MIN_EXT")]
    Min = unchecked((uint)0x878B),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_SET_GE_EXT")]
    SetGe = unchecked((uint)0x878C),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_SET_LT_EXT")]
    SetLt = unchecked((uint)0x878D),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_CLAMP_EXT")]
    Clamp = unchecked((uint)0x878E),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_FLOOR_EXT")]
    Floor = unchecked((uint)0x878F),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_ROUND_EXT")]
    Round = unchecked((uint)0x8790),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_EXP_BASE_2_EXT")]
    ExpBase2 = unchecked((uint)0x8791),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_LOG_BASE_2_EXT")]
    LogBase2 = unchecked((uint)0x8792),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_POWER_EXT")]
    Power = unchecked((uint)0x8793),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_RECIP_EXT")]
    Recip = unchecked((uint)0x8794),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_RECIP_SQRT_EXT")]
    RecipSqrt = unchecked((uint)0x8795),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_SUB_EXT")]
    Sub = unchecked((uint)0x8796),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_CROSS_PRODUCT_EXT")]
    CrossProduct = unchecked((uint)0x8797),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_MULTIPLY_MATRIX_EXT")]
    MultiplyMatrix = unchecked((uint)0x8798),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_OP_MOV_EXT")]
    Mov = unchecked((uint)0x8799),
}
