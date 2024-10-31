// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPipelineStageFlags2")]
    public enum PipelineStageFlags2 : long
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_NONE")]
        PipelineStage2None = 0,
        [Obsolete("Deprecated in favour of \"NoneKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_NONE_KHR")]
        PipelineStage2NoneKhr = 0,
        [Obsolete("Deprecated in favour of \"TopOfPipeBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT")]
        PipelineStage2TopOfPipeBit = 1,
        [Obsolete("Deprecated in favour of \"TopOfPipeBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT_KHR")]
        PipelineStage2TopOfPipeBitKhr = 1,
        [Obsolete("Deprecated in favour of \"DrawIndirectBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT")]
        PipelineStage2DrawIndirectBit = 2,
        [Obsolete("Deprecated in favour of \"DrawIndirectBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT_KHR")]
        PipelineStage2DrawIndirectBitKhr = 2,
        [Obsolete("Deprecated in favour of \"VertexInputBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT")]
        PipelineStage2VertexInputBit = 4,
        [Obsolete("Deprecated in favour of \"VertexInputBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT_KHR")]
        PipelineStage2VertexInputBitKhr = 4,
        [Obsolete("Deprecated in favour of \"VertexShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT")]
        PipelineStage2VertexShaderBit = 8,
        [Obsolete("Deprecated in favour of \"VertexShaderBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT_KHR")]
        PipelineStage2VertexShaderBitKhr = 8,
        [Obsolete("Deprecated in favour of \"TessellationControlShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT")]
        PipelineStage2TessellationControlShaderBit = 16,
        [Obsolete("Deprecated in favour of \"TessellationControlShaderBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT_KHR")]
        PipelineStage2TessellationControlShaderBitKhr = 16,
        [Obsolete("Deprecated in favour of \"TessellationEvaluationShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT")]
        PipelineStage2TessellationEvaluationShaderBit = 32,
        [Obsolete("Deprecated in favour of \"TessellationEvaluationShaderBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT_KHR")]
        PipelineStage2TessellationEvaluationShaderBitKhr = 32,
        [Obsolete("Deprecated in favour of \"GeometryShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT")]
        PipelineStage2GeometryShaderBit = 64,
        [Obsolete("Deprecated in favour of \"GeometryShaderBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT_KHR")]
        PipelineStage2GeometryShaderBitKhr = 64,
        [Obsolete("Deprecated in favour of \"FragmentShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT")]
        PipelineStage2FragmentShaderBit = 128,
        [Obsolete("Deprecated in favour of \"FragmentShaderBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT_KHR")]
        PipelineStage2FragmentShaderBitKhr = 128,
        [Obsolete("Deprecated in favour of \"EarlyFragmentTestsBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT")]
        PipelineStage2EarlyFragmentTestsBit = 256,
        [Obsolete("Deprecated in favour of \"EarlyFragmentTestsBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT_KHR")]
        PipelineStage2EarlyFragmentTestsBitKhr = 256,
        [Obsolete("Deprecated in favour of \"LateFragmentTestsBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT")]
        PipelineStage2LateFragmentTestsBit = 512,
        [Obsolete("Deprecated in favour of \"LateFragmentTestsBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT_KHR")]
        PipelineStage2LateFragmentTestsBitKhr = 512,
        [Obsolete("Deprecated in favour of \"ColorAttachmentOutputBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT")]
        PipelineStage2ColorAttachmentOutputBit = 1024,
        [Obsolete("Deprecated in favour of \"ColorAttachmentOutputBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT_KHR")]
        PipelineStage2ColorAttachmentOutputBitKhr = 1024,
        [Obsolete("Deprecated in favour of \"ComputeShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT")]
        PipelineStage2ComputeShaderBit = 2048,
        [Obsolete("Deprecated in favour of \"ComputeShaderBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT_KHR")]
        PipelineStage2ComputeShaderBitKhr = 2048,
        [Obsolete("Deprecated in favour of \"AllTransferBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT")]
        PipelineStage2AllTransferBit = 4096,
        [Obsolete("Deprecated in favour of \"AllTransferBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT_KHR")]
        PipelineStage2AllTransferBitKhr = 4096,
        [Obsolete("Deprecated in favour of \"TransferBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TRANSFER_BIT")]
        PipelineStage2TransferBit = 4096,
        [Obsolete("Deprecated in favour of \"TransferBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TRANSFER_BIT_KHR")]
        PipelineStage2TransferBitKhr = 4096,
        [Obsolete("Deprecated in favour of \"BottomOfPipeBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT")]
        PipelineStage2BottomOfPipeBit = 8192,
        [Obsolete("Deprecated in favour of \"BottomOfPipeBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT_KHR")]
        PipelineStage2BottomOfPipeBitKhr = 8192,
        [Obsolete("Deprecated in favour of \"HostBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_HOST_BIT")]
        PipelineStage2HostBit = 16384,
        [Obsolete("Deprecated in favour of \"HostBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_HOST_BIT_KHR")]
        PipelineStage2HostBitKhr = 16384,
        [Obsolete("Deprecated in favour of \"AllGraphicsBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT")]
        PipelineStage2AllGraphicsBit = 32768,
        [Obsolete("Deprecated in favour of \"AllGraphicsBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT_KHR")]
        PipelineStage2AllGraphicsBitKhr = 32768,
        [Obsolete("Deprecated in favour of \"AllCommandsBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT")]
        PipelineStage2AllCommandsBit = 65536,
        [Obsolete("Deprecated in favour of \"AllCommandsBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT_KHR")]
        PipelineStage2AllCommandsBitKhr = 65536,
        [Obsolete("Deprecated in favour of \"CopyBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COPY_BIT")]
        PipelineStage2CopyBit = 4294967296,
        [Obsolete("Deprecated in favour of \"CopyBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COPY_BIT_KHR")]
        PipelineStage2CopyBitKhr = 4294967296,
        [Obsolete("Deprecated in favour of \"ResolveBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_RESOLVE_BIT")]
        PipelineStage2ResolveBit = 8589934592,
        [Obsolete("Deprecated in favour of \"ResolveBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_RESOLVE_BIT_KHR")]
        PipelineStage2ResolveBitKhr = 8589934592,
        [Obsolete("Deprecated in favour of \"BlitBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_BLIT_BIT")]
        PipelineStage2BlitBit = 17179869184,
        [Obsolete("Deprecated in favour of \"BlitBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_BLIT_BIT_KHR")]
        PipelineStage2BlitBitKhr = 17179869184,
        [Obsolete("Deprecated in favour of \"ClearBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_CLEAR_BIT")]
        PipelineStage2ClearBit = 34359738368,
        [Obsolete("Deprecated in favour of \"ClearBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_CLEAR_BIT_KHR")]
        PipelineStage2ClearBitKhr = 34359738368,
        [Obsolete("Deprecated in favour of \"IndexInputBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT")]
        PipelineStage2IndexInputBit = 68719476736,
        [Obsolete("Deprecated in favour of \"IndexInputBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT_KHR")]
        PipelineStage2IndexInputBitKhr = 68719476736,
        [Obsolete("Deprecated in favour of \"VertexAttributeInputBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT")]
        PipelineStage2VertexAttributeInputBit = 137438953472,
        [Obsolete("Deprecated in favour of \"VertexAttributeInputBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT_KHR")]
        PipelineStage2VertexAttributeInputBitKhr = 137438953472,
        [Obsolete("Deprecated in favour of \"PreRasterizationShadersBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT")]
        PipelineStage2PreRasterizationShadersBit = 274877906944,
        [Obsolete("Deprecated in favour of \"PreRasterizationShadersBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT_KHR")]
        PipelineStage2PreRasterizationShadersBitKhr = 274877906944,
        [Obsolete("Deprecated in favour of \"VideoDecodeBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VIDEO_DECODE_BIT_KHR")]
        PipelineStage2VideoDecodeBitKhr = 67108864,
        [Obsolete("Deprecated in favour of \"VideoEncodeBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VIDEO_ENCODE_BIT_KHR")]
        PipelineStage2VideoEncodeBitKhr = 134217728,
        [Obsolete("Deprecated in favour of \"TransformFeedbackBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TRANSFORM_FEEDBACK_BIT_EXT")]
        PipelineStage2TransformFeedbackBitExt = 16777216,
        [Obsolete("Deprecated in favour of \"ConditionalRenderingBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_CONDITIONAL_RENDERING_BIT_EXT")]
        PipelineStage2ConditionalRenderingBitExt = 262144,
        [Obsolete("Deprecated in favour of \"CommandPreprocessBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_NV")]
        PipelineStage2CommandPreprocessBitNV = 131072,
        [Obsolete("Deprecated in favour of \"CommandPreprocessBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_EXT")]
        PipelineStage2CommandPreprocessBitExt = 131072,
        [Obsolete("Deprecated in favour of \"FragmentShadingRateAttachmentBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        PipelineStage2FragmentShadingRateAttachmentBitKhr = 4194304,
        [Obsolete("Deprecated in favour of \"ShadingRateImageBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_SHADING_RATE_IMAGE_BIT_NV")]
        PipelineStage2ShadingRateImageBitNV = 4194304,
        [Obsolete("Deprecated in favour of \"AccelerationStructureBuildBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR")]
        PipelineStage2AccelerationStructureBuildBitKhr = 33554432,
        [Obsolete("Deprecated in favour of \"RayTracingShaderBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_KHR")]
        PipelineStage2RayTracingShaderBitKhr = 2097152,
        [Obsolete("Deprecated in favour of \"RayTracingShaderBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_NV")]
        PipelineStage2RayTracingShaderBitNV = 2097152,
        [Obsolete("Deprecated in favour of \"AccelerationStructureBuildBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_NV")]
        PipelineStage2AccelerationStructureBuildBitNV = 33554432,
        [Obsolete("Deprecated in favour of \"FragmentDensityProcessBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_FRAGMENT_DENSITY_PROCESS_BIT_EXT")]
        PipelineStage2FragmentDensityProcessBitExt = 8388608,
        [Obsolete("Deprecated in favour of \"TaskShaderBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_NV")]
        PipelineStage2TaskShaderBitNV = 524288,
        [Obsolete("Deprecated in favour of \"MeshShaderBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_NV")]
        PipelineStage2MeshShaderBitNV = 1048576,
        [Obsolete("Deprecated in favour of \"TaskShaderBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_EXT")]
        PipelineStage2TaskShaderBitExt = 524288,
        [Obsolete("Deprecated in favour of \"MeshShaderBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_EXT")]
        PipelineStage2MeshShaderBitExt = 1048576,
        [Obsolete("Deprecated in favour of \"SubpassShaderBitHuawei\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_SUBPASS_SHADER_BIT_HUAWEI")]
        PipelineStage2SubpassShaderBitHuawei = 549755813888,
        [Obsolete("Deprecated in favour of \"SubpassShadingBitHuawei\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_SUBPASS_SHADING_BIT_HUAWEI")]
        PipelineStage2SubpassShadingBitHuawei = 549755813888,
        [Obsolete("Deprecated in favour of \"InvocationMaskBitHuawei\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_INVOCATION_MASK_BIT_HUAWEI")]
        PipelineStage2InvocationMaskBitHuawei = 1099511627776,
        [Obsolete("Deprecated in favour of \"AccelerationStructureCopyBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_COPY_BIT_KHR")]
        PipelineStage2AccelerationStructureCopyBitKhr = 268435456,
        [Obsolete("Deprecated in favour of \"MicromapBuildBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_MICROMAP_BUILD_BIT_EXT")]
        PipelineStage2MicromapBuildBitExt = 1073741824,
        [Obsolete("Deprecated in favour of \"ClusterCullingShaderBitHuawei\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_CLUSTER_CULLING_SHADER_BIT_HUAWEI")]
        PipelineStage2ClusterCullingShaderBitHuawei = 2199023255552,
        [Obsolete("Deprecated in favour of \"OpticalFlowBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_OPTICAL_FLOW_BIT_NV")]
        PipelineStage2OpticalFlowBitNV = 536870912,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_NONE")]
        None = 0,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_NONE_KHR")]
        NoneKhr = 0,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT")]
        TopOfPipeBit = 1,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT_KHR")]
        TopOfPipeBitKhr = 1,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT")]
        DrawIndirectBit = 2,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT_KHR")]
        DrawIndirectBitKhr = 2,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT")]
        VertexInputBit = 4,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT_KHR")]
        VertexInputBitKhr = 4,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT")]
        VertexShaderBit = 8,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT_KHR")]
        VertexShaderBitKhr = 8,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT")]
        TessellationControlShaderBit = 16,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT_KHR")]
        TessellationControlShaderBitKhr = 16,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT")]
        TessellationEvaluationShaderBit = 32,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT_KHR")]
        TessellationEvaluationShaderBitKhr = 32,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT")]
        GeometryShaderBit = 64,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT_KHR")]
        GeometryShaderBitKhr = 64,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT")]
        FragmentShaderBit = 128,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT_KHR")]
        FragmentShaderBitKhr = 128,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT")]
        EarlyFragmentTestsBit = 256,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT_KHR")]
        EarlyFragmentTestsBitKhr = 256,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT")]
        LateFragmentTestsBit = 512,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT_KHR")]
        LateFragmentTestsBitKhr = 512,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT")]
        ColorAttachmentOutputBit = 1024,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT_KHR")]
        ColorAttachmentOutputBitKhr = 1024,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT")]
        ComputeShaderBit = 2048,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT_KHR")]
        ComputeShaderBitKhr = 2048,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT")]
        AllTransferBit = 4096,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT_KHR")]
        AllTransferBitKhr = 4096,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TRANSFER_BIT")]
        TransferBit = 4096,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TRANSFER_BIT_KHR")]
        TransferBitKhr = 4096,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT")]
        BottomOfPipeBit = 8192,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT_KHR")]
        BottomOfPipeBitKhr = 8192,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_HOST_BIT")]
        HostBit = 16384,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_HOST_BIT_KHR")]
        HostBitKhr = 16384,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT")]
        AllGraphicsBit = 32768,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT_KHR")]
        AllGraphicsBitKhr = 32768,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT")]
        AllCommandsBit = 65536,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT_KHR")]
        AllCommandsBitKhr = 65536,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COPY_BIT")]
        CopyBit = 4294967296,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COPY_BIT_KHR")]
        CopyBitKhr = 4294967296,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_RESOLVE_BIT")]
        ResolveBit = 8589934592,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_RESOLVE_BIT_KHR")]
        ResolveBitKhr = 8589934592,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_BLIT_BIT")]
        BlitBit = 17179869184,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_BLIT_BIT_KHR")]
        BlitBitKhr = 17179869184,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_CLEAR_BIT")]
        ClearBit = 34359738368,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_CLEAR_BIT_KHR")]
        ClearBitKhr = 34359738368,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT")]
        IndexInputBit = 68719476736,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT_KHR")]
        IndexInputBitKhr = 68719476736,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT")]
        VertexAttributeInputBit = 137438953472,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT_KHR")]
        VertexAttributeInputBitKhr = 137438953472,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT")]
        PreRasterizationShadersBit = 274877906944,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT_KHR")]
        PreRasterizationShadersBitKhr = 274877906944,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VIDEO_DECODE_BIT_KHR")]
        VideoDecodeBitKhr = 67108864,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VIDEO_ENCODE_BIT_KHR")]
        VideoEncodeBitKhr = 134217728,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TRANSFORM_FEEDBACK_BIT_EXT")]
        TransformFeedbackBitExt = 16777216,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_CONDITIONAL_RENDERING_BIT_EXT")]
        ConditionalRenderingBitExt = 262144,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_NV")]
        CommandPreprocessBitNV = 131072,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_EXT")]
        CommandPreprocessBitExt = 131072,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        FragmentShadingRateAttachmentBitKhr = 4194304,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_SHADING_RATE_IMAGE_BIT_NV")]
        ShadingRateImageBitNV = 4194304,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR")]
        AccelerationStructureBuildBitKhr = 33554432,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_KHR")]
        RayTracingShaderBitKhr = 2097152,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_NV")]
        RayTracingShaderBitNV = 2097152,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_NV")]
        AccelerationStructureBuildBitNV = 33554432,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_FRAGMENT_DENSITY_PROCESS_BIT_EXT")]
        FragmentDensityProcessBitExt = 8388608,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_NV")]
        TaskShaderBitNV = 524288,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_NV")]
        MeshShaderBitNV = 1048576,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_EXT")]
        TaskShaderBitExt = 524288,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_EXT")]
        MeshShaderBitExt = 1048576,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_SUBPASS_SHADER_BIT_HUAWEI")]
        SubpassShaderBitHuawei = 549755813888,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_SUBPASS_SHADING_BIT_HUAWEI")]
        SubpassShadingBitHuawei = 549755813888,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_INVOCATION_MASK_BIT_HUAWEI")]
        InvocationMaskBitHuawei = 1099511627776,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_COPY_BIT_KHR")]
        AccelerationStructureCopyBitKhr = 268435456,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_MICROMAP_BUILD_BIT_EXT")]
        MicromapBuildBitExt = 1073741824,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_CLUSTER_CULLING_SHADER_BIT_HUAWEI")]
        ClusterCullingShaderBitHuawei = 2199023255552,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_OPTICAL_FLOW_BIT_NV")]
        OpticalFlowBitNV = 536870912,
    }
}
