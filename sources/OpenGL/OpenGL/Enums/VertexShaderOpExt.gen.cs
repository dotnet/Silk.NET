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
public enum VertexShaderOpExt : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_INDEX_EXT")]
    Indexext = unchecked((uint)0x8782),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_NEGATE_EXT")]
    Negateext = unchecked((uint)0x8783),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_DOT3_EXT")]
    Dot3Ext = unchecked((uint)0x8784),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_DOT4_EXT")]
    Dot4Ext = unchecked((uint)0x8785),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MUL_EXT")]
    Mulext = unchecked((uint)0x8786),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_ADD_EXT")]
    Addext = unchecked((uint)0x8787),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MADD_EXT")]
    Maddext = unchecked((uint)0x8788),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_FRAC_EXT")]
    Fracext = unchecked((uint)0x8789),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MAX_EXT")]
    Maxext = unchecked((uint)0x878A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MIN_EXT")]
    Minext = unchecked((uint)0x878B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_SET_GE_EXT")]
    SetGeext = unchecked((uint)0x878C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_SET_LT_EXT")]
    SetLtext = unchecked((uint)0x878D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_CLAMP_EXT")]
    Clampext = unchecked((uint)0x878E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_FLOOR_EXT")]
    Floorext = unchecked((uint)0x878F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_ROUND_EXT")]
    Roundext = unchecked((uint)0x8790),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_EXP_BASE_2_EXT")]
    ExpBase2Ext = unchecked((uint)0x8791),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_LOG_BASE_2_EXT")]
    LogBase2Ext = unchecked((uint)0x8792),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_POWER_EXT")]
    Powerext = unchecked((uint)0x8793),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_RECIP_EXT")]
    Recipext = unchecked((uint)0x8794),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_RECIP_SQRT_EXT")]
    RecipSqrtext = unchecked((uint)0x8795),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_SUB_EXT")]
    Subext = unchecked((uint)0x8796),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_CROSS_PRODUCT_EXT")]
    CrossProductext = unchecked((uint)0x8797),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MULTIPLY_MATRIX_EXT")]
    MultiplyMatrixext = unchecked((uint)0x8798),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OP_MOV_EXT")]
    Movext = unchecked((uint)0x8799),
}
