// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkPipelineStageFlags")]
    public enum PipelineStageFlags : int
    {
        [NativeName("Name", "VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT")]
        PipelineStageTopOfPipeBit = 1,
        [NativeName("Name", "VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT")]
        PipelineStageDrawIndirectBit = 2,
        [NativeName("Name", "VK_PIPELINE_STAGE_VERTEX_INPUT_BIT")]
        PipelineStageVertexInputBit = 4,
        [NativeName("Name", "VK_PIPELINE_STAGE_VERTEX_SHADER_BIT")]
        PipelineStageVertexShaderBit = 8,
        [NativeName("Name", "VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT")]
        PipelineStageTessellationControlShaderBit = 16,
        [NativeName("Name", "VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT")]
        PipelineStageTessellationEvaluationShaderBit = 32,
        [NativeName("Name", "VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT")]
        PipelineStageGeometryShaderBit = 64,
        [NativeName("Name", "VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT")]
        PipelineStageFragmentShaderBit = 128,
        [NativeName("Name", "VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT")]
        PipelineStageEarlyFragmentTestsBit = 256,
        [NativeName("Name", "VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT")]
        PipelineStageLateFragmentTestsBit = 512,
        [NativeName("Name", "VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT")]
        PipelineStageColorAttachmentOutputBit = 1024,
        [NativeName("Name", "VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT")]
        PipelineStageComputeShaderBit = 2048,
        [NativeName("Name", "VK_PIPELINE_STAGE_TRANSFER_BIT")]
        PipelineStageTransferBit = 4096,
        [NativeName("Name", "VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT")]
        PipelineStageBottomOfPipeBit = 8192,
        [NativeName("Name", "VK_PIPELINE_STAGE_HOST_BIT")]
        PipelineStageHostBit = 16384,
        [NativeName("Name", "VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT")]
        PipelineStageAllGraphicsBit = 32768,
        [NativeName("Name", "VK_PIPELINE_STAGE_ALL_COMMANDS_BIT")]
        PipelineStageAllCommandsBit = 65536,
        [NativeName("Name", "VK_PIPELINE_STAGE_RESERVED_27_BIT_KHR")]
        PipelineStageReserved27BitKhr = 134217728,
        [NativeName("Name", "VK_PIPELINE_STAGE_RESERVED_26_BIT_KHR")]
        PipelineStageReserved26BitKhr = 67108864,
        [NativeName("Name", "VK_PIPELINE_STAGE_TRANSFORM_FEEDBACK_BIT_EXT")]
        PipelineStageTransformFeedbackBitExt = 16777216,
        [NativeName("Name", "VK_PIPELINE_STAGE_CONDITIONAL_RENDERING_BIT_EXT")]
        PipelineStageConditionalRenderingBitExt = 262144,
        [NativeName("Name", "VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_KHR")]
        PipelineStageAccelerationStructureBuildBitKhr = 33554432,
        [NativeName("Name", "VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_KHR")]
        PipelineStageRayTracingShaderBitKhr = 2097152,
        [NativeName("Name", "VK_PIPELINE_STAGE_SHADING_RATE_IMAGE_BIT_NV")]
        PipelineStageShadingRateImageBitNV = 4194304,
        [NativeName("Name", "VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_NV")]
        PipelineStageRayTracingShaderBitNV = 2097152,
        [NativeName("Name", "VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_NV")]
        PipelineStageAccelerationStructureBuildBitNV = 33554432,
        [NativeName("Name", "VK_PIPELINE_STAGE_TASK_SHADER_BIT_NV")]
        PipelineStageTaskShaderBitNV = 524288,
        [NativeName("Name", "VK_PIPELINE_STAGE_MESH_SHADER_BIT_NV")]
        PipelineStageMeshShaderBitNV = 1048576,
        [NativeName("Name", "VK_PIPELINE_STAGE_FRAGMENT_DENSITY_PROCESS_BIT_EXT")]
        PipelineStageFragmentDensityProcessBitExt = 8388608,
        [NativeName("Name", "VK_PIPELINE_STAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR")]
        PipelineStageFragmentShadingRateAttachmentBitKhr = 4194304,
        [NativeName("Name", "VK_PIPELINE_STAGE_COMMAND_PREPROCESS_BIT_NV")]
        PipelineStageCommandPreprocessBitNV = 131072,
    }
}
