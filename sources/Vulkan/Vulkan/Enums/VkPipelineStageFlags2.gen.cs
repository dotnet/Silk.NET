// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineStageFlags2")]
[Transformed]
[Flags]
public enum VkPipelineStageFlags2 : ulong
{
    [NativeName("VK_PIPELINE_STAGE_2_NONE")]
    VkPipelineStage2None = unchecked((ulong)0UL),

    [NativeName("VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT")]
    VkPipelineStage2TopOfPipeBit = unchecked((ulong)0x00000001UL),

    [NativeName("VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT")]
    VkPipelineStage2DrawIndirectBit = unchecked((ulong)0x00000002UL),

    [NativeName("VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT")]
    VkPipelineStage2VertexInputBit = unchecked((ulong)0x00000004UL),

    [NativeName("VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT")]
    VkPipelineStage2VertexShaderBit = unchecked((ulong)0x00000008UL),

    [NativeName("VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT")]
    VkPipelineStage2TessellationControlShaderBit = unchecked((ulong)0x00000010UL),

    [NativeName("VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT")]
    VkPipelineStage2TessellationEvaluationShaderBit = unchecked((ulong)0x00000020UL),

    [NativeName("VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT")]
    VkPipelineStage2GeometryShaderBit = unchecked((ulong)0x00000040UL),

    [NativeName("VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT")]
    VkPipelineStage2FragmentShaderBit = unchecked((ulong)0x00000080UL),

    [NativeName("VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT")]
    VkPipelineStage2EarlyFragmentTestsBit = unchecked((ulong)0x00000100UL),

    [NativeName("VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT")]
    VkPipelineStage2LateFragmentTestsBit = unchecked((ulong)0x00000200UL),

    [NativeName("VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT")]
    VkPipelineStage2ColorAttachmentOutputBit = unchecked((ulong)0x00000400UL),

    [NativeName("VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT")]
    VkPipelineStage2ComputeShaderBit = unchecked((ulong)0x00000800UL),

    [NativeName("VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT")]
    VkPipelineStage2AllTransferBit = unchecked((ulong)0x00001000UL),

    [NativeName("VK_PIPELINE_STAGE_2_TRANSFER_BIT")]
    VkPipelineStage2TransferBit = unchecked((ulong)0x00001000UL),

    [NativeName("VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT")]
    VkPipelineStage2BottomOfPipeBit = unchecked((ulong)0x00002000UL),

    [NativeName("VK_PIPELINE_STAGE_2_HOST_BIT")]
    VkPipelineStage2HostBit = unchecked((ulong)0x00004000UL),

    [NativeName("VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT")]
    VkPipelineStage2AllGraphicsBit = unchecked((ulong)0x00008000UL),

    [NativeName("VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT")]
    VkPipelineStage2AllCommandsBit = unchecked((ulong)0x00010000UL),

