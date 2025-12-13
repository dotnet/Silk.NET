// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [NativeName("Name", "GLenum")]
    public enum EXT : int
    {
        [NativeName("Name", "GL_SRC1_COLOR_EXT")]
        Src1ColorExt = 0x88F9,
        [NativeName("Name", "GL_SRC1_ALPHA_EXT")]
        Src1AlphaExt = 0x8589,
        [NativeName("Name", "GL_ONE_MINUS_SRC1_COLOR_EXT")]
        OneMinusSrc1ColorExt = 0x88FA,
        [NativeName("Name", "GL_ONE_MINUS_SRC1_ALPHA_EXT")]
        OneMinusSrc1AlphaExt = 0x88FB,
        [NativeName("Name", "GL_SRC_ALPHA_SATURATE_EXT")]
        SrcAlphaSaturateExt = 0x308,
        [NativeName("Name", "GL_LOCATION_INDEX_EXT")]
        LocationIndexExt = 0x930F,
        [NativeName("Name", "GL_MAX_DUAL_SOURCE_DRAW_BUFFERS_EXT")]
        MaxDualSourceDrawBuffersExt = 0x88FC,
        [NativeName("Name", "GL_MIN_EXT")]
        MinExt = 0x8007,
        [NativeName("Name", "GL_MAX_EXT")]
        MaxExt = 0x8008,
        [NativeName("Name", "GL_MAP_READ_BIT")]
        MapReadBit = 0x1,
        [NativeName("Name", "GL_MAP_WRITE_BIT")]
        MapWriteBit = 0x2,
        [NativeName("Name", "GL_MAP_PERSISTENT_BIT_EXT")]
        MapPersistentBitExt = 0x40,
        [NativeName("Name", "GL_MAP_COHERENT_BIT_EXT")]
        MapCoherentBitExt = 0x80,
        [NativeName("Name", "GL_DYNAMIC_STORAGE_BIT_EXT")]
        DynamicStorageBitExt = 0x100,
        [NativeName("Name", "GL_CLIENT_STORAGE_BIT_EXT")]
        ClientStorageBitExt = 0x200,
        [NativeName("Name", "GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT")]
        ClientMappedBufferBarrierBitExt = 0x4000,
        [NativeName("Name", "GL_BUFFER_IMMUTABLE_STORAGE_EXT")]
        BufferImmutableStorageExt = 0x821F,
        [NativeName("Name", "GL_BUFFER_STORAGE_FLAGS_EXT")]
        BufferStorageFlagsExt = 0x8220,
        [NativeName("Name", "GL_LOWER_LEFT_EXT")]
        LowerLeftExt = 0x8CA1,
        [NativeName("Name", "GL_UPPER_LEFT_EXT")]
        UpperLeftExt = 0x8CA2,
        [NativeName("Name", "GL_NEGATIVE_ONE_TO_ONE_EXT")]
        NegativeOneToOneExt = 0x935E,
        [NativeName("Name", "GL_ZERO_TO_ONE_EXT")]
        ZeroToOneExt = 0x935F,
        [NativeName("Name", "GL_CLIP_ORIGIN_EXT")]
        ClipOriginExt = 0x935C,
        [NativeName("Name", "GL_CLIP_DEPTH_MODE_EXT")]
        ClipDepthModeExt = 0x935D,
        [NativeName("Name", "GL_MAX_CLIP_DISTANCES_EXT")]
        MaxClipDistancesExt = 0xD32,
        [NativeName("Name", "GL_MAX_CULL_DISTANCES_EXT")]
        MaxCullDistancesExt = 0x82F9,
        [NativeName("Name", "GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES_EXT")]
        MaxCombinedClipAndCullDistancesExt = 0x82FA,
        [NativeName("Name", "GL_CLIP_DISTANCE0_EXT")]
        ClipDistance0Ext = 0x3000,
        [NativeName("Name", "GL_CLIP_DISTANCE1_EXT")]
        ClipDistance1Ext = 0x3001,
        [NativeName("Name", "GL_CLIP_DISTANCE2_EXT")]
        ClipDistance2Ext = 0x3002,
        [NativeName("Name", "GL_CLIP_DISTANCE3_EXT")]
        ClipDistance3Ext = 0x3003,
        [NativeName("Name", "GL_CLIP_DISTANCE4_EXT")]
        ClipDistance4Ext = 0x3004,
        [NativeName("Name", "GL_CLIP_DISTANCE5_EXT")]
        ClipDistance5Ext = 0x3005,
        [NativeName("Name", "GL_CLIP_DISTANCE6_EXT")]
        ClipDistance6Ext = 0x3006,
        [NativeName("Name", "GL_CLIP_DISTANCE7_EXT")]
        ClipDistance7Ext = 0x3007,
        [NativeName("Name", "GL_RGBA16F_EXT")]
        Rgba16fExt = 0x881A,
        [NativeName("Name", "GL_RGB16F_EXT")]
        Rgb16fExt = 0x881B,
        [NativeName("Name", "GL_RG16F_EXT")]
        RG16fExt = 0x822F,
        [NativeName("Name", "GL_R16F_EXT")]
        R16fExt = 0x822D,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT")]
        FramebufferAttachmentComponentTypeExt = 0x8211,
        [NativeName("Name", "GL_UNSIGNED_NORMALIZED_EXT")]
        UnsignedNormalizedExt = 0x8C17,
        [NativeName("Name", "GL_PROGRAM_PIPELINE_OBJECT_EXT")]
        ProgramPipelineObjectExt = 0x8A4F,
        [NativeName("Name", "GL_PROGRAM_OBJECT_EXT")]
        ProgramObjectExt = 0x8B40,
        [NativeName("Name", "GL_SHADER_OBJECT_EXT")]
        ShaderObjectExt = 0x8B48,
        [NativeName("Name", "GL_BUFFER_OBJECT_EXT")]
        BufferObjectExt = 0x9151,
        [NativeName("Name", "GL_QUERY_OBJECT_EXT")]
        QueryObjectExt = 0x9153,
        [NativeName("Name", "GL_VERTEX_ARRAY_OBJECT_EXT")]
        VertexArrayObjectExt = 0x9154,
        [NativeName("Name", "GL_SAMPLER")]
        Sampler = 0x82E6,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK")]
        TransformFeedback = 0x8E22,
        [NativeName("Name", "GL_DEPTH_CLAMP_EXT")]
        DepthClampExt = 0x864F,
        [NativeName("Name", "GL_COLOR_EXT")]
        ColorExt = 0x1800,
        [NativeName("Name", "GL_DEPTH_EXT")]
        DepthExt = 0x1801,
        [NativeName("Name", "GL_STENCIL_EXT")]
        StencilExt = 0x1802,
        [NativeName("Name", "GL_QUERY_COUNTER_BITS_EXT")]
        QueryCounterBitsExt = 0x8864,
        [NativeName("Name", "GL_CURRENT_QUERY_EXT")]
        CurrentQueryExt = 0x8865,
        [NativeName("Name", "GL_QUERY_RESULT_EXT")]
        QueryResultExt = 0x8866,
        [NativeName("Name", "GL_QUERY_RESULT_AVAILABLE_EXT")]
        QueryResultAvailableExt = 0x8867,
        [NativeName("Name", "GL_TIME_ELAPSED_EXT")]
        TimeElapsedExt = 0x88BF,
        [NativeName("Name", "GL_TIMESTAMP_EXT")]
        TimestampExt = 0x8E28,
        [NativeName("Name", "GL_GPU_DISJOINT_EXT")]
        GpuDisjointExt = 0x8FBB,
        [NativeName("Name", "GL_MAX_COLOR_ATTACHMENTS_EXT")]
        MaxColorAttachmentsExt = 0x8CDF,
        [NativeName("Name", "GL_MAX_DRAW_BUFFERS_EXT")]
        MaxDrawBuffersExt = 0x8824,
        [NativeName("Name", "GL_DRAW_BUFFER0_EXT")]
        DrawBuffer0Ext = 0x8825,
        [NativeName("Name", "GL_DRAW_BUFFER1_EXT")]
        DrawBuffer1Ext = 0x8826,
        [NativeName("Name", "GL_DRAW_BUFFER2_EXT")]
        DrawBuffer2Ext = 0x8827,
        [NativeName("Name", "GL_DRAW_BUFFER3_EXT")]
        DrawBuffer3Ext = 0x8828,
        [NativeName("Name", "GL_DRAW_BUFFER4_EXT")]
        DrawBuffer4Ext = 0x8829,
        [NativeName("Name", "GL_DRAW_BUFFER5_EXT")]
        DrawBuffer5Ext = 0x882A,
        [NativeName("Name", "GL_DRAW_BUFFER6_EXT")]
        DrawBuffer6Ext = 0x882B,
        [NativeName("Name", "GL_DRAW_BUFFER7_EXT")]
        DrawBuffer7Ext = 0x882C,
        [NativeName("Name", "GL_DRAW_BUFFER8_EXT")]
        DrawBuffer8Ext = 0x882D,
        [NativeName("Name", "GL_DRAW_BUFFER9_EXT")]
        DrawBuffer9Ext = 0x882E,
        [NativeName("Name", "GL_DRAW_BUFFER10_EXT")]
        DrawBuffer10Ext = 0x882F,
        [NativeName("Name", "GL_DRAW_BUFFER11_EXT")]
        DrawBuffer11Ext = 0x8830,
        [NativeName("Name", "GL_DRAW_BUFFER12_EXT")]
        DrawBuffer12Ext = 0x8831,
        [NativeName("Name", "GL_DRAW_BUFFER13_EXT")]
        DrawBuffer13Ext = 0x8832,
        [NativeName("Name", "GL_DRAW_BUFFER14_EXT")]
        DrawBuffer14Ext = 0x8833,
        [NativeName("Name", "GL_DRAW_BUFFER15_EXT")]
        DrawBuffer15Ext = 0x8834,
        [NativeName("Name", "GL_COLOR_ATTACHMENT0_EXT")]
        ColorAttachment0Ext = 0x8CE0,
        [NativeName("Name", "GL_COLOR_ATTACHMENT1_EXT")]
        ColorAttachment1Ext = 0x8CE1,
        [NativeName("Name", "GL_COLOR_ATTACHMENT2_EXT")]
        ColorAttachment2Ext = 0x8CE2,
        [NativeName("Name", "GL_COLOR_ATTACHMENT3_EXT")]
        ColorAttachment3Ext = 0x8CE3,
        [NativeName("Name", "GL_COLOR_ATTACHMENT4_EXT")]
        ColorAttachment4Ext = 0x8CE4,
        [NativeName("Name", "GL_COLOR_ATTACHMENT5_EXT")]
        ColorAttachment5Ext = 0x8CE5,
        [NativeName("Name", "GL_COLOR_ATTACHMENT6_EXT")]
        ColorAttachment6Ext = 0x8CE6,
        [NativeName("Name", "GL_COLOR_ATTACHMENT7_EXT")]
        ColorAttachment7Ext = 0x8CE7,
        [NativeName("Name", "GL_COLOR_ATTACHMENT8_EXT")]
        ColorAttachment8Ext = 0x8CE8,
        [NativeName("Name", "GL_COLOR_ATTACHMENT9_EXT")]
        ColorAttachment9Ext = 0x8CE9,
        [NativeName("Name", "GL_COLOR_ATTACHMENT10_EXT")]
        ColorAttachment10Ext = 0x8CEA,
        [NativeName("Name", "GL_COLOR_ATTACHMENT11_EXT")]
        ColorAttachment11Ext = 0x8CEB,
        [NativeName("Name", "GL_COLOR_ATTACHMENT12_EXT")]
        ColorAttachment12Ext = 0x8CEC,
        [NativeName("Name", "GL_COLOR_ATTACHMENT13_EXT")]
        ColorAttachment13Ext = 0x8CED,
        [NativeName("Name", "GL_COLOR_ATTACHMENT14_EXT")]
        ColorAttachment14Ext = 0x8CEE,
        [NativeName("Name", "GL_COLOR_ATTACHMENT15_EXT")]
        ColorAttachment15Ext = 0x8CEF,
        [NativeName("Name", "GL_BLEND_EQUATION_RGB")]
        BlendEquationRgb = 0x8009,
        [NativeName("Name", "GL_BLEND_EQUATION_ALPHA")]
        BlendEquationAlpha = 0x883D,
        [NativeName("Name", "GL_BLEND_SRC_RGB")]
        BlendSrcRgb = 0x80C9,
        [NativeName("Name", "GL_BLEND_SRC_ALPHA")]
        BlendSrcAlpha = 0x80CB,
        [NativeName("Name", "GL_BLEND_DST_RGB")]
        BlendDstRgb = 0x80C8,
        [NativeName("Name", "GL_BLEND_DST_ALPHA")]
        BlendDstAlpha = 0x80CA,
        [NativeName("Name", "GL_COLOR_WRITEMASK")]
        ColorWritemask = 0xC23,
        [NativeName("Name", "GL_BLEND")]
        Blend = 0xBE2,
        [NativeName("Name", "GL_FUNC_ADD")]
        FuncAdd = 0x8006,
        [NativeName("Name", "GL_FUNC_SUBTRACT")]
        FuncSubtract = 0x800A,
        [NativeName("Name", "GL_FUNC_REVERSE_SUBTRACT")]
        FuncReverseSubtract = 0x800B,
        [NativeName("Name", "GL_MIN")]
        Min = 0x8007,
        [NativeName("Name", "GL_MAX")]
        Max = 0x8008,
        [NativeName("Name", "GL_ZERO")]
        Zero = 0x0,
        [NativeName("Name", "GL_ONE")]
        One = 0x1,
        [NativeName("Name", "GL_SRC_COLOR")]
        SrcColor = 0x300,
        [NativeName("Name", "GL_ONE_MINUS_SRC_COLOR")]
        OneMinusSrcColor = 0x301,
        [NativeName("Name", "GL_DST_COLOR")]
        DstColor = 0x306,
        [NativeName("Name", "GL_ONE_MINUS_DST_COLOR")]
        OneMinusDstColor = 0x307,
        [NativeName("Name", "GL_SRC_ALPHA")]
        SrcAlpha = 0x302,
        [NativeName("Name", "GL_ONE_MINUS_SRC_ALPHA")]
        OneMinusSrcAlpha = 0x303,
        [NativeName("Name", "GL_DST_ALPHA")]
        DstAlpha = 0x304,
        [NativeName("Name", "GL_ONE_MINUS_DST_ALPHA")]
        OneMinusDstAlpha = 0x305,
        [NativeName("Name", "GL_CONSTANT_COLOR")]
        ConstantColor = 0x8001,
        [NativeName("Name", "GL_ONE_MINUS_CONSTANT_COLOR")]
        OneMinusConstantColor = 0x8002,
        [NativeName("Name", "GL_CONSTANT_ALPHA")]
        ConstantAlpha = 0x8003,
        [NativeName("Name", "GL_ONE_MINUS_CONSTANT_ALPHA")]
        OneMinusConstantAlpha = 0x8004,
        [NativeName("Name", "GL_SRC_ALPHA_SATURATE")]
        SrcAlphaSaturate = 0x308,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_EXT")]
        SurfaceCompressionExt = 0x96C0,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_NONE_EXT")]
        SurfaceCompressionFixedRateNoneExt = 0x96C1,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_DEFAULT_EXT")]
        SurfaceCompressionFixedRateDefaultExt = 0x96C2,
        [NativeName("Name", "GL_SHADING_RATE_1X1_PIXELS_EXT")]
        ShadingRate1X1PixelsExt = 0x96A6,
        [NativeName("Name", "GL_SHADING_RATE_1X2_PIXELS_EXT")]
        ShadingRate1X2PixelsExt = 0x96A7,
        [NativeName("Name", "GL_SHADING_RATE_2X1_PIXELS_EXT")]
        ShadingRate2X1PixelsExt = 0x96A8,
        [NativeName("Name", "GL_SHADING_RATE_2X2_PIXELS_EXT")]
        ShadingRate2X2PixelsExt = 0x96A9,
        [NativeName("Name", "GL_SHADING_RATE_1X4_PIXELS_EXT")]
        ShadingRate1X4PixelsExt = 0x96AA,
        [NativeName("Name", "GL_SHADING_RATE_4X1_PIXELS_EXT")]
        ShadingRate4X1PixelsExt = 0x96AB,
        [NativeName("Name", "GL_SHADING_RATE_4X2_PIXELS_EXT")]
        ShadingRate4X2PixelsExt = 0x96AC,
        [NativeName("Name", "GL_SHADING_RATE_2X4_PIXELS_EXT")]
        ShadingRate2X4PixelsExt = 0x96AD,
        [NativeName("Name", "GL_SHADING_RATE_4X4_PIXELS_EXT")]
        ShadingRate4X4PixelsExt = 0x96AE,
        [NativeName("Name", "GL_SHADING_RATE_EXT")]
        ShadingRateExt = 0x96D0,
        [NativeName("Name", "GL_SHADING_RATE_ATTACHMENT_EXT")]
        ShadingRateAttachmentExt = 0x96D1,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_COMBINER_OP_KEEP_EXT")]
        FragmentShadingRateCombinerOpKeepExt = 0x96D2,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_COMBINER_OP_REPLACE_EXT")]
        FragmentShadingRateCombinerOpReplaceExt = 0x96D3,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MIN_EXT")]
        FragmentShadingRateCombinerOpMinExt = 0x96D4,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MAX_EXT")]
        FragmentShadingRateCombinerOpMaxExt = 0x96D5,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_EXT")]
        FragmentShadingRateCombinerOpMulExt = 0x96D6,
        [NativeName("Name", "GL_MIN_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_WIDTH_EXT")]
        MinFragmentShadingRateAttachmentTexelWidthExt = 0x96D7,
        [NativeName("Name", "GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_WIDTH_EXT")]
        MaxFragmentShadingRateAttachmentTexelWidthExt = 0x96D8,
        [NativeName("Name", "GL_MIN_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_HEIGHT_EXT")]
        MinFragmentShadingRateAttachmentTexelHeightExt = 0x96D9,
        [NativeName("Name", "GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_HEIGHT_EXT")]
        MaxFragmentShadingRateAttachmentTexelHeightExt = 0x96DA,
        [NativeName("Name", "GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_TEXEL_ASPECT_RATIO_EXT")]
        MaxFragmentShadingRateAttachmentTexelAspectRatioExt = 0x96DB,
        [NativeName("Name", "GL_MAX_FRAGMENT_SHADING_RATE_ATTACHMENT_LAYERS_EXT")]
        MaxFragmentShadingRateAttachmentLayersExt = 0x96DC,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_WITH_SHADER_DEPTH_STENCIL_WRITES_SUPPORTED_EXT")]
        FragmentShadingRateWithShaderDepthStencilWritesSupportedExt = 0x96DD,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_WITH_SAMPLE_MASK_SUPPORTED_EXT")]
        FragmentShadingRateWithSampleMaskSupportedExt = 0x96DE,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_ATTACHMENT_WITH_DEFAULT_FRAMEBUFFER_SUPPORTED_EXT")]
        FragmentShadingRateAttachmentWithDefaultFramebufferSupportedExt = 0x96DF,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_NON_TRIVIAL_COMBINERS_SUPPORTED_EXT")]
        FragmentShadingRateNonTrivialCombinersSupportedExt = 0x8F6F,
        [NativeName("Name", "GL_GEOMETRY_SHADER_EXT")]
        GeometryShaderExt = 0x8DD9,
        [NativeName("Name", "GL_GEOMETRY_SHADER_BIT_EXT")]
        GeometryShaderBitExt = 0x4,
        [NativeName("Name", "GL_GEOMETRY_LINKED_VERTICES_OUT_EXT")]
        GeometryLinkedVerticesOutExt = 0x8916,
        [NativeName("Name", "GL_GEOMETRY_LINKED_INPUT_TYPE_EXT")]
        GeometryLinkedInputTypeExt = 0x8917,
        [NativeName("Name", "GL_GEOMETRY_LINKED_OUTPUT_TYPE_EXT")]
        GeometryLinkedOutputTypeExt = 0x8918,
        [NativeName("Name", "GL_GEOMETRY_SHADER_INVOCATIONS_EXT")]
        GeometryShaderInvocationsExt = 0x887F,
        [NativeName("Name", "GL_LAYER_PROVOKING_VERTEX_EXT")]
        LayerProvokingVertexExt = 0x825E,
        [NativeName("Name", "GL_LINES_ADJACENCY_EXT")]
        LinesAdjacencyExt = 0xA,
        [NativeName("Name", "GL_LINE_STRIP_ADJACENCY_EXT")]
        LineStripAdjacencyExt = 0xB,
        [NativeName("Name", "GL_TRIANGLES_ADJACENCY_EXT")]
        TrianglesAdjacencyExt = 0xC,
        [NativeName("Name", "GL_TRIANGLE_STRIP_ADJACENCY_EXT")]
        TriangleStripAdjacencyExt = 0xD,
        [NativeName("Name", "GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT")]
        MaxGeometryUniformComponentsExt = 0x8DDF,
        [NativeName("Name", "GL_MAX_GEOMETRY_UNIFORM_BLOCKS_EXT")]
        MaxGeometryUniformBlocksExt = 0x8A2C,
        [NativeName("Name", "GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_EXT")]
        MaxCombinedGeometryUniformComponentsExt = 0x8A32,
        [NativeName("Name", "GL_MAX_GEOMETRY_INPUT_COMPONENTS_EXT")]
        MaxGeometryInputComponentsExt = 0x9123,
        [NativeName("Name", "GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_EXT")]
        MaxGeometryOutputComponentsExt = 0x9124,
        [NativeName("Name", "GL_MAX_GEOMETRY_OUTPUT_VERTICES_EXT")]
        MaxGeometryOutputVerticesExt = 0x8DE0,
        [NativeName("Name", "GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT")]
        MaxGeometryTotalOutputComponentsExt = 0x8DE1,
        [NativeName("Name", "GL_MAX_GEOMETRY_SHADER_INVOCATIONS_EXT")]
        MaxGeometryShaderInvocationsExt = 0x8E5A,
        [NativeName("Name", "GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT")]
        MaxGeometryTextureImageUnitsExt = 0x8C29,
        [NativeName("Name", "GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_EXT")]
        MaxGeometryAtomicCounterBuffersExt = 0x92CF,
        [NativeName("Name", "GL_MAX_GEOMETRY_ATOMIC_COUNTERS_EXT")]
        MaxGeometryAtomicCountersExt = 0x92D5,
        [NativeName("Name", "GL_MAX_GEOMETRY_IMAGE_UNIFORMS_EXT")]
        MaxGeometryImageUniformsExt = 0x90CD,
        [NativeName("Name", "GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_EXT")]
        MaxGeometryShaderStorageBlocksExt = 0x90D7,
        [NativeName("Name", "GL_FIRST_VERTEX_CONVENTION_EXT")]
        FirstVertexConventionExt = 0x8E4D,
        [NativeName("Name", "GL_LAST_VERTEX_CONVENTION_EXT")]
        LastVertexConventionExt = 0x8E4E,
        [NativeName("Name", "GL_UNDEFINED_VERTEX_EXT")]
        UndefinedVertexExt = 0x8260,
        [NativeName("Name", "GL_PRIMITIVES_GENERATED_EXT")]
        PrimitivesGeneratedExt = 0x8C87,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_LAYERS_EXT")]
        FramebufferDefaultLayersExt = 0x9312,
        [NativeName("Name", "GL_MAX_FRAMEBUFFER_LAYERS_EXT")]
        MaxFramebufferLayersExt = 0x9317,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT")]
        FramebufferIncompleteLayerTargetsExt = 0x8DA8,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT")]
        FramebufferAttachmentLayeredExt = 0x8DA7,
        [NativeName("Name", "GL_REFERENCED_BY_GEOMETRY_SHADER_EXT")]
        ReferencedByGeometryShaderExt = 0x9309,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_DIVISOR_EXT")]
        VertexAttribArrayDivisorExt = 0x88FE,
        [NativeName("Name", "GL_MAP_READ_BIT_EXT")]
        MapReadBitExt = 0x1,
        [NativeName("Name", "GL_MAP_WRITE_BIT_EXT")]
        MapWriteBitExt = 0x2,
        [NativeName("Name", "GL_MAP_INVALIDATE_RANGE_BIT_EXT")]
        MapInvalidateRangeBitExt = 0x4,
        [NativeName("Name", "GL_MAP_INVALIDATE_BUFFER_BIT_EXT")]
        MapInvalidateBufferBitExt = 0x8,
        [NativeName("Name", "GL_MAP_FLUSH_EXPLICIT_BIT_EXT")]
        MapFlushExplicitBitExt = 0x10,
        [NativeName("Name", "GL_MAP_UNSYNCHRONIZED_BIT_EXT")]
        MapUnsynchronizedBitExt = 0x20,
        [NativeName("Name", "GL_TEXTURE_TILING_EXT")]
        TextureTilingExt = 0x9580,
        [NativeName("Name", "GL_DEDICATED_MEMORY_OBJECT_EXT")]
        DedicatedMemoryObjectExt = 0x9581,
        [NativeName("Name", "GL_PROTECTED_MEMORY_OBJECT_EXT")]
        ProtectedMemoryObjectExt = 0x959B,
        [NativeName("Name", "GL_NUM_TILING_TYPES_EXT")]
        NumTilingTypesExt = 0x9582,
        [NativeName("Name", "GL_TILING_TYPES_EXT")]
        TilingTypesExt = 0x9583,
        [NativeName("Name", "GL_OPTIMAL_TILING_EXT")]
        OptimalTilingExt = 0x9584,
        [NativeName("Name", "GL_LINEAR_TILING_EXT")]
        LinearTilingExt = 0x9585,
        [NativeName("Name", "GL_NUM_DEVICE_UUIDS_EXT")]
        NumDeviceUuidsExt = 0x9596,
        [NativeName("Name", "GL_DEVICE_UUID_EXT")]
        DeviceUuidExt = 0x9597,
        [NativeName("Name", "GL_DRIVER_UUID_EXT")]
        DriverUuidExt = 0x9598,
        [NativeName("Name", "GL_UUID_SIZE_EXT")]
        UuidSizeExt = 0x16,
        [NativeName("Name", "GL_HANDLE_TYPE_OPAQUE_FD_EXT")]
        HandleTypeOpaqueFDExt = 0x9586,
        [NativeName("Name", "GL_HANDLE_TYPE_OPAQUE_WIN32_EXT")]
        HandleTypeOpaqueWin32Ext = 0x9587,
        [NativeName("Name", "GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT")]
        HandleTypeOpaqueWin32KmtExt = 0x9588,
        [NativeName("Name", "GL_DEVICE_LUID_EXT")]
        DeviceLuidExt = 0x9599,
        [NativeName("Name", "GL_DEVICE_NODE_MASK_EXT")]
        DeviceNodeMaskExt = 0x959A,
        [NativeName("Name", "GL_LUID_SIZE_EXT")]
        LuidSizeExt = 0x8,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT")]
        HandleTypeD3D12TilepoolExt = 0x9589,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D12_RESOURCE_EXT")]
        HandleTypeD3D12ResourceExt = 0x958A,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D11_IMAGE_EXT")]
        HandleTypeD3D11ImageExt = 0x958B,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT")]
        HandleTypeD3D11ImageKmtExt = 0x958C,
        [NativeName("Name", "GL_MESH_SHADER_EXT")]
        MeshShaderExt = 0x9559,
        [NativeName("Name", "GL_TASK_SHADER_EXT")]
        TaskShaderExt = 0x955A,
        [NativeName("Name", "GL_MAX_MESH_UNIFORM_BLOCKS_EXT")]
        MaxMeshUniformBlocksExt = 0x8E60,
        [NativeName("Name", "GL_MAX_MESH_TEXTURE_IMAGE_UNITS_EXT")]
        MaxMeshTextureImageUnitsExt = 0x8E61,
        [NativeName("Name", "GL_MAX_MESH_IMAGE_UNIFORMS_EXT")]
        MaxMeshImageUniformsExt = 0x8E62,
        [NativeName("Name", "GL_MAX_MESH_UNIFORM_COMPONENTS_EXT")]
        MaxMeshUniformComponentsExt = 0x8E63,
        [NativeName("Name", "GL_MAX_MESH_ATOMIC_COUNTER_BUFFERS_EXT")]
        MaxMeshAtomicCounterBuffersExt = 0x8E64,
        [NativeName("Name", "GL_MAX_MESH_ATOMIC_COUNTERS_EXT")]
        MaxMeshAtomicCountersExt = 0x8E65,
        [NativeName("Name", "GL_MAX_MESH_SHADER_STORAGE_BLOCKS_EXT")]
        MaxMeshShaderStorageBlocksExt = 0x8E66,
        [NativeName("Name", "GL_MAX_COMBINED_MESH_UNIFORM_COMPONENTS_EXT")]
        MaxCombinedMeshUniformComponentsExt = 0x8E67,
        [NativeName("Name", "GL_MAX_TASK_UNIFORM_BLOCKS_EXT")]
        MaxTaskUniformBlocksExt = 0x8E68,
        [NativeName("Name", "GL_MAX_TASK_TEXTURE_IMAGE_UNITS_EXT")]
        MaxTaskTextureImageUnitsExt = 0x8E69,
        [NativeName("Name", "GL_MAX_TASK_IMAGE_UNIFORMS_EXT")]
        MaxTaskImageUniformsExt = 0x8E6A,
        [NativeName("Name", "GL_MAX_TASK_UNIFORM_COMPONENTS_EXT")]
        MaxTaskUniformComponentsExt = 0x8E6B,
        [NativeName("Name", "GL_MAX_TASK_ATOMIC_COUNTER_BUFFERS_EXT")]
        MaxTaskAtomicCounterBuffersExt = 0x8E6C,
        [NativeName("Name", "GL_MAX_TASK_ATOMIC_COUNTERS_EXT")]
        MaxTaskAtomicCountersExt = 0x8E6D,
        [NativeName("Name", "GL_MAX_TASK_SHADER_STORAGE_BLOCKS_EXT")]
        MaxTaskShaderStorageBlocksExt = 0x8E6E,
        [NativeName("Name", "GL_MAX_COMBINED_TASK_UNIFORM_COMPONENTS_EXT")]
        MaxCombinedTaskUniformComponentsExt = 0x8E6F,
        [NativeName("Name", "GL_MAX_TASK_WORK_GROUP_TOTAL_COUNT_EXT")]
        MaxTaskWorkGroupTotalCountExt = 0x9740,
        [NativeName("Name", "GL_MAX_MESH_WORK_GROUP_TOTAL_COUNT_EXT")]
        MaxMeshWorkGroupTotalCountExt = 0x9741,
        [NativeName("Name", "GL_MAX_MESH_WORK_GROUP_INVOCATIONS_EXT")]
        MaxMeshWorkGroupInvocationsExt = 0x9757,
        [NativeName("Name", "GL_MAX_TASK_WORK_GROUP_INVOCATIONS_EXT")]
        MaxTaskWorkGroupInvocationsExt = 0x9759,
        [NativeName("Name", "GL_MAX_TASK_PAYLOAD_SIZE_EXT")]
        MaxTaskPayloadSizeExt = 0x9742,
        [NativeName("Name", "GL_MAX_TASK_SHARED_MEMORY_SIZE_EXT")]
        MaxTaskSharedMemorySizeExt = 0x9743,
        [NativeName("Name", "GL_MAX_MESH_SHARED_MEMORY_SIZE_EXT")]
        MaxMeshSharedMemorySizeExt = 0x9744,
        [NativeName("Name", "GL_MAX_TASK_PAYLOAD_AND_SHARED_MEMORY_SIZE_EXT")]
        MaxTaskPayloadAndSharedMemorySizeExt = 0x9745,
        [NativeName("Name", "GL_MAX_MESH_PAYLOAD_AND_SHARED_MEMORY_SIZE_EXT")]
        MaxMeshPayloadAndSharedMemorySizeExt = 0x9746,
        [NativeName("Name", "GL_MAX_MESH_OUTPUT_MEMORY_SIZE_EXT")]
        MaxMeshOutputMemorySizeExt = 0x9747,
        [NativeName("Name", "GL_MAX_MESH_PAYLOAD_AND_OUTPUT_MEMORY_SIZE_EXT")]
        MaxMeshPayloadAndOutputMemorySizeExt = 0x9748,
        [NativeName("Name", "GL_MAX_MESH_OUTPUT_VERTICES_EXT")]
        MaxMeshOutputVerticesExt = 0x9538,
        [NativeName("Name", "GL_MAX_MESH_OUTPUT_PRIMITIVES_EXT")]
        MaxMeshOutputPrimitivesExt = 0x9756,
        [NativeName("Name", "GL_MAX_MESH_OUTPUT_COMPONENTS_EXT")]
        MaxMeshOutputComponentsExt = 0x9749,
        [NativeName("Name", "GL_MAX_MESH_OUTPUT_LAYERS_EXT")]
        MaxMeshOutputLayersExt = 0x974A,
        [NativeName("Name", "GL_MAX_MESH_MULTIVIEW_VIEW_COUNT_EXT")]
        MaxMeshMultiviewViewCountExt = 0x9557,
        [NativeName("Name", "GL_MESH_OUTPUT_PER_VERTEX_GRANULARITY_EXT")]
        MeshOutputPerVertexGranularityExt = 0x92DF,
        [NativeName("Name", "GL_MESH_OUTPUT_PER_PRIMITIVE_GRANULARITY_EXT")]
        MeshOutputPerPrimitiveGranularityExt = 0x9543,
        [NativeName("Name", "GL_MAX_PREFERRED_TASK_WORK_GROUP_INVOCATIONS_EXT")]
        MaxPreferredTaskWorkGroupInvocationsExt = 0x974B,
        [NativeName("Name", "GL_MAX_PREFERRED_MESH_WORK_GROUP_INVOCATIONS_EXT")]
        MaxPreferredMeshWorkGroupInvocationsExt = 0x974C,
        [NativeName("Name", "GL_MESH_PREFERS_LOCAL_INVOCATION_VERTEX_OUTPUT_EXT")]
        MeshPrefersLocalInvocationVertexOutputExt = 0x974D,
        [NativeName("Name", "GL_MESH_PREFERS_LOCAL_INVOCATION_PRIMITIVE_OUTPUT_EXT")]
        MeshPrefersLocalInvocationPrimitiveOutputExt = 0x974E,
        [NativeName("Name", "GL_MESH_PREFERS_COMPACT_VERTEX_OUTPUT_EXT")]
        MeshPrefersCompactVertexOutputExt = 0x974F,
        [NativeName("Name", "GL_MESH_PREFERS_COMPACT_PRIMITIVE_OUTPUT_EXT")]
        MeshPrefersCompactPrimitiveOutputExt = 0x9750,
        [NativeName("Name", "GL_MAX_TASK_WORK_GROUP_COUNT_EXT")]
        MaxTaskWorkGroupCountExt = 0x9751,
        [NativeName("Name", "GL_MAX_MESH_WORK_GROUP_COUNT_EXT")]
        MaxMeshWorkGroupCountExt = 0x9752,
        [NativeName("Name", "GL_MAX_MESH_WORK_GROUP_SIZE_EXT")]
        MaxMeshWorkGroupSizeExt = 0x9758,
        [NativeName("Name", "GL_MAX_TASK_WORK_GROUP_SIZE_EXT")]
        MaxTaskWorkGroupSizeExt = 0x975A,
        [NativeName("Name", "GL_MESH_WORK_GROUP_SIZE_EXT")]
        MeshWorkGroupSizeExt = 0x953E,
        [NativeName("Name", "GL_TASK_WORK_GROUP_SIZE_EXT")]
        TaskWorkGroupSizeExt = 0x953F,
        [NativeName("Name", "GL_MESH_VERTICES_OUT_EXT")]
        MeshVerticesOutExt = 0x9579,
        [NativeName("Name", "GL_MESH_PRIMITIVES_OUT_EXT")]
        MeshPrimitivesOutExt = 0x957A,
        [NativeName("Name", "GL_MESH_OUTPUT_TYPE_EXT")]
        MeshOutputTypeExt = 0x957B,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_MESH_SHADER_EXT")]
        UniformBlockReferencedByMeshShaderExt = 0x959C,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_TASK_SHADER_EXT")]
        UniformBlockReferencedByTaskShaderExt = 0x959D,
        [NativeName("Name", "GL_REFERENCED_BY_MESH_SHADER_EXT")]
        ReferencedByMeshShaderExt = 0x95A0,
        [NativeName("Name", "GL_REFERENCED_BY_TASK_SHADER_EXT")]
        ReferencedByTaskShaderExt = 0x95A1,
        [NativeName("Name", "GL_TASK_SHADER_INVOCATIONS_EXT")]
        TaskShaderInvocationsExt = 0x9753,
        [NativeName("Name", "GL_MESH_SHADER_INVOCATIONS_EXT")]
        MeshShaderInvocationsExt = 0x9754,
        [NativeName("Name", "GL_MESH_PRIMITIVES_GENERATED_EXT")]
        MeshPrimitivesGeneratedExt = 0x9755,
        [NativeName("Name", "GL_MESH_SHADER_BIT_EXT")]
        MeshShaderBitExt = 0x40,
        [NativeName("Name", "GL_TASK_SHADER_BIT_EXT")]
        TaskShaderBitExt = 0x80,
        [NativeName("Name", "GL_MESH_SUBROUTINE_EXT")]
        MeshSubroutineExt = 0x957C,
        [NativeName("Name", "GL_TASK_SUBROUTINE_EXT")]
        TaskSubroutineExt = 0x957D,
        [NativeName("Name", "GL_MESH_SUBROUTINE_UNIFORM_EXT")]
        MeshSubroutineUniformExt = 0x957E,
        [NativeName("Name", "GL_TASK_SUBROUTINE_UNIFORM_EXT")]
        TaskSubroutineUniformExt = 0x957F,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_MESH_SHADER_EXT")]
        AtomicCounterBufferReferencedByMeshShaderExt = 0x959E,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TASK_SHADER_EXT")]
        AtomicCounterBufferReferencedByTaskShaderExt = 0x959F,
        [NativeName("Name", "GL_MULTISAMPLE_EXT")]
        MultisampleExt = 0x809D,
        [NativeName("Name", "GL_SAMPLE_ALPHA_TO_ONE_EXT")]
        SampleAlphaToOneExt = 0x809F,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT")]
        FramebufferAttachmentTextureSamplesExt = 0x8D6C,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_EXT")]
        RenderbufferSamplesExt = 0x8CAB,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT")]
        FramebufferIncompleteMultisampleExt = 0x8D56,
        [NativeName("Name", "GL_MAX_SAMPLES_EXT")]
        MaxSamplesExt = 0x8D57,
        [NativeName("Name", "GL_COLOR_ATTACHMENT_EXT")]
        ColorAttachmentExt = 0x90F0,
        [NativeName("Name", "GL_MULTIVIEW_EXT")]
        MultiviewExt = 0x90F1,
        [NativeName("Name", "GL_DRAW_BUFFER_EXT")]
        DrawBufferExt = 0xC01,
        [NativeName("Name", "GL_READ_BUFFER_EXT")]
        ReadBufferExt = 0xC02,
        [NativeName("Name", "GL_MAX_MULTIVIEW_BUFFERS_EXT")]
        MaxMultiviewBuffersExt = 0x90F2,
        [NativeName("Name", "GL_ANY_SAMPLES_PASSED_EXT")]
        AnySamplesPassedExt = 0x8C2F,
        [NativeName("Name", "GL_ANY_SAMPLES_PASSED_CONSERVATIVE_EXT")]
        AnySamplesPassedConservativeExt = 0x8D6A,
        [NativeName("Name", "GL_POLYGON_OFFSET_CLAMP_EXT")]
        PolygonOffsetClampExt = 0x8E1B,
        [NativeName("Name", "GL_PRIMITIVE_BOUNDING_BOX_EXT")]
        PrimitiveBoundingBoxExt = 0x92BE,
        [NativeName("Name", "GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT")]
        ContextFlagProtectedContentBitExt = 0x10,
        [NativeName("Name", "GL_TEXTURE_PROTECTED_EXT")]
        TextureProtectedExt = 0x8BFA,
        [NativeName("Name", "GL_COMPRESSED_SRGB_PVRTC_2BPPV1_EXT")]
        CompressedSrgbPvrtc2Bppv1Ext = 0x8A54,
        [NativeName("Name", "GL_COMPRESSED_SRGB_PVRTC_4BPPV1_EXT")]
        CompressedSrgbPvrtc4Bppv1Ext = 0x8A55,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV1_EXT")]
        CompressedSrgbAlphaPvrtc2Bppv1Ext = 0x8A56,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV1_EXT")]
        CompressedSrgbAlphaPvrtc4Bppv1Ext = 0x8A57,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV2_IMG")]
        CompressedSrgbAlphaPvrtc2Bppv2Img = 0x93F0,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV2_IMG")]
        CompressedSrgbAlphaPvrtc4Bppv2Img = 0x93F1,
        [NativeName("Name", "GL_RASTER_MULTISAMPLE_EXT")]
        RasterMultisampleExt = 0x9327,
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
        [NativeName("Name", "GL_BGRA_EXT")]
        BgraExt = 0x80E1,
        [NativeName("Name", "GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT")]
        UnsignedShort4444RevExt = 0x8365,
        [NativeName("Name", "GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT")]
        UnsignedShort1555RevExt = 0x8366,
        [NativeName("Name", "GL_BYTE")]
        Byte = 0x1400,
        [NativeName("Name", "GL_SHORT")]
        Short = 0x1402,
        [NativeName("Name", "GL_R8_SNORM")]
        R8SNorm = 0x8F94,
        [NativeName("Name", "GL_RG8_SNORM")]
        RG8SNorm = 0x8F95,
        [NativeName("Name", "GL_RGBA8_SNORM")]
        Rgba8SNorm = 0x8F97,
        [NativeName("Name", "GL_R16_SNORM_EXT")]
        R16SNormExt = 0x8F98,
        [NativeName("Name", "GL_RG16_SNORM_EXT")]
        RG16SNormExt = 0x8F99,
        [NativeName("Name", "GL_RGBA16_SNORM_EXT")]
        Rgba16SNormExt = 0x8F9B,
        [NativeName("Name", "GL_NO_ERROR")]
        NoError = 0x0,
        [NativeName("Name", "GL_GUILTY_CONTEXT_RESET_EXT")]
        GuiltyContextResetExt = 0x8253,
        [NativeName("Name", "GL_INNOCENT_CONTEXT_RESET_EXT")]
        InnocentContextResetExt = 0x8254,
        [NativeName("Name", "GL_UNKNOWN_CONTEXT_RESET_EXT")]
        UnknownContextResetExt = 0x8255,
        [NativeName("Name", "GL_CONTEXT_ROBUST_ACCESS_EXT")]
        ContextRobustAccessExt = 0x90F3,
        [NativeName("Name", "GL_RESET_NOTIFICATION_STRATEGY_EXT")]
        ResetNotificationStrategyExt = 0x8256,
        [NativeName("Name", "GL_LOSE_CONTEXT_ON_RESET_EXT")]
        LoseContextOnResetExt = 0x8252,
        [NativeName("Name", "GL_NO_RESET_NOTIFICATION_EXT")]
        NoResetNotificationExt = 0x8261,
        [NativeName("Name", "GL_LAYOUT_GENERAL_EXT")]
        LayoutGeneralExt = 0x958D,
        [NativeName("Name", "GL_LAYOUT_COLOR_ATTACHMENT_EXT")]
        LayoutColorAttachmentExt = 0x958E,
        [NativeName("Name", "GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT")]
        LayoutDepthStencilAttachmentExt = 0x958F,
        [NativeName("Name", "GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT")]
        LayoutDepthStencilReadOnlyExt = 0x9590,
        [NativeName("Name", "GL_LAYOUT_SHADER_READ_ONLY_EXT")]
        LayoutShaderReadOnlyExt = 0x9591,
        [NativeName("Name", "GL_LAYOUT_TRANSFER_SRC_EXT")]
        LayoutTransferSrcExt = 0x9592,
        [NativeName("Name", "GL_LAYOUT_TRANSFER_DST_EXT")]
        LayoutTransferDstExt = 0x9593,
        [NativeName("Name", "GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT")]
        LayoutDepthReadOnlyStencilAttachmentExt = 0x9530,
        [NativeName("Name", "GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT")]
        LayoutDepthAttachmentStencilReadOnlyExt = 0x9531,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D12_FENCE_EXT")]
        HandleTypeD3D12FenceExt = 0x9594,
        [NativeName("Name", "GL_D3D12_FENCE_VALUE_EXT")]
        D3D12FenceValueExt = 0x9595,
        [NativeName("Name", "GL_VERTEX_SHADER_BIT_EXT")]
        VertexShaderBitExt = 0x1,
        [NativeName("Name", "GL_FRAGMENT_SHADER_BIT_EXT")]
        FragmentShaderBitExt = 0x2,
        [NativeName("Name", "GL_ALL_SHADER_BITS_EXT")]
        AllShaderBitsExt = unchecked((int)0xFFFFFFFF),
        [NativeName("Name", "GL_PROGRAM_SEPARABLE_EXT")]
        ProgramSeparableExt = 0x8258,
        [NativeName("Name", "GL_ACTIVE_PROGRAM_EXT")]
        ActiveProgramExt = 0x8259,
        [NativeName("Name", "GL_PROGRAM_PIPELINE_BINDING_EXT")]
        ProgramPipelineBindingExt = 0x825A,
        [NativeName("Name", "GL_FRAGMENT_SHADER_DISCARDS_SAMPLES_EXT")]
        FragmentShaderDiscardsSamplesExt = 0x8A52,
        [NativeName("Name", "GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_FAST_SIZE_EXT")]
        MaxShaderPixelLocalStorageFastSizeExt = 0x8F63,
        [NativeName("Name", "GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_SIZE_EXT")]
        MaxShaderPixelLocalStorageSizeExt = 0x8F67,
        [NativeName("Name", "GL_SHADER_PIXEL_LOCAL_STORAGE_EXT")]
        ShaderPixelLocalStorageExt = 0x8F64,
        [NativeName("Name", "GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_FAST_SIZE_EXT")]
        MaxShaderCombinedLocalStorageFastSizeExt = 0x9650,
        [NativeName("Name", "GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_SIZE_EXT")]
        MaxShaderCombinedLocalStorageSizeExt = 0x9651,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_INSUFFICIENT_SHADER_COMBINED_LOCAL_STORAGE_EXT")]
        FramebufferIncompleteInsufficientShaderCombinedLocalStorageExt = 0x9652,
        [NativeName("Name", "GL_TEXTURE_COMPARE_MODE_EXT")]
        TextureCompareModeExt = 0x884C,
        [NativeName("Name", "GL_TEXTURE_COMPARE_FUNC_EXT")]
        TextureCompareFuncExt = 0x884D,
        [NativeName("Name", "GL_COMPARE_REF_TO_TEXTURE_EXT")]
        CompareRefToTextureExt = 0x884E,
        [NativeName("Name", "GL_SAMPLER_2D_SHADOW_EXT")]
        Sampler2DShadowExt = 0x8B62,
        [NativeName("Name", "GL_TEXTURE_SPARSE_EXT")]
        TextureSparseExt = 0x91A6,
        [NativeName("Name", "GL_VIRTUAL_PAGE_SIZE_INDEX_EXT")]
        VirtualPageSizeIndexExt = 0x91A7,
        [NativeName("Name", "GL_NUM_SPARSE_LEVELS_EXT")]
        NumSparseLevelsExt = 0x91AA,
        [NativeName("Name", "GL_NUM_VIRTUAL_PAGE_SIZES_EXT")]
        NumVirtualPageSizesExt = 0x91A8,
        [NativeName("Name", "GL_VIRTUAL_PAGE_SIZE_X_EXT")]
        VirtualPageSizeXExt = 0x9195,
        [NativeName("Name", "GL_VIRTUAL_PAGE_SIZE_Y_EXT")]
        VirtualPageSizeYExt = 0x9196,
        [NativeName("Name", "GL_VIRTUAL_PAGE_SIZE_Z_EXT")]
        VirtualPageSizeZExt = 0x9197,
        [NativeName("Name", "GL_TEXTURE_2D")]
        Texture2D = 0xDE1,
        [NativeName("Name", "GL_TEXTURE_2D_ARRAY")]
        Texture2DArray = 0x8C1A,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP")]
        TextureCubeMap = 0x8513,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_ARRAY_OES")]
        TextureCubeMapArrayOes = 0x9009,
        [NativeName("Name", "GL_TEXTURE_3D")]
        Texture3D = 0x806F,
        [NativeName("Name", "GL_MAX_SPARSE_TEXTURE_SIZE_EXT")]
        MaxSparseTextureSizeExt = 0x9198,
        [NativeName("Name", "GL_MAX_SPARSE_3D_TEXTURE_SIZE_EXT")]
        MaxSparse3DTextureSizeExt = 0x9199,
        [NativeName("Name", "GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_EXT")]
        MaxSparseArrayTextureLayersExt = 0x919A,
        [NativeName("Name", "GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_EXT")]
        SparseTextureFullArrayCubeMipmapsExt = 0x91A9,
        [NativeName("Name", "GL_SRGB_EXT")]
        SrgbExt = 0x8C40,
        [NativeName("Name", "GL_SRGB_ALPHA_EXT")]
        SrgbAlphaExt = 0x8C42,
        [NativeName("Name", "GL_SRGB8_ALPHA8_EXT")]
        Srgb8Alpha8Ext = 0x8C43,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT")]
        FramebufferAttachmentColorEncodingExt = 0x8210,
        [NativeName("Name", "GL_FRAMEBUFFER_SRGB_EXT")]
        FramebufferSrgbExt = 0x8DB9,
        [NativeName("Name", "GL_PATCHES_EXT")]
        PatchesExt = 0xE,
        [NativeName("Name", "GL_PATCH_VERTICES_EXT")]
        PatchVerticesExt = 0x8E72,
        [NativeName("Name", "GL_TESS_CONTROL_OUTPUT_VERTICES_EXT")]
        TessControlOutputVerticesExt = 0x8E75,
        [NativeName("Name", "GL_TESS_GEN_MODE_EXT")]
        TessGenModeExt = 0x8E76,
        [NativeName("Name", "GL_TESS_GEN_SPACING_EXT")]
        TessGenSpacingExt = 0x8E77,
        [NativeName("Name", "GL_TESS_GEN_VERTEX_ORDER_EXT")]
        TessGenVertexOrderExt = 0x8E78,
        [NativeName("Name", "GL_TESS_GEN_POINT_MODE_EXT")]
        TessGenPointModeExt = 0x8E79,
        [NativeName("Name", "GL_TRIANGLES")]
        Triangles = 0x4,
        [NativeName("Name", "GL_ISOLINES_EXT")]
        IsolinesExt = 0x8E7A,
        [NativeName("Name", "GL_QUADS_EXT")]
        QuadsExt = 0x7,
        [NativeName("Name", "GL_EQUAL")]
        Equal = 0x202,
        [NativeName("Name", "GL_FRACTIONAL_ODD_EXT")]
        FractionalOddExt = 0x8E7B,
        [NativeName("Name", "GL_FRACTIONAL_EVEN_EXT")]
        FractionalEvenExt = 0x8E7C,
        [NativeName("Name", "GL_CCW")]
        Ccw = 0x901,
        [NativeName("Name", "GL_CW")]
        CW = 0x900,
        [NativeName("Name", "GL_MAX_PATCH_VERTICES_EXT")]
        MaxPatchVerticesExt = 0x8E7D,
        [NativeName("Name", "GL_MAX_TESS_GEN_LEVEL_EXT")]
        MaxTessGenLevelExt = 0x8E7E,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS_EXT")]
        MaxTessControlUniformComponentsExt = 0x8E7F,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT")]
        MaxTessEvaluationUniformComponentsExt = 0x8E80,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_EXT")]
        MaxTessControlTextureImageUnitsExt = 0x8E81,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_EXT")]
        MaxTessEvaluationTextureImageUnitsExt = 0x8E82,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS_EXT")]
        MaxTessControlOutputComponentsExt = 0x8E83,
        [NativeName("Name", "GL_MAX_TESS_PATCH_COMPONENTS_EXT")]
        MaxTessPatchComponentsExt = 0x8E84,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_EXT")]
        MaxTessControlTotalOutputComponentsExt = 0x8E85,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_EXT")]
        MaxTessEvaluationOutputComponentsExt = 0x8E86,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS_EXT")]
        MaxTessControlUniformBlocksExt = 0x8E89,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS_EXT")]
        MaxTessEvaluationUniformBlocksExt = 0x8E8A,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_INPUT_COMPONENTS_EXT")]
        MaxTessControlInputComponentsExt = 0x886C,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS_EXT")]
        MaxTessEvaluationInputComponentsExt = 0x886D,
        [NativeName("Name", "GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_EXT")]
        MaxCombinedTessControlUniformComponentsExt = 0x8E1E,
        [NativeName("Name", "GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT")]
        MaxCombinedTessEvaluationUniformComponentsExt = 0x8E1F,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_EXT")]
        MaxTessControlAtomicCounterBuffersExt = 0x92CD,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_EXT")]
        MaxTessEvaluationAtomicCounterBuffersExt = 0x92CE,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_EXT")]
        MaxTessControlAtomicCountersExt = 0x92D3,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_EXT")]
        MaxTessEvaluationAtomicCountersExt = 0x92D4,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_EXT")]
        MaxTessControlImageUniformsExt = 0x90CB,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_EXT")]
        MaxTessEvaluationImageUniformsExt = 0x90CC,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_EXT")]
        MaxTessControlShaderStorageBlocksExt = 0x90D8,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_EXT")]
        MaxTessEvaluationShaderStorageBlocksExt = 0x90D9,
        [NativeName("Name", "GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED")]
        PrimitiveRestartForPatchesSupported = 0x8221,
        [NativeName("Name", "GL_IS_PER_PATCH_EXT")]
        IsPerPatchExt = 0x92E7,
        [NativeName("Name", "GL_REFERENCED_BY_TESS_CONTROL_SHADER_EXT")]
        ReferencedByTessControlShaderExt = 0x9307,
        [NativeName("Name", "GL_REFERENCED_BY_TESS_EVALUATION_SHADER_EXT")]
        ReferencedByTessEvaluationShaderExt = 0x9308,
        [NativeName("Name", "GL_TESS_CONTROL_SHADER_EXT")]
        TessControlShaderExt = 0x8E88,
        [NativeName("Name", "GL_TESS_EVALUATION_SHADER_EXT")]
        TessEvaluationShaderExt = 0x8E87,
        [NativeName("Name", "GL_TESS_CONTROL_SHADER_BIT_EXT")]
        TessControlShaderBitExt = 0x8,
        [NativeName("Name", "GL_TESS_EVALUATION_SHADER_BIT_EXT")]
        TessEvaluationShaderBitExt = 0x10,
        [NativeName("Name", "GL_TEXTURE_BORDER_COLOR_EXT")]
        TextureBorderColorExt = 0x1004,
        [NativeName("Name", "GL_CLAMP_TO_BORDER_EXT")]
        ClampToBorderExt = 0x812D,
        [NativeName("Name", "GL_TEXTURE_BUFFER_EXT")]
        TextureBufferExt = 0x8C2A,
        [NativeName("Name", "GL_TEXTURE_BUFFER_BINDING_EXT")]
        TextureBufferBindingExt = 0x8C2A,
        [NativeName("Name", "GL_MAX_TEXTURE_BUFFER_SIZE_EXT")]
        MaxTextureBufferSizeExt = 0x8C2B,
        [NativeName("Name", "GL_TEXTURE_BINDING_BUFFER_EXT")]
        TextureBindingBufferExt = 0x8C2C,
        [NativeName("Name", "GL_TEXTURE_BUFFER_DATA_STORE_BINDING_EXT")]
        TextureBufferDataStoreBindingExt = 0x8C2D,
        [NativeName("Name", "GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_EXT")]
        TextureBufferOffsetAlignmentExt = 0x919F,
        [NativeName("Name", "GL_SAMPLER_BUFFER_EXT")]
        SamplerBufferExt = 0x8DC2,
        [NativeName("Name", "GL_INT_SAMPLER_BUFFER_EXT")]
        IntSamplerBufferExt = 0x8DD0,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_BUFFER_EXT")]
        UnsignedIntSamplerBufferExt = 0x8DD8,
        [NativeName("Name", "GL_IMAGE_BUFFER_EXT")]
        ImageBufferExt = 0x9051,
        [NativeName("Name", "GL_INT_IMAGE_BUFFER_EXT")]
        IntImageBufferExt = 0x905C,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_BUFFER_EXT")]
        UnsignedIntImageBufferExt = 0x9067,
        [NativeName("Name", "GL_TEXTURE_BUFFER_OFFSET_EXT")]
        TextureBufferOffsetExt = 0x919D,
        [NativeName("Name", "GL_TEXTURE_BUFFER_SIZE_EXT")]
        TextureBufferSizeExt = 0x919E,
        [NativeName("Name", "GL_TEXTURE_ASTC_DECODE_PRECISION_EXT")]
        TextureAstcDecodePrecisionExt = 0x8F69,
        [NativeName("Name", "GL_COMPRESSED_RGBA_BPTC_UNORM_EXT")]
        CompressedRgbaBptcUnormExt = 0x8E8C,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT")]
        CompressedSrgbAlphaBptcUnormExt = 0x8E8D,
        [NativeName("Name", "GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT")]
        CompressedRgbBptcSignedFloatExt = 0x8E8E,
        [NativeName("Name", "GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT")]
        CompressedRgbBptcUnsignedFloatExt = 0x8E8F,
        [NativeName("Name", "GL_COMPRESSED_RGB_S3TC_DXT1_EXT")]
        CompressedRgbS3TCDxt1Ext = 0x83F0,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT1_EXT")]
        CompressedRgbaS3TCDxt1Ext = 0x83F1,
        [NativeName("Name", "GL_COMPRESSED_RED_RGTC1_EXT")]
        CompressedRedRgtc1Ext = 0x8DBB,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_RED_RGTC1_EXT")]
        CompressedSignedRedRgtc1Ext = 0x8DBC,
        [NativeName("Name", "GL_COMPRESSED_RED_GREEN_RGTC2_EXT")]
        CompressedRedGreenRgtc2Ext = 0x8DBD,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT")]
        CompressedSignedRedGreenRgtc2Ext = 0x8DBE,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT3_EXT")]
        CompressedRgbaS3TCDxt3Ext = 0x83F2,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT5_EXT")]
        CompressedRgbaS3TCDxt5Ext = 0x83F3,
        [NativeName("Name", "GL_COMPRESSED_SRGB_S3TC_DXT1_EXT")]
        CompressedSrgbS3TCDxt1Ext = 0x8C4C,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT")]
        CompressedSrgbAlphaS3TCDxt1Ext = 0x8C4D,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT")]
        CompressedSrgbAlphaS3TCDxt3Ext = 0x8C4E,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT")]
        CompressedSrgbAlphaS3TCDxt5Ext = 0x8C4F,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_ARRAY_EXT")]
        TextureCubeMapArrayExt = 0x9009,
        [NativeName("Name", "GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_EXT")]
        TextureBindingCubeMapArrayExt = 0x900A,
        [NativeName("Name", "GL_SAMPLER_CUBE_MAP_ARRAY_EXT")]
        SamplerCubeMapArrayExt = 0x900C,
        [NativeName("Name", "GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_EXT")]
        SamplerCubeMapArrayShadowExt = 0x900D,
        [NativeName("Name", "GL_INT_SAMPLER_CUBE_MAP_ARRAY_EXT")]
        IntSamplerCubeMapArrayExt = 0x900E,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_EXT")]
        UnsignedIntSamplerCubeMapArrayExt = 0x900F,
        [NativeName("Name", "GL_IMAGE_CUBE_MAP_ARRAY_EXT")]
        ImageCubeMapArrayExt = 0x9054,
        [NativeName("Name", "GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT")]
        IntImageCubeMapArrayExt = 0x905F,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT")]
        UnsignedIntImageCubeMapArrayExt = 0x906A,
        [NativeName("Name", "GL_TEXTURE_MAX_ANISOTROPY_EXT")]
        TextureMaxAnisotropyExt = 0x84FE,
        [NativeName("Name", "GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT")]
        MaxTextureMaxAnisotropyExt = 0x84FF,
        [NativeName("Name", "GL_TEXTURE_REDUCTION_MODE_EXT")]
        TextureReductionModeExt = 0x9366,
        [NativeName("Name", "GL_WEIGHTED_AVERAGE_EXT")]
        WeightedAverageExt = 0x9367,
        [NativeName("Name", "GL_TEXTURE_FORMAT_SRGB_OVERRIDE_EXT")]
        TextureFormatSrgbOverrideExt = 0x8FBF,
        [NativeName("Name", "GL_MIRROR_CLAMP_TO_EDGE_EXT")]
        MirrorClampToEdgeExt = 0x8743,
        [NativeName("Name", "GL_R16_EXT")]
        R16Ext = 0x822A,
        [NativeName("Name", "GL_RG16_EXT")]
        RG16Ext = 0x822C,
        [NativeName("Name", "GL_RGBA16_EXT")]
        Rgba16Ext = 0x805B,
        [NativeName("Name", "GL_RGB16_EXT")]
        Rgb16Ext = 0x8054,
        [NativeName("Name", "GL_RGB16_SNORM_EXT")]
        Rgb16SNormExt = 0x8F9A,
        [NativeName("Name", "GL_RED_EXT")]
        RedExt = 0x1903,
        [NativeName("Name", "GL_RG_EXT")]
        RGExt = 0x8227,
        [NativeName("Name", "GL_R8_EXT")]
        R8Ext = 0x8229,
        [NativeName("Name", "GL_RG8_EXT")]
        RG8Ext = 0x822B,
        [NativeName("Name", "GL_TEXTURE_SRGB_DECODE_EXT")]
        TextureSrgbDecodeExt = 0x8A48,
        [NativeName("Name", "GL_DECODE_EXT")]
        DecodeExt = 0x8A49,
        [NativeName("Name", "GL_SKIP_DECODE_EXT")]
        SkipDecodeExt = 0x8A4A,
        [NativeName("Name", "GL_SR8_EXT")]
        SR8Ext = 0x8FBD,
        [NativeName("Name", "GL_SRG8_EXT")]
        Srg8Ext = 0x8FBE,
        [NativeName("Name", "GL_TEXTURE_IMMUTABLE_FORMAT_EXT")]
        TextureImmutableFormatExt = 0x912F,
        [NativeName("Name", "GL_ALPHA8_EXT")]
        Alpha8Ext = 0x803C,
        [NativeName("Name", "GL_LUMINANCE8_EXT")]
        Luminance8Ext = 0x8040,
        [NativeName("Name", "GL_LUMINANCE8_ALPHA8_EXT")]
        Luminance8Alpha8Ext = 0x8045,
        [NativeName("Name", "GL_RGBA32F_EXT")]
        Rgba32fExt = 0x8814,
        [NativeName("Name", "GL_RGB32F_EXT")]
        Rgb32fExt = 0x8815,
        [NativeName("Name", "GL_ALPHA32F_EXT")]
        Alpha32fExt = 0x8816,
        [NativeName("Name", "GL_LUMINANCE32F_EXT")]
        Luminance32fExt = 0x8818,
        [NativeName("Name", "GL_LUMINANCE_ALPHA32F_EXT")]
        LuminanceAlpha32fExt = 0x8819,
        [NativeName("Name", "GL_ALPHA16F_EXT")]
        Alpha16fExt = 0x881C,
        [NativeName("Name", "GL_LUMINANCE16F_EXT")]
        Luminance16fExt = 0x881E,
        [NativeName("Name", "GL_LUMINANCE_ALPHA16F_EXT")]
        LuminanceAlpha16fExt = 0x881F,
        [NativeName("Name", "GL_RGB10_A2_EXT")]
        Rgb10A2Ext = 0x8059,
        [NativeName("Name", "GL_RGB10_EXT")]
        Rgb10Ext = 0x8052,
        [NativeName("Name", "GL_BGRA8_EXT")]
        Bgra8Ext = 0x93A1,
        [NativeName("Name", "GL_R32F_EXT")]
        R32fExt = 0x822E,
        [NativeName("Name", "GL_RG32F_EXT")]
        RG32fExt = 0x8230,
        [NativeName("Name", "GL_NUM_SURFACE_COMPRESSION_FIXED_RATES_EXT")]
        NumSurfaceCompressionFixedRatesExt = 0x8F6E,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_1BPC_EXT")]
        SurfaceCompressionFixedRate1BpcExt = 0x96C4,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_2BPC_EXT")]
        SurfaceCompressionFixedRate2BpcExt = 0x96C5,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_3BPC_EXT")]
        SurfaceCompressionFixedRate3BpcExt = 0x96C6,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_4BPC_EXT")]
        SurfaceCompressionFixedRate4BpcExt = 0x96C7,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_5BPC_EXT")]
        SurfaceCompressionFixedRate5BpcExt = 0x96C8,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_6BPC_EXT")]
        SurfaceCompressionFixedRate6BpcExt = 0x96C9,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_7BPC_EXT")]
        SurfaceCompressionFixedRate7BpcExt = 0x96CA,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_8BPC_EXT")]
        SurfaceCompressionFixedRate8BpcExt = 0x96CB,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_9BPC_EXT")]
        SurfaceCompressionFixedRate9BpcExt = 0x96CC,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_10BPC_EXT")]
        SurfaceCompressionFixedRate10BpcExt = 0x96CD,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_11BPC_EXT")]
        SurfaceCompressionFixedRate11BpcExt = 0x96CE,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_12BPC_EXT")]
        SurfaceCompressionFixedRate12BpcExt = 0x96CF,
        [NativeName("Name", "GL_UNSIGNED_INT_2_10_10_10_REV_EXT")]
        UnsignedInt2101010RevExt = 0x8368,
        [NativeName("Name", "GL_TEXTURE_VIEW_MIN_LEVEL_EXT")]
        TextureViewMinLevelExt = 0x82DB,
        [NativeName("Name", "GL_TEXTURE_VIEW_NUM_LEVELS_EXT")]
        TextureViewNumLevelsExt = 0x82DC,
        [NativeName("Name", "GL_TEXTURE_VIEW_MIN_LAYER_EXT")]
        TextureViewMinLayerExt = 0x82DD,
        [NativeName("Name", "GL_TEXTURE_VIEW_NUM_LAYERS_EXT")]
        TextureViewNumLayersExt = 0x82DE,
        [NativeName("Name", "GL_TEXTURE_IMMUTABLE_LEVELS")]
        TextureImmutableLevels = 0x82DF,
        [NativeName("Name", "GL_UNPACK_ROW_LENGTH_EXT")]
        UnpackRowLengthExt = 0xCF2,
        [NativeName("Name", "GL_UNPACK_SKIP_ROWS_EXT")]
        UnpackSkipRowsExt = 0xCF3,
        [NativeName("Name", "GL_UNPACK_SKIP_PIXELS_EXT")]
        UnpackSkipPixelsExt = 0xCF4,
        [NativeName("Name", "GL_INCLUSIVE_EXT")]
        InclusiveExt = 0x8F10,
        [NativeName("Name", "GL_EXCLUSIVE_EXT")]
        ExclusiveExt = 0x8F11,
        [NativeName("Name", "GL_WINDOW_RECTANGLE_EXT")]
        WindowRectangleExt = 0x8F12,
        [NativeName("Name", "GL_WINDOW_RECTANGLE_MODE_EXT")]
        WindowRectangleModeExt = 0x8F13,
        [NativeName("Name", "GL_MAX_WINDOW_RECTANGLES_EXT")]
        MaxWindowRectanglesExt = 0x8F14,
        [NativeName("Name", "GL_NUM_WINDOW_RECTANGLES_EXT")]
        NumWindowRectanglesExt = 0x8F15,
        [NativeName("Name", "GL_SAMPLER_EXTERNAL_2D_Y2Y_EXT")]
        SamplerExternal2DY2YExt = 0x8BE7,
        [NativeName("Name", "GL_TEXTURE_EXTERNAL_OES")]
        TextureExternalOes = 0x8D65,
        [NativeName("Name", "GL_TEXTURE_BINDING_EXTERNAL_OES")]
        TextureBindingExternalOes = 0x8D67,
        [NativeName("Name", "GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES")]
        RequiredTextureImageUnitsOes = 0x8D68,
    }
}
