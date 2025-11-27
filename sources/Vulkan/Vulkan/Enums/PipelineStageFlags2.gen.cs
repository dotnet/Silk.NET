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

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_VIDEO_DECODE_BIT_KHR")]
    VideoDecodeBitKHR = 0x4000000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_VIDEO_ENCODE_BIT_KHR")]
    VideoEncodeBitKHR = 0x8000000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_NONE_KHR")]
    NoneKHR = 0x0,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT_KHR")]
    TopOfPipeBitKHR = 0x1,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT_KHR")]
    DrawIndirectBitKHR = 0x2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT_KHR")]
    VertexInputBitKHR = 0x4,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT_KHR")]
    VertexShaderBitKHR = 0x8,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT_KHR")]
    TessellationControlShaderBitKHR = 0x10,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT_KHR")]
    TessellationEvaluationShaderBitKHR = 0x20,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT_KHR")]
    GeometryShaderBitKHR = 0x40,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT_KHR")]
    FragmentShaderBitKHR = 0x80,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT_KHR")]
    EarlyFragmentTestsBitKHR = 0x100,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT_KHR")]
    LateFragmentTestsBitKHR = 0x200,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT_KHR")]
    ColorAttachmentOutputBitKHR = 0x400,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT_KHR")]
    ComputeShaderBitKHR = 0x800,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT_KHR")]
    AllTransferBitKHR = 0x1000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_TRANSFER_BIT_KHR")]
    TransferBitKHR = 0x1000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT_KHR")]
    BottomOfPipeBitKHR = 0x2000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_HOST_BIT_KHR")]
    HostBitKHR = 0x4000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT_KHR")]
    AllGraphicsBitKHR = 0x8000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT_KHR")]
    AllCommandsBitKHR = 0x10000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_COPY_BIT_KHR")]
    CopyBitKHR = 0x100000000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_RESOLVE_BIT_KHR")]
    ResolveBitKHR = 0x200000000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_BLIT_BIT_KHR")]
    BlitBitKHR = 0x400000000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_CLEAR_BIT_KHR")]
    ClearBitKHR = 0x800000000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT_KHR")]
    IndexInputBitKHR = 0x1000000000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT_KHR")]
    VertexAttributeInputBitKHR = 0x2000000000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT_KHR")]
    PreRasterizationShadersBitKHR = 0x4000000000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_TRANSFORM_FEEDBACK_BIT_EXT")]
    TransformFeedbackBitEXT = 0x1000000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_CONDITIONAL_RENDERING_BIT_EXT")]
    ConditionalRenderingBitEXT = 0x40000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_NV")]
    CommandPreprocessBitNV = 0x20000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_EXT")]
    CommandPreprocessBitEXT = 0x20000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
    FragmentShadingRateAttachmentBitKHR = 0x400000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_SHADING_RATE_IMAGE_BIT_NV")]
    ShadingRateImageBitNV = 0x400000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR")]
    AccelerationStructureBuildBitKHR = 0x2000000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_KHR")]
    RayTracingShaderBitKHR = 0x200000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_NV")]
    RayTracingShaderBitNV = 0x200000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_NV")]
    AccelerationStructureBuildBitNV = 0x2000000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_FRAGMENT_DENSITY_PROCESS_BIT_EXT")]
    FragmentDensityProcessBitEXT = 0x800000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_NV")]
    TaskShaderBitNV = 0x80000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_NV")]
    MeshShaderBitNV = 0x100000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_EXT")]
    TaskShaderBitEXT = 0x80000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_EXT")]
    MeshShaderBitEXT = 0x100000,

    [NameSuffix("HUAWEI", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_SUBPASS_SHADER_BIT_HUAWEI")]
    SubpassShaderBitHuawei = 0x8000000000,

    [NameSuffix("HUAWEI", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_INVOCATION_MASK_BIT_HUAWEI")]
    InvocationMaskBitHuawei = 0x10000000000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_COPY_BIT_KHR")]
    AccelerationStructureCopyBitKHR = 0x10000000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_MICROMAP_BUILD_BIT_EXT")]
    MicromapBuildBitEXT = 0x40000000,

    [NameSuffix("HUAWEI", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_CLUSTER_CULLING_SHADER_BIT_HUAWEI")]
    ClusterCullingShaderBitHuawei = 0x20000000000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_OPTICAL_FLOW_BIT_NV")]
    OpticalFlowBitNV = 0x20000000,

    [NameSuffix("NV", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_CONVERT_COOPERATIVE_VECTOR_MATRIX_BIT_NV")]
    ConvertCooperativeVectorMatrixBitNV = 0x100000000000,

    [NameSuffix("ARM", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_DATA_GRAPH_BIT_ARM")]
    DataGraphBitARM = 0x40000000000,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_COPY_INDIRECT_BIT_KHR")]
    CopyIndirectBitKHR = 0x400000000000,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_PIPELINE_STAGE_2_MEMORY_DECOMPRESSION_BIT_EXT")]
    MemoryDecompressionBitEXT = 0x200000000000,
}
