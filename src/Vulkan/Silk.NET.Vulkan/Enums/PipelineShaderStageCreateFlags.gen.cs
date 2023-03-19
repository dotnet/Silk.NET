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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"AllowVaryingSubgroupSizeBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT")]
        PipelineShaderStageCreateAllowVaryingSubgroupSizeBitExt = 1,
        [Obsolete("Deprecated in favour of \"RequireFullSubgroupsBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT")]
        PipelineShaderStageCreateRequireFullSubgroupsBitExt = 2,
        [Obsolete("Deprecated in favour of \"AllowVaryingSubgroupSizeBit\"")]
        [NativeName("Name", "VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT")]
        PipelineShaderStageCreateAllowVaryingSubgroupSizeBit = 1,
        [Obsolete("Deprecated in favour of \"RequireFullSubgroupsBit\"")]
        [NativeName("Name", "VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BIT")]
        PipelineShaderStageCreateRequireFullSubgroupsBit = 2,
        [NativeName("Name", "VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT")]
        AllowVaryingSubgroupSizeBitExt = 1,
        [NativeName("Name", "VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT")]
        RequireFullSubgroupsBitExt = 2,
        [NativeName("Name", "VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT")]
        AllowVaryingSubgroupSizeBit = 1,
        [NativeName("Name", "VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BIT")]
        RequireFullSubgroupsBit = 2,
    }
}
