// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineStageFlags")]
[Flags]
public enum PipelineStageFlags : uint
{
    [NativeName("VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT")]
    TopOfPipeBit = 0x1,

    [NativeName("VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT")]
    DrawIndirectBit = 0x2,

    [NativeName("VK_PIPELINE_STAGE_VERTEX_INPUT_BIT")]
    VertexInputBit = 0x4,

    [NativeName("VK_PIPELINE_STAGE_VERTEX_SHADER_BIT")]
    VertexShaderBit = 0x8,

    [NativeName("VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT")]
    TessellationControlShaderBit = 0x10,

    [NativeName("VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT")]
    TessellationEvaluationShaderBit = 0x20,

    [NativeName("VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT")]
    GeometryShaderBit = 0x40,

    [NativeName("VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT")]
    FragmentShaderBit = 0x80,

    [NativeName("VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT")]
    EarlyFragmentTestsBit = 0x100,

    [NativeName("VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT")]
    LateFragmentTestsBit = 0x200,

    [NativeName("VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT")]
    ColorAttachmentOutputBit = 0x400,

    [NativeName("VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT")]
    ComputeShaderBit = 0x800,

    [NativeName("VK_PIPELINE_STAGE_TRANSFER_BIT")]
    TransferBit = 0x1000,

    [NativeName("VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT")]
    BottomOfPipeBit = 0x2000,

    [NativeName("VK_PIPELINE_STAGE_HOST_BIT")]
    HostBit = 0x4000,

    [NativeName("VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT")]
    AllGraphicsBit = 0x8000,

    [NativeName("VK_PIPELINE_STAGE_ALL_COMMANDS_BIT")]
    AllCommandsBit = 0x10000,

    [NativeName("VK_PIPELINE_STAGE_NONE")]
    None = 0x0,

    [NativeName("VK_PIPELINE_STAGE_TRANSFORM_FEEDBACK_BIT_EXT")]
    TransformFeedbackBitEXT = 0x1000000,

    [NativeName("VK_PIPELINE_STAGE_CONDITIONAL_RENDERING_BIT_EXT")]
    ConditionalRenderingBitEXT = 0x40000,

    [NativeName("VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_KHR")]
    AccelerationStructureBuildBitKHR = 0x2000000,

    [NativeName("VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_KHR")]
    RayTracingShaderBitKHR = 0x200000,

    [NativeName("VK_PIPELINE_STAGE_FRAGMENT_DENSITY_PROCESS_BIT_EXT")]
    FragmentDensityProcessBitEXT = 0x800000,

    [NativeName("VK_PIPELINE_STAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
    FragmentShadingRateAttachmentBitKHR = 0x400000,

    [NativeName("VK_PIPELINE_STAGE_TASK_SHADER_BIT_EXT")]
    TaskShaderBitEXT = 0x80000,

    [NativeName("VK_PIPELINE_STAGE_MESH_SHADER_BIT_EXT")]
    MeshShaderBitEXT = 0x100000,

    [NativeName("VK_PIPELINE_STAGE_COMMAND_PREPROCESS_BIT_EXT")]
    CommandPreprocessBitEXT = 0x20000,

    [NativeName("VK_PIPELINE_STAGE_SHADING_RATE_IMAGE_BIT_NV")]
    ShadingRateImageBitNV = FragmentShadingRateAttachmentBitKHR,

    [NativeName("VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_NV")]
    RayTracingShaderBitNV = RayTracingShaderBitKHR,

    [NativeName("VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_NV")]
    AccelerationStructureBuildBitNV = AccelerationStructureBuildBitKHR,

    [NativeName("VK_PIPELINE_STAGE_TASK_SHADER_BIT_NV")]
    TaskShaderBitNV = TaskShaderBitEXT,

    [NativeName("VK_PIPELINE_STAGE_MESH_SHADER_BIT_NV")]
    MeshShaderBitNV = MeshShaderBitEXT,

    [NativeName("VK_PIPELINE_STAGE_COMMAND_PREPROCESS_BIT_NV")]
    CommandPreprocessBitNV = CommandPreprocessBitEXT,

    [NativeName("VK_PIPELINE_STAGE_NONE_KHR")]
    NoneKHR = None,
}
