// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [NativeName("Name", "GLenum")]
    public enum NV : int
    {
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
        [NativeName("Name", "GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_NV")]
        ConservativeRasterModePreSnapNV = 0x9550,
        [NativeName("Name", "GL_CONSERVATIVE_RASTER_MODE_NV")]
        ConservativeRasterModeNV = 0x954D,
        [NativeName("Name", "GL_CONSERVATIVE_RASTER_MODE_POST_SNAP_NV")]
        ConservativeRasterModePostSnapNV = 0x954E,
        [NativeName("Name", "GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_TRIANGLES_NV")]
        ConservativeRasterModePreSnapTrianglesNV = 0x954F,
        [NativeName("Name", "GL_COPY_READ_BUFFER_NV")]
        CopyReadBufferNV = 0x8F36,
        [NativeName("Name", "GL_COPY_WRITE_BUFFER_NV")]
        CopyWriteBufferNV = 0x8F37,
        [NativeName("Name", "GL_COVERAGE_COMPONENT_NV")]
        CoverageComponentNV = 0x8ED0,
        [NativeName("Name", "GL_COVERAGE_COMPONENT4_NV")]
        CoverageComponent4NV = 0x8ED1,
        [NativeName("Name", "GL_COVERAGE_ATTACHMENT_NV")]
        CoverageAttachmentNV = 0x8ED2,
        [NativeName("Name", "GL_COVERAGE_BUFFERS_NV")]
        CoverageBuffersNV = 0x8ED3,
        [NativeName("Name", "GL_COVERAGE_SAMPLES_NV")]
        CoverageSamplesNV = 0x8ED4,
        [NativeName("Name", "GL_COVERAGE_ALL_FRAGMENTS_NV")]
        CoverageAllFragmentsNV = 0x8ED5,
        [NativeName("Name", "GL_COVERAGE_EDGE_FRAGMENTS_NV")]
        CoverageEdgeFragmentsNV = 0x8ED6,
        [NativeName("Name", "GL_COVERAGE_AUTOMATIC_NV")]
        CoverageAutomaticNV = 0x8ED7,
        [NativeName("Name", "GL_COVERAGE_BUFFER_BIT_NV")]
        CoverageBufferBitNV = 0x8000,
        [NativeName("Name", "GL_DEPTH_COMPONENT16_NONLINEAR_NV")]
        DepthComponent16NonlinearNV = 0x8E2C,
        [NativeName("Name", "GL_MAX_DRAW_BUFFERS_NV")]
        MaxDrawBuffersNV = 0x8824,
        [NativeName("Name", "GL_DRAW_BUFFER0_NV")]
        DrawBuffer0NV = 0x8825,
        [NativeName("Name", "GL_DRAW_BUFFER1_NV")]
        DrawBuffer1NV = 0x8826,
        [NativeName("Name", "GL_DRAW_BUFFER2_NV")]
        DrawBuffer2NV = 0x8827,
        [NativeName("Name", "GL_DRAW_BUFFER3_NV")]
        DrawBuffer3NV = 0x8828,
        [NativeName("Name", "GL_DRAW_BUFFER4_NV")]
        DrawBuffer4NV = 0x8829,
        [NativeName("Name", "GL_DRAW_BUFFER5_NV")]
        DrawBuffer5NV = 0x882A,
        [NativeName("Name", "GL_DRAW_BUFFER6_NV")]
        DrawBuffer6NV = 0x882B,
        [NativeName("Name", "GL_DRAW_BUFFER7_NV")]
        DrawBuffer7NV = 0x882C,
        [NativeName("Name", "GL_DRAW_BUFFER8_NV")]
        DrawBuffer8NV = 0x882D,
        [NativeName("Name", "GL_DRAW_BUFFER9_NV")]
        DrawBuffer9NV = 0x882E,
        [NativeName("Name", "GL_DRAW_BUFFER10_NV")]
        DrawBuffer10NV = 0x882F,
        [NativeName("Name", "GL_DRAW_BUFFER11_NV")]
        DrawBuffer11NV = 0x8830,
        [NativeName("Name", "GL_DRAW_BUFFER12_NV")]
        DrawBuffer12NV = 0x8831,
        [NativeName("Name", "GL_DRAW_BUFFER13_NV")]
        DrawBuffer13NV = 0x8832,
        [NativeName("Name", "GL_DRAW_BUFFER14_NV")]
        DrawBuffer14NV = 0x8833,
        [NativeName("Name", "GL_DRAW_BUFFER15_NV")]
        DrawBuffer15NV = 0x8834,
        [NativeName("Name", "GL_COLOR_ATTACHMENT0_NV")]
        ColorAttachment0NV = 0x8CE0,
        [NativeName("Name", "GL_COLOR_ATTACHMENT1_NV")]
        ColorAttachment1NV = 0x8CE1,
        [NativeName("Name", "GL_COLOR_ATTACHMENT2_NV")]
        ColorAttachment2NV = 0x8CE2,
        [NativeName("Name", "GL_COLOR_ATTACHMENT3_NV")]
        ColorAttachment3NV = 0x8CE3,
        [NativeName("Name", "GL_COLOR_ATTACHMENT4_NV")]
        ColorAttachment4NV = 0x8CE4,
        [NativeName("Name", "GL_COLOR_ATTACHMENT5_NV")]
        ColorAttachment5NV = 0x8CE5,
        [NativeName("Name", "GL_COLOR_ATTACHMENT6_NV")]
        ColorAttachment6NV = 0x8CE6,
        [NativeName("Name", "GL_COLOR_ATTACHMENT7_NV")]
        ColorAttachment7NV = 0x8CE7,
        [NativeName("Name", "GL_COLOR_ATTACHMENT8_NV")]
        ColorAttachment8NV = 0x8CE8,
        [NativeName("Name", "GL_COLOR_ATTACHMENT9_NV")]
        ColorAttachment9NV = 0x8CE9,
        [NativeName("Name", "GL_COLOR_ATTACHMENT10_NV")]
        ColorAttachment10NV = 0x8CEA,
        [NativeName("Name", "GL_COLOR_ATTACHMENT11_NV")]
        ColorAttachment11NV = 0x8CEB,
        [NativeName("Name", "GL_COLOR_ATTACHMENT12_NV")]
        ColorAttachment12NV = 0x8CEC,
        [NativeName("Name", "GL_COLOR_ATTACHMENT13_NV")]
        ColorAttachment13NV = 0x8CED,
        [NativeName("Name", "GL_COLOR_ATTACHMENT14_NV")]
        ColorAttachment14NV = 0x8CEE,
        [NativeName("Name", "GL_COLOR_ATTACHMENT15_NV")]
        ColorAttachment15NV = 0x8CEF,
        [NativeName("Name", "GL_MAX_COLOR_ATTACHMENTS_NV")]
        MaxColorAttachmentsNV = 0x8CDF,
        [NativeName("Name", "GL_ALL_COMPLETED_NV")]
        AllCompletedNV = 0x84F2,
        [NativeName("Name", "GL_FENCE_STATUS_NV")]
        FenceStatusNV = 0x84F3,
        [NativeName("Name", "GL_FENCE_CONDITION_NV")]
        FenceConditionNV = 0x84F4,
        [NativeName("Name", "GL_FILL_RECTANGLE_NV")]
        FillRectangleNV = 0x933C,
        [NativeName("Name", "GL_FRAGMENT_COVERAGE_TO_COLOR_NV")]
        FragmentCoverageToColorNV = 0x92DD,
        [NativeName("Name", "GL_FRAGMENT_COVERAGE_COLOR_NV")]
        FragmentCoverageColorNV = 0x92DE,
        [NativeName("Name", "GL_READ_FRAMEBUFFER_NV")]
        ReadFramebufferNV = 0x8CA8,
        [NativeName("Name", "GL_DRAW_FRAMEBUFFER_NV")]
        DrawFramebufferNV = 0x8CA9,
        [NativeName("Name", "GL_DRAW_FRAMEBUFFER_BINDING_NV")]
        DrawFramebufferBindingNV = 0x8CA6,
        [NativeName("Name", "GL_READ_FRAMEBUFFER_BINDING_NV")]
        ReadFramebufferBindingNV = 0x8CAA,
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
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_NV")]
        RenderbufferSamplesNV = 0x8CAB,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_NV")]
        FramebufferIncompleteMultisampleNV = 0x8D56,
        [NativeName("Name", "GL_MAX_SAMPLES_NV")]
        MaxSamplesNV = 0x8D57,
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
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_DIVISOR_NV")]
        VertexAttribArrayDivisorNV = 0x88FE,
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
        [NativeName("Name", "GL_FLOAT_MAT2x3_NV")]
        FloatMat2x3NV = 0x8B65,
        [NativeName("Name", "GL_FLOAT_MAT2x4_NV")]
        FloatMat2x4NV = 0x8B66,
        [NativeName("Name", "GL_FLOAT_MAT3x2_NV")]
        FloatMat3x2NV = 0x8B67,
        [NativeName("Name", "GL_FLOAT_MAT3x4_NV")]
        FloatMat3x4NV = 0x8B68,
        [NativeName("Name", "GL_FLOAT_MAT4x2_NV")]
        FloatMat4x2NV = 0x8B69,
        [NativeName("Name", "GL_FLOAT_MAT4x3_NV")]
        FloatMat4x3NV = 0x8B6A,
        [NativeName("Name", "GL_PACK_ROW_LENGTH_NV")]
        PackRowLengthNV = 0xD02,
        [NativeName("Name", "GL_PACK_SKIP_ROWS_NV")]
        PackSkipRowsNV = 0xD03,
        [NativeName("Name", "GL_PACK_SKIP_PIXELS_NV")]
        PackSkipPixelsNV = 0xD04,
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
        [NativeName("Name", "GL_PIXEL_PACK_BUFFER_NV")]
        PixelPackBufferNV = 0x88EB,
        [NativeName("Name", "GL_PIXEL_UNPACK_BUFFER_NV")]
        PixelUnpackBufferNV = 0x88EC,
        [NativeName("Name", "GL_PIXEL_PACK_BUFFER_BINDING_NV")]
        PixelPackBufferBindingNV = 0x88ED,
        [NativeName("Name", "GL_PIXEL_UNPACK_BUFFER_BINDING_NV")]
        PixelUnpackBufferBindingNV = 0x88EF,
        [NativeName("Name", "GL_POLYGON_MODE_NV")]
        PolygonModeNV = 0xB40,
        [NativeName("Name", "GL_POLYGON_OFFSET_POINT_NV")]
        PolygonOffsetPointNV = 0x2A01,
        [NativeName("Name", "GL_POLYGON_OFFSET_LINE_NV")]
        PolygonOffsetLineNV = 0x2A02,
        [NativeName("Name", "GL_POINT_NV")]
        PointNV = 0x1B00,
        [NativeName("Name", "GL_LINE_NV")]
        LineNV = 0x1B01,
        [NativeName("Name", "GL_FILL_NV")]
        FillNV = 0x1B02,
        [NativeName("Name", "GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV")]
        ShadingRateImagePerPrimitiveNV = 0x95B1,
        [NativeName("Name", "GL_SHADING_RATE_IMAGE_PALETTE_COUNT_NV")]
        ShadingRateImagePaletteCountNV = 0x95B2,
        [NativeName("Name", "GL_READ_BUFFER_NV")]
        ReadBufferNV = 0xC02,
        [NativeName("Name", "GL_REPRESENTATIVE_FRAGMENT_TEST_NV")]
        RepresentativeFragmentTestNV = 0x937F,
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
        [NativeName("Name", "GL_SUBGROUP_FEATURE_PARTITIONED_BIT_NV")]
        SubgroupFeaturePartitionedBitNV = 0x100,
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
        [NativeName("Name", "GL_SAMPLER_2D_ARRAY_SHADOW_NV")]
        Sampler2DArrayShadowNV = 0x8DC4,
        [NativeName("Name", "GL_SAMPLER_CUBE_SHADOW_NV")]
        SamplerCubeShadowNV = 0x8DC5,
        [NativeName("Name", "GL_SLUMINANCE_NV")]
        SluminanceNV = 0x8C46,
        [NativeName("Name", "GL_SLUMINANCE_ALPHA_NV")]
        SluminanceAlphaNV = 0x8C44,
        [NativeName("Name", "GL_SRGB8_NV")]
        Srgb8NV = 0x8C41,
        [NativeName("Name", "GL_SLUMINANCE8_NV")]
        Sluminance8NV = 0x8C47,
        [NativeName("Name", "GL_SLUMINANCE8_ALPHA8_NV")]
        Sluminance8Alpha8NV = 0x8C45,
        [NativeName("Name", "GL_COMPRESSED_SRGB_S3TC_DXT1_NV")]
        CompressedSrgbS3TCDxt1NV = 0x8C4C,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV")]
        CompressedSrgbAlphaS3TCDxt1NV = 0x8C4D,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV")]
        CompressedSrgbAlphaS3TCDxt3NV = 0x8C4E,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV")]
        CompressedSrgbAlphaS3TCDxt5NV = 0x8C4F,
        [NativeName("Name", "GL_ETC1_SRGB8_NV")]
        Etc1Srgb8NV = 0x88EE,
        [NativeName("Name", "GL_TEXTURE_BORDER_COLOR_NV")]
        TextureBorderColorNV = 0x1004,
        [NativeName("Name", "GL_CLAMP_TO_BORDER_NV")]
        ClampToBorderNV = 0x812D,
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
        [NativeName("Name", "GL_MAX_VIEWPORTS_NV")]
        MaxViewportsNV = 0x825B,
        [NativeName("Name", "GL_VIEWPORT_SUBPIXEL_BITS_NV")]
        ViewportSubpixelBitsNV = 0x825C,
        [NativeName("Name", "GL_VIEWPORT_BOUNDS_RANGE_NV")]
        ViewportBoundsRangeNV = 0x825D,
        [NativeName("Name", "GL_VIEWPORT_INDEX_PROVOKING_VERTEX_NV")]
        ViewportIndexProvokingVertexNV = 0x825F,
        [NativeName("Name", "GL_SCISSOR_BOX")]
        ScissorBox = 0xC10,
        [NativeName("Name", "GL_VIEWPORT")]
        Viewport = 0xBA2,
        [NativeName("Name", "GL_DEPTH_RANGE")]
        DepthRange = 0xB70,
        [NativeName("Name", "GL_SCISSOR_TEST")]
        ScissorTest = 0xC11,
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
