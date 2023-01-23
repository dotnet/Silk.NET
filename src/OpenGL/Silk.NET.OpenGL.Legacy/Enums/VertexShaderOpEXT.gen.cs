// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "VertexShaderOpEXT")]
    public enum VertexShaderOpEXT : int
    {
        [Obsolete("Deprecated in favour of \"IndexExt\"")]
        [NativeName("Name", "GL_OP_INDEX_EXT")]
        OpIndexExt = 0x8782,
        [Obsolete("Deprecated in favour of \"NegateExt\"")]
        [NativeName("Name", "GL_OP_NEGATE_EXT")]
        OpNegateExt = 0x8783,
        [Obsolete("Deprecated in favour of \"Dot3Ext\"")]
        [NativeName("Name", "GL_OP_DOT3_EXT")]
        OpDot3Ext = 0x8784,
        [Obsolete("Deprecated in favour of \"Dot4Ext\"")]
        [NativeName("Name", "GL_OP_DOT4_EXT")]
        OpDot4Ext = 0x8785,
        [Obsolete("Deprecated in favour of \"MulExt\"")]
        [NativeName("Name", "GL_OP_MUL_EXT")]
        OpMulExt = 0x8786,
        [Obsolete("Deprecated in favour of \"AddExt\"")]
        [NativeName("Name", "GL_OP_ADD_EXT")]
        OpAddExt = 0x8787,
        [Obsolete("Deprecated in favour of \"MaddExt\"")]
        [NativeName("Name", "GL_OP_MADD_EXT")]
        OpMaddExt = 0x8788,
        [Obsolete("Deprecated in favour of \"FracExt\"")]
        [NativeName("Name", "GL_OP_FRAC_EXT")]
        OpFracExt = 0x8789,
        [Obsolete("Deprecated in favour of \"MaxExt\"")]
        [NativeName("Name", "GL_OP_MAX_EXT")]
        OpMaxExt = 0x878A,
        [Obsolete("Deprecated in favour of \"MinExt\"")]
        [NativeName("Name", "GL_OP_MIN_EXT")]
        OpMinExt = 0x878B,
        [Obsolete("Deprecated in favour of \"SetGEExt\"")]
        [NativeName("Name", "GL_OP_SET_GE_EXT")]
        OpSetGEExt = 0x878C,
        [Obsolete("Deprecated in favour of \"SetLTExt\"")]
        [NativeName("Name", "GL_OP_SET_LT_EXT")]
        OpSetLTExt = 0x878D,
        [Obsolete("Deprecated in favour of \"ClampExt\"")]
        [NativeName("Name", "GL_OP_CLAMP_EXT")]
        OpClampExt = 0x878E,
        [Obsolete("Deprecated in favour of \"FloorExt\"")]
        [NativeName("Name", "GL_OP_FLOOR_EXT")]
        OpFloorExt = 0x878F,
        [Obsolete("Deprecated in favour of \"RoundExt\"")]
        [NativeName("Name", "GL_OP_ROUND_EXT")]
        OpRoundExt = 0x8790,
        [Obsolete("Deprecated in favour of \"ExpBase2Ext\"")]
        [NativeName("Name", "GL_OP_EXP_BASE_2_EXT")]
        OpExpBase2Ext = 0x8791,
        [Obsolete("Deprecated in favour of \"LogBase2Ext\"")]
        [NativeName("Name", "GL_OP_LOG_BASE_2_EXT")]
        OpLogBase2Ext = 0x8792,
        [Obsolete("Deprecated in favour of \"PowerExt\"")]
        [NativeName("Name", "GL_OP_POWER_EXT")]
        OpPowerExt = 0x8793,
        [Obsolete("Deprecated in favour of \"RecipExt\"")]
        [NativeName("Name", "GL_OP_RECIP_EXT")]
        OpRecipExt = 0x8794,
        [Obsolete("Deprecated in favour of \"RecipSqrtExt\"")]
        [NativeName("Name", "GL_OP_RECIP_SQRT_EXT")]
        OpRecipSqrtExt = 0x8795,
        [Obsolete("Deprecated in favour of \"SubExt\"")]
        [NativeName("Name", "GL_OP_SUB_EXT")]
        OpSubExt = 0x8796,
        [Obsolete("Deprecated in favour of \"CrossProductExt\"")]
        [NativeName("Name", "GL_OP_CROSS_PRODUCT_EXT")]
        OpCrossProductExt = 0x8797,
        [Obsolete("Deprecated in favour of \"MultiplyMatrixExt\"")]
        [NativeName("Name", "GL_OP_MULTIPLY_MATRIX_EXT")]
        OpMultiplyMatrixExt = 0x8798,
        [Obsolete("Deprecated in favour of \"MovExt\"")]
        [NativeName("Name", "GL_OP_MOV_EXT")]
        OpMovExt = 0x8799,
        [NativeName("Name", "GL_OP_INDEX_EXT")]
        IndexExt = 0x8782,
        [NativeName("Name", "GL_OP_NEGATE_EXT")]
        NegateExt = 0x8783,
        [NativeName("Name", "GL_OP_DOT3_EXT")]
        Dot3Ext = 0x8784,
        [NativeName("Name", "GL_OP_DOT4_EXT")]
        Dot4Ext = 0x8785,
        [NativeName("Name", "GL_OP_MUL_EXT")]
        MulExt = 0x8786,
        [NativeName("Name", "GL_OP_ADD_EXT")]
        AddExt = 0x8787,
        [NativeName("Name", "GL_OP_MADD_EXT")]
        MaddExt = 0x8788,
        [NativeName("Name", "GL_OP_FRAC_EXT")]
        FracExt = 0x8789,
        [NativeName("Name", "GL_OP_MAX_EXT")]
        MaxExt = 0x878A,
        [NativeName("Name", "GL_OP_MIN_EXT")]
        MinExt = 0x878B,
        [NativeName("Name", "GL_OP_SET_GE_EXT")]
        SetGEExt = 0x878C,
        [NativeName("Name", "GL_OP_SET_LT_EXT")]
        SetLTExt = 0x878D,
        [NativeName("Name", "GL_OP_CLAMP_EXT")]
        ClampExt = 0x878E,
        [NativeName("Name", "GL_OP_FLOOR_EXT")]
        FloorExt = 0x878F,
        [NativeName("Name", "GL_OP_ROUND_EXT")]
        RoundExt = 0x8790,
        [NativeName("Name", "GL_OP_EXP_BASE_2_EXT")]
        ExpBase2Ext = 0x8791,
        [NativeName("Name", "GL_OP_LOG_BASE_2_EXT")]
        LogBase2Ext = 0x8792,
        [NativeName("Name", "GL_OP_POWER_EXT")]
        PowerExt = 0x8793,
        [NativeName("Name", "GL_OP_RECIP_EXT")]
        RecipExt = 0x8794,
        [NativeName("Name", "GL_OP_RECIP_SQRT_EXT")]
        RecipSqrtExt = 0x8795,
        [NativeName("Name", "GL_OP_SUB_EXT")]
        SubExt = 0x8796,
        [NativeName("Name", "GL_OP_CROSS_PRODUCT_EXT")]
        CrossProductExt = 0x8797,
        [NativeName("Name", "GL_OP_MULTIPLY_MATRIX_EXT")]
        MultiplyMatrixExt = 0x8798,
        [NativeName("Name", "GL_OP_MOV_EXT")]
        MovExt = 0x8799,
    }
}
