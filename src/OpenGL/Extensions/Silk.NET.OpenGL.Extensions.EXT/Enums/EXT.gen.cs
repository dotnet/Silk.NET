// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.EXT
{
    [NativeName("Name", "GLenum")]
    public enum EXT : int
    {
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
        [NativeName("Name", "GL_PROGRAM_MATRIX_EXT")]
        ProgramMatrixExt = 0x8E2D,
        [NativeName("Name", "GL_TRANSPOSE_PROGRAM_MATRIX_EXT")]
        TransposeProgramMatrixExt = 0x8E2E,
        [NativeName("Name", "GL_PROGRAM_MATRIX_STACK_DEPTH_EXT")]
        ProgramMatrixStackDepthExt = 0x8E2F,
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
        [NativeName("Name", "GL_POLYGON_OFFSET_CLAMP_EXT")]
        PolygonOffsetClampExt = 0x8E1B,
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
        [NativeName("Name", "GL_FRAGMENT_SHADER_DISCARDS_SAMPLES_EXT")]
        FragmentShaderDiscardsSamplesExt = 0x8A52,
        [NativeName("Name", "GL_COMPRESSED_RGB_S3TC_DXT1_EXT")]
        CompressedRgbS3TCDxt1Ext = 0x83F0,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT1_EXT")]
        CompressedRgbaS3TCDxt1Ext = 0x83F1,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT3_EXT")]
        CompressedRgbaS3TCDxt3Ext = 0x83F2,
        [NativeName("Name", "GL_COMPRESSED_RGBA_S3TC_DXT5_EXT")]
        CompressedRgbaS3TCDxt5Ext = 0x83F3,
        [NativeName("Name", "GL_TEXTURE_REDUCTION_MODE_EXT")]
        TextureReductionModeExt = 0x9366,
        [NativeName("Name", "GL_WEIGHTED_AVERAGE_EXT")]
        WeightedAverageExt = 0x9367,
        [NativeName("Name", "GL_SRGB_EXT")]
        SrgbExt = 0x8C40,
        [NativeName("Name", "GL_SRGB8_EXT")]
        Srgb8Ext = 0x8C41,
        [NativeName("Name", "GL_SRGB_ALPHA_EXT")]
        SrgbAlphaExt = 0x8C42,
        [NativeName("Name", "GL_SRGB8_ALPHA8_EXT")]
        Srgb8Alpha8Ext = 0x8C43,
        [NativeName("Name", "GL_COMPRESSED_SRGB_EXT")]
        CompressedSrgbExt = 0x8C48,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_EXT")]
        CompressedSrgbAlphaExt = 0x8C49,
        [NativeName("Name", "GL_COMPRESSED_SRGB_S3TC_DXT1_EXT")]
        CompressedSrgbS3TCDxt1Ext = 0x8C4C,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT")]
        CompressedSrgbAlphaS3TCDxt1Ext = 0x8C4D,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT")]
        CompressedSrgbAlphaS3TCDxt3Ext = 0x8C4E,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT")]
        CompressedSrgbAlphaS3TCDxt5Ext = 0x8C4F,
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
        [NativeName("Name", "GL_RGBA16F_EXT")]
        Rgba16fExt = 0x881A,
        [NativeName("Name", "GL_RGB16F_EXT")]
        Rgb16fExt = 0x881B,
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
        [NativeName("Name", "GL_R8_EXT")]
        R8Ext = 0x8229,
        [NativeName("Name", "GL_RG8_EXT")]
        RG8Ext = 0x822B,
        [NativeName("Name", "GL_R32F_EXT")]
        R32fExt = 0x822E,
        [NativeName("Name", "GL_RG32F_EXT")]
        RG32fExt = 0x8230,
        [NativeName("Name", "GL_R16F_EXT")]
        R16fExt = 0x822D,
        [NativeName("Name", "GL_RG16F_EXT")]
        RG16fExt = 0x822F,
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
    }
}
