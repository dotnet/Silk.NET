// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineShaderStageCreateFlags")]
[Flags]
public enum PipelineShaderStageCreateFlags : uint
{
    None = 0x0,

    [NativeName("VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT")]
    AllowVaryingSubgroupSizeBit = 0x1,

    [NativeName("VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BIT")]
    RequireFullSubgroupsBit = 0x2,

    [NativeName("VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT")]
    AllowVaryingSubgroupSizeBitEXT = AllowVaryingSubgroupSizeBit,

    [NativeName("VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT")]
    RequireFullSubgroupsBitEXT = RequireFullSubgroupsBit,
}
