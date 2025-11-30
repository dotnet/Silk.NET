// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineStageFlags2")]
[Flags]
public enum PipelineStageFlags2 : ulong
{
    [NativeName("VK_PIPELINE_STAGE_2_NONE")]
    None = 0x0,

    [NativeName("VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT")]
    TopOfPipeBit = 0x1,

    [NativeName("VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT")]
    DrawIndirectBit = 0x2,

    [NativeName("VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT")]
    VertexInputBit = 0x4,

    [NativeName("VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT")]
    VertexShaderBit = 0x8,

    [NativeName("VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT")]
    TessellationControlShaderBit = 0x10,

    [NativeName("VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT")]
    TessellationEvaluationShaderBit = 0x20,

    [NativeName("VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT")]
    GeometryShaderBit = 0x40,

    [NativeName("VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT")]
    FragmentShaderBit = 0x80,

    [NativeName("VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT")]
    EarlyFragmentTestsBit = 0x100,

    [NativeName("VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT")]
    LateFragmentTestsBit = 0x200,

    [NativeName("VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT")]
    ColorAttachmentOutputBit = 0x400,

    [NativeName("VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT")]
    ComputeShaderBit = 0x800,

    [NativeName("VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT")]
    AllTransferBit = 0x1000,

    [NativeName("VK_PIPELINE_STAGE_2_TRANSFER_BIT")]
    TransferBit = 0x1000,

    [NativeName("VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT")]
    BottomOfPipeBit = 0x2000,

    [NativeName("VK_PIPELINE_STAGE_2_HOST_BIT")]
    HostBit = 0x4000,

    [NativeName("VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT")]
    AllGraphicsBit = 0x8000,

    [NativeName("VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT")]
    AllCommandsBit = 0x10000,

    [NativeName("VK_PIPELINE_STAGE_2_COPY_BIT")]
    CopyBit = 0x100000000,

    [NativeName("VK_PIPELINE_STAGE_2_RESOLVE_BIT")]
    ResolveBit = 0x200000000,

    [NativeName("VK_PIPELINE_STAGE_2_BLIT_BIT")]
    BlitBit = 0x400000000,

    [NativeName("VK_PIPELINE_STAGE_2_CLEAR_BIT")]
    ClearBit = 0x800000000,

    [NativeName("VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT")]
    IndexInputBit = 0x1000000000,

    [NativeName("VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT")]
    VertexAttributeInputBit = 0x2000000000,

    [NativeName("VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT")]
    PreRasterizationShadersBit = 0x4000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_VIDEO_DECODE_BIT_KHR")]
    VideoDecodeBitkhr = 0x4000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_VIDEO_ENCODE_BIT_KHR")]
    VideoEncodeBitkhr = 0x8000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_NONE_KHR")]
    Nonekhr = 0x0,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT_KHR")]
    TopOfPipeBitkhr = 0x1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT_KHR")]
    DrawIndirectBitkhr = 0x2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT_KHR")]
    VertexInputBitkhr = 0x4,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT_KHR")]
    VertexShaderBitkhr = 0x8,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT_KHR")]
    TessellationControlShaderBitkhr = 0x10,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT_KHR")]
    TessellationEvaluationShaderBitkhr = 0x20,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT_KHR")]
    GeometryShaderBitkhr = 0x40,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT_KHR")]
    FragmentShaderBitkhr = 0x80,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT_KHR")]
    EarlyFragmentTestsBitkhr = 0x100,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT_KHR")]
    LateFragmentTestsBitkhr = 0x200,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT_KHR")]
    ColorAttachmentOutputBitkhr = 0x400,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT_KHR")]
    ComputeShaderBitkhr = 0x800,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT_KHR")]
    AllTransferBitkhr = 0x1000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_TRANSFER_BIT_KHR")]
    TransferBitkhr = 0x1000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT_KHR")]
    BottomOfPipeBitkhr = 0x2000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_HOST_BIT_KHR")]
    HostBitkhr = 0x4000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT_KHR")]
    AllGraphicsBitkhr = 0x8000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT_KHR")]
    AllCommandsBitkhr = 0x10000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_COPY_BIT_KHR")]
    CopyBitkhr = 0x100000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_RESOLVE_BIT_KHR")]
    ResolveBitkhr = 0x200000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_BLIT_BIT_KHR")]
    BlitBitkhr = 0x400000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_CLEAR_BIT_KHR")]
    ClearBitkhr = 0x800000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT_KHR")]
    IndexInputBitkhr = 0x1000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT_KHR")]
    VertexAttributeInputBitkhr = 0x2000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT_KHR")]
    PreRasterizationShadersBitkhr = 0x4000000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_TRANSFORM_FEEDBACK_BIT_EXT")]
    TransformFeedbackBitext = 0x1000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_CONDITIONAL_RENDERING_BIT_EXT")]
    ConditionalRenderingBitext = 0x40000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_NV")]
    CommandPreprocessBitnv = 0x20000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_EXT")]
    CommandPreprocessBitext = 0x20000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
    FragmentShadingRateAttachmentBitkhr = 0x400000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_SHADING_RATE_IMAGE_BIT_NV")]
    ShadingRateImageBitnv = 0x400000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR")]
    AccelerationStructureBuildBitkhr = 0x2000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_KHR")]
    RayTracingShaderBitkhr = 0x200000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_NV")]
    RayTracingShaderBitnv = 0x200000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_NV")]
    AccelerationStructureBuildBitnv = 0x2000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_FRAGMENT_DENSITY_PROCESS_BIT_EXT")]
    FragmentDensityProcessBitext = 0x800000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_NV")]
    TaskShaderBitnv = 0x80000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_NV")]
    MeshShaderBitnv = 0x100000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_EXT")]
    TaskShaderBitext = 0x80000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_EXT")]
    MeshShaderBitext = 0x100000,

    [NameAffix("Suffix", "HUAWEI", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_SUBPASS_SHADER_BIT_HUAWEI")]
    SubpassShaderBithuawei = 0x8000000000,

    [NameAffix("Suffix", "HUAWEI", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_INVOCATION_MASK_BIT_HUAWEI")]
    InvocationMaskBithuawei = 0x10000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_COPY_BIT_KHR")]
    AccelerationStructureCopyBitkhr = 0x10000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_MICROMAP_BUILD_BIT_EXT")]
    MicromapBuildBitext = 0x40000000,

    [NameAffix("Suffix", "HUAWEI", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_CLUSTER_CULLING_SHADER_BIT_HUAWEI")]
    ClusterCullingShaderBithuawei = 0x20000000000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_OPTICAL_FLOW_BIT_NV")]
    OpticalFlowBitnv = 0x20000000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_CONVERT_COOPERATIVE_VECTOR_MATRIX_BIT_NV")]
    ConvertCooperativeVectorMatrixBitnv = 0x100000000000,

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_DATA_GRAPH_BIT_ARM")]
    DataGraphBitarm = 0x40000000000,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_COPY_INDIRECT_BIT_KHR")]
    CopyIndirectBitkhr = 0x400000000000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_MEMORY_DECOMPRESSION_BIT_EXT")]
    MemoryDecompressionBitext = 0x200000000000,
}
