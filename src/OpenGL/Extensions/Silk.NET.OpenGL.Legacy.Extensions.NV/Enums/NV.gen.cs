// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [NativeName("Name", "GLenum")]
    public enum NV : int
    {
        [NativeName("Name", "GL_ALPHA_TO_COVERAGE_DITHER_DEFAULT_NV")]
        AlphaToCoverageDitherDefaultNV = 0x934D,
        [NativeName("Name", "GL_ALPHA_TO_COVERAGE_DITHER_ENABLE_NV")]
        AlphaToCoverageDitherEnableNV = 0x934E,
        [NativeName("Name", "GL_ALPHA_TO_COVERAGE_DITHER_DISABLE_NV")]
        AlphaToCoverageDitherDisableNV = 0x934F,
        [NativeName("Name", "GL_ALPHA_TO_COVERAGE_DITHER_MODE_NV")]
        AlphaToCoverageDitherModeNV = 0x92BF,
        [NativeName("Name", "GL_BLEND_OVERLAP_NV")]
        BlendOverlapNV = 0x9281,
        [NativeName("Name", "GL_BLEND_PREMULTIPLIED_SRC_NV")]
        BlendPremultipliedSrcNV = 0x9280,
        [NativeName("Name", "GL_BLUE_NV")]
        BlueNV = 0x1905,
        [NativeName("Name", "GL_COLORBURN_NV")]
        ColorburnNV = 0x929A,
        [NativeName("Name", "GL_COLORDODGE_NV")]
        ColordodgeNV = 0x9299,
        [NativeName("Name", "GL_CONJOINT_NV")]
        ConjointNV = 0x9284,
        [NativeName("Name", "GL_CONTRAST_NV")]
        ContrastNV = 0x92A1,
        [NativeName("Name", "GL_DARKEN_NV")]
        DarkenNV = 0x9297,
        [NativeName("Name", "GL_DIFFERENCE_NV")]
        DifferenceNV = 0x929E,
        [NativeName("Name", "GL_DISJOINT_NV")]
        DisjointNV = 0x9283,
        [NativeName("Name", "GL_DST_ATOP_NV")]
        DstAtopNV = 0x928F,
        [NativeName("Name", "GL_DST_IN_NV")]
        DstInNV = 0x928B,
        [NativeName("Name", "GL_DST_NV")]
        DstNV = 0x9287,
        [NativeName("Name", "GL_DST_OUT_NV")]
        DstOutNV = 0x928D,
        [NativeName("Name", "GL_DST_OVER_NV")]
        DstOverNV = 0x9289,
        [NativeName("Name", "GL_EXCLUSION_NV")]
        ExclusionNV = 0x92A0,
        [NativeName("Name", "GL_GREEN_NV")]
        GreenNV = 0x1904,
        [NativeName("Name", "GL_HARDLIGHT_NV")]
        HardlightNV = 0x929B,
        [NativeName("Name", "GL_HARDMIX_NV")]
        HardmixNV = 0x92A9,
        [NativeName("Name", "GL_HSL_COLOR_NV")]
        HslColorNV = 0x92AF,
        [NativeName("Name", "GL_HSL_HUE_NV")]
        HslHueNV = 0x92AD,
        [NativeName("Name", "GL_HSL_LUMINOSITY_NV")]
        HslLuminosityNV = 0x92B0,
        [NativeName("Name", "GL_HSL_SATURATION_NV")]
        HslSaturationNV = 0x92AE,
        [NativeName("Name", "GL_INVERT")]
        Invert = 0x150A,
        [NativeName("Name", "GL_INVERT_OVG_NV")]
        InvertOvgNV = 0x92B4,
        [NativeName("Name", "GL_INVERT_RGB_NV")]
        InvertRgbNV = 0x92A3,
        [NativeName("Name", "GL_LIGHTEN_NV")]
        LightenNV = 0x9298,
        [NativeName("Name", "GL_LINEARBURN_NV")]
        LinearburnNV = 0x92A5,
        [NativeName("Name", "GL_LINEARDODGE_NV")]
        LineardodgeNV = 0x92A4,
        [NativeName("Name", "GL_LINEARLIGHT_NV")]
        LinearlightNV = 0x92A7,
        [NativeName("Name", "GL_MINUS_CLAMPED_NV")]
        MinusClampedNV = 0x92B3,
        [NativeName("Name", "GL_MINUS_NV")]
        MinusNV = 0x929F,
        [NativeName("Name", "GL_MULTIPLY_NV")]
        MultiplyNV = 0x9294,
        [NativeName("Name", "GL_OVERLAY_NV")]
        OverlayNV = 0x9296,
        [NativeName("Name", "GL_PINLIGHT_NV")]
        PinlightNV = 0x92A8,
        [NativeName("Name", "GL_PLUS_CLAMPED_ALPHA_NV")]
        PlusClampedAlphaNV = 0x92B2,
        [NativeName("Name", "GL_PLUS_CLAMPED_NV")]
        PlusClampedNV = 0x92B1,
        [NativeName("Name", "GL_PLUS_DARKER_NV")]
        PlusDarkerNV = 0x9292,
        [NativeName("Name", "GL_PLUS_NV")]
        PlusNV = 0x9291,
        [NativeName("Name", "GL_RED_NV")]
        RedNV = 0x1903,
        [NativeName("Name", "GL_SCREEN_NV")]
        ScreenNV = 0x9295,
        [NativeName("Name", "GL_SOFTLIGHT_NV")]
        SoftlightNV = 0x929C,
        [NativeName("Name", "GL_SRC_ATOP_NV")]
        SrcAtopNV = 0x928E,
        [NativeName("Name", "GL_SRC_IN_NV")]
        SrcInNV = 0x928A,
        [NativeName("Name", "GL_SRC_NV")]
        SrcNV = 0x9286,
        [NativeName("Name", "GL_SRC_OUT_NV")]
        SrcOutNV = 0x928C,
        [NativeName("Name", "GL_SRC_OVER_NV")]
        SrcOverNV = 0x9288,
        [NativeName("Name", "GL_UNCORRELATED_NV")]
        UncorrelatedNV = 0x9282,
        [NativeName("Name", "GL_VIVIDLIGHT_NV")]
        VividlightNV = 0x92A6,
        [NativeName("Name", "GL_XOR_NV")]
        XorNV = 0x1506,
        [NativeName("Name", "GL_ZERO")]
        Zero = 0x0,
        [NativeName("Name", "GL_BLEND_ADVANCED_COHERENT_NV")]
        BlendAdvancedCoherentNV = 0x9285,
        [NativeName("Name", "GL_FACTOR_MIN_AMD")]
        FactorMinAmd = 0x901C,
        [NativeName("Name", "GL_FACTOR_MAX_AMD")]
        FactorMaxAmd = 0x901D,
        [NativeName("Name", "GL_VIEWPORT_POSITION_W_SCALE_NV")]
        ViewportPositionWScaleNV = 0x937C,
        [NativeName("Name", "GL_VIEWPORT_POSITION_W_SCALE_X_COEFF_NV")]
        ViewportPositionWScaleXCoeffNV = 0x937D,
        [NativeName("Name", "GL_VIEWPORT_POSITION_W_SCALE_Y_COEFF_NV")]
        ViewportPositionWScaleYCoeffNV = 0x937E,
        [NativeName("Name", "GL_TERMINATE_SEQUENCE_COMMAND_NV")]
        TerminateSequenceCommandNV = 0x0,
        [NativeName("Name", "GL_NOP_COMMAND_NV")]
        NopCommandNV = 0x1,
        [NativeName("Name", "GL_DRAW_ELEMENTS_COMMAND_NV")]
        DrawElementsCommandNV = 0x2,
        [NativeName("Name", "GL_DRAW_ARRAYS_COMMAND_NV")]
        DrawArraysCommandNV = 0x3,
        [NativeName("Name", "GL_DRAW_ELEMENTS_STRIP_COMMAND_NV")]
        DrawElementsStripCommandNV = 0x4,
        [NativeName("Name", "GL_DRAW_ARRAYS_STRIP_COMMAND_NV")]
        DrawArraysStripCommandNV = 0x5,
        [NativeName("Name", "GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV")]
        DrawElementsInstancedCommandNV = 0x6,
        [NativeName("Name", "GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV")]
        DrawArraysInstancedCommandNV = 0x7,
        [NativeName("Name", "GL_ELEMENT_ADDRESS_COMMAND_NV")]
        ElementAddressCommandNV = 0x8,
        [NativeName("Name", "GL_ATTRIBUTE_ADDRESS_COMMAND_NV")]
        AttributeAddressCommandNV = 0x9,
        [NativeName("Name", "GL_UNIFORM_ADDRESS_COMMAND_NV")]
        UniformAddressCommandNV = 0xA,
        [NativeName("Name", "GL_BLEND_COLOR_COMMAND_NV")]
        BlendColorCommandNV = 0xB,
        [NativeName("Name", "GL_STENCIL_REF_COMMAND_NV")]
        StencilRefCommandNV = 0xC,
        [NativeName("Name", "GL_LINE_WIDTH_COMMAND_NV")]
        LineWidthCommandNV = 0xD,
        [NativeName("Name", "GL_POLYGON_OFFSET_COMMAND_NV")]
        PolygonOffsetCommandNV = 0xE,
        [NativeName("Name", "GL_ALPHA_REF_COMMAND_NV")]
        AlphaRefCommandNV = 0xF,
        [NativeName("Name", "GL_VIEWPORT_COMMAND_NV")]
        ViewportCommandNV = 0x10,
        [NativeName("Name", "GL_SCISSOR_COMMAND_NV")]
        ScissorCommandNV = 0x11,
        [NativeName("Name", "GL_FRONT_FACE_COMMAND_NV")]
        FrontFaceCommandNV = 0x12,
        [NativeName("Name", "GL_COMPUTE_PROGRAM_NV")]
        ComputeProgramNV = 0x90FB,
        [NativeName("Name", "GL_COMPUTE_PROGRAM_PARAMETER_BUFFER_NV")]
        ComputeProgramParameterBufferNV = 0x90FC,
        [NativeName("Name", "GL_QUERY_WAIT_NV")]
        QueryWaitNV = 0x8E13,
        [NativeName("Name", "GL_QUERY_NO_WAIT_NV")]
        QueryNoWaitNV = 0x8E14,
        [NativeName("Name", "GL_QUERY_BY_REGION_WAIT_NV")]
        QueryByRegionWaitNV = 0x8E15,
        [NativeName("Name", "GL_QUERY_BY_REGION_NO_WAIT_NV")]
        QueryByRegionNoWaitNV = 0x8E16,
        [NativeName("Name", "GL_CONSERVATIVE_RASTERIZATION_NV")]
        ConservativeRasterizationNV = 0x9346,
        [NativeName("Name", "GL_SUBPIXEL_PRECISION_BIAS_X_BITS_NV")]
        SubpixelPrecisionBiasXBitsNV = 0x9347,
        [NativeName("Name", "GL_SUBPIXEL_PRECISION_BIAS_Y_BITS_NV")]
        SubpixelPrecisionBiasYBitsNV = 0x9348,
        [NativeName("Name", "GL_MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV")]
        MaxSubpixelPrecisionBiasBitsNV = 0x9349,
        [NativeName("Name", "GL_CONSERVATIVE_RASTER_DILATE_NV")]
        ConservativeRasterDilateNV = 0x9379,
        [NativeName("Name", "GL_CONSERVATIVE_RASTER_DILATE_RANGE_NV")]
        ConservativeRasterDilateRangeNV = 0x937A,
        [NativeName("Name", "GL_CONSERVATIVE_RASTER_DILATE_GRANULARITY_NV")]
        ConservativeRasterDilateGranularityNV = 0x937B,
        [NativeName("Name", "GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_NV")]
        ConservativeRasterModePreSnapNV = 0x9550,
        [NativeName("Name", "GL_CONSERVATIVE_RASTER_MODE_NV")]
        ConservativeRasterModeNV = 0x954D,
        [NativeName("Name", "GL_CONSERVATIVE_RASTER_MODE_POST_SNAP_NV")]
        ConservativeRasterModePostSnapNV = 0x954E,
        [NativeName("Name", "GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_TRIANGLES_NV")]
        ConservativeRasterModePreSnapTrianglesNV = 0x954F,
        [NativeName("Name", "GL_DEPTH_STENCIL_TO_RGBA_NV")]
        DepthStencilToRgbaNV = 0x886E,
        [NativeName("Name", "GL_DEPTH_STENCIL_TO_BGRA_NV")]
        DepthStencilToBgraNV = 0x886F,
        [NativeName("Name", "GL_MAX_DEEP_3D_TEXTURE_WIDTH_HEIGHT_NV")]
        MaxDeep3DTextureWidthHeightNV = 0x90D0,
        [NativeName("Name", "GL_MAX_DEEP_3D_TEXTURE_DEPTH_NV")]
        MaxDeep3DTextureDepthNV = 0x90D1,
        [NativeName("Name", "GL_DEPTH_COMPONENT32F_NV")]
        DepthComponent32fNV = 0x8DAB,
        [NativeName("Name", "GL_DEPTH32F_STENCIL8_NV")]
        Depth32fStencil8NV = 0x8DAC,
        [NativeName("Name", "GL_FLOAT_32_UNSIGNED_INT_24_8_REV_NV")]
        Float32UnsignedInt248RevNV = 0x8DAD,
        [NativeName("Name", "GL_DEPTH_BUFFER_FLOAT_MODE_NV")]
        DepthBufferFloatModeNV = 0x8DAF,
        [NativeName("Name", "GL_DEPTH_CLAMP_NV")]
        DepthClampNV = 0x864F,
        [NativeName("Name", "GL_EVAL_2D_NV")]
        Eval2DNV = 0x86C0,
        [NativeName("Name", "GL_EVAL_TRIANGULAR_2D_NV")]
        EvalTriangular2DNV = 0x86C1,
        [NativeName("Name", "GL_MAP_TESSELLATION_NV")]
        MapTessellationNV = 0x86C2,
        [NativeName("Name", "GL_MAP_ATTRIB_U_ORDER_NV")]
        MapAttribUOrderNV = 0x86C3,
        [NativeName("Name", "GL_MAP_ATTRIB_V_ORDER_NV")]
        MapAttribVOrderNV = 0x86C4,
        [NativeName("Name", "GL_EVAL_FRACTIONAL_TESSELLATION_NV")]
        EvalFractionalTessellationNV = 0x86C5,
        [NativeName("Name", "GL_EVAL_VERTEX_ATTRIB0_NV")]
        EvalVertexAttrib0NV = 0x86C6,
        [NativeName("Name", "GL_EVAL_VERTEX_ATTRIB1_NV")]
        EvalVertexAttrib1NV = 0x86C7,
        [NativeName("Name", "GL_EVAL_VERTEX_ATTRIB2_NV")]
        EvalVertexAttrib2NV = 0x86C8,
        [NativeName("Name", "GL_EVAL_VERTEX_ATTRIB3_NV")]
        EvalVertexAttrib3NV = 0x86C9,
        [NativeName("Name", "GL_EVAL_VERTEX_ATTRIB4_NV")]
        EvalVertexAttrib4NV = 0x86CA,
        [NativeName("Name", "GL_EVAL_VERTEX_ATTRIB5_NV")]
        EvalVertexAttrib5NV = 0x86CB,
        [NativeName("Name", "GL_EVAL_VERTEX_ATTRIB6_NV")]
        EvalVertexAttrib6NV = 0x86CC,
        [NativeName("Name", "GL_EVAL_VERTEX_ATTRIB7_NV")]
        EvalVertexAttrib7NV = 0x86CD,
        [NativeName("Name", "GL_EVAL_VERTEX_ATTRIB8_NV")]
        EvalVertexAttrib8NV = 0x86CE,
        [NativeName("Name", "GL_EVAL_VERTEX_ATTRIB9_NV")]
        EvalVertexAttrib9NV = 0x86CF,
        [NativeName("Name", "GL_EVAL_VERTEX_ATTRIB10_NV")]
        EvalVertexAttrib10NV = 0x86D0,
        [NativeName("Name", "GL_EVAL_VERTEX_ATTRIB11_NV")]
        EvalVertexAttrib11NV = 0x86D1,
        [NativeName("Name", "GL_EVAL_VERTEX_ATTRIB12_NV")]
        EvalVertexAttrib12NV = 0x86D2,
        [NativeName("Name", "GL_EVAL_VERTEX_ATTRIB13_NV")]
        EvalVertexAttrib13NV = 0x86D3,
        [NativeName("Name", "GL_EVAL_VERTEX_ATTRIB14_NV")]
        EvalVertexAttrib14NV = 0x86D4,
        [NativeName("Name", "GL_EVAL_VERTEX_ATTRIB15_NV")]
        EvalVertexAttrib15NV = 0x86D5,
        [NativeName("Name", "GL_MAX_MAP_TESSELLATION_NV")]
        MaxMapTessellationNV = 0x86D6,
        [NativeName("Name", "GL_MAX_RATIONAL_EVAL_ORDER_NV")]
        MaxRationalEvalOrderNV = 0x86D7,
        [NativeName("Name", "GL_SAMPLE_POSITION_NV")]
        SamplePositionNV = 0x8E50,
        [NativeName("Name", "GL_SAMPLE_MASK_NV")]
        SampleMaskNV = 0x8E51,
        [NativeName("Name", "GL_SAMPLE_MASK_VALUE_NV")]
        SampleMaskValueNV = 0x8E52,
        [NativeName("Name", "GL_TEXTURE_BINDING_RENDERBUFFER_NV")]
        TextureBindingRenderbufferNV = 0x8E53,
        [NativeName("Name", "GL_TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV")]
        TextureRenderbufferDataStoreBindingNV = 0x8E54,
        [NativeName("Name", "GL_TEXTURE_RENDERBUFFER_NV")]
        TextureRenderbufferNV = 0x8E55,
        [NativeName("Name", "GL_SAMPLER_RENDERBUFFER_NV")]
        SamplerRenderbufferNV = 0x8E56,
        [NativeName("Name", "GL_INT_SAMPLER_RENDERBUFFER_NV")]
        IntSamplerRenderbufferNV = 0x8E57,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV")]
        UnsignedIntSamplerRenderbufferNV = 0x8E58,
        [NativeName("Name", "GL_MAX_SAMPLE_MASK_WORDS_NV")]
        MaxSampleMaskWordsNV = 0x8E59,
        [NativeName("Name", "GL_ALL_COMPLETED_NV")]
        AllCompletedNV = 0x84F2,
        [NativeName("Name", "GL_FENCE_STATUS_NV")]
        FenceStatusNV = 0x84F3,
        [NativeName("Name", "GL_FENCE_CONDITION_NV")]
        FenceConditionNV = 0x84F4,
        [NativeName("Name", "GL_FILL_RECTANGLE_NV")]
        FillRectangleNV = 0x933C,
        [NativeName("Name", "GL_FLOAT_R_NV")]
        FloatRNV = 0x8880,
        [NativeName("Name", "GL_FLOAT_RG_NV")]
        FloatRGNV = 0x8881,
        [NativeName("Name", "GL_FLOAT_RGB_NV")]
        FloatRgbNV = 0x8882,
        [NativeName("Name", "GL_FLOAT_RGBA_NV")]
        FloatRgbaNV = 0x8883,
        [NativeName("Name", "GL_FLOAT_R16_NV")]
        FloatR16NV = 0x8884,
        [NativeName("Name", "GL_FLOAT_R32_NV")]
        FloatR32NV = 0x8885,
        [NativeName("Name", "GL_FLOAT_RG16_NV")]
        FloatRG16NV = 0x8886,
        [NativeName("Name", "GL_FLOAT_RG32_NV")]
        FloatRG32NV = 0x8887,
        [NativeName("Name", "GL_FLOAT_RGB16_NV")]
        FloatRgb16NV = 0x8888,
        [NativeName("Name", "GL_FLOAT_RGB32_NV")]
        FloatRgb32NV = 0x8889,
        [NativeName("Name", "GL_FLOAT_RGBA16_NV")]
        FloatRgba16NV = 0x888A,
        [NativeName("Name", "GL_FLOAT_RGBA32_NV")]
        FloatRgba32NV = 0x888B,
        [NativeName("Name", "GL_TEXTURE_FLOAT_COMPONENTS_NV")]
        TextureFloatComponentsNV = 0x888C,
        [NativeName("Name", "GL_FLOAT_CLEAR_COLOR_VALUE_NV")]
        FloatClearColorValueNV = 0x888D,
        [NativeName("Name", "GL_FLOAT_RGBA_MODE_NV")]
        FloatRgbaModeNV = 0x888E,
        [NativeName("Name", "GL_FOG_DISTANCE_MODE_NV")]
        FogDistanceModeNV = 0x855A,
        [NativeName("Name", "GL_EYE_RADIAL_NV")]
        EyeRadialNV = 0x855B,
        [NativeName("Name", "GL_EYE_PLANE_ABSOLUTE_NV")]
        EyePlaneAbsoluteNV = 0x855C,
        [System.Obsolete("Deprecated in version ")]
        [NativeName("Name", "GL_EYE_PLANE")]
        EyePlane = 0x2502,
        [NativeName("Name", "GL_FRAGMENT_COVERAGE_TO_COLOR_NV")]
        FragmentCoverageToColorNV = 0x92DD,
        [NativeName("Name", "GL_FRAGMENT_COVERAGE_COLOR_NV")]
        FragmentCoverageColorNV = 0x92DE,
        [NativeName("Name", "GL_MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV")]
        MaxFragmentProgramLocalParametersNV = 0x8868,
        [NativeName("Name", "GL_FRAGMENT_PROGRAM_NV")]
        FragmentProgramNV = 0x8870,
        [NativeName("Name", "GL_MAX_TEXTURE_COORDS_NV")]
        MaxTextureCoordsNV = 0x8871,
        [NativeName("Name", "GL_MAX_TEXTURE_IMAGE_UNITS_NV")]
        MaxTextureImageUnitsNV = 0x8872,
        [NativeName("Name", "GL_FRAGMENT_PROGRAM_BINDING_NV")]
        FragmentProgramBindingNV = 0x8873,
        [NativeName("Name", "GL_PROGRAM_ERROR_STRING_NV")]
        ProgramErrorStringNV = 0x8874,
        [NativeName("Name", "GL_MAX_PROGRAM_EXEC_INSTRUCTIONS_NV")]
        MaxProgramExecInstructionsNV = 0x88F4,
        [NativeName("Name", "GL_MAX_PROGRAM_CALL_DEPTH_NV")]
        MaxProgramCallDepthNV = 0x88F5,
        [NativeName("Name", "GL_MAX_PROGRAM_IF_DEPTH_NV")]
        MaxProgramIFDepthNV = 0x88F6,
        [NativeName("Name", "GL_MAX_PROGRAM_LOOP_DEPTH_NV")]
        MaxProgramLoopDepthNV = 0x88F7,
        [NativeName("Name", "GL_MAX_PROGRAM_LOOP_COUNT_NV")]
        MaxProgramLoopCountNV = 0x88F8,
        [NativeName("Name", "GL_RASTER_MULTISAMPLE_EXT")]
        RasterMultisampleExt = 0x9327,
        [NativeName("Name", "GL_COVERAGE_MODULATION_TABLE_NV")]
        CoverageModulationTableNV = 0x9331,
        [NativeName("Name", "GL_RASTER_SAMPLES_EXT")]
        RasterSamplesExt = 0x9328,
        [NativeName("Name", "GL_MAX_RASTER_SAMPLES_EXT")]
        MaxRasterSamplesExt = 0x9329,
        [NativeName("Name", "GL_RASTER_FIXED_SAMPLE_LOCATIONS_EXT")]
        RasterFixedSampleLocationsExt = 0x932A,
        [NativeName("Name", "GL_MULTISAMPLE_RASTERIZATION_ALLOWED_EXT")]
        MultisampleRasterizationAllowedExt = 0x932B,
        [NativeName("Name", "GL_EFFECTIVE_RASTER_SAMPLES_EXT")]
        EffectiveRasterSamplesExt = 0x932C,
        [NativeName("Name", "GL_COLOR_SAMPLES_NV")]
        ColorSamplesNV = 0x8E20,
        [NativeName("Name", "GL_DEPTH_SAMPLES_NV")]
        DepthSamplesNV = 0x932D,
        [NativeName("Name", "GL_STENCIL_SAMPLES_NV")]
        StencilSamplesNV = 0x932E,
        [NativeName("Name", "GL_MIXED_DEPTH_SAMPLES_SUPPORTED_NV")]
        MixedDepthSamplesSupportedNV = 0x932F,
        [NativeName("Name", "GL_MIXED_STENCIL_SAMPLES_SUPPORTED_NV")]
        MixedStencilSamplesSupportedNV = 0x9330,
        [NativeName("Name", "GL_COVERAGE_MODULATION_NV")]
        CoverageModulationNV = 0x9332,
        [NativeName("Name", "GL_COVERAGE_MODULATION_TABLE_SIZE_NV")]
        CoverageModulationTableSizeNV = 0x9333,
        [NativeName("Name", "GL_RENDERBUFFER_COVERAGE_SAMPLES_NV")]
        RenderbufferCoverageSamplesNV = 0x8CAB,
        [NativeName("Name", "GL_RENDERBUFFER_COLOR_SAMPLES_NV")]
        RenderbufferColorSamplesNV = 0x8E10,
        [NativeName("Name", "GL_MAX_MULTISAMPLE_COVERAGE_MODES_NV")]
        MaxMultisampleCoverageModesNV = 0x8E11,
        [NativeName("Name", "GL_MULTISAMPLE_COVERAGE_MODES_NV")]
        MultisampleCoverageModesNV = 0x8E12,
        [NativeName("Name", "GL_LINES_ADJACENCY_EXT")]
        LinesAdjacencyExt = 0xA,
        [NativeName("Name", "GL_LINE_STRIP_ADJACENCY_EXT")]
        LineStripAdjacencyExt = 0xB,
        [NativeName("Name", "GL_TRIANGLES_ADJACENCY_EXT")]
        TrianglesAdjacencyExt = 0xC,
        [NativeName("Name", "GL_TRIANGLE_STRIP_ADJACENCY_EXT")]
        TriangleStripAdjacencyExt = 0xD,
        [NativeName("Name", "GL_GEOMETRY_PROGRAM_NV")]
        GeometryProgramNV = 0x8C26,
        [NativeName("Name", "GL_MAX_PROGRAM_OUTPUT_VERTICES_NV")]
        MaxProgramOutputVerticesNV = 0x8C27,
        [NativeName("Name", "GL_MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV")]
        MaxProgramTotalOutputComponentsNV = 0x8C28,
        [NativeName("Name", "GL_GEOMETRY_VERTICES_OUT_EXT")]
        GeometryVerticesOutExt = 0x8DDA,
        [NativeName("Name", "GL_GEOMETRY_INPUT_TYPE_EXT")]
        GeometryInputTypeExt = 0x8DDB,
        [NativeName("Name", "GL_GEOMETRY_OUTPUT_TYPE_EXT")]
        GeometryOutputTypeExt = 0x8DDC,
        [NativeName("Name", "GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT")]
        MaxGeometryTextureImageUnitsExt = 0x8C29,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT")]
        FramebufferAttachmentLayeredExt = 0x8DA7,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT")]
        FramebufferIncompleteLayerTargetsExt = 0x8DA8,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT")]
        FramebufferIncompleteLayerCountExt = 0x8DA9,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT")]
        FramebufferAttachmentTextureLayerExt = 0x8CD4,
        [NativeName("Name", "GL_PROGRAM_POINT_SIZE_EXT")]
        ProgramPointSizeExt = 0x8642,
        [NativeName("Name", "GL_PER_GPU_STORAGE_BIT_NV")]
        PerGpuStorageBitNV = 0x800,
        [NativeName("Name", "GL_MULTICAST_GPUS_NV")]
        MulticastGpusNV = 0x92BA,
        [NativeName("Name", "GL_RENDER_GPU_MASK_NV")]
        RenderGpuMaskNV = 0x9558,
        [NativeName("Name", "GL_PER_GPU_STORAGE_NV")]
        PerGpuStorageNV = 0x9548,
        [NativeName("Name", "GL_MULTICAST_PROGRAMMABLE_SAMPLE_LOCATION_NV")]
        MulticastProgrammableSampleLocationNV = 0x9549,
        [NativeName("Name", "GL_MIN_PROGRAM_TEXEL_OFFSET_NV")]
        MinProgramTexelOffsetNV = 0x8904,
        [NativeName("Name", "GL_MAX_PROGRAM_TEXEL_OFFSET_NV")]
        MaxProgramTexelOffsetNV = 0x8905,
        [NativeName("Name", "GL_PROGRAM_ATTRIB_COMPONENTS_NV")]
        ProgramAttribComponentsNV = 0x8906,
        [NativeName("Name", "GL_PROGRAM_RESULT_COMPONENTS_NV")]
        ProgramResultComponentsNV = 0x8907,
        [NativeName("Name", "GL_MAX_PROGRAM_ATTRIB_COMPONENTS_NV")]
        MaxProgramAttribComponentsNV = 0x8908,
        [NativeName("Name", "GL_MAX_PROGRAM_RESULT_COMPONENTS_NV")]
        MaxProgramResultComponentsNV = 0x8909,
        [NativeName("Name", "GL_MAX_PROGRAM_GENERIC_ATTRIBS_NV")]
        MaxProgramGenericAttribsNV = 0x8DA5,
        [NativeName("Name", "GL_MAX_PROGRAM_GENERIC_RESULTS_NV")]
        MaxProgramGenericResultsNV = 0x8DA6,
        [NativeName("Name", "GL_MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV")]
        MaxGeometryProgramInvocationsNV = 0x8E5A,
        [NativeName("Name", "GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_NV")]
        MinFragmentInterpolationOffsetNV = 0x8E5B,
        [NativeName("Name", "GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_NV")]
        MaxFragmentInterpolationOffsetNV = 0x8E5C,
        [NativeName("Name", "GL_FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV")]
        FragmentProgramInterpolationOffsetBitsNV = 0x8E5D,
        [NativeName("Name", "GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_NV")]
        MinProgramTextureGatherOffsetNV = 0x8E5E,
        [NativeName("Name", "GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_NV")]
        MaxProgramTextureGatherOffsetNV = 0x8E5F,
        [NativeName("Name", "GL_MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV")]
        MaxProgramSubroutineParametersNV = 0x8F44,
        [NativeName("Name", "GL_MAX_PROGRAM_SUBROUTINE_NUM_NV")]
        MaxProgramSubroutineNumNV = 0x8F45,
        [NativeName("Name", "GL_INT64_NV")]
        Int64NV = 0x140E,
        [NativeName("Name", "GL_UNSIGNED_INT64_NV")]
        UnsignedInt64NV = 0x140F,
        [NativeName("Name", "GL_INT8_NV")]
        Int8NV = 0x8FE0,
        [NativeName("Name", "GL_INT8_VEC2_NV")]
        Int8Vec2NV = 0x8FE1,
        [NativeName("Name", "GL_INT8_VEC3_NV")]
        Int8Vec3NV = 0x8FE2,
        [NativeName("Name", "GL_INT8_VEC4_NV")]
        Int8Vec4NV = 0x8FE3,
        [NativeName("Name", "GL_INT16_NV")]
        Int16NV = 0x8FE4,
        [NativeName("Name", "GL_INT16_VEC2_NV")]
        Int16Vec2NV = 0x8FE5,
        [NativeName("Name", "GL_INT16_VEC3_NV")]
        Int16Vec3NV = 0x8FE6,
        [NativeName("Name", "GL_INT16_VEC4_NV")]
        Int16Vec4NV = 0x8FE7,
        [NativeName("Name", "GL_INT64_VEC2_NV")]
        Int64Vec2NV = 0x8FE9,
        [NativeName("Name", "GL_INT64_VEC3_NV")]
        Int64Vec3NV = 0x8FEA,
        [NativeName("Name", "GL_INT64_VEC4_NV")]
        Int64Vec4NV = 0x8FEB,
        [NativeName("Name", "GL_UNSIGNED_INT8_NV")]
        UnsignedInt8NV = 0x8FEC,
        [NativeName("Name", "GL_UNSIGNED_INT8_VEC2_NV")]
        UnsignedInt8Vec2NV = 0x8FED,
        [NativeName("Name", "GL_UNSIGNED_INT8_VEC3_NV")]
        UnsignedInt8Vec3NV = 0x8FEE,
        [NativeName("Name", "GL_UNSIGNED_INT8_VEC4_NV")]
        UnsignedInt8Vec4NV = 0x8FEF,
        [NativeName("Name", "GL_UNSIGNED_INT16_NV")]
        UnsignedInt16NV = 0x8FF0,
        [NativeName("Name", "GL_UNSIGNED_INT16_VEC2_NV")]
        UnsignedInt16Vec2NV = 0x8FF1,
        [NativeName("Name", "GL_UNSIGNED_INT16_VEC3_NV")]
        UnsignedInt16Vec3NV = 0x8FF2,
        [NativeName("Name", "GL_UNSIGNED_INT16_VEC4_NV")]
        UnsignedInt16Vec4NV = 0x8FF3,
        [NativeName("Name", "GL_UNSIGNED_INT64_VEC2_NV")]
        UnsignedInt64Vec2NV = 0x8FF5,
        [NativeName("Name", "GL_UNSIGNED_INT64_VEC3_NV")]
        UnsignedInt64Vec3NV = 0x8FF6,
        [NativeName("Name", "GL_UNSIGNED_INT64_VEC4_NV")]
        UnsignedInt64Vec4NV = 0x8FF7,
        [NativeName("Name", "GL_FLOAT16_NV")]
        Float16NV = 0x8FF8,
        [NativeName("Name", "GL_FLOAT16_VEC2_NV")]
        Float16Vec2NV = 0x8FF9,
        [NativeName("Name", "GL_FLOAT16_VEC3_NV")]
        Float16Vec3NV = 0x8FFA,
        [NativeName("Name", "GL_FLOAT16_VEC4_NV")]
        Float16Vec4NV = 0x8FFB,
        [NativeName("Name", "GL_PATCHES")]
        Patches = 0xE,
        [NativeName("Name", "GL_HALF_FLOAT_NV")]
        HalfFloatNV = 0x140B,
        [NativeName("Name", "GL_RENDERBUFFER")]
        Renderbuffer = 0x8D41,
        [NativeName("Name", "GL_TEXTURE_2D_MULTISAMPLE")]
        Texture2DMultisample = 0x9100,
        [NativeName("Name", "GL_TEXTURE_2D_MULTISAMPLE_ARRAY")]
        Texture2DMultisampleArray = 0x9102,
        [NativeName("Name", "GL_MULTISAMPLES_NV")]
        MultisamplesNV = 0x9371,
        [NativeName("Name", "GL_SUPERSAMPLE_SCALE_X_NV")]
        SupersampleScaleXNV = 0x9372,
        [NativeName("Name", "GL_SUPERSAMPLE_SCALE_Y_NV")]
        SupersampleScaleYNV = 0x9373,
        [NativeName("Name", "GL_CONFORMANT_NV")]
        ConformantNV = 0x9374,
        [NativeName("Name", "GL_MAX_SHININESS_NV")]
        MaxShininessNV = 0x8504,
        [NativeName("Name", "GL_MAX_SPOT_EXPONENT_NV")]
        MaxSpotExponentNV = 0x8505,
        [NativeName("Name", "GL_ATTACHED_MEMORY_OBJECT_NV")]
        AttachedMemoryObjectNV = 0x95A4,
        [NativeName("Name", "GL_ATTACHED_MEMORY_OFFSET_NV")]
        AttachedMemoryOffsetNV = 0x95A5,
        [NativeName("Name", "GL_MEMORY_ATTACHABLE_ALIGNMENT_NV")]
        MemoryAttachableAlignmentNV = 0x95A6,
        [NativeName("Name", "GL_MEMORY_ATTACHABLE_SIZE_NV")]
        MemoryAttachableSizeNV = 0x95A7,
        [NativeName("Name", "GL_MEMORY_ATTACHABLE_NV")]
        MemoryAttachableNV = 0x95A8,
        [NativeName("Name", "GL_DETACHED_MEMORY_INCARNATION_NV")]
        DetachedMemoryIncarnationNV = 0x95A9,
        [NativeName("Name", "GL_DETACHED_TEXTURES_NV")]
        DetachedTexturesNV = 0x95AA,
        [NativeName("Name", "GL_DETACHED_BUFFERS_NV")]
        DetachedBuffersNV = 0x95AB,
        [NativeName("Name", "GL_MAX_DETACHED_TEXTURES_NV")]
        MaxDetachedTexturesNV = 0x95AC,
        [NativeName("Name", "GL_MAX_DETACHED_BUFFERS_NV")]
        MaxDetachedBuffersNV = 0x95AD,
        [NativeName("Name", "GL_MESH_SHADER_NV")]
        MeshShaderNV = 0x9559,
        [NativeName("Name", "GL_TASK_SHADER_NV")]
        TaskShaderNV = 0x955A,
        [NativeName("Name", "GL_MAX_MESH_UNIFORM_BLOCKS_NV")]
        MaxMeshUniformBlocksNV = 0x8E60,
        [NativeName("Name", "GL_MAX_MESH_TEXTURE_IMAGE_UNITS_NV")]
        MaxMeshTextureImageUnitsNV = 0x8E61,
        [NativeName("Name", "GL_MAX_MESH_IMAGE_UNIFORMS_NV")]
        MaxMeshImageUniformsNV = 0x8E62,
        [NativeName("Name", "GL_MAX_MESH_UNIFORM_COMPONENTS_NV")]
        MaxMeshUniformComponentsNV = 0x8E63,
        [NativeName("Name", "GL_MAX_MESH_ATOMIC_COUNTER_BUFFERS_NV")]
        MaxMeshAtomicCounterBuffersNV = 0x8E64,
        [NativeName("Name", "GL_MAX_MESH_ATOMIC_COUNTERS_NV")]
        MaxMeshAtomicCountersNV = 0x8E65,
        [NativeName("Name", "GL_MAX_MESH_SHADER_STORAGE_BLOCKS_NV")]
        MaxMeshShaderStorageBlocksNV = 0x8E66,
        [NativeName("Name", "GL_MAX_COMBINED_MESH_UNIFORM_COMPONENTS_NV")]
        MaxCombinedMeshUniformComponentsNV = 0x8E67,
        [NativeName("Name", "GL_MAX_TASK_UNIFORM_BLOCKS_NV")]
        MaxTaskUniformBlocksNV = 0x8E68,
        [NativeName("Name", "GL_MAX_TASK_TEXTURE_IMAGE_UNITS_NV")]
        MaxTaskTextureImageUnitsNV = 0x8E69,
        [NativeName("Name", "GL_MAX_TASK_IMAGE_UNIFORMS_NV")]
        MaxTaskImageUniformsNV = 0x8E6A,
        [NativeName("Name", "GL_MAX_TASK_UNIFORM_COMPONENTS_NV")]
        MaxTaskUniformComponentsNV = 0x8E6B,
        [NativeName("Name", "GL_MAX_TASK_ATOMIC_COUNTER_BUFFERS_NV")]
        MaxTaskAtomicCounterBuffersNV = 0x8E6C,
        [NativeName("Name", "GL_MAX_TASK_ATOMIC_COUNTERS_NV")]
        MaxTaskAtomicCountersNV = 0x8E6D,
        [NativeName("Name", "GL_MAX_TASK_SHADER_STORAGE_BLOCKS_NV")]
        MaxTaskShaderStorageBlocksNV = 0x8E6E,
        [NativeName("Name", "GL_MAX_COMBINED_TASK_UNIFORM_COMPONENTS_NV")]
        MaxCombinedTaskUniformComponentsNV = 0x8E6F,
        [NativeName("Name", "GL_MAX_MESH_WORK_GROUP_INVOCATIONS_NV")]
        MaxMeshWorkGroupInvocationsNV = 0x95A2,
        [NativeName("Name", "GL_MAX_TASK_WORK_GROUP_INVOCATIONS_NV")]
        MaxTaskWorkGroupInvocationsNV = 0x95A3,
        [NativeName("Name", "GL_MAX_MESH_TOTAL_MEMORY_SIZE_NV")]
        MaxMeshTotalMemorySizeNV = 0x9536,
        [NativeName("Name", "GL_MAX_TASK_TOTAL_MEMORY_SIZE_NV")]
        MaxTaskTotalMemorySizeNV = 0x9537,
        [NativeName("Name", "GL_MAX_MESH_OUTPUT_VERTICES_NV")]
        MaxMeshOutputVerticesNV = 0x9538,
        [NativeName("Name", "GL_MAX_MESH_OUTPUT_PRIMITIVES_NV")]
        MaxMeshOutputPrimitivesNV = 0x9539,
        [NativeName("Name", "GL_MAX_TASK_OUTPUT_COUNT_NV")]
        MaxTaskOutputCountNV = 0x953A,
        [NativeName("Name", "GL_MAX_DRAW_MESH_TASKS_COUNT_NV")]
        MaxDrawMeshTasksCountNV = 0x953D,
        [NativeName("Name", "GL_MAX_MESH_VIEWS_NV")]
        MaxMeshViewsNV = 0x9557,
        [NativeName("Name", "GL_MESH_OUTPUT_PER_VERTEX_GRANULARITY_NV")]
        MeshOutputPerVertexGranularityNV = 0x92DF,
        [NativeName("Name", "GL_MESH_OUTPUT_PER_PRIMITIVE_GRANULARITY_NV")]
        MeshOutputPerPrimitiveGranularityNV = 0x9543,
        [NativeName("Name", "GL_MAX_MESH_WORK_GROUP_SIZE_NV")]
        MaxMeshWorkGroupSizeNV = 0x953B,
        [NativeName("Name", "GL_MAX_TASK_WORK_GROUP_SIZE_NV")]
        MaxTaskWorkGroupSizeNV = 0x953C,
        [NativeName("Name", "GL_MESH_WORK_GROUP_SIZE_NV")]
        MeshWorkGroupSizeNV = 0x953E,
        [NativeName("Name", "GL_TASK_WORK_GROUP_SIZE_NV")]
        TaskWorkGroupSizeNV = 0x953F,
        [NativeName("Name", "GL_MESH_VERTICES_OUT_NV")]
        MeshVerticesOutNV = 0x9579,
        [NativeName("Name", "GL_MESH_PRIMITIVES_OUT_NV")]
        MeshPrimitivesOutNV = 0x957A,
        [NativeName("Name", "GL_MESH_OUTPUT_TYPE_NV")]
        MeshOutputTypeNV = 0x957B,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_MESH_SHADER_NV")]
        UniformBlockReferencedByMeshShaderNV = 0x959C,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_TASK_SHADER_NV")]
        UniformBlockReferencedByTaskShaderNV = 0x959D,
        [NativeName("Name", "GL_REFERENCED_BY_MESH_SHADER_NV")]
        ReferencedByMeshShaderNV = 0x95A0,
        [NativeName("Name", "GL_REFERENCED_BY_TASK_SHADER_NV")]
        ReferencedByTaskShaderNV = 0x95A1,
        [NativeName("Name", "GL_MESH_SHADER_BIT_NV")]
        MeshShaderBitNV = 0x40,
        [NativeName("Name", "GL_TASK_SHADER_BIT_NV")]
        TaskShaderBitNV = 0x80,
        [NativeName("Name", "GL_MESH_SUBROUTINE_NV")]
        MeshSubroutineNV = 0x957C,
        [NativeName("Name", "GL_TASK_SUBROUTINE_NV")]
        TaskSubroutineNV = 0x957D,
        [NativeName("Name", "GL_MESH_SUBROUTINE_UNIFORM_NV")]
        MeshSubroutineUniformNV = 0x957E,
        [NativeName("Name", "GL_TASK_SUBROUTINE_UNIFORM_NV")]
        TaskSubroutineUniformNV = 0x957F,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_MESH_SHADER_NV")]
        AtomicCounterBufferReferencedByMeshShaderNV = 0x959E,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TASK_SHADER_NV")]
        AtomicCounterBufferReferencedByTaskShaderNV = 0x959F,
        [NativeName("Name", "GL_SAMPLES_ARB")]
        SamplesArb = 0x80A9,
        [NativeName("Name", "GL_MULTISAMPLE_FILTER_HINT_NV")]
        MultisampleFilterHintNV = 0x8534,
        [NativeName("Name", "GL_PIXEL_COUNTER_BITS_NV")]
        PixelCounterBitsNV = 0x8864,
        [NativeName("Name", "GL_CURRENT_OCCLUSION_QUERY_ID_NV")]
        CurrentOcclusionQueryIDNV = 0x8865,
        [NativeName("Name", "GL_PIXEL_COUNT_NV")]
        PixelCountNV = 0x8866,
        [NativeName("Name", "GL_PIXEL_COUNT_AVAILABLE_NV")]
        PixelCountAvailableNV = 0x8867,
        [NativeName("Name", "GL_DEPTH_STENCIL_NV")]
        DepthStencilNV = 0x84F9,
        [NativeName("Name", "GL_UNSIGNED_INT_24_8_NV")]
        UnsignedInt248NV = 0x84FA,
        [NativeName("Name", "GL_MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV")]
        MaxProgramParameterBufferBindingsNV = 0x8DA0,
        [NativeName("Name", "GL_MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV")]
        MaxProgramParameterBufferSizeNV = 0x8DA1,
        [NativeName("Name", "GL_VERTEX_PROGRAM_PARAMETER_BUFFER_NV")]
        VertexProgramParameterBufferNV = 0x8DA2,
        [NativeName("Name", "GL_GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV")]
        GeometryProgramParameterBufferNV = 0x8DA3,
        [NativeName("Name", "GL_FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV")]
        FragmentProgramParameterBufferNV = 0x8DA4,
        [NativeName("Name", "GL_PATH_FORMAT_SVG_NV")]
        PathFormatSvgNV = 0x9070,
        [NativeName("Name", "GL_PATH_FORMAT_PS_NV")]
        PathFormatPSNV = 0x9071,
        [NativeName("Name", "GL_STANDARD_FONT_NAME_NV")]
        StandardFontNameNV = 0x9072,
        [NativeName("Name", "GL_SYSTEM_FONT_NAME_NV")]
        SystemFontNameNV = 0x9073,
        [NativeName("Name", "GL_FILE_NAME_NV")]
        FileNameNV = 0x9074,
        [NativeName("Name", "GL_PATH_STROKE_WIDTH_NV")]
        PathStrokeWidthNV = 0x9075,
        [NativeName("Name", "GL_PATH_END_CAPS_NV")]
        PathEndCapsNV = 0x9076,
        [NativeName("Name", "GL_PATH_INITIAL_END_CAP_NV")]
        PathInitialEndCapNV = 0x9077,
        [NativeName("Name", "GL_PATH_TERMINAL_END_CAP_NV")]
        PathTerminalEndCapNV = 0x9078,
        [NativeName("Name", "GL_PATH_JOIN_STYLE_NV")]
        PathJoinStyleNV = 0x9079,
        [NativeName("Name", "GL_PATH_MITER_LIMIT_NV")]
        PathMiterLimitNV = 0x907A,
        [NativeName("Name", "GL_PATH_DASH_CAPS_NV")]
        PathDashCapsNV = 0x907B,
        [NativeName("Name", "GL_PATH_INITIAL_DASH_CAP_NV")]
        PathInitialDashCapNV = 0x907C,
        [NativeName("Name", "GL_PATH_TERMINAL_DASH_CAP_NV")]
        PathTerminalDashCapNV = 0x907D,
        [NativeName("Name", "GL_PATH_DASH_OFFSET_NV")]
        PathDashOffsetNV = 0x907E,
        [NativeName("Name", "GL_PATH_CLIENT_LENGTH_NV")]
        PathClientLengthNV = 0x907F,
        [NativeName("Name", "GL_PATH_FILL_MODE_NV")]
        PathFillModeNV = 0x9080,
        [NativeName("Name", "GL_PATH_FILL_MASK_NV")]
        PathFillMaskNV = 0x9081,
        [NativeName("Name", "GL_PATH_FILL_COVER_MODE_NV")]
        PathFillCoverModeNV = 0x9082,
        [NativeName("Name", "GL_PATH_STROKE_COVER_MODE_NV")]
        PathStrokeCoverModeNV = 0x9083,
        [NativeName("Name", "GL_PATH_STROKE_MASK_NV")]
        PathStrokeMaskNV = 0x9084,
        [NativeName("Name", "GL_COUNT_UP_NV")]
        CountUpNV = 0x9088,
        [NativeName("Name", "GL_COUNT_DOWN_NV")]
        CountDownNV = 0x9089,
        [NativeName("Name", "GL_PATH_OBJECT_BOUNDING_BOX_NV")]
        PathObjectBoundingBoxNV = 0x908A,
        [NativeName("Name", "GL_CONVEX_HULL_NV")]
        ConvexHullNV = 0x908B,
        [NativeName("Name", "GL_BOUNDING_BOX_NV")]
        BoundingBoxNV = 0x908D,
        [NativeName("Name", "GL_TRANSLATE_X_NV")]
        TranslateXNV = 0x908E,
        [NativeName("Name", "GL_TRANSLATE_Y_NV")]
        TranslateYNV = 0x908F,
        [NativeName("Name", "GL_TRANSLATE_2D_NV")]
        Translate2DNV = 0x9090,
        [NativeName("Name", "GL_TRANSLATE_3D_NV")]
        Translate3DNV = 0x9091,
        [NativeName("Name", "GL_AFFINE_2D_NV")]
        Affine2DNV = 0x9092,
        [NativeName("Name", "GL_AFFINE_3D_NV")]
        Affine3DNV = 0x9094,
        [NativeName("Name", "GL_TRANSPOSE_AFFINE_2D_NV")]
        TransposeAffine2DNV = 0x9096,
        [NativeName("Name", "GL_TRANSPOSE_AFFINE_3D_NV")]
        TransposeAffine3DNV = 0x9098,
        [NativeName("Name", "GL_UTF8_NV")]
        Utf8NV = 0x909A,
        [NativeName("Name", "GL_UTF16_NV")]
        Utf16NV = 0x909B,
        [NativeName("Name", "GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV")]
        BoundingBoxOfBoundingBoxesNV = 0x909C,
        [NativeName("Name", "GL_PATH_COMMAND_COUNT_NV")]
        PathCommandCountNV = 0x909D,
        [NativeName("Name", "GL_PATH_COORD_COUNT_NV")]
        PathCoordCountNV = 0x909E,
        [NativeName("Name", "GL_PATH_DASH_ARRAY_COUNT_NV")]
        PathDashArrayCountNV = 0x909F,
        [NativeName("Name", "GL_PATH_COMPUTED_LENGTH_NV")]
        PathComputedLengthNV = 0x90A0,
        [NativeName("Name", "GL_PATH_FILL_BOUNDING_BOX_NV")]
        PathFillBoundingBoxNV = 0x90A1,
        [NativeName("Name", "GL_PATH_STROKE_BOUNDING_BOX_NV")]
        PathStrokeBoundingBoxNV = 0x90A2,
        [NativeName("Name", "GL_SQUARE_NV")]
        SquareNV = 0x90A3,
        [NativeName("Name", "GL_ROUND_NV")]
        RoundNV = 0x90A4,
        [NativeName("Name", "GL_TRIANGULAR_NV")]
        TriangularNV = 0x90A5,
        [NativeName("Name", "GL_BEVEL_NV")]
        BevelNV = 0x90A6,
        [NativeName("Name", "GL_MITER_REVERT_NV")]
        MiterRevertNV = 0x90A7,
        [NativeName("Name", "GL_MITER_TRUNCATE_NV")]
        MiterTruncateNV = 0x90A8,
        [NativeName("Name", "GL_SKIP_MISSING_GLYPH_NV")]
        SkipMissingGlyphNV = 0x90A9,
        [NativeName("Name", "GL_USE_MISSING_GLYPH_NV")]
        UseMissingGlyphNV = 0x90AA,
        [NativeName("Name", "GL_PATH_ERROR_POSITION_NV")]
        PathErrorPositionNV = 0x90AB,
        [NativeName("Name", "GL_ACCUM_ADJACENT_PAIRS_NV")]
        AccumAdjacentPairsNV = 0x90AD,
        [NativeName("Name", "GL_ADJACENT_PAIRS_NV")]
        AdjacentPairsNV = 0x90AE,
        [NativeName("Name", "GL_FIRST_TO_REST_NV")]
        FirstToRestNV = 0x90AF,
        [NativeName("Name", "GL_PATH_GEN_MODE_NV")]
        PathGenModeNV = 0x90B0,
        [NativeName("Name", "GL_PATH_GEN_COEFF_NV")]
        PathGenCoeffNV = 0x90B1,
        [NativeName("Name", "GL_PATH_GEN_COMPONENTS_NV")]
        PathGenComponentsNV = 0x90B3,
        [NativeName("Name", "GL_PATH_STENCIL_FUNC_NV")]
        PathStencilFuncNV = 0x90B7,
        [NativeName("Name", "GL_PATH_STENCIL_REF_NV")]
        PathStencilRefNV = 0x90B8,
        [NativeName("Name", "GL_PATH_STENCIL_VALUE_MASK_NV")]
        PathStencilValueMaskNV = 0x90B9,
        [NativeName("Name", "GL_PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV")]
        PathStencilDepthOffsetFactorNV = 0x90BD,
        [NativeName("Name", "GL_PATH_STENCIL_DEPTH_OFFSET_UNITS_NV")]
        PathStencilDepthOffsetUnitsNV = 0x90BE,
        [NativeName("Name", "GL_PATH_COVER_DEPTH_FUNC_NV")]
        PathCoverDepthFuncNV = 0x90BF,
        [NativeName("Name", "GL_PATH_DASH_OFFSET_RESET_NV")]
        PathDashOffsetResetNV = 0x90B4,
        [NativeName("Name", "GL_MOVE_TO_RESETS_NV")]
        MoveToResetsNV = 0x90B5,
        [NativeName("Name", "GL_MOVE_TO_CONTINUES_NV")]
        MoveToContinuesNV = 0x90B6,
        [NativeName("Name", "GL_CLOSE_PATH_NV")]
        ClosePathNV = 0x0,
        [NativeName("Name", "GL_MOVE_TO_NV")]
        MoveToNV = 0x2,
        [NativeName("Name", "GL_RELATIVE_MOVE_TO_NV")]
        RelativeMoveToNV = 0x3,
        [NativeName("Name", "GL_LINE_TO_NV")]
        LineToNV = 0x4,
        [NativeName("Name", "GL_RELATIVE_LINE_TO_NV")]
        RelativeLineToNV = 0x5,
        [NativeName("Name", "GL_HORIZONTAL_LINE_TO_NV")]
        HorizontalLineToNV = 0x6,
        [NativeName("Name", "GL_RELATIVE_HORIZONTAL_LINE_TO_NV")]
        RelativeHorizontalLineToNV = 0x7,
        [NativeName("Name", "GL_VERTICAL_LINE_TO_NV")]
        VerticalLineToNV = 0x8,
        [NativeName("Name", "GL_RELATIVE_VERTICAL_LINE_TO_NV")]
        RelativeVerticalLineToNV = 0x9,
        [NativeName("Name", "GL_QUADRATIC_CURVE_TO_NV")]
        QuadraticCurveToNV = 0xA,
        [NativeName("Name", "GL_RELATIVE_QUADRATIC_CURVE_TO_NV")]
        RelativeQuadraticCurveToNV = 0xB,
        [NativeName("Name", "GL_CUBIC_CURVE_TO_NV")]
        CubicCurveToNV = 0xC,
        [NativeName("Name", "GL_RELATIVE_CUBIC_CURVE_TO_NV")]
        RelativeCubicCurveToNV = 0xD,
        [NativeName("Name", "GL_SMOOTH_QUADRATIC_CURVE_TO_NV")]
        SmoothQuadraticCurveToNV = 0xE,
        [NativeName("Name", "GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV")]
        RelativeSmoothQuadraticCurveToNV = 0xF,
        [NativeName("Name", "GL_SMOOTH_CUBIC_CURVE_TO_NV")]
        SmoothCubicCurveToNV = 0x10,
        [NativeName("Name", "GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV")]
        RelativeSmoothCubicCurveToNV = 0x11,
        [NativeName("Name", "GL_SMALL_CCW_ARC_TO_NV")]
        SmallCcwArcToNV = 0x12,
        [NativeName("Name", "GL_RELATIVE_SMALL_CCW_ARC_TO_NV")]
        RelativeSmallCcwArcToNV = 0x13,
        [NativeName("Name", "GL_SMALL_CW_ARC_TO_NV")]
        SmallCWArcToNV = 0x14,
        [NativeName("Name", "GL_RELATIVE_SMALL_CW_ARC_TO_NV")]
        RelativeSmallCWArcToNV = 0x15,
        [NativeName("Name", "GL_LARGE_CCW_ARC_TO_NV")]
        LargeCcwArcToNV = 0x16,
        [NativeName("Name", "GL_RELATIVE_LARGE_CCW_ARC_TO_NV")]
        RelativeLargeCcwArcToNV = 0x17,
        [NativeName("Name", "GL_LARGE_CW_ARC_TO_NV")]
        LargeCWArcToNV = 0x18,
        [NativeName("Name", "GL_RELATIVE_LARGE_CW_ARC_TO_NV")]
        RelativeLargeCWArcToNV = 0x19,
        [NativeName("Name", "GL_RESTART_PATH_NV")]
        RestartPathNV = 0xF0,
        [NativeName("Name", "GL_DUP_FIRST_CUBIC_CURVE_TO_NV")]
        DupFirstCubicCurveToNV = 0xF2,
        [NativeName("Name", "GL_DUP_LAST_CUBIC_CURVE_TO_NV")]
        DupLastCubicCurveToNV = 0xF4,
        [NativeName("Name", "GL_RECT_NV")]
        RectNV = 0xF6,
        [NativeName("Name", "GL_CIRCULAR_CCW_ARC_TO_NV")]
        CircularCcwArcToNV = 0xF8,
        [NativeName("Name", "GL_CIRCULAR_CW_ARC_TO_NV")]
        CircularCWArcToNV = 0xFA,
        [NativeName("Name", "GL_CIRCULAR_TANGENT_ARC_TO_NV")]
        CircularTangentArcToNV = 0xFC,
        [NativeName("Name", "GL_ARC_TO_NV")]
        ArcToNV = 0xFE,
        [NativeName("Name", "GL_RELATIVE_ARC_TO_NV")]
        RelativeArcToNV = 0xFF,
        [NativeName("Name", "GL_BOLD_BIT_NV")]
        BoldBitNV = 0x1,
        [NativeName("Name", "GL_ITALIC_BIT_NV")]
        ItalicBitNV = 0x2,
        [NativeName("Name", "GL_GLYPH_WIDTH_BIT_NV")]
        GlyphWidthBitNV = 0x1,
        [NativeName("Name", "GL_GLYPH_HEIGHT_BIT_NV")]
        GlyphHeightBitNV = 0x2,
        [NativeName("Name", "GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV")]
        GlyphHorizontalBearingXBitNV = 0x4,
        [NativeName("Name", "GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV")]
        GlyphHorizontalBearingYBitNV = 0x8,
        [NativeName("Name", "GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV")]
        GlyphHorizontalBearingAdvanceBitNV = 0x10,
        [NativeName("Name", "GL_GLYPH_VERTICAL_BEARING_X_BIT_NV")]
        GlyphVerticalBearingXBitNV = 0x20,
        [NativeName("Name", "GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV")]
        GlyphVerticalBearingYBitNV = 0x40,
        [NativeName("Name", "GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV")]
        GlyphVerticalBearingAdvanceBitNV = 0x80,
        [NativeName("Name", "GL_GLYPH_HAS_KERNING_BIT_NV")]
        GlyphHasKerningBitNV = 0x100,
        [NativeName("Name", "GL_FONT_X_MIN_BOUNDS_BIT_NV")]
        FontXMinBoundsBitNV = 0x10000,
        [NativeName("Name", "GL_FONT_Y_MIN_BOUNDS_BIT_NV")]
        FontYMinBoundsBitNV = 0x20000,
        [NativeName("Name", "GL_FONT_X_MAX_BOUNDS_BIT_NV")]
        FontXMaxBoundsBitNV = 0x40000,
        [NativeName("Name", "GL_FONT_Y_MAX_BOUNDS_BIT_NV")]
        FontYMaxBoundsBitNV = 0x80000,
        [NativeName("Name", "GL_FONT_UNITS_PER_EM_BIT_NV")]
        FontUnitsPerEMBitNV = 0x100000,
        [NativeName("Name", "GL_FONT_ASCENDER_BIT_NV")]
        FontAscenderBitNV = 0x200000,
        [NativeName("Name", "GL_FONT_DESCENDER_BIT_NV")]
        FontDescenderBitNV = 0x400000,
        [NativeName("Name", "GL_FONT_HEIGHT_BIT_NV")]
        FontHeightBitNV = 0x800000,
        [NativeName("Name", "GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV")]
        FontMaxAdvanceWidthBitNV = 0x1000000,
        [NativeName("Name", "GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV")]
        FontMaxAdvanceHeightBitNV = 0x2000000,
        [NativeName("Name", "GL_FONT_UNDERLINE_POSITION_BIT_NV")]
        FontUnderlinePositionBitNV = 0x4000000,
        [NativeName("Name", "GL_FONT_UNDERLINE_THICKNESS_BIT_NV")]
        FontUnderlineThicknessBitNV = 0x8000000,
        [NativeName("Name", "GL_FONT_HAS_KERNING_BIT_NV")]
        FontHasKerningBitNV = 0x10000000,
        [NativeName("Name", "GL_ROUNDED_RECT_NV")]
        RoundedRectNV = 0xE8,
        [NativeName("Name", "GL_RELATIVE_ROUNDED_RECT_NV")]
        RelativeRoundedRectNV = 0xE9,
        [NativeName("Name", "GL_ROUNDED_RECT2_NV")]
        RoundedRect2NV = 0xEA,
        [NativeName("Name", "GL_RELATIVE_ROUNDED_RECT2_NV")]
        RelativeRoundedRect2NV = 0xEB,
        [NativeName("Name", "GL_ROUNDED_RECT4_NV")]
        RoundedRect4NV = 0xEC,
        [NativeName("Name", "GL_RELATIVE_ROUNDED_RECT4_NV")]
        RelativeRoundedRect4NV = 0xED,
        [NativeName("Name", "GL_ROUNDED_RECT8_NV")]
        RoundedRect8NV = 0xEE,
        [NativeName("Name", "GL_RELATIVE_ROUNDED_RECT8_NV")]
        RelativeRoundedRect8NV = 0xEF,
        [NativeName("Name", "GL_RELATIVE_RECT_NV")]
        RelativeRectNV = 0xF7,
        [NativeName("Name", "GL_FONT_GLYPHS_AVAILABLE_NV")]
        FontGlyphsAvailableNV = 0x9368,
        [NativeName("Name", "GL_FONT_TARGET_UNAVAILABLE_NV")]
        FontTargetUnavailableNV = 0x9369,
        [NativeName("Name", "GL_FONT_UNAVAILABLE_NV")]
        FontUnavailableNV = 0x936A,
        [NativeName("Name", "GL_FONT_UNINTELLIGIBLE_NV")]
        FontUnintelligibleNV = 0x936B,
        [NativeName("Name", "GL_CONIC_CURVE_TO_NV")]
        ConicCurveToNV = 0x1A,
        [NativeName("Name", "GL_RELATIVE_CONIC_CURVE_TO_NV")]
        RelativeConicCurveToNV = 0x1B,
        [NativeName("Name", "GL_FONT_NUM_GLYPH_INDICES_BIT_NV")]
        FontNumGlyphIndicesBitNV = 0x20000000,
        [NativeName("Name", "GL_STANDARD_FONT_FORMAT_NV")]
        StandardFontFormatNV = 0x936C,
        [NativeName("Name", "GL_2_BYTES_NV")]
        Gl2BytesNV = 0x1407,
        [NativeName("Name", "GL_3_BYTES_NV")]
        Gl3BytesNV = 0x1408,
        [NativeName("Name", "GL_4_BYTES_NV")]
        Gl4BytesNV = 0x1409,
        [NativeName("Name", "GL_EYE_LINEAR_NV")]
        EyeLinearNV = 0x2400,
        [NativeName("Name", "GL_OBJECT_LINEAR_NV")]
        ObjectLinearNV = 0x2401,
        [NativeName("Name", "GL_CONSTANT_NV")]
        ConstantNV = 0x8576,
        [NativeName("Name", "GL_PATH_FOG_GEN_MODE_NV")]
        PathFogGenModeNV = 0x90AC,
        [System.Obsolete("Deprecated in version ")]
        [NativeName("Name", "GL_PRIMARY_COLOR")]
        PrimaryColor = 0x8577,
        [NativeName("Name", "GL_PRIMARY_COLOR_NV")]
        PrimaryColorNV = 0x852C,
        [NativeName("Name", "GL_SECONDARY_COLOR_NV")]
        SecondaryColorNV = 0x852D,
        [NativeName("Name", "GL_PATH_GEN_COLOR_FORMAT_NV")]
        PathGenColorFormatNV = 0x90B2,
        [NativeName("Name", "GL_PATH_PROJECTION_NV")]
        PathProjectionNV = 0x1701,
        [NativeName("Name", "GL_PATH_MODELVIEW_NV")]
        PathModelviewNV = 0x1700,
        [NativeName("Name", "GL_PATH_MODELVIEW_STACK_DEPTH_NV")]
        PathModelviewStackDepthNV = 0xBA3,
        [NativeName("Name", "GL_PATH_MODELVIEW_MATRIX_NV")]
        PathModelviewMatrixNV = 0xBA6,
        [NativeName("Name", "GL_PATH_MAX_MODELVIEW_STACK_DEPTH_NV")]
        PathMaxModelviewStackDepthNV = 0xD36,
        [NativeName("Name", "GL_PATH_TRANSPOSE_MODELVIEW_MATRIX_NV")]
        PathTransposeModelviewMatrixNV = 0x84E3,
        [NativeName("Name", "GL_PATH_PROJECTION_STACK_DEPTH_NV")]
        PathProjectionStackDepthNV = 0xBA4,
        [NativeName("Name", "GL_PATH_PROJECTION_MATRIX_NV")]
        PathProjectionMatrixNV = 0xBA7,
        [NativeName("Name", "GL_PATH_MAX_PROJECTION_STACK_DEPTH_NV")]
        PathMaxProjectionStackDepthNV = 0xD38,
        [NativeName("Name", "GL_PATH_TRANSPOSE_PROJECTION_MATRIX_NV")]
        PathTransposeProjectionMatrixNV = 0x84E4,
        [NativeName("Name", "GL_FRAGMENT_INPUT_NV")]
        FragmentInputNV = 0x936D,
        [NativeName("Name", "GL_SHARED_EDGE_NV")]
        SharedEdgeNV = 0xC0,
        [NativeName("Name", "GL_WRITE_PIXEL_DATA_RANGE_NV")]
        WritePixelDataRangeNV = 0x8878,
        [NativeName("Name", "GL_READ_PIXEL_DATA_RANGE_NV")]
        ReadPixelDataRangeNV = 0x8879,
        [NativeName("Name", "GL_WRITE_PIXEL_DATA_RANGE_LENGTH_NV")]
        WritePixelDataRangeLengthNV = 0x887A,
        [NativeName("Name", "GL_READ_PIXEL_DATA_RANGE_LENGTH_NV")]
        ReadPixelDataRangeLengthNV = 0x887B,
        [NativeName("Name", "GL_WRITE_PIXEL_DATA_RANGE_POINTER_NV")]
        WritePixelDataRangePointerNV = 0x887C,
        [NativeName("Name", "GL_READ_PIXEL_DATA_RANGE_POINTER_NV")]
        ReadPixelDataRangePointerNV = 0x887D,
        [NativeName("Name", "GL_POINT_SPRITE_NV")]
        PointSpriteNV = 0x8861,
        [NativeName("Name", "GL_COORD_REPLACE_NV")]
        CoordReplaceNV = 0x8862,
        [NativeName("Name", "GL_POINT_SPRITE_R_MODE_NV")]
        PointSpriteRModeNV = 0x8863,
        [NativeName("Name", "GL_FRAME_NV")]
        FrameNV = 0x8E26,
        [NativeName("Name", "GL_FIELDS_NV")]
        FieldsNV = 0x8E27,
        [NativeName("Name", "GL_CURRENT_TIME_NV")]
        CurrentTimeNV = 0x8E28,
        [NativeName("Name", "GL_NUM_FILL_STREAMS_NV")]
        NumFillStreamsNV = 0x8E29,
        [NativeName("Name", "GL_PRESENT_TIME_NV")]
        PresentTimeNV = 0x8E2A,
        [NativeName("Name", "GL_PRESENT_DURATION_NV")]
        PresentDurationNV = 0x8E2B,
        [NativeName("Name", "GL_PRIMITIVE_RESTART_NV")]
        PrimitiveRestartNV = 0x8558,
        [NativeName("Name", "GL_PRIMITIVE_RESTART_INDEX_NV")]
        PrimitiveRestartIndexNV = 0x8559,
        [NativeName("Name", "GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV")]
        ShadingRateImagePerPrimitiveNV = 0x95B1,
        [NativeName("Name", "GL_SHADING_RATE_IMAGE_PALETTE_COUNT_NV")]
        ShadingRateImagePaletteCountNV = 0x95B2,
        [NativeName("Name", "GL_QUERY_RESOURCE_TYPE_VIDMEM_ALLOC_NV")]
        QueryResourceTypeVidmemAllocNV = 0x9540,
        [NativeName("Name", "GL_QUERY_RESOURCE_MEMTYPE_VIDMEM_NV")]
        QueryResourceMemtypeVidmemNV = 0x9542,
        [NativeName("Name", "GL_QUERY_RESOURCE_SYS_RESERVED_NV")]
        QueryResourceSysReservedNV = 0x9544,
        [NativeName("Name", "GL_QUERY_RESOURCE_TEXTURE_NV")]
        QueryResourceTextureNV = 0x9545,
        [NativeName("Name", "GL_QUERY_RESOURCE_RENDERBUFFER_NV")]
        QueryResourceRenderbufferNV = 0x9546,
        [NativeName("Name", "GL_QUERY_RESOURCE_BUFFEROBJECT_NV")]
        QueryResourceBufferobjectNV = 0x9547,
        [NativeName("Name", "GL_REGISTER_COMBINERS_NV")]
        RegisterCombinersNV = 0x8522,
        [NativeName("Name", "GL_VARIABLE_A_NV")]
        VariableANV = 0x8523,
        [NativeName("Name", "GL_VARIABLE_B_NV")]
        VariableBNV = 0x8524,
        [NativeName("Name", "GL_VARIABLE_C_NV")]
        VariableCNV = 0x8525,
        [NativeName("Name", "GL_VARIABLE_D_NV")]
        VariableDNV = 0x8526,
        [NativeName("Name", "GL_VARIABLE_E_NV")]
        VariableENV = 0x8527,
        [NativeName("Name", "GL_VARIABLE_F_NV")]
        VariableFNV = 0x8528,
        [NativeName("Name", "GL_VARIABLE_G_NV")]
        VariableGNV = 0x8529,
        [NativeName("Name", "GL_CONSTANT_COLOR0_NV")]
        ConstantColor0NV = 0x852A,
        [NativeName("Name", "GL_CONSTANT_COLOR1_NV")]
        ConstantColor1NV = 0x852B,
        [NativeName("Name", "GL_SPARE0_NV")]
        Spare0NV = 0x852E,
        [NativeName("Name", "GL_SPARE1_NV")]
        Spare1NV = 0x852F,
        [NativeName("Name", "GL_DISCARD_NV")]
        DiscardNV = 0x8530,
        [NativeName("Name", "GL_E_TIMES_F_NV")]
        ETimesFNV = 0x8531,
        [NativeName("Name", "GL_SPARE0_PLUS_SECONDARY_COLOR_NV")]
        Spare0PlusSecondaryColorNV = 0x8532,
        [NativeName("Name", "GL_UNSIGNED_IDENTITY_NV")]
        UnsignedIdentityNV = 0x8536,
        [NativeName("Name", "GL_UNSIGNED_INVERT_NV")]
        UnsignedInvertNV = 0x8537,
        [NativeName("Name", "GL_EXPAND_NORMAL_NV")]
        ExpandNormalNV = 0x8538,
        [NativeName("Name", "GL_EXPAND_NEGATE_NV")]
        ExpandNegateNV = 0x8539,
        [NativeName("Name", "GL_HALF_BIAS_NORMAL_NV")]
        HalfBiasNormalNV = 0x853A,
        [NativeName("Name", "GL_HALF_BIAS_NEGATE_NV")]
        HalfBiasNegateNV = 0x853B,
        [NativeName("Name", "GL_SIGNED_IDENTITY_NV")]
        SignedIdentityNV = 0x853C,
        [NativeName("Name", "GL_SIGNED_NEGATE_NV")]
        SignedNegateNV = 0x853D,
        [NativeName("Name", "GL_SCALE_BY_TWO_NV")]
        ScaleByTwoNV = 0x853E,
        [NativeName("Name", "GL_SCALE_BY_FOUR_NV")]
        ScaleByFourNV = 0x853F,
        [NativeName("Name", "GL_SCALE_BY_ONE_HALF_NV")]
        ScaleByOneHalfNV = 0x8540,
        [NativeName("Name", "GL_BIAS_BY_NEGATIVE_ONE_HALF_NV")]
        BiasByNegativeOneHalfNV = 0x8541,
        [NativeName("Name", "GL_COMBINER_INPUT_NV")]
        CombinerInputNV = 0x8542,
        [NativeName("Name", "GL_COMBINER_MAPPING_NV")]
        CombinerMappingNV = 0x8543,
        [NativeName("Name", "GL_COMBINER_COMPONENT_USAGE_NV")]
        CombinerComponentUsageNV = 0x8544,
        [NativeName("Name", "GL_COMBINER_AB_DOT_PRODUCT_NV")]
        CombinerABDotProductNV = 0x8545,
        [NativeName("Name", "GL_COMBINER_CD_DOT_PRODUCT_NV")]
        CombinerCDDotProductNV = 0x8546,
        [NativeName("Name", "GL_COMBINER_MUX_SUM_NV")]
        CombinerMuxSumNV = 0x8547,
        [NativeName("Name", "GL_COMBINER_SCALE_NV")]
        CombinerScaleNV = 0x8548,
        [NativeName("Name", "GL_COMBINER_BIAS_NV")]
        CombinerBiasNV = 0x8549,
        [NativeName("Name", "GL_COMBINER_AB_OUTPUT_NV")]
        CombinerABOutputNV = 0x854A,
        [NativeName("Name", "GL_COMBINER_CD_OUTPUT_NV")]
        CombinerCDOutputNV = 0x854B,
        [NativeName("Name", "GL_COMBINER_SUM_OUTPUT_NV")]
        CombinerSumOutputNV = 0x854C,
        [NativeName("Name", "GL_MAX_GENERAL_COMBINERS_NV")]
        MaxGeneralCombinersNV = 0x854D,
        [NativeName("Name", "GL_NUM_GENERAL_COMBINERS_NV")]
        NumGeneralCombinersNV = 0x854E,
        [NativeName("Name", "GL_COLOR_SUM_CLAMP_NV")]
        ColorSumClampNV = 0x854F,
        [NativeName("Name", "GL_COMBINER0_NV")]
        Combiner0NV = 0x8550,
        [NativeName("Name", "GL_COMBINER1_NV")]
        Combiner1NV = 0x8551,
        [NativeName("Name", "GL_COMBINER2_NV")]
        Combiner2NV = 0x8552,
        [NativeName("Name", "GL_COMBINER3_NV")]
        Combiner3NV = 0x8553,
        [NativeName("Name", "GL_COMBINER4_NV")]
        Combiner4NV = 0x8554,
        [NativeName("Name", "GL_COMBINER5_NV")]
        Combiner5NV = 0x8555,
        [NativeName("Name", "GL_COMBINER6_NV")]
        Combiner6NV = 0x8556,
        [NativeName("Name", "GL_COMBINER7_NV")]
        Combiner7NV = 0x8557,
        [NativeName("Name", "GL_TEXTURE0_ARB")]
        Texture0Arb = 0x84C0,
        [NativeName("Name", "GL_TEXTURE1_ARB")]
        Texture1Arb = 0x84C1,
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
        [System.Obsolete("Deprecated in version ")]
        [NativeName("Name", "GL_FOG")]
        Fog = 0xB60,
        [NativeName("Name", "GL_PER_STAGE_CONSTANTS_NV")]
        PerStageConstantsNV = 0x8535,
        [NativeName("Name", "GL_REPRESENTATIVE_FRAGMENT_TEST_NV")]
        RepresentativeFragmentTestNV = 0x937F,
        [NativeName("Name", "GL_PURGED_CONTEXT_RESET_NV")]
        PurgedContextResetNV = 0x92BB,
        [NativeName("Name", "GL_SAMPLE_LOCATION_SUBPIXEL_BITS_NV")]
        SampleLocationSubpixelBitsNV = 0x933D,
        [NativeName("Name", "GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_NV")]
        SampleLocationPixelGridWidthNV = 0x933E,
        [NativeName("Name", "GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_NV")]
        SampleLocationPixelGridHeightNV = 0x933F,
        [NativeName("Name", "GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_NV")]
        ProgrammableSampleLocationTableSizeNV = 0x9340,
        [NativeName("Name", "GL_SAMPLE_LOCATION_NV")]
        SampleLocationNV = 0x8E50,
        [NativeName("Name", "GL_PROGRAMMABLE_SAMPLE_LOCATION_NV")]
        ProgrammableSampleLocationNV = 0x9341,
        [NativeName("Name", "GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_NV")]
        FramebufferProgrammableSampleLocationsNV = 0x9342,
        [NativeName("Name", "GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_NV")]
        FramebufferSampleLocationPixelGridNV = 0x9343,
        [NativeName("Name", "GL_SCISSOR_TEST_EXCLUSIVE_NV")]
        ScissorTestExclusiveNV = 0x9555,
        [NativeName("Name", "GL_SCISSOR_BOX_EXCLUSIVE_NV")]
        ScissorBoxExclusiveNV = 0x9556,
        [NativeName("Name", "GL_BUFFER_GPU_ADDRESS_NV")]
        BufferGpuAddressNV = 0x8F1D,
        [NativeName("Name", "GL_GPU_ADDRESS_NV")]
        GpuAddressNV = 0x8F34,
        [NativeName("Name", "GL_MAX_SHADER_BUFFER_ADDRESS_NV")]
        MaxShaderBufferAddressNV = 0x8F35,
        [NativeName("Name", "GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV")]
        ShaderGlobalAccessBarrierBitNV = 0x10,
        [NativeName("Name", "GL_READ_WRITE")]
        ReadWrite = 0x88BA,
        [NativeName("Name", "GL_WRITE_ONLY")]
        WriteOnly = 0x88B9,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_PARTITIONED_BIT_NV")]
        SubgroupFeaturePartitionedBitNV = 0x100,
        [NativeName("Name", "GL_WARP_SIZE_NV")]
        WarpSizeNV = 0x9339,
        [NativeName("Name", "GL_WARPS_PER_SM_NV")]
        WarpsPerSMNV = 0x933A,
        [NativeName("Name", "GL_SM_COUNT_NV")]
        SMCountNV = 0x933B,
        [NativeName("Name", "GL_SHADING_RATE_IMAGE_NV")]
        ShadingRateImageNV = 0x9563,
        [NativeName("Name", "GL_SHADING_RATE_NO_INVOCATIONS_NV")]
        ShadingRateNoInvocationsNV = 0x9564,
        [NativeName("Name", "GL_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV")]
        ShadingRate1InvocationPerPixelNV = 0x9565,
        [NativeName("Name", "GL_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV")]
        ShadingRate1InvocationPer1X2PixelsNV = 0x9566,
        [NativeName("Name", "GL_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV")]
        ShadingRate1InvocationPer2X1PixelsNV = 0x9567,
        [NativeName("Name", "GL_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV")]
        ShadingRate1InvocationPer2X2PixelsNV = 0x9568,
        [NativeName("Name", "GL_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV")]
        ShadingRate1InvocationPer2X4PixelsNV = 0x9569,
        [NativeName("Name", "GL_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV")]
        ShadingRate1InvocationPer4X2PixelsNV = 0x956A,
        [NativeName("Name", "GL_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV")]
        ShadingRate1InvocationPer4X4PixelsNV = 0x956B,
        [NativeName("Name", "GL_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV")]
        ShadingRate2InvocationsPerPixelNV = 0x956C,
        [NativeName("Name", "GL_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV")]
        ShadingRate4InvocationsPerPixelNV = 0x956D,
        [NativeName("Name", "GL_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV")]
        ShadingRate8InvocationsPerPixelNV = 0x956E,
        [NativeName("Name", "GL_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV")]
        ShadingRate16InvocationsPerPixelNV = 0x956F,
        [NativeName("Name", "GL_SHADING_RATE_IMAGE_BINDING_NV")]
        ShadingRateImageBindingNV = 0x955B,
        [NativeName("Name", "GL_SHADING_RATE_IMAGE_TEXEL_WIDTH_NV")]
        ShadingRateImageTexelWidthNV = 0x955C,
        [NativeName("Name", "GL_SHADING_RATE_IMAGE_TEXEL_HEIGHT_NV")]
        ShadingRateImageTexelHeightNV = 0x955D,
        [NativeName("Name", "GL_SHADING_RATE_IMAGE_PALETTE_SIZE_NV")]
        ShadingRateImagePaletteSizeNV = 0x955E,
        [NativeName("Name", "GL_MAX_COARSE_FRAGMENT_SAMPLES_NV")]
        MaxCoarseFragmentSamplesNV = 0x955F,
        [NativeName("Name", "GL_SHADING_RATE_SAMPLE_ORDER_DEFAULT_NV")]
        ShadingRateSampleOrderDefaultNV = 0x95AE,
        [NativeName("Name", "GL_SHADING_RATE_SAMPLE_ORDER_PIXEL_MAJOR_NV")]
        ShadingRateSampleOrderPixelMajorNV = 0x95AF,
        [NativeName("Name", "GL_SHADING_RATE_SAMPLE_ORDER_SAMPLE_MAJOR_NV")]
        ShadingRateSampleOrderSampleMajorNV = 0x95B0,
        [NativeName("Name", "GL_MAX_PROGRAM_PATCH_ATTRIBS_NV")]
        MaxProgramPatchAttribsNV = 0x86D8,
        [NativeName("Name", "GL_TESS_CONTROL_PROGRAM_NV")]
        TessControlProgramNV = 0x891E,
        [NativeName("Name", "GL_TESS_EVALUATION_PROGRAM_NV")]
        TessEvaluationProgramNV = 0x891F,
        [NativeName("Name", "GL_TESS_CONTROL_PROGRAM_PARAMETER_BUFFER_NV")]
        TessControlProgramParameterBufferNV = 0x8C74,
        [NativeName("Name", "GL_TESS_EVALUATION_PROGRAM_PARAMETER_BUFFER_NV")]
        TessEvaluationProgramParameterBufferNV = 0x8C75,
        [NativeName("Name", "GL_EMBOSS_LIGHT_NV")]
        EmbossLightNV = 0x855D,
        [NativeName("Name", "GL_EMBOSS_CONSTANT_NV")]
        EmbossConstantNV = 0x855E,
        [NativeName("Name", "GL_EMBOSS_MAP_NV")]
        EmbossMapNV = 0x855F,
        [NativeName("Name", "GL_NORMAL_MAP_NV")]
        NormalMapNV = 0x8511,
        [NativeName("Name", "GL_REFLECTION_MAP_NV")]
        ReflectionMapNV = 0x8512,
        [NativeName("Name", "GL_COMBINE4_NV")]
        Combine4NV = 0x8503,
        [NativeName("Name", "GL_SOURCE3_RGB_NV")]
        Source3RgbNV = 0x8583,
        [NativeName("Name", "GL_SOURCE3_ALPHA_NV")]
        Source3AlphaNV = 0x858B,
        [NativeName("Name", "GL_OPERAND3_RGB_NV")]
        Operand3RgbNV = 0x8593,
        [NativeName("Name", "GL_OPERAND3_ALPHA_NV")]
        Operand3AlphaNV = 0x859B,
        [NativeName("Name", "GL_TEXTURE_UNSIGNED_REMAP_MODE_NV")]
        TextureUnsignedRemapModeNV = 0x888F,
        [NativeName("Name", "GL_TEXTURE_COVERAGE_SAMPLES_NV")]
        TextureCoverageSamplesNV = 0x9045,
        [NativeName("Name", "GL_TEXTURE_COLOR_SAMPLES_NV")]
        TextureColorSamplesNV = 0x9046,
        [NativeName("Name", "GL_TEXTURE_RECTANGLE_NV")]
        TextureRectangleNV = 0x84F5,
        [NativeName("Name", "GL_TEXTURE_BINDING_RECTANGLE_NV")]
        TextureBindingRectangleNV = 0x84F6,
        [NativeName("Name", "GL_PROXY_TEXTURE_RECTANGLE_NV")]
        ProxyTextureRectangleNV = 0x84F7,
        [NativeName("Name", "GL_MAX_RECTANGLE_TEXTURE_SIZE_NV")]
        MaxRectangleTextureSizeNV = 0x84F8,
        [NativeName("Name", "GL_OFFSET_TEXTURE_RECTANGLE_NV")]
        OffsetTextureRectangleNV = 0x864C,
        [NativeName("Name", "GL_OFFSET_TEXTURE_RECTANGLE_SCALE_NV")]
        OffsetTextureRectangleScaleNV = 0x864D,
        [NativeName("Name", "GL_DOT_PRODUCT_TEXTURE_RECTANGLE_NV")]
        DotProductTextureRectangleNV = 0x864E,
        [NativeName("Name", "GL_RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV")]
        RgbaUnsignedDotProductMappingNV = 0x86D9,
        [NativeName("Name", "GL_UNSIGNED_INT_S8_S8_8_8_NV")]
        UnsignedIntS8S888NV = 0x86DA,
        [NativeName("Name", "GL_UNSIGNED_INT_8_8_S8_S8_REV_NV")]
        UnsignedInt88S8S8RevNV = 0x86DB,
        [NativeName("Name", "GL_DSDT_MAG_INTENSITY_NV")]
        DsdtMagIntensityNV = 0x86DC,
        [NativeName("Name", "GL_SHADER_CONSISTENT_NV")]
        ShaderConsistentNV = 0x86DD,
        [NativeName("Name", "GL_TEXTURE_SHADER_NV")]
        TextureShaderNV = 0x86DE,
        [NativeName("Name", "GL_SHADER_OPERATION_NV")]
        ShaderOperationNV = 0x86DF,
        [NativeName("Name", "GL_CULL_MODES_NV")]
        CullModesNV = 0x86E0,
        [NativeName("Name", "GL_OFFSET_TEXTURE_MATRIX_NV")]
        OffsetTextureMatrixNV = 0x86E1,
        [NativeName("Name", "GL_OFFSET_TEXTURE_SCALE_NV")]
        OffsetTextureScaleNV = 0x86E2,
        [NativeName("Name", "GL_OFFSET_TEXTURE_BIAS_NV")]
        OffsetTextureBiasNV = 0x86E3,
        [NativeName("Name", "GL_OFFSET_TEXTURE_2D_MATRIX_NV")]
        OffsetTexture2DMatrixNV = 0x86E1,
        [NativeName("Name", "GL_OFFSET_TEXTURE_2D_SCALE_NV")]
        OffsetTexture2DScaleNV = 0x86E2,
        [NativeName("Name", "GL_OFFSET_TEXTURE_2D_BIAS_NV")]
        OffsetTexture2DBiasNV = 0x86E3,
        [NativeName("Name", "GL_PREVIOUS_TEXTURE_INPUT_NV")]
        PreviousTextureInputNV = 0x86E4,
        [NativeName("Name", "GL_CONST_EYE_NV")]
        ConstEyeNV = 0x86E5,
        [NativeName("Name", "GL_PASS_THROUGH_NV")]
        PassThroughNV = 0x86E6,
        [NativeName("Name", "GL_CULL_FRAGMENT_NV")]
        CullFragmentNV = 0x86E7,
        [NativeName("Name", "GL_OFFSET_TEXTURE_2D_NV")]
        OffsetTexture2DNV = 0x86E8,
        [NativeName("Name", "GL_DEPENDENT_AR_TEXTURE_2D_NV")]
        DependentARTexture2DNV = 0x86E9,
        [NativeName("Name", "GL_DEPENDENT_GB_TEXTURE_2D_NV")]
        DependentGBTexture2DNV = 0x86EA,
        [NativeName("Name", "GL_DOT_PRODUCT_NV")]
        DotProductNV = 0x86EC,
        [NativeName("Name", "GL_DOT_PRODUCT_DEPTH_REPLACE_NV")]
        DotProductDepthReplaceNV = 0x86ED,
        [NativeName("Name", "GL_DOT_PRODUCT_TEXTURE_2D_NV")]
        DotProductTexture2DNV = 0x86EE,
        [NativeName("Name", "GL_DOT_PRODUCT_TEXTURE_CUBE_MAP_NV")]
        DotProductTextureCubeMapNV = 0x86F0,
        [NativeName("Name", "GL_DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV")]
        DotProductDiffuseCubeMapNV = 0x86F1,
        [NativeName("Name", "GL_DOT_PRODUCT_REFLECT_CUBE_MAP_NV")]
        DotProductReflectCubeMapNV = 0x86F2,
        [NativeName("Name", "GL_DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV")]
        DotProductConstEyeReflectCubeMapNV = 0x86F3,
        [NativeName("Name", "GL_HILO_NV")]
        HiloNV = 0x86F4,
        [NativeName("Name", "GL_DSDT_NV")]
        DsdtNV = 0x86F5,
        [NativeName("Name", "GL_DSDT_MAG_NV")]
        DsdtMagNV = 0x86F6,
        [NativeName("Name", "GL_DSDT_MAG_VIB_NV")]
        DsdtMagVibNV = 0x86F7,
        [NativeName("Name", "GL_HILO16_NV")]
        Hilo16NV = 0x86F8,
        [NativeName("Name", "GL_SIGNED_HILO_NV")]
        SignedHiloNV = 0x86F9,
        [NativeName("Name", "GL_SIGNED_HILO16_NV")]
        SignedHilo16NV = 0x86FA,
        [NativeName("Name", "GL_SIGNED_RGBA_NV")]
        SignedRgbaNV = 0x86FB,
        [NativeName("Name", "GL_SIGNED_RGBA8_NV")]
        SignedRgba8NV = 0x86FC,
        [NativeName("Name", "GL_SIGNED_RGB_NV")]
        SignedRgbNV = 0x86FE,
        [NativeName("Name", "GL_SIGNED_RGB8_NV")]
        SignedRgb8NV = 0x86FF,
        [NativeName("Name", "GL_SIGNED_LUMINANCE_NV")]
        SignedLuminanceNV = 0x8701,
        [NativeName("Name", "GL_SIGNED_LUMINANCE8_NV")]
        SignedLuminance8NV = 0x8702,
        [NativeName("Name", "GL_SIGNED_LUMINANCE_ALPHA_NV")]
        SignedLuminanceAlphaNV = 0x8703,
        [NativeName("Name", "GL_SIGNED_LUMINANCE8_ALPHA8_NV")]
        SignedLuminance8Alpha8NV = 0x8704,
        [NativeName("Name", "GL_SIGNED_ALPHA_NV")]
        SignedAlphaNV = 0x8705,
        [NativeName("Name", "GL_SIGNED_ALPHA8_NV")]
        SignedAlpha8NV = 0x8706,
        [NativeName("Name", "GL_SIGNED_INTENSITY_NV")]
        SignedIntensityNV = 0x8707,
        [NativeName("Name", "GL_SIGNED_INTENSITY8_NV")]
        SignedIntensity8NV = 0x8708,
        [NativeName("Name", "GL_DSDT8_NV")]
        Dsdt8NV = 0x8709,
        [NativeName("Name", "GL_DSDT8_MAG8_NV")]
        Dsdt8Mag8NV = 0x870A,
        [NativeName("Name", "GL_DSDT8_MAG8_INTENSITY8_NV")]
        Dsdt8Mag8Intensity8NV = 0x870B,
        [NativeName("Name", "GL_SIGNED_RGB_UNSIGNED_ALPHA_NV")]
        SignedRgbUnsignedAlphaNV = 0x870C,
        [NativeName("Name", "GL_SIGNED_RGB8_UNSIGNED_ALPHA8_NV")]
        SignedRgb8UnsignedAlpha8NV = 0x870D,
        [NativeName("Name", "GL_HI_SCALE_NV")]
        HIScaleNV = 0x870E,
        [NativeName("Name", "GL_LO_SCALE_NV")]
        LOScaleNV = 0x870F,
        [NativeName("Name", "GL_DS_SCALE_NV")]
        DSScaleNV = 0x8710,
        [NativeName("Name", "GL_DT_SCALE_NV")]
        DTScaleNV = 0x8711,
        [NativeName("Name", "GL_MAGNITUDE_SCALE_NV")]
        MagnitudeScaleNV = 0x8712,
        [NativeName("Name", "GL_VIBRANCE_SCALE_NV")]
        VibranceScaleNV = 0x8713,
        [NativeName("Name", "GL_HI_BIAS_NV")]
        HIBiasNV = 0x8714,
        [NativeName("Name", "GL_LO_BIAS_NV")]
        LOBiasNV = 0x8715,
        [NativeName("Name", "GL_DS_BIAS_NV")]
        DSBiasNV = 0x8716,
        [NativeName("Name", "GL_DT_BIAS_NV")]
        DTBiasNV = 0x8717,
        [NativeName("Name", "GL_MAGNITUDE_BIAS_NV")]
        MagnitudeBiasNV = 0x8718,
        [NativeName("Name", "GL_VIBRANCE_BIAS_NV")]
        VibranceBiasNV = 0x8719,
        [NativeName("Name", "GL_TEXTURE_BORDER_VALUES_NV")]
        TextureBorderValuesNV = 0x871A,
        [NativeName("Name", "GL_TEXTURE_HI_SIZE_NV")]
        TextureHISizeNV = 0x871B,
        [NativeName("Name", "GL_TEXTURE_LO_SIZE_NV")]
        TextureLOSizeNV = 0x871C,
        [NativeName("Name", "GL_TEXTURE_DS_SIZE_NV")]
        TextureDSSizeNV = 0x871D,
        [NativeName("Name", "GL_TEXTURE_DT_SIZE_NV")]
        TextureDTSizeNV = 0x871E,
        [NativeName("Name", "GL_TEXTURE_MAG_SIZE_NV")]
        TextureMagSizeNV = 0x871F,
        [NativeName("Name", "GL_DOT_PRODUCT_TEXTURE_3D_NV")]
        DotProductTexture3DNV = 0x86EF,
        [NativeName("Name", "GL_OFFSET_PROJECTIVE_TEXTURE_2D_NV")]
        OffsetProjectiveTexture2DNV = 0x8850,
        [NativeName("Name", "GL_OFFSET_PROJECTIVE_TEXTURE_2D_SCALE_NV")]
        OffsetProjectiveTexture2DScaleNV = 0x8851,
        [NativeName("Name", "GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_NV")]
        OffsetProjectiveTextureRectangleNV = 0x8852,
        [NativeName("Name", "GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_SCALE_NV")]
        OffsetProjectiveTextureRectangleScaleNV = 0x8853,
        [NativeName("Name", "GL_OFFSET_HILO_TEXTURE_2D_NV")]
        OffsetHiloTexture2DNV = 0x8854,
        [NativeName("Name", "GL_OFFSET_HILO_TEXTURE_RECTANGLE_NV")]
        OffsetHiloTextureRectangleNV = 0x8855,
        [NativeName("Name", "GL_OFFSET_HILO_PROJECTIVE_TEXTURE_2D_NV")]
        OffsetHiloProjectiveTexture2DNV = 0x8856,
        [NativeName("Name", "GL_OFFSET_HILO_PROJECTIVE_TEXTURE_RECTANGLE_NV")]
        OffsetHiloProjectiveTextureRectangleNV = 0x8857,
        [NativeName("Name", "GL_DEPENDENT_HILO_TEXTURE_2D_NV")]
        DependentHiloTexture2DNV = 0x8858,
        [NativeName("Name", "GL_DEPENDENT_RGB_TEXTURE_3D_NV")]
        DependentRgbTexture3DNV = 0x8859,
        [NativeName("Name", "GL_DEPENDENT_RGB_TEXTURE_CUBE_MAP_NV")]
        DependentRgbTextureCubeMapNV = 0x885A,
        [NativeName("Name", "GL_DOT_PRODUCT_PASS_THROUGH_NV")]
        DotProductPassThroughNV = 0x885B,
        [NativeName("Name", "GL_DOT_PRODUCT_TEXTURE_1D_NV")]
        DotProductTexture1DNV = 0x885C,
        [NativeName("Name", "GL_DOT_PRODUCT_AFFINE_DEPTH_REPLACE_NV")]
        DotProductAffineDepthReplaceNV = 0x885D,
        [NativeName("Name", "GL_HILO8_NV")]
        Hilo8NV = 0x885E,
        [NativeName("Name", "GL_SIGNED_HILO8_NV")]
        SignedHilo8NV = 0x885F,
        [NativeName("Name", "GL_FORCE_BLUE_TO_ONE_NV")]
        ForceBlueToOneNV = 0x8860,
        [NativeName("Name", "GL_TIMELINE_SEMAPHORE_VALUE_NV")]
        TimelineSemaphoreValueNV = 0x9595,
        [NativeName("Name", "GL_SEMAPHORE_TYPE_NV")]
        SemaphoreTypeNV = 0x95B3,
        [NativeName("Name", "GL_SEMAPHORE_TYPE_BINARY_NV")]
        SemaphoreTypeBinaryNV = 0x95B4,
        [NativeName("Name", "GL_SEMAPHORE_TYPE_TIMELINE_NV")]
        SemaphoreTypeTimelineNV = 0x95B5,
        [NativeName("Name", "GL_MAX_TIMELINE_SEMAPHORE_VALUE_DIFFERENCE_NV")]
        MaxTimelineSemaphoreValueDifferenceNV = 0x95B6,
        [NativeName("Name", "GL_BACK_PRIMARY_COLOR_NV")]
        BackPrimaryColorNV = 0x8C77,
        [NativeName("Name", "GL_BACK_SECONDARY_COLOR_NV")]
        BackSecondaryColorNV = 0x8C78,
        [NativeName("Name", "GL_TEXTURE_COORD_NV")]
        TextureCoordNV = 0x8C79,
        [NativeName("Name", "GL_CLIP_DISTANCE_NV")]
        ClipDistanceNV = 0x8C7A,
        [NativeName("Name", "GL_VERTEX_ID_NV")]
        VertexIDNV = 0x8C7B,
        [NativeName("Name", "GL_PRIMITIVE_ID_NV")]
        PrimitiveIDNV = 0x8C7C,
        [NativeName("Name", "GL_GENERIC_ATTRIB_NV")]
        GenericAttribNV = 0x8C7D,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_ATTRIBS_NV")]
        TransformFeedbackAttribsNV = 0x8C7E,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_MODE_NV")]
        TransformFeedbackBufferModeNV = 0x8C7F,
        [NativeName("Name", "GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_NV")]
        MaxTransformFeedbackSeparateComponentsNV = 0x8C80,
        [NativeName("Name", "GL_ACTIVE_VARYINGS_NV")]
        ActiveVaryingsNV = 0x8C81,
        [NativeName("Name", "GL_ACTIVE_VARYING_MAX_LENGTH_NV")]
        ActiveVaryingMaxLengthNV = 0x8C82,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_VARYINGS_NV")]
        TransformFeedbackVaryingsNV = 0x8C83,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_START_NV")]
        TransformFeedbackBufferStartNV = 0x8C84,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_NV")]
        TransformFeedbackBufferSizeNV = 0x8C85,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_RECORD_NV")]
        TransformFeedbackRecordNV = 0x8C86,
        [NativeName("Name", "GL_PRIMITIVES_GENERATED_NV")]
        PrimitivesGeneratedNV = 0x8C87,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_NV")]
        TransformFeedbackPrimitivesWrittenNV = 0x8C88,
        [NativeName("Name", "GL_RASTERIZER_DISCARD_NV")]
        RasterizerDiscardNV = 0x8C89,
        [NativeName("Name", "GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_NV")]
        MaxTransformFeedbackInterleavedComponentsNV = 0x8C8A,
        [NativeName("Name", "GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_NV")]
        MaxTransformFeedbackSeparateAttribsNV = 0x8C8B,
        [NativeName("Name", "GL_INTERLEAVED_ATTRIBS_NV")]
        InterleavedAttribsNV = 0x8C8C,
        [NativeName("Name", "GL_SEPARATE_ATTRIBS_NV")]
        SeparateAttribsNV = 0x8C8D,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_NV")]
        TransformFeedbackBufferNV = 0x8C8E,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_NV")]
        TransformFeedbackBufferBindingNV = 0x8C8F,
        [NativeName("Name", "GL_LAYER_NV")]
        LayerNV = 0x8DAA,
        [NativeName("Name", "GL_NEXT_BUFFER_NV")]
        NextBufferNV = unchecked((int)0xFFFFFFFFFFFFFFFE),
        [NativeName("Name", "GL_SKIP_COMPONENTS4_NV")]
        SkipComponents4NV = unchecked((int)0xFFFFFFFFFFFFFFFD),
        [NativeName("Name", "GL_SKIP_COMPONENTS3_NV")]
        SkipComponents3NV = unchecked((int)0xFFFFFFFFFFFFFFFC),
        [NativeName("Name", "GL_SKIP_COMPONENTS2_NV")]
        SkipComponents2NV = unchecked((int)0xFFFFFFFFFFFFFFFB),
        [NativeName("Name", "GL_SKIP_COMPONENTS1_NV")]
        SkipComponents1NV = unchecked((int)0xFFFFFFFFFFFFFFFA),
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_NV")]
        TransformFeedbackNV = 0x8E22,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED_NV")]
        TransformFeedbackBufferPausedNV = 0x8E23,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE_NV")]
        TransformFeedbackBufferActiveNV = 0x8E24,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BINDING_NV")]
        TransformFeedbackBindingNV = 0x8E25,
        [NativeName("Name", "GL_UNIFORM_BUFFER_UNIFIED_NV")]
        UniformBufferUnifiedNV = 0x936E,
        [NativeName("Name", "GL_UNIFORM_BUFFER_ADDRESS_NV")]
        UniformBufferAddressNV = 0x936F,
        [NativeName("Name", "GL_UNIFORM_BUFFER_LENGTH_NV")]
        UniformBufferLengthNV = 0x9370,
        [NativeName("Name", "GL_SURFACE_STATE_NV")]
        SurfaceStateNV = 0x86EB,
        [NativeName("Name", "GL_SURFACE_REGISTERED_NV")]
        SurfaceRegisteredNV = 0x86FD,
        [NativeName("Name", "GL_SURFACE_MAPPED_NV")]
        SurfaceMappedNV = 0x8700,
        [NativeName("Name", "GL_WRITE_DISCARD_NV")]
        WriteDiscardNV = 0x88BE,
        [NativeName("Name", "GL_VERTEX_ARRAY_RANGE_NV")]
        VertexArrayRangeNV = 0x851D,
        [NativeName("Name", "GL_VERTEX_ARRAY_RANGE_LENGTH_NV")]
        VertexArrayRangeLengthNV = 0x851E,
        [NativeName("Name", "GL_VERTEX_ARRAY_RANGE_VALID_NV")]
        VertexArrayRangeValidNV = 0x851F,
        [NativeName("Name", "GL_MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV")]
        MaxVertexArrayRangeElementNV = 0x8520,
        [NativeName("Name", "GL_VERTEX_ARRAY_RANGE_POINTER_NV")]
        VertexArrayRangePointerNV = 0x8521,
        [NativeName("Name", "GL_VERTEX_ARRAY_RANGE_WITHOUT_FLUSH_NV")]
        VertexArrayRangeWithoutFlushNV = 0x8533,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_UNIFIED_NV")]
        VertexAttribArrayUnifiedNV = 0x8F1E,
        [NativeName("Name", "GL_ELEMENT_ARRAY_UNIFIED_NV")]
        ElementArrayUnifiedNV = 0x8F1F,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_ADDRESS_NV")]
        VertexAttribArrayAddressNV = 0x8F20,
        [NativeName("Name", "GL_VERTEX_ARRAY_ADDRESS_NV")]
        VertexArrayAddressNV = 0x8F21,
        [NativeName("Name", "GL_NORMAL_ARRAY_ADDRESS_NV")]
        NormalArrayAddressNV = 0x8F22,
        [NativeName("Name", "GL_COLOR_ARRAY_ADDRESS_NV")]
        ColorArrayAddressNV = 0x8F23,
        [NativeName("Name", "GL_INDEX_ARRAY_ADDRESS_NV")]
        IndexArrayAddressNV = 0x8F24,
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_ADDRESS_NV")]
        TextureCoordArrayAddressNV = 0x8F25,
        [NativeName("Name", "GL_EDGE_FLAG_ARRAY_ADDRESS_NV")]
        EdgeFlagArrayAddressNV = 0x8F26,
        [NativeName("Name", "GL_SECONDARY_COLOR_ARRAY_ADDRESS_NV")]
        SecondaryColorArrayAddressNV = 0x8F27,
        [NativeName("Name", "GL_FOG_COORD_ARRAY_ADDRESS_NV")]
        FogCoordArrayAddressNV = 0x8F28,
        [NativeName("Name", "GL_ELEMENT_ARRAY_ADDRESS_NV")]
        ElementArrayAddressNV = 0x8F29,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_LENGTH_NV")]
        VertexAttribArrayLengthNV = 0x8F2A,
        [NativeName("Name", "GL_VERTEX_ARRAY_LENGTH_NV")]
        VertexArrayLengthNV = 0x8F2B,
        [NativeName("Name", "GL_NORMAL_ARRAY_LENGTH_NV")]
        NormalArrayLengthNV = 0x8F2C,
        [NativeName("Name", "GL_COLOR_ARRAY_LENGTH_NV")]
        ColorArrayLengthNV = 0x8F2D,
        [NativeName("Name", "GL_INDEX_ARRAY_LENGTH_NV")]
        IndexArrayLengthNV = 0x8F2E,
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_LENGTH_NV")]
        TextureCoordArrayLengthNV = 0x8F2F,
        [NativeName("Name", "GL_EDGE_FLAG_ARRAY_LENGTH_NV")]
        EdgeFlagArrayLengthNV = 0x8F30,
        [NativeName("Name", "GL_SECONDARY_COLOR_ARRAY_LENGTH_NV")]
        SecondaryColorArrayLengthNV = 0x8F31,
        [NativeName("Name", "GL_FOG_COORD_ARRAY_LENGTH_NV")]
        FogCoordArrayLengthNV = 0x8F32,
        [NativeName("Name", "GL_ELEMENT_ARRAY_LENGTH_NV")]
        ElementArrayLengthNV = 0x8F33,
        [NativeName("Name", "GL_DRAW_INDIRECT_UNIFIED_NV")]
        DrawIndirectUnifiedNV = 0x8F40,
        [NativeName("Name", "GL_DRAW_INDIRECT_ADDRESS_NV")]
        DrawIndirectAddressNV = 0x8F41,
        [NativeName("Name", "GL_DRAW_INDIRECT_LENGTH_NV")]
        DrawIndirectLengthNV = 0x8F42,
        [NativeName("Name", "GL_VERTEX_PROGRAM_NV")]
        VertexProgramNV = 0x8620,
        [NativeName("Name", "GL_VERTEX_STATE_PROGRAM_NV")]
        VertexStateProgramNV = 0x8621,
        [NativeName("Name", "GL_ATTRIB_ARRAY_SIZE_NV")]
        AttribArraySizeNV = 0x8623,
        [NativeName("Name", "GL_ATTRIB_ARRAY_STRIDE_NV")]
        AttribArrayStrideNV = 0x8624,
        [NativeName("Name", "GL_ATTRIB_ARRAY_TYPE_NV")]
        AttribArrayTypeNV = 0x8625,
        [NativeName("Name", "GL_CURRENT_ATTRIB_NV")]
        CurrentAttribNV = 0x8626,
        [NativeName("Name", "GL_PROGRAM_LENGTH_NV")]
        ProgramLengthNV = 0x8627,
        [NativeName("Name", "GL_PROGRAM_STRING_NV")]
        ProgramStringNV = 0x8628,
        [NativeName("Name", "GL_MODELVIEW_PROJECTION_NV")]
        ModelviewProjectionNV = 0x8629,
        [NativeName("Name", "GL_IDENTITY_NV")]
        IdentityNV = 0x862A,
        [NativeName("Name", "GL_INVERSE_NV")]
        InverseNV = 0x862B,
        [NativeName("Name", "GL_TRANSPOSE_NV")]
        TransposeNV = 0x862C,
        [NativeName("Name", "GL_INVERSE_TRANSPOSE_NV")]
        InverseTransposeNV = 0x862D,
        [NativeName("Name", "GL_MAX_TRACK_MATRIX_STACK_DEPTH_NV")]
        MaxTrackMatrixStackDepthNV = 0x862E,
        [NativeName("Name", "GL_MAX_TRACK_MATRICES_NV")]
        MaxTrackMatricesNV = 0x862F,
        [NativeName("Name", "GL_MATRIX0_NV")]
        Matrix0NV = 0x8630,
        [NativeName("Name", "GL_MATRIX1_NV")]
        Matrix1NV = 0x8631,
        [NativeName("Name", "GL_MATRIX2_NV")]
        Matrix2NV = 0x8632,
        [NativeName("Name", "GL_MATRIX3_NV")]
        Matrix3NV = 0x8633,
        [NativeName("Name", "GL_MATRIX4_NV")]
        Matrix4NV = 0x8634,
        [NativeName("Name", "GL_MATRIX5_NV")]
        Matrix5NV = 0x8635,
        [NativeName("Name", "GL_MATRIX6_NV")]
        Matrix6NV = 0x8636,
        [NativeName("Name", "GL_MATRIX7_NV")]
        Matrix7NV = 0x8637,
        [NativeName("Name", "GL_CURRENT_MATRIX_STACK_DEPTH_NV")]
        CurrentMatrixStackDepthNV = 0x8640,
        [NativeName("Name", "GL_CURRENT_MATRIX_NV")]
        CurrentMatrixNV = 0x8641,
        [NativeName("Name", "GL_VERTEX_PROGRAM_POINT_SIZE_NV")]
        VertexProgramPointSizeNV = 0x8642,
        [NativeName("Name", "GL_VERTEX_PROGRAM_TWO_SIDE_NV")]
        VertexProgramTwoSideNV = 0x8643,
        [NativeName("Name", "GL_PROGRAM_PARAMETER_NV")]
        ProgramParameterNV = 0x8644,
        [NativeName("Name", "GL_ATTRIB_ARRAY_POINTER_NV")]
        AttribArrayPointerNV = 0x8645,
        [NativeName("Name", "GL_PROGRAM_TARGET_NV")]
        ProgramTargetNV = 0x8646,
        [NativeName("Name", "GL_PROGRAM_RESIDENT_NV")]
        ProgramResidentNV = 0x8647,
        [NativeName("Name", "GL_TRACK_MATRIX_NV")]
        TrackMatrixNV = 0x8648,
        [NativeName("Name", "GL_TRACK_MATRIX_TRANSFORM_NV")]
        TrackMatrixTransformNV = 0x8649,
        [NativeName("Name", "GL_VERTEX_PROGRAM_BINDING_NV")]
        VertexProgramBindingNV = 0x864A,
        [NativeName("Name", "GL_PROGRAM_ERROR_POSITION_NV")]
        ProgramErrorPositionNV = 0x864B,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY0_NV")]
        VertexAttribArray0NV = 0x8650,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY1_NV")]
        VertexAttribArray1NV = 0x8651,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY2_NV")]
        VertexAttribArray2NV = 0x8652,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY3_NV")]
        VertexAttribArray3NV = 0x8653,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY4_NV")]
        VertexAttribArray4NV = 0x8654,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY5_NV")]
        VertexAttribArray5NV = 0x8655,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY6_NV")]
        VertexAttribArray6NV = 0x8656,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY7_NV")]
        VertexAttribArray7NV = 0x8657,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY8_NV")]
        VertexAttribArray8NV = 0x8658,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY9_NV")]
        VertexAttribArray9NV = 0x8659,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY10_NV")]
        VertexAttribArray10NV = 0x865A,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY11_NV")]
        VertexAttribArray11NV = 0x865B,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY12_NV")]
        VertexAttribArray12NV = 0x865C,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY13_NV")]
        VertexAttribArray13NV = 0x865D,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY14_NV")]
        VertexAttribArray14NV = 0x865E,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY15_NV")]
        VertexAttribArray15NV = 0x865F,
        [NativeName("Name", "GL_MAP1_VERTEX_ATTRIB0_4_NV")]
        Map1VertexAttrib04NV = 0x8660,
        [NativeName("Name", "GL_MAP1_VERTEX_ATTRIB1_4_NV")]
        Map1VertexAttrib14NV = 0x8661,
        [NativeName("Name", "GL_MAP1_VERTEX_ATTRIB2_4_NV")]
        Map1VertexAttrib24NV = 0x8662,
        [NativeName("Name", "GL_MAP1_VERTEX_ATTRIB3_4_NV")]
        Map1VertexAttrib34NV = 0x8663,
        [NativeName("Name", "GL_MAP1_VERTEX_ATTRIB4_4_NV")]
        Map1VertexAttrib44NV = 0x8664,
        [NativeName("Name", "GL_MAP1_VERTEX_ATTRIB5_4_NV")]
        Map1VertexAttrib54NV = 0x8665,
        [NativeName("Name", "GL_MAP1_VERTEX_ATTRIB6_4_NV")]
        Map1VertexAttrib64NV = 0x8666,
        [NativeName("Name", "GL_MAP1_VERTEX_ATTRIB7_4_NV")]
        Map1VertexAttrib74NV = 0x8667,
        [NativeName("Name", "GL_MAP1_VERTEX_ATTRIB8_4_NV")]
        Map1VertexAttrib84NV = 0x8668,
        [NativeName("Name", "GL_MAP1_VERTEX_ATTRIB9_4_NV")]
        Map1VertexAttrib94NV = 0x8669,
        [NativeName("Name", "GL_MAP1_VERTEX_ATTRIB10_4_NV")]
        Map1VertexAttrib104NV = 0x866A,
        [NativeName("Name", "GL_MAP1_VERTEX_ATTRIB11_4_NV")]
        Map1VertexAttrib114NV = 0x866B,
        [NativeName("Name", "GL_MAP1_VERTEX_ATTRIB12_4_NV")]
        Map1VertexAttrib124NV = 0x866C,
        [NativeName("Name", "GL_MAP1_VERTEX_ATTRIB13_4_NV")]
        Map1VertexAttrib134NV = 0x866D,
        [NativeName("Name", "GL_MAP1_VERTEX_ATTRIB14_4_NV")]
        Map1VertexAttrib144NV = 0x866E,
        [NativeName("Name", "GL_MAP1_VERTEX_ATTRIB15_4_NV")]
        Map1VertexAttrib154NV = 0x866F,
        [NativeName("Name", "GL_MAP2_VERTEX_ATTRIB0_4_NV")]
        Map2VertexAttrib04NV = 0x8670,
        [NativeName("Name", "GL_MAP2_VERTEX_ATTRIB1_4_NV")]
        Map2VertexAttrib14NV = 0x8671,
        [NativeName("Name", "GL_MAP2_VERTEX_ATTRIB2_4_NV")]
        Map2VertexAttrib24NV = 0x8672,
        [NativeName("Name", "GL_MAP2_VERTEX_ATTRIB3_4_NV")]
        Map2VertexAttrib34NV = 0x8673,
        [NativeName("Name", "GL_MAP2_VERTEX_ATTRIB4_4_NV")]
        Map2VertexAttrib44NV = 0x8674,
        [NativeName("Name", "GL_MAP2_VERTEX_ATTRIB5_4_NV")]
        Map2VertexAttrib54NV = 0x8675,
        [NativeName("Name", "GL_MAP2_VERTEX_ATTRIB6_4_NV")]
        Map2VertexAttrib64NV = 0x8676,
        [NativeName("Name", "GL_MAP2_VERTEX_ATTRIB7_4_NV")]
        Map2VertexAttrib74NV = 0x8677,
        [NativeName("Name", "GL_MAP2_VERTEX_ATTRIB8_4_NV")]
        Map2VertexAttrib84NV = 0x8678,
        [NativeName("Name", "GL_MAP2_VERTEX_ATTRIB9_4_NV")]
        Map2VertexAttrib94NV = 0x8679,
        [NativeName("Name", "GL_MAP2_VERTEX_ATTRIB10_4_NV")]
        Map2VertexAttrib104NV = 0x867A,
        [NativeName("Name", "GL_MAP2_VERTEX_ATTRIB11_4_NV")]
        Map2VertexAttrib114NV = 0x867B,
        [NativeName("Name", "GL_MAP2_VERTEX_ATTRIB12_4_NV")]
        Map2VertexAttrib124NV = 0x867C,
        [NativeName("Name", "GL_MAP2_VERTEX_ATTRIB13_4_NV")]
        Map2VertexAttrib134NV = 0x867D,
        [NativeName("Name", "GL_MAP2_VERTEX_ATTRIB14_4_NV")]
        Map2VertexAttrib144NV = 0x867E,
        [NativeName("Name", "GL_MAP2_VERTEX_ATTRIB15_4_NV")]
        Map2VertexAttrib154NV = 0x867F,
        [NativeName("Name", "GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB")]
        MaxVertexTextureImageUnitsArb = 0x8B4C,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_INTEGER_NV")]
        VertexAttribArrayIntegerNV = 0x88FD,
        [NativeName("Name", "GL_VIDEO_BUFFER_NV")]
        VideoBufferNV = 0x9020,
        [NativeName("Name", "GL_VIDEO_BUFFER_BINDING_NV")]
        VideoBufferBindingNV = 0x9021,
        [NativeName("Name", "GL_FIELD_UPPER_NV")]
        FieldUpperNV = 0x9022,
        [NativeName("Name", "GL_FIELD_LOWER_NV")]
        FieldLowerNV = 0x9023,
        [NativeName("Name", "GL_NUM_VIDEO_CAPTURE_STREAMS_NV")]
        NumVideoCaptureStreamsNV = 0x9024,
        [NativeName("Name", "GL_NEXT_VIDEO_CAPTURE_BUFFER_STATUS_NV")]
        NextVideoCaptureBufferStatusNV = 0x9025,
        [NativeName("Name", "GL_VIDEO_CAPTURE_TO_422_SUPPORTED_NV")]
        VideoCaptureTo422SupportedNV = 0x9026,
        [NativeName("Name", "GL_LAST_VIDEO_CAPTURE_STATUS_NV")]
        LastVideoCaptureStatusNV = 0x9027,
        [NativeName("Name", "GL_VIDEO_BUFFER_PITCH_NV")]
        VideoBufferPitchNV = 0x9028,
        [NativeName("Name", "GL_VIDEO_COLOR_CONVERSION_MATRIX_NV")]
        VideoColorConversionMatrixNV = 0x9029,
        [NativeName("Name", "GL_VIDEO_COLOR_CONVERSION_MAX_NV")]
        VideoColorConversionMaxNV = 0x902A,
        [NativeName("Name", "GL_VIDEO_COLOR_CONVERSION_MIN_NV")]
        VideoColorConversionMinNV = 0x902B,
        [NativeName("Name", "GL_VIDEO_COLOR_CONVERSION_OFFSET_NV")]
        VideoColorConversionOffsetNV = 0x902C,
        [NativeName("Name", "GL_VIDEO_BUFFER_INTERNAL_FORMAT_NV")]
        VideoBufferInternalFormatNV = 0x902D,
        [NativeName("Name", "GL_PARTIAL_SUCCESS_NV")]
        PartialSuccessNV = 0x902E,
        [NativeName("Name", "GL_SUCCESS_NV")]
        SuccessNV = 0x902F,
        [NativeName("Name", "GL_FAILURE_NV")]
        FailureNV = 0x9030,
        [NativeName("Name", "GL_YCBYCR8_422_NV")]
        Ycbycr8422NV = 0x9031,
        [NativeName("Name", "GL_YCBAYCR8A_4224_NV")]
        Ycbaycr8A4224NV = 0x9032,
        [NativeName("Name", "GL_Z6Y10Z6CB10Z6Y10Z6CR10_422_NV")]
        Z6Y10Z6CB10Z6Y10Z6CR10422NV = 0x9033,
        [NativeName("Name", "GL_Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A10_4224_NV")]
        Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A104224NV = 0x9034,
        [NativeName("Name", "GL_Z4Y12Z4CB12Z4Y12Z4CR12_422_NV")]
        Z4Y12Z4CB12Z4Y12Z4CR12422NV = 0x9035,
        [NativeName("Name", "GL_Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A12_4224_NV")]
        Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A124224NV = 0x9036,
        [NativeName("Name", "GL_Z4Y12Z4CB12Z4CR12_444_NV")]
        Z4Y12Z4CB12Z4CR12444NV = 0x9037,
        [NativeName("Name", "GL_VIDEO_CAPTURE_FRAME_WIDTH_NV")]
        VideoCaptureFrameWidthNV = 0x9038,
        [NativeName("Name", "GL_VIDEO_CAPTURE_FRAME_HEIGHT_NV")]
        VideoCaptureFrameHeightNV = 0x9039,
        [NativeName("Name", "GL_VIDEO_CAPTURE_FIELD_UPPER_HEIGHT_NV")]
        VideoCaptureFieldUpperHeightNV = 0x903A,
        [NativeName("Name", "GL_VIDEO_CAPTURE_FIELD_LOWER_HEIGHT_NV")]
        VideoCaptureFieldLowerHeightNV = 0x903B,
        [NativeName("Name", "GL_VIDEO_CAPTURE_SURFACE_ORIGIN_NV")]
        VideoCaptureSurfaceOriginNV = 0x903C,
        [NativeName("Name", "GL_VIEWPORT_SWIZZLE_POSITIVE_X_NV")]
        ViewportSwizzlePositiveXNV = 0x9350,
        [NativeName("Name", "GL_VIEWPORT_SWIZZLE_NEGATIVE_X_NV")]
        ViewportSwizzleNegativeXNV = 0x9351,
        [NativeName("Name", "GL_VIEWPORT_SWIZZLE_POSITIVE_Y_NV")]
        ViewportSwizzlePositiveYNV = 0x9352,
        [NativeName("Name", "GL_VIEWPORT_SWIZZLE_NEGATIVE_Y_NV")]
        ViewportSwizzleNegativeYNV = 0x9353,
        [NativeName("Name", "GL_VIEWPORT_SWIZZLE_POSITIVE_Z_NV")]
        ViewportSwizzlePositiveZNV = 0x9354,
        [NativeName("Name", "GL_VIEWPORT_SWIZZLE_NEGATIVE_Z_NV")]
        ViewportSwizzleNegativeZNV = 0x9355,
        [NativeName("Name", "GL_VIEWPORT_SWIZZLE_POSITIVE_W_NV")]
        ViewportSwizzlePositiveWNV = 0x9356,
        [NativeName("Name", "GL_VIEWPORT_SWIZZLE_NEGATIVE_W_NV")]
        ViewportSwizzleNegativeWNV = 0x9357,
        [NativeName("Name", "GL_VIEWPORT_SWIZZLE_X_NV")]
        ViewportSwizzleXNV = 0x9358,
        [NativeName("Name", "GL_VIEWPORT_SWIZZLE_Y_NV")]
        ViewportSwizzleYNV = 0x9359,
        [NativeName("Name", "GL_VIEWPORT_SWIZZLE_Z_NV")]
        ViewportSwizzleZNV = 0x935A,
        [NativeName("Name", "GL_VIEWPORT_SWIZZLE_W_NV")]
        ViewportSwizzleWNV = 0x935B,
    }
}
