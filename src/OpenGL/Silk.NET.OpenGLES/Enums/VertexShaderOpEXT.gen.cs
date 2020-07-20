// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "VertexShaderOpEXT")]
    public enum VertexShaderOpEXT
    {
        [NativeName("Name", "GL_OP_INDEX_EXT")]
        OpIndexExt = 0x8782,
        [NativeName("Name", "GL_OP_NEGATE_EXT")]
        OpNegateExt = 0x8783,
        [NativeName("Name", "GL_OP_DOT3_EXT")]
        OpDot3Ext = 0x8784,
        [NativeName("Name", "GL_OP_DOT4_EXT")]
        OpDot4Ext = 0x8785,
        [NativeName("Name", "GL_OP_MUL_EXT")]
        OpMulExt = 0x8786,
        [NativeName("Name", "GL_OP_ADD_EXT")]
        OpAddExt = 0x8787,
        [NativeName("Name", "GL_OP_MADD_EXT")]
        OpMaddExt = 0x8788,
        [NativeName("Name", "GL_OP_FRAC_EXT")]
        OpFracExt = 0x8789,
        [NativeName("Name", "GL_OP_MAX_EXT")]
        OpMaxExt = 0x878A,
        [NativeName("Name", "GL_OP_MIN_EXT")]
        OpMinExt = 0x878B,
        [NativeName("Name", "GL_OP_SET_GE_EXT")]
        OpSetGEExt = 0x878C,
        [NativeName("Name", "GL_OP_SET_LT_EXT")]
        OpSetLTExt = 0x878D,
        [NativeName("Name", "GL_OP_CLAMP_EXT")]
        OpClampExt = 0x878E,
        [NativeName("Name", "GL_OP_FLOOR_EXT")]
        OpFloorExt = 0x878F,
        [NativeName("Name", "GL_OP_ROUND_EXT")]
        OpRoundExt = 0x8790,
        [NativeName("Name", "GL_OP_EXP_BASE_2_EXT")]
        OpExpBase2Ext = 0x8791,
        [NativeName("Name", "GL_OP_LOG_BASE_2_EXT")]
        OpLogBase2Ext = 0x8792,
        [NativeName("Name", "GL_OP_POWER_EXT")]
        OpPowerExt = 0x8793,
        [NativeName("Name", "GL_OP_RECIP_EXT")]
        OpRecipExt = 0x8794,
        [NativeName("Name", "GL_OP_RECIP_SQRT_EXT")]
        OpRecipSqrtExt = 0x8795,
        [NativeName("Name", "GL_OP_SUB_EXT")]
        OpSubExt = 0x8796,
        [NativeName("Name", "GL_OP_CROSS_PRODUCT_EXT")]
        OpCrossProductExt = 0x8797,
        [NativeName("Name", "GL_OP_MULTIPLY_MATRIX_EXT")]
        OpMultiplyMatrixExt = 0x8798,
        [NativeName("Name", "GL_OP_MOV_EXT")]
        OpMovExt = 0x8799,
    }
}
