// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPipelineStageFlags")]
    public enum PipelineStageFlags : int
    {
        [Obsolete("Deprecated in favour of \"TopOfPipeBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT")]
        PipelineStageTopOfPipeBit = 1,
        [Obsolete("Deprecated in favour of \"DrawIndirectBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT")]
        PipelineStageDrawIndirectBit = 2,
        [Obsolete("Deprecated in favour of \"VertexInputBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_VERTEX_INPUT_BIT")]
        PipelineStageVertexInputBit = 4,
        [Obsolete("Deprecated in favour of \"VertexShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_VERTEX_SHADER_BIT")]
        PipelineStageVertexShaderBit = 8,
        [Obsolete("Deprecated in favour of \"TessellationControlShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT")]
        PipelineStageTessellationControlShaderBit = 16,
        [Obsolete("Deprecated in favour of \"TessellationEvaluationShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT")]
        PipelineStageTessellationEvaluationShaderBit = 32,
        [Obsolete("Deprecated in favour of \"GeometryShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT")]
        PipelineStageGeometryShaderBit = 64,
        [Obsolete("Deprecated in favour of \"FragmentShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT")]
        PipelineStageFragmentShaderBit = 128,
        [Obsolete("Deprecated in favour of \"EarlyFragmentTestsBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT")]
        PipelineStageEarlyFragmentTestsBit = 256,
        [Obsolete("Deprecated in favour of \"LateFragmentTestsBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT")]
        PipelineStageLateFragmentTestsBit = 512,
        [Obsolete("Deprecated in favour of \"ColorAttachmentOutputBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT")]
        PipelineStageColorAttachmentOutputBit = 1024,
        [Obsolete("Deprecated in favour of \"ComputeShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT")]
        PipelineStageComputeShaderBit = 2048,
        [Obsolete("Deprecated in favour of \"TransferBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_TRANSFER_BIT")]
        PipelineStageTransferBit = 4096,
        [Obsolete("Deprecated in favour of \"BottomOfPipeBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT")]
        PipelineStageBottomOfPipeBit = 8192,
        [Obsolete("Deprecated in favour of \"HostBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_HOST_BIT")]
        PipelineStageHostBit = 16384,
        [Obsolete("Deprecated in favour of \"AllGraphicsBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT")]
        PipelineStageAllGraphicsBit = 32768,
        [Obsolete("Deprecated in favour of \"AllCommandsBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_ALL_COMMANDS_BIT")]
        PipelineStageAllCommandsBit = 65536,
        [Obsolete("Deprecated in favour of \"TransformFeedbackBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_TRANSFORM_FEEDBACK_BIT_EXT")]
        PipelineStageTransformFeedbackBitExt = 16777216,
        [Obsolete("Deprecated in favour of \"ConditionalRenderingBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_CONDITIONAL_RENDERING_BIT_EXT")]
        PipelineStageConditionalRenderingBitExt = 262144,
        [Obsolete("Deprecated in favour of \"AccelerationStructureBuildBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_KHR")]
        PipelineStageAccelerationStructureBuildBitKhr = 33554432,
        [Obsolete("Deprecated in favour of \"RayTracingShaderBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_KHR")]
        PipelineStageRayTracingShaderBitKhr = 2097152,
        [Obsolete("Deprecated in favour of \"ShadingRateImageBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_SHADING_RATE_IMAGE_BIT_NV")]
        PipelineStageShadingRateImageBitNV = 4194304,
        [Obsolete("Deprecated in favour of \"RayTracingShaderBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_NV")]
        PipelineStageRayTracingShaderBitNV = 2097152,
        [Obsolete("Deprecated in favour of \"AccelerationStructureBuildBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_NV")]
        PipelineStageAccelerationStructureBuildBitNV = 33554432,
        [Obsolete("Deprecated in favour of \"TaskShaderBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_TASK_SHADER_BIT_NV")]
        PipelineStageTaskShaderBitNV = 524288,
        [Obsolete("Deprecated in favour of \"MeshShaderBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_MESH_SHADER_BIT_NV")]
        PipelineStageMeshShaderBitNV = 1048576,
        [Obsolete("Deprecated in favour of \"FragmentDensityProcessBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_FRAGMENT_DENSITY_PROCESS_BIT_EXT")]
        PipelineStageFragmentDensityProcessBitExt = 8388608,
        [Obsolete("Deprecated in favour of \"FragmentShadingRateAttachmentBitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        PipelineStageFragmentShadingRateAttachmentBitKhr = 4194304,
        [Obsolete("Deprecated in favour of \"CommandPreprocessBitNV\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_COMMAND_PREPROCESS_BIT_NV")]
        PipelineStageCommandPreprocessBitNV = 131072,
        [Obsolete("Deprecated in favour of \"NoneKhr\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_NONE_KHR")]
        PipelineStageNoneKhr = 0,
        [Obsolete("Deprecated in favour of \"TaskShaderBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_TASK_SHADER_BIT_EXT")]
        PipelineStageTaskShaderBitExt = 524288,
        [Obsolete("Deprecated in favour of \"MeshShaderBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_MESH_SHADER_BIT_EXT")]
        PipelineStageMeshShaderBitExt = 1048576,
        [Obsolete("Deprecated in favour of \"CommandPreprocessBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_COMMAND_PREPROCESS_BIT_EXT")]
        PipelineStageCommandPreprocessBitExt = 131072,
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_NONE")]
        PipelineStageNone = 0,
        [NativeName("Name", "VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT")]
        TopOfPipeBit = 1,
        [NativeName("Name", "VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT")]
        DrawIndirectBit = 2,
        [NativeName("Name", "VK_PIPELINE_STAGE_VERTEX_INPUT_BIT")]
        VertexInputBit = 4,
        [NativeName("Name", "VK_PIPELINE_STAGE_VERTEX_SHADER_BIT")]
        VertexShaderBit = 8,
        [NativeName("Name", "VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT")]
        TessellationControlShaderBit = 16,
        [NativeName("Name", "VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT")]
        TessellationEvaluationShaderBit = 32,
        [NativeName("Name", "VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT")]
        GeometryShaderBit = 64,
        [NativeName("Name", "VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT")]
        FragmentShaderBit = 128,
        [NativeName("Name", "VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT")]
        EarlyFragmentTestsBit = 256,
        [NativeName("Name", "VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT")]
        LateFragmentTestsBit = 512,
        [NativeName("Name", "VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT")]
        ColorAttachmentOutputBit = 1024,
        [NativeName("Name", "VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT")]
        ComputeShaderBit = 2048,
        [NativeName("Name", "VK_PIPELINE_STAGE_TRANSFER_BIT")]
        TransferBit = 4096,
        [NativeName("Name", "VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT")]
        BottomOfPipeBit = 8192,
        [NativeName("Name", "VK_PIPELINE_STAGE_HOST_BIT")]
        HostBit = 16384,
        [NativeName("Name", "VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT")]
        AllGraphicsBit = 32768,
        [NativeName("Name", "VK_PIPELINE_STAGE_ALL_COMMANDS_BIT")]
        AllCommandsBit = 65536,
        [NativeName("Name", "VK_PIPELINE_STAGE_TRANSFORM_FEEDBACK_BIT_EXT")]
        TransformFeedbackBitExt = 16777216,
        [NativeName("Name", "VK_PIPELINE_STAGE_CONDITIONAL_RENDERING_BIT_EXT")]
        ConditionalRenderingBitExt = 262144,
        [NativeName("Name", "VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_KHR")]
        AccelerationStructureBuildBitKhr = 33554432,
        [NativeName("Name", "VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_KHR")]
        RayTracingShaderBitKhr = 2097152,
        [NativeName("Name", "VK_PIPELINE_STAGE_SHADING_RATE_IMAGE_BIT_NV")]
        ShadingRateImageBitNV = 4194304,
        [NativeName("Name", "VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_NV")]
        RayTracingShaderBitNV = 2097152,
        [NativeName("Name", "VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_NV")]
        AccelerationStructureBuildBitNV = 33554432,
        [NativeName("Name", "VK_PIPELINE_STAGE_TASK_SHADER_BIT_NV")]
        TaskShaderBitNV = 524288,
        [NativeName("Name", "VK_PIPELINE_STAGE_MESH_SHADER_BIT_NV")]
        MeshShaderBitNV = 1048576,
        [NativeName("Name", "VK_PIPELINE_STAGE_FRAGMENT_DENSITY_PROCESS_BIT_EXT")]
        FragmentDensityProcessBitExt = 8388608,
        [NativeName("Name", "VK_PIPELINE_STAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        FragmentShadingRateAttachmentBitKhr = 4194304,
        [NativeName("Name", "VK_PIPELINE_STAGE_COMMAND_PREPROCESS_BIT_NV")]
        CommandPreprocessBitNV = 131072,
        [NativeName("Name", "VK_PIPELINE_STAGE_NONE_KHR")]
        NoneKhr = 0,
        [NativeName("Name", "VK_PIPELINE_STAGE_TASK_SHADER_BIT_EXT")]
        TaskShaderBitExt = 524288,
        [NativeName("Name", "VK_PIPELINE_STAGE_MESH_SHADER_BIT_EXT")]
        MeshShaderBitExt = 1048576,
        [NativeName("Name", "VK_PIPELINE_STAGE_COMMAND_PREPROCESS_BIT_EXT")]
        CommandPreprocessBitExt = 131072,
        [NativeName("Name", "VK_PIPELINE_STAGE_NONE")]
        None = 0,
    }
}
