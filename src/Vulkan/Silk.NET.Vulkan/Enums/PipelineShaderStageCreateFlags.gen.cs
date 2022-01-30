// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPipelineShaderStageCreateFlags")]
    public enum PipelineShaderStageCreateFlags : int
    {
        [NativeName("Name", "VK_PIPELINE_SHADER_STAGE_CREATE_RESERVED_2_BIT_NV")]
        PipelineShaderStageCreateReserved2BitNV = 4,
        [NativeName("Name", "VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT")]
        PipelineShaderStageCreateAllowVaryingSubgroupSizeBitExt = 1,
        [NativeName("Name", "VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT")]
        PipelineShaderStageCreateRequireFullSubgroupsBitExt = 2,
        [NativeName("Name", "VK_PIPELINE_SHADER_STAGE_CREATE_RESERVED_3_BIT_KHR")]
        PipelineShaderStageCreateReserved3BitKhr = 8,
    }
}