    [NativeName("VK_PIPELINE_STAGE_2_COPY_BIT")]
    VkPipelineStage2CopyBit = unchecked((ulong)0x100000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_RESOLVE_BIT")]
    VkPipelineStage2ResolveBit = unchecked((ulong)0x200000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_BLIT_BIT")]
    VkPipelineStage2BlitBit = unchecked((ulong)0x400000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_CLEAR_BIT")]
    VkPipelineStage2ClearBit = unchecked((ulong)0x800000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT")]
    VkPipelineStage2IndexInputBit = unchecked((ulong)0x1000000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT")]
    VkPipelineStage2VertexAttributeInputBit = unchecked((ulong)0x2000000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT")]
    VkPipelineStage2PreRasterizationShadersBit = unchecked((ulong)0x4000000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_VIDEO_DECODE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2VideoDecodeBitKHR = unchecked((ulong)0x04000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_VIDEO_ENCODE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2VideoEncodeBitKHR = unchecked((ulong)0x08000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_NONE_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2NoneKHR = unchecked((ulong)0UL),

    [NativeName("VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2TopOfPipeBitKHR = unchecked((ulong)0x00000001UL),

    [NativeName("VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2DrawIndirectBitKHR = unchecked((ulong)0x00000002UL),

    [NativeName("VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2VertexInputBitKHR = unchecked((ulong)0x00000004UL),

    [NativeName("VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2VertexShaderBitKHR = unchecked((ulong)0x00000008UL),

    [NativeName("VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2TessellationControlShaderBitKHR = unchecked((ulong)0x00000010UL),

    [NativeName("VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2TessellationEvaluationShaderBitKHR = unchecked((ulong)0x00000020UL),

    [NativeName("VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2GeometryShaderBitKHR = unchecked((ulong)0x00000040UL),

    [NativeName("VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2FragmentShaderBitKHR = unchecked((ulong)0x00000080UL),

    [NativeName("VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2EarlyFragmentTestsBitKHR = unchecked((ulong)0x00000100UL),

    [NativeName("VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2LateFragmentTestsBitKHR = unchecked((ulong)0x00000200UL),

    [NativeName("VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2ColorAttachmentOutputBitKHR = unchecked((ulong)0x00000400UL),

    [NativeName("VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2ComputeShaderBitKHR = unchecked((ulong)0x00000800UL),

    [NativeName("VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2AllTransferBitKHR = unchecked((ulong)0x00001000UL),

    [NativeName("VK_PIPELINE_STAGE_2_TRANSFER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2TransferBitKHR = unchecked((ulong)0x00001000UL),

    [NativeName("VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2BottomOfPipeBitKHR = unchecked((ulong)0x00002000UL),

    [NativeName("VK_PIPELINE_STAGE_2_HOST_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2HostBitKHR = unchecked((ulong)0x00004000UL),

    [NativeName("VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2AllGraphicsBitKHR = unchecked((ulong)0x00008000UL),

    [NativeName("VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2AllCommandsBitKHR = unchecked((ulong)0x00010000UL),

    [NativeName("VK_PIPELINE_STAGE_2_COPY_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2CopyBitKHR = unchecked((ulong)0x100000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_RESOLVE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2ResolveBitKHR = unchecked((ulong)0x200000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_BLIT_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2BlitBitKHR = unchecked((ulong)0x400000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_CLEAR_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2ClearBitKHR = unchecked((ulong)0x800000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2IndexInputBitKHR = unchecked((ulong)0x1000000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2VertexAttributeInputBitKHR = unchecked((ulong)0x2000000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2PreRasterizationShadersBitKHR = unchecked((ulong)0x4000000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_TRANSFORM_FEEDBACK_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineStage2TransformFeedbackBitEXT = unchecked((ulong)0x01000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_CONDITIONAL_RENDERING_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineStage2ConditionalRenderingBitEXT = unchecked((ulong)0x00040000UL),

    [NativeName("VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkPipelineStage2CommandPreprocessBitNV = unchecked((ulong)0x00020000UL),

    [NativeName("VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineStage2CommandPreprocessBitEXT = unchecked((ulong)0x00020000UL),

    [NativeName("VK_PIPELINE_STAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2FragmentShadingRateAttachmentBitKHR = unchecked((ulong)0x00400000UL),

    [NativeName("VK_PIPELINE_STAGE_2_SHADING_RATE_IMAGE_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkPipelineStage2ShadingRateImageBitNV = unchecked((ulong)0x00400000UL),

    [NativeName("VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2AccelerationStructureBuildBitKHR = unchecked((ulong)0x02000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2RayTracingShaderBitKHR = unchecked((ulong)0x00200000UL),

    [NativeName("VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkPipelineStage2RayTracingShaderBitNV = unchecked((ulong)0x00200000UL),

    [NativeName("VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkPipelineStage2AccelerationStructureBuildBitNV = unchecked((ulong)0x02000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_FRAGMENT_DENSITY_PROCESS_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineStage2FragmentDensityProcessBitEXT = unchecked((ulong)0x00800000UL),

    [NativeName("VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkPipelineStage2TaskShaderBitNV = unchecked((ulong)0x00080000UL),

    [NativeName("VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkPipelineStage2MeshShaderBitNV = unchecked((ulong)0x00100000UL),

    [NativeName("VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineStage2TaskShaderBitEXT = unchecked((ulong)0x00080000UL),

    [NativeName("VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineStage2MeshShaderBitEXT = unchecked((ulong)0x00100000UL),

    [NativeName("VK_PIPELINE_STAGE_2_SUBPASS_SHADER_BIT_HUAWEI")]
    [NameAffix("Suffix", "KhronosVendor", "HUAWEI")]
    VkPipelineStage2SubpassShaderBitHUAWEI = unchecked((ulong)0x8000000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_INVOCATION_MASK_BIT_HUAWEI")]
    [NameAffix("Suffix", "KhronosVendor", "HUAWEI")]
    VkPipelineStage2InvocationMaskBitHUAWEI = unchecked((ulong)0x10000000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_COPY_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2AccelerationStructureCopyBitKHR = unchecked((ulong)0x10000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_MICROMAP_BUILD_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineStage2MicromapBuildBitEXT = unchecked((ulong)0x40000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_CLUSTER_CULLING_SHADER_BIT_HUAWEI")]
    [NameAffix("Suffix", "KhronosVendor", "HUAWEI")]
    VkPipelineStage2ClusterCullingShaderBitHUAWEI = unchecked((ulong)0x20000000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_OPTICAL_FLOW_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkPipelineStage2OpticalFlowBitNV = unchecked((ulong)0x20000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_CONVERT_COOPERATIVE_VECTOR_MATRIX_BIT_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    VkPipelineStage2ConvertCooperativeVectorMatrixBitNV = unchecked((ulong)0x100000000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_DATA_GRAPH_BIT_ARM")]
    [NameAffix("Suffix", "KhronosVendor", "ARM")]
    VkPipelineStage2DataGraphBitARM = unchecked((ulong)0x40000000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_COPY_INDIRECT_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    VkPipelineStage2CopyIndirectBitKHR = unchecked((ulong)0x400000000000UL),

    [NativeName("VK_PIPELINE_STAGE_2_MEMORY_DECOMPRESSION_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    VkPipelineStage2MemoryDecompressionBitEXT = unchecked((ulong)0x200000000000UL),
}
