// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [NativeName("Name", "GLenum")]
    public enum ATI
    {
        [NativeName("Name", "GL_MAX_DRAW_BUFFERS_ATI")]
        MaxDrawBuffersAti = 0x8824,
        [NativeName("Name", "GL_DRAW_BUFFER0_ATI")]
        DrawBuffer0Ati = 0x8825,
        [NativeName("Name", "GL_DRAW_BUFFER1_ATI")]
        DrawBuffer1Ati = 0x8826,
        [NativeName("Name", "GL_DRAW_BUFFER2_ATI")]
        DrawBuffer2Ati = 0x8827,
        [NativeName("Name", "GL_DRAW_BUFFER3_ATI")]
        DrawBuffer3Ati = 0x8828,
        [NativeName("Name", "GL_DRAW_BUFFER4_ATI")]
        DrawBuffer4Ati = 0x8829,
        [NativeName("Name", "GL_DRAW_BUFFER5_ATI")]
        DrawBuffer5Ati = 0x882A,
        [NativeName("Name", "GL_DRAW_BUFFER6_ATI")]
        DrawBuffer6Ati = 0x882B,
        [NativeName("Name", "GL_DRAW_BUFFER7_ATI")]
        DrawBuffer7Ati = 0x882C,
        [NativeName("Name", "GL_DRAW_BUFFER8_ATI")]
        DrawBuffer8Ati = 0x882D,
        [NativeName("Name", "GL_DRAW_BUFFER9_ATI")]
        DrawBuffer9Ati = 0x882E,
        [NativeName("Name", "GL_DRAW_BUFFER10_ATI")]
        DrawBuffer10Ati = 0x882F,
        [NativeName("Name", "GL_DRAW_BUFFER11_ATI")]
        DrawBuffer11Ati = 0x8830,
        [NativeName("Name", "GL_DRAW_BUFFER12_ATI")]
        DrawBuffer12Ati = 0x8831,
        [NativeName("Name", "GL_DRAW_BUFFER13_ATI")]
        DrawBuffer13Ati = 0x8832,
        [NativeName("Name", "GL_DRAW_BUFFER14_ATI")]
        DrawBuffer14Ati = 0x8833,
        [NativeName("Name", "GL_DRAW_BUFFER15_ATI")]
        DrawBuffer15Ati = 0x8834,
        [NativeName("Name", "GL_ELEMENT_ARRAY_ATI")]
        ElementArrayAti = 0x8768,
        [NativeName("Name", "GL_ELEMENT_ARRAY_TYPE_ATI")]
        ElementArrayTypeAti = 0x8769,
        [NativeName("Name", "GL_ELEMENT_ARRAY_POINTER_ATI")]
        ElementArrayPointerAti = 0x876A,
        [NativeName("Name", "GL_BUMP_ROT_MATRIX_ATI")]
        BumpRotMatrixAti = 0x8775,
        [NativeName("Name", "GL_BUMP_ROT_MATRIX_SIZE_ATI")]
        BumpRotMatrixSizeAti = 0x8776,
        [NativeName("Name", "GL_BUMP_NUM_TEX_UNITS_ATI")]
        BumpNumTexUnitsAti = 0x8777,
        [NativeName("Name", "GL_BUMP_TEX_UNITS_ATI")]
        BumpTexUnitsAti = 0x8778,
        [NativeName("Name", "GL_DUDV_ATI")]
        DudvAti = 0x8779,
        [NativeName("Name", "GL_DU8DV8_ATI")]
        DU8DV8Ati = 0x877A,
        [NativeName("Name", "GL_BUMP_ENVMAP_ATI")]
        BumpEnvmapAti = 0x877B,
        [NativeName("Name", "GL_BUMP_TARGET_ATI")]
        BumpTargetAti = 0x877C,
        [NativeName("Name", "GL_FRAGMENT_SHADER_ATI")]
        FragmentShaderAti = 0x8920,
        [NativeName("Name", "GL_REG_0_ATI")]
        Reg0Ati = 0x8921,
        [NativeName("Name", "GL_REG_1_ATI")]
        Reg1Ati = 0x8922,
        [NativeName("Name", "GL_REG_2_ATI")]
        Reg2Ati = 0x8923,
        [NativeName("Name", "GL_REG_3_ATI")]
        Reg3Ati = 0x8924,
        [NativeName("Name", "GL_REG_4_ATI")]
        Reg4Ati = 0x8925,
        [NativeName("Name", "GL_REG_5_ATI")]
        Reg5Ati = 0x8926,
        [NativeName("Name", "GL_REG_6_ATI")]
        Reg6Ati = 0x8927,
        [NativeName("Name", "GL_REG_7_ATI")]
        Reg7Ati = 0x8928,
        [NativeName("Name", "GL_REG_8_ATI")]
        Reg8Ati = 0x8929,
        [NativeName("Name", "GL_REG_9_ATI")]
        Reg9Ati = 0x892A,
        [NativeName("Name", "GL_REG_10_ATI")]
        Reg10Ati = 0x892B,
        [NativeName("Name", "GL_REG_11_ATI")]
        Reg11Ati = 0x892C,
        [NativeName("Name", "GL_REG_12_ATI")]
        Reg12Ati = 0x892D,
        [NativeName("Name", "GL_REG_13_ATI")]
        Reg13Ati = 0x892E,
        [NativeName("Name", "GL_REG_14_ATI")]
        Reg14Ati = 0x892F,
        [NativeName("Name", "GL_REG_15_ATI")]
        Reg15Ati = 0x8930,
        [NativeName("Name", "GL_REG_16_ATI")]
        Reg16Ati = 0x8931,
        [NativeName("Name", "GL_REG_17_ATI")]
        Reg17Ati = 0x8932,
        [NativeName("Name", "GL_REG_18_ATI")]
        Reg18Ati = 0x8933,
        [NativeName("Name", "GL_REG_19_ATI")]
        Reg19Ati = 0x8934,
        [NativeName("Name", "GL_REG_20_ATI")]
        Reg20Ati = 0x8935,
        [NativeName("Name", "GL_REG_21_ATI")]
        Reg21Ati = 0x8936,
        [NativeName("Name", "GL_REG_22_ATI")]
        Reg22Ati = 0x8937,
        [NativeName("Name", "GL_REG_23_ATI")]
        Reg23Ati = 0x8938,
        [NativeName("Name", "GL_REG_24_ATI")]
        Reg24Ati = 0x8939,
        [NativeName("Name", "GL_REG_25_ATI")]
        Reg25Ati = 0x893A,
        [NativeName("Name", "GL_REG_26_ATI")]
        Reg26Ati = 0x893B,
        [NativeName("Name", "GL_REG_27_ATI")]
        Reg27Ati = 0x893C,
        [NativeName("Name", "GL_REG_28_ATI")]
        Reg28Ati = 0x893D,
        [NativeName("Name", "GL_REG_29_ATI")]
        Reg29Ati = 0x893E,
        [NativeName("Name", "GL_REG_30_ATI")]
        Reg30Ati = 0x893F,
        [NativeName("Name", "GL_REG_31_ATI")]
        Reg31Ati = 0x8940,
        [NativeName("Name", "GL_CON_0_ATI")]
        Con0Ati = 0x8941,
        [NativeName("Name", "GL_CON_1_ATI")]
        Con1Ati = 0x8942,
        [NativeName("Name", "GL_CON_2_ATI")]
        Con2Ati = 0x8943,
        [NativeName("Name", "GL_CON_3_ATI")]
        Con3Ati = 0x8944,
        [NativeName("Name", "GL_CON_4_ATI")]
        Con4Ati = 0x8945,
        [NativeName("Name", "GL_CON_5_ATI")]
        Con5Ati = 0x8946,
        [NativeName("Name", "GL_CON_6_ATI")]
        Con6Ati = 0x8947,
        [NativeName("Name", "GL_CON_7_ATI")]
        Con7Ati = 0x8948,
        [NativeName("Name", "GL_CON_8_ATI")]
        Con8Ati = 0x8949,
        [NativeName("Name", "GL_CON_9_ATI")]
        Con9Ati = 0x894A,
        [NativeName("Name", "GL_CON_10_ATI")]
        Con10Ati = 0x894B,
        [NativeName("Name", "GL_CON_11_ATI")]
        Con11Ati = 0x894C,
        [NativeName("Name", "GL_CON_12_ATI")]
        Con12Ati = 0x894D,
        [NativeName("Name", "GL_CON_13_ATI")]
        Con13Ati = 0x894E,
        [NativeName("Name", "GL_CON_14_ATI")]
        Con14Ati = 0x894F,
        [NativeName("Name", "GL_CON_15_ATI")]
        Con15Ati = 0x8950,
        [NativeName("Name", "GL_CON_16_ATI")]
        Con16Ati = 0x8951,
        [NativeName("Name", "GL_CON_17_ATI")]
        Con17Ati = 0x8952,
        [NativeName("Name", "GL_CON_18_ATI")]
        Con18Ati = 0x8953,
        [NativeName("Name", "GL_CON_19_ATI")]
        Con19Ati = 0x8954,
        [NativeName("Name", "GL_CON_20_ATI")]
        Con20Ati = 0x8955,
        [NativeName("Name", "GL_CON_21_ATI")]
        Con21Ati = 0x8956,
        [NativeName("Name", "GL_CON_22_ATI")]
        Con22Ati = 0x8957,
        [NativeName("Name", "GL_CON_23_ATI")]
        Con23Ati = 0x8958,
        [NativeName("Name", "GL_CON_24_ATI")]
        Con24Ati = 0x8959,
        [NativeName("Name", "GL_CON_25_ATI")]
        Con25Ati = 0x895A,
        [NativeName("Name", "GL_CON_26_ATI")]
        Con26Ati = 0x895B,
        [NativeName("Name", "GL_CON_27_ATI")]
        Con27Ati = 0x895C,
        [NativeName("Name", "GL_CON_28_ATI")]
        Con28Ati = 0x895D,
        [NativeName("Name", "GL_CON_29_ATI")]
        Con29Ati = 0x895E,
        [NativeName("Name", "GL_CON_30_ATI")]
        Con30Ati = 0x895F,
        [NativeName("Name", "GL_CON_31_ATI")]
        Con31Ati = 0x8960,
        [NativeName("Name", "GL_MOV_ATI")]
        MovAti = 0x8961,
        [NativeName("Name", "GL_ADD_ATI")]
        AddAti = 0x8963,
        [NativeName("Name", "GL_MUL_ATI")]
        MulAti = 0x8964,
        [NativeName("Name", "GL_SUB_ATI")]
        SubAti = 0x8965,
        [NativeName("Name", "GL_DOT3_ATI")]
        Dot3Ati = 0x8966,
        [NativeName("Name", "GL_DOT4_ATI")]
        Dot4Ati = 0x8967,
        [NativeName("Name", "GL_MAD_ATI")]
        MadAti = 0x8968,
        [NativeName("Name", "GL_LERP_ATI")]
        LerpAti = 0x8969,
        [NativeName("Name", "GL_CND_ATI")]
        CndAti = 0x896A,
        [NativeName("Name", "GL_CND0_ATI")]
        Cnd0Ati = 0x896B,
        [NativeName("Name", "GL_DOT2_ADD_ATI")]
        Dot2AddAti = 0x896C,
        [NativeName("Name", "GL_SECONDARY_INTERPOLATOR_ATI")]
        SecondaryInterpolatorAti = 0x896D,
        [NativeName("Name", "GL_NUM_FRAGMENT_REGISTERS_ATI")]
        NumFragmentRegistersAti = 0x896E,
        [NativeName("Name", "GL_NUM_FRAGMENT_CONSTANTS_ATI")]
        NumFragmentConstantsAti = 0x896F,
        [NativeName("Name", "GL_NUM_PASSES_ATI")]
        NumPassesAti = 0x8970,
        [NativeName("Name", "GL_NUM_INSTRUCTIONS_PER_PASS_ATI")]
        NumInstructionsPerPassAti = 0x8971,
        [NativeName("Name", "GL_NUM_INSTRUCTIONS_TOTAL_ATI")]
        NumInstructionsTotalAti = 0x8972,
        [NativeName("Name", "GL_NUM_INPUT_INTERPOLATOR_COMPONENTS_ATI")]
        NumInputInterpolatorComponentsAti = 0x8973,
        [NativeName("Name", "GL_NUM_LOOPBACK_COMPONENTS_ATI")]
        NumLoopbackComponentsAti = 0x8974,
        [NativeName("Name", "GL_COLOR_ALPHA_PAIRING_ATI")]
        ColorAlphaPairingAti = 0x8975,
        [NativeName("Name", "GL_SWIZZLE_STR_ATI")]
        SwizzleStrAti = 0x8976,
        [NativeName("Name", "GL_SWIZZLE_STQ_ATI")]
        SwizzleStqAti = 0x8977,
        [NativeName("Name", "GL_SWIZZLE_STR_DR_ATI")]
        SwizzleStrDRAti = 0x8978,
        [NativeName("Name", "GL_SWIZZLE_STQ_DQ_ATI")]
        SwizzleStqDQAti = 0x8979,
        [NativeName("Name", "GL_SWIZZLE_STRQ_ATI")]
        SwizzleStrqAti = 0x897A,
        [NativeName("Name", "GL_SWIZZLE_STRQ_DQ_ATI")]
        SwizzleStrqDQAti = 0x897B,
        [NativeName("Name", "GL_RED_BIT_ATI")]
        RedBitAti = 0x1,
        [NativeName("Name", "GL_GREEN_BIT_ATI")]
        GreenBitAti = 0x2,
        [NativeName("Name", "GL_BLUE_BIT_ATI")]
        BlueBitAti = 0x4,
        [NativeName("Name", "GL_2X_BIT_ATI")]
        C2XBitAti = 0x1,
        [NativeName("Name", "GL_4X_BIT_ATI")]
        C4XBitAti = 0x2,
        [NativeName("Name", "GL_8X_BIT_ATI")]
        C8XBitAti = 0x4,
        [NativeName("Name", "GL_HALF_BIT_ATI")]
        HalfBitAti = 0x8,
        [NativeName("Name", "GL_QUARTER_BIT_ATI")]
        QuarterBitAti = 0x10,
        [NativeName("Name", "GL_EIGHTH_BIT_ATI")]
        EighthBitAti = 0x20,
        [NativeName("Name", "GL_SATURATE_BIT_ATI")]
        SaturateBitAti = 0x40,
        [NativeName("Name", "GL_COMP_BIT_ATI")]
        CompBitAti = 0x2,
        [NativeName("Name", "GL_NEGATE_BIT_ATI")]
        NegateBitAti = 0x4,
        [NativeName("Name", "GL_BIAS_BIT_ATI")]
        BiasBitAti = 0x8,
        [NativeName("Name", "GL_VBO_FREE_MEMORY_ATI")]
        VboFreeMemoryAti = 0x87FB,
        [NativeName("Name", "GL_TEXTURE_FREE_MEMORY_ATI")]
        TextureFreeMemoryAti = 0x87FC,
        [NativeName("Name", "GL_RENDERBUFFER_FREE_MEMORY_ATI")]
        RenderbufferFreeMemoryAti = 0x87FD,
        [NativeName("Name", "GL_RGBA_FLOAT_MODE_ATI")]
        RgbaFloatModeAti = 0x8820,
        [NativeName("Name", "GL_COLOR_CLEAR_UNCLAMPED_VALUE_ATI")]
        ColorClearUnclampedValueAti = 0x8835,
        [NativeName("Name", "GL_PN_TRIANGLES_ATI")]
        PNTrianglesAti = 0x87F0,
        [NativeName("Name", "GL_MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI")]
        MaxPNTrianglesTesselationLevelAti = 0x87F1,
        [NativeName("Name", "GL_PN_TRIANGLES_POINT_MODE_ATI")]
        PNTrianglesPointModeAti = 0x87F2,
        [NativeName("Name", "GL_PN_TRIANGLES_NORMAL_MODE_ATI")]
        PNTrianglesNormalModeAti = 0x87F3,
        [NativeName("Name", "GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI")]
        PNTrianglesTesselationLevelAti = 0x87F4,
        [NativeName("Name", "GL_PN_TRIANGLES_POINT_MODE_LINEAR_ATI")]
        PNTrianglesPointModeLinearAti = 0x87F5,
        [NativeName("Name", "GL_PN_TRIANGLES_POINT_MODE_CUBIC_ATI")]
        PNTrianglesPointModeCubicAti = 0x87F6,
        [NativeName("Name", "GL_PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI")]
        PNTrianglesNormalModeLinearAti = 0x87F7,
        [NativeName("Name", "GL_PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI")]
        PNTrianglesNormalModeQuadraticAti = 0x87F8,
        [NativeName("Name", "GL_STENCIL_BACK_FUNC_ATI")]
        StencilBackFuncAti = 0x8800,
        [NativeName("Name", "GL_STENCIL_BACK_FAIL_ATI")]
        StencilBackFailAti = 0x8801,
        [NativeName("Name", "GL_STENCIL_BACK_PASS_DEPTH_FAIL_ATI")]
        StencilBackPassDepthFailAti = 0x8802,
        [NativeName("Name", "GL_STENCIL_BACK_PASS_DEPTH_PASS_ATI")]
        StencilBackPassDepthPassAti = 0x8803,
        [NativeName("Name", "GL_TEXT_FRAGMENT_SHADER_ATI")]
        TextFragmentShaderAti = 0x8200,
        [NativeName("Name", "GL_MODULATE_ADD_ATI")]
        ModulateAddAti = 0x8744,
        [NativeName("Name", "GL_MODULATE_SIGNED_ADD_ATI")]
        ModulateSignedAddAti = 0x8745,
        [NativeName("Name", "GL_MODULATE_SUBTRACT_ATI")]
        ModulateSubtractAti = 0x8746,
        [NativeName("Name", "GL_RGBA_FLOAT32_ATI")]
        RgbaFloat32Ati = 0x8814,
        [NativeName("Name", "GL_RGB_FLOAT32_ATI")]
        RgbFloat32Ati = 0x8815,
        [NativeName("Name", "GL_ALPHA_FLOAT32_ATI")]
        AlphaFloat32Ati = 0x8816,
        [NativeName("Name", "GL_INTENSITY_FLOAT32_ATI")]
        IntensityFloat32Ati = 0x8817,
        [NativeName("Name", "GL_LUMINANCE_FLOAT32_ATI")]
        LuminanceFloat32Ati = 0x8818,
        [NativeName("Name", "GL_LUMINANCE_ALPHA_FLOAT32_ATI")]
        LuminanceAlphaFloat32Ati = 0x8819,
        [NativeName("Name", "GL_RGBA_FLOAT16_ATI")]
        RgbaFloat16Ati = 0x881A,
        [NativeName("Name", "GL_RGB_FLOAT16_ATI")]
        RgbFloat16Ati = 0x881B,
        [NativeName("Name", "GL_ALPHA_FLOAT16_ATI")]
        AlphaFloat16Ati = 0x881C,
        [NativeName("Name", "GL_INTENSITY_FLOAT16_ATI")]
        IntensityFloat16Ati = 0x881D,
        [NativeName("Name", "GL_LUMINANCE_FLOAT16_ATI")]
        LuminanceFloat16Ati = 0x881E,
        [NativeName("Name", "GL_LUMINANCE_ALPHA_FLOAT16_ATI")]
        LuminanceAlphaFloat16Ati = 0x881F,
        [NativeName("Name", "GL_MIRROR_CLAMP_ATI")]
        MirrorClampAti = 0x8742,
        [NativeName("Name", "GL_MIRROR_CLAMP_TO_EDGE_ATI")]
        MirrorClampToEdgeAti = 0x8743,
        [NativeName("Name", "GL_STATIC_ATI")]
        StaticAti = 0x8760,
        [NativeName("Name", "GL_DYNAMIC_ATI")]
        DynamicAti = 0x8761,
        [NativeName("Name", "GL_PRESERVE_ATI")]
        PreserveAti = 0x8762,
        [NativeName("Name", "GL_DISCARD_ATI")]
        DiscardAti = 0x8763,
        [NativeName("Name", "GL_OBJECT_BUFFER_SIZE_ATI")]
        ObjectBufferSizeAti = 0x8764,
        [NativeName("Name", "GL_OBJECT_BUFFER_USAGE_ATI")]
        ObjectBufferUsageAti = 0x8765,
        [NativeName("Name", "GL_ARRAY_OBJECT_BUFFER_ATI")]
        ArrayObjectBufferAti = 0x8766,
        [NativeName("Name", "GL_ARRAY_OBJECT_OFFSET_ATI")]
        ArrayObjectOffsetAti = 0x8767,
        [NativeName("Name", "GL_MAX_VERTEX_STREAMS_ATI")]
        MaxVertexStreamsAti = 0x876B,
        [NativeName("Name", "GL_VERTEX_STREAM0_ATI")]
        VertexStream0Ati = 0x876C,
        [NativeName("Name", "GL_VERTEX_STREAM1_ATI")]
        VertexStream1Ati = 0x876D,
        [NativeName("Name", "GL_VERTEX_STREAM2_ATI")]
        VertexStream2Ati = 0x876E,
        [NativeName("Name", "GL_VERTEX_STREAM3_ATI")]
        VertexStream3Ati = 0x876F,
        [NativeName("Name", "GL_VERTEX_STREAM4_ATI")]
        VertexStream4Ati = 0x8770,
        [NativeName("Name", "GL_VERTEX_STREAM5_ATI")]
        VertexStream5Ati = 0x8771,
        [NativeName("Name", "GL_VERTEX_STREAM6_ATI")]
        VertexStream6Ati = 0x8772,
        [NativeName("Name", "GL_VERTEX_STREAM7_ATI")]
        VertexStream7Ati = 0x8773,
        [NativeName("Name", "GL_VERTEX_SOURCE_ATI")]
        VertexSourceAti = 0x8774,
    }
}
