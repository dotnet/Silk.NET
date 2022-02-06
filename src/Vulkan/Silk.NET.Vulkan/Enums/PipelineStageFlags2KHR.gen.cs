// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPipelineStageFlags2KHR")]
    public enum PipelineStageFlags2KHR : long
    {
        [NativeName("Name", "VK_PIPELINE_STAGE_2_NONE")]
        PipelineStage2None = 0,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_NONE_KHR")]
        PipelineStage2NoneKhr = 0,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT")]
        PipelineStage2TopOfPipeBit = 1,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT_KHR")]
        PipelineStage2TopOfPipeBitKhr = 1,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT")]
        PipelineStage2DrawIndirectBit = 2,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT_KHR")]
        PipelineStage2DrawIndirectBitKhr = 2,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT")]
        PipelineStage2VertexInputBit = 4,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT_KHR")]
        PipelineStage2VertexInputBitKhr = 4,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT")]
        PipelineStage2VertexShaderBit = 8,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT_KHR")]
        PipelineStage2VertexShaderBitKhr = 8,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT")]
        PipelineStage2TessellationControlShaderBit = 16,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT_KHR")]
        PipelineStage2TessellationControlShaderBitKhr = 16,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT")]
        PipelineStage2TessellationEvaluationShaderBit = 32,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT_KHR")]
        PipelineStage2TessellationEvaluationShaderBitKhr = 32,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT")]
        PipelineStage2GeometryShaderBit = 64,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT_KHR")]
        PipelineStage2GeometryShaderBitKhr = 64,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT")]
        PipelineStage2FragmentShaderBit = 128,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT_KHR")]
        PipelineStage2FragmentShaderBitKhr = 128,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT")]
        PipelineStage2EarlyFragmentTestsBit = 256,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT_KHR")]
        PipelineStage2EarlyFragmentTestsBitKhr = 256,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT")]
        PipelineStage2LateFragmentTestsBit = 512,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT_KHR")]
        PipelineStage2LateFragmentTestsBitKhr = 512,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT")]
        PipelineStage2ColorAttachmentOutputBit = 1024,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT_KHR")]
        PipelineStage2ColorAttachmentOutputBitKhr = 1024,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT")]
        PipelineStage2ComputeShaderBit = 2048,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT_KHR")]
        PipelineStage2ComputeShaderBitKhr = 2048,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT")]
        PipelineStage2AllTransferBit = 4096,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT_KHR")]
        PipelineStage2AllTransferBitKhr = 4096,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TRANSFER_BIT")]
        PipelineStage2TransferBit = 4096,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TRANSFER_BIT_KHR")]
        PipelineStage2TransferBitKhr = 4096,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT")]
        PipelineStage2BottomOfPipeBit = 8192,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT_KHR")]
        PipelineStage2BottomOfPipeBitKhr = 8192,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_HOST_BIT")]
        PipelineStage2HostBit = 16384,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_HOST_BIT_KHR")]
        PipelineStage2HostBitKhr = 16384,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT")]
        PipelineStage2AllGraphicsBit = 32768,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT_KHR")]
        PipelineStage2AllGraphicsBitKhr = 32768,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT")]
        PipelineStage2AllCommandsBit = 65536,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT_KHR")]
        PipelineStage2AllCommandsBitKhr = 65536,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COPY_BIT")]
        PipelineStage2CopyBit = 4294967296,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COPY_BIT_KHR")]
        PipelineStage2CopyBitKhr = 4294967296,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_RESOLVE_BIT")]
        PipelineStage2ResolveBit = 8589934592,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_RESOLVE_BIT_KHR")]
        PipelineStage2ResolveBitKhr = 8589934592,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_BLIT_BIT")]
        PipelineStage2BlitBit = 17179869184,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_BLIT_BIT_KHR")]
        PipelineStage2BlitBitKhr = 17179869184,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_CLEAR_BIT")]
        PipelineStage2ClearBit = 34359738368,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_CLEAR_BIT_KHR")]
        PipelineStage2ClearBitKhr = 34359738368,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT")]
        PipelineStage2IndexInputBit = 68719476736,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT_KHR")]
        PipelineStage2IndexInputBitKhr = 68719476736,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT")]
        PipelineStage2VertexAttributeInputBit = 137438953472,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT_KHR")]
        PipelineStage2VertexAttributeInputBitKhr = 137438953472,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT")]
        PipelineStage2PreRasterizationShadersBit = 274877906944,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT_KHR")]
        PipelineStage2PreRasterizationShadersBitKhr = 274877906944,
    }
}
