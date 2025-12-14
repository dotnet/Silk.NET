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
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_NONE")]
        PipelineStage2None = 0,
        [Obsolete("Deprecated in favour of \"TopOfPipeBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT")]
        PipelineStage2TopOfPipeBit = 1,
        [Obsolete("Deprecated in favour of \"DrawIndirectBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT")]
        PipelineStage2DrawIndirectBit = 2,
        [Obsolete("Deprecated in favour of \"VertexInputBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT")]
        PipelineStage2VertexInputBit = 4,
        [Obsolete("Deprecated in favour of \"VertexShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT")]
        PipelineStage2VertexShaderBit = 8,
        [Obsolete("Deprecated in favour of \"TessellationControlShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT")]
        PipelineStage2TessellationControlShaderBit = 16,
        [Obsolete("Deprecated in favour of \"TessellationEvaluationShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT")]
        PipelineStage2TessellationEvaluationShaderBit = 32,
        [Obsolete("Deprecated in favour of \"GeometryShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT")]
        PipelineStage2GeometryShaderBit = 64,
        [Obsolete("Deprecated in favour of \"FragmentShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT")]
        PipelineStage2FragmentShaderBit = 128,
        [Obsolete("Deprecated in favour of \"EarlyFragmentTestsBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT")]
        PipelineStage2EarlyFragmentTestsBit = 256,
        [Obsolete("Deprecated in favour of \"LateFragmentTestsBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT")]
        PipelineStage2LateFragmentTestsBit = 512,
        [Obsolete("Deprecated in favour of \"ColorAttachmentOutputBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT")]
        PipelineStage2ColorAttachmentOutputBit = 1024,
        [Obsolete("Deprecated in favour of \"ComputeShaderBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT")]
        PipelineStage2ComputeShaderBit = 2048,
        [Obsolete("Deprecated in favour of \"AllTransferBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT")]
        PipelineStage2AllTransferBit = 4096,
        [Obsolete("Deprecated in favour of \"TransferBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TRANSFER_BIT")]
        PipelineStage2TransferBit = 4096,
        [Obsolete("Deprecated in favour of \"BottomOfPipeBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT")]
        PipelineStage2BottomOfPipeBit = 8192,
        [Obsolete("Deprecated in favour of \"HostBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_HOST_BIT")]
        PipelineStage2HostBit = 16384,
        [Obsolete("Deprecated in favour of \"AllGraphicsBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT")]
        PipelineStage2AllGraphicsBit = 32768,
        [Obsolete("Deprecated in favour of \"AllCommandsBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT")]
        PipelineStage2AllCommandsBit = 65536,
        [Obsolete("Deprecated in favour of \"CopyBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COPY_BIT")]
        PipelineStage2CopyBit = 4294967296,
        [Obsolete("Deprecated in favour of \"ResolveBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_RESOLVE_BIT")]
        PipelineStage2ResolveBit = 8589934592,
        [Obsolete("Deprecated in favour of \"BlitBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_BLIT_BIT")]
        PipelineStage2BlitBit = 17179869184,
        [Obsolete("Deprecated in favour of \"ClearBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_CLEAR_BIT")]
        PipelineStage2ClearBit = 34359738368,
        [Obsolete("Deprecated in favour of \"IndexInputBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT")]
        PipelineStage2IndexInputBit = 68719476736,
        [Obsolete("Deprecated in favour of \"VertexAttributeInputBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT")]
        PipelineStage2VertexAttributeInputBit = 137438953472,
        [Obsolete("Deprecated in favour of \"PreRasterizationShadersBit\"")]
        [NativeName("Name", "VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT")]
        PipelineStage2PreRasterizationShadersBit = 274877906944,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_NONE")]
        None = 0,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT")]
        TopOfPipeBit = 1,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT")]
        DrawIndirectBit = 2,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT")]
        VertexInputBit = 4,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT")]
        VertexShaderBit = 8,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT")]
        TessellationControlShaderBit = 16,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT")]
        TessellationEvaluationShaderBit = 32,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT")]
        GeometryShaderBit = 64,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT")]
        FragmentShaderBit = 128,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT")]
        EarlyFragmentTestsBit = 256,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT")]
        LateFragmentTestsBit = 512,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT")]
        ColorAttachmentOutputBit = 1024,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT")]
        ComputeShaderBit = 2048,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT")]
        AllTransferBit = 4096,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_TRANSFER_BIT")]
        TransferBit = 4096,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT")]
        BottomOfPipeBit = 8192,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_HOST_BIT")]
        HostBit = 16384,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT")]
        AllGraphicsBit = 32768,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT")]
        AllCommandsBit = 65536,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_COPY_BIT")]
        CopyBit = 4294967296,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_RESOLVE_BIT")]
        ResolveBit = 8589934592,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_BLIT_BIT")]
        BlitBit = 17179869184,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_CLEAR_BIT")]
        ClearBit = 34359738368,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT")]
        IndexInputBit = 68719476736,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT")]
        VertexAttributeInputBit = 137438953472,
        [NativeName("Name", "VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT")]
        PreRasterizationShadersBit = 274877906944,
    }
}
