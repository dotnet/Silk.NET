// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("VertexShaderOpEXT")]
public enum VertexShaderOpEXT : uint
{
    [NativeName("GL_OP_INDEX_EXT")]
    Index = 34690,

    [NativeName("GL_OP_NEGATE_EXT")]
    Negate = 34691,

    [NativeName("GL_OP_DOT3_EXT")]
    Dot3 = 34692,

    [NativeName("GL_OP_DOT4_EXT")]
    Dot4 = 34693,

    [NativeName("GL_OP_MUL_EXT")]
    Mul = 34694,

    [NativeName("GL_OP_ADD_EXT")]
    Add = 34695,

    [NativeName("GL_OP_MADD_EXT")]
    Madd = 34696,

    [NativeName("GL_OP_FRAC_EXT")]
    Frac = 34697,

    [NativeName("GL_OP_MAX_EXT")]
    Max = 34698,

    [NativeName("GL_OP_MIN_EXT")]
    Min = 34699,

    [NativeName("GL_OP_SET_GE_EXT")]
    SetGe = 34700,

    [NativeName("GL_OP_SET_LT_EXT")]
    SetLt = 34701,

    [NativeName("GL_OP_CLAMP_EXT")]
    Clamp = 34702,

    [NativeName("GL_OP_FLOOR_EXT")]
    Floor = 34703,

    [NativeName("GL_OP_ROUND_EXT")]
    Round = 34704,

    [NativeName("GL_OP_EXP_BASE_2_EXT")]
    ExpBase2 = 34705,

    [NativeName("GL_OP_LOG_BASE_2_EXT")]
    LogBase2 = 34706,

    [NativeName("GL_OP_POWER_EXT")]
    Power = 34707,

    [NativeName("GL_OP_RECIP_EXT")]
    Recip = 34708,

    [NativeName("GL_OP_RECIP_SQRT_EXT")]
    RecipSqrt = 34709,

    [NativeName("GL_OP_SUB_EXT")]
    Sub = 34710,

    [NativeName("GL_OP_CROSS_PRODUCT_EXT")]
    CrossProduct = 34711,

    [NativeName("GL_OP_MULTIPLY_MATRIX_EXT")]
    MultiplyMatrix = 34712,

    [NativeName("GL_OP_MOV_EXT")]
    Mov = 34713,
}
