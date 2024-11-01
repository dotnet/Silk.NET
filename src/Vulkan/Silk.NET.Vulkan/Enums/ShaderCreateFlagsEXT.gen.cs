// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkShaderCreateFlagsEXT")]
    public enum ShaderCreateFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"LinkStageBitExt\"")]
        [NativeName("Name", "VK_SHADER_CREATE_LINK_STAGE_BIT_EXT")]
        ShaderCreateLinkStageBitExt = 1,
        [Obsolete("Deprecated in favour of \"AllowVaryingSubgroupSizeBitExt\"")]
        [NativeName("Name", "VK_SHADER_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT")]
        ShaderCreateAllowVaryingSubgroupSizeBitExt = 2,
        [Obsolete("Deprecated in favour of \"RequireFullSubgroupsBitExt\"")]
        [NativeName("Name", "VK_SHADER_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT")]
        ShaderCreateRequireFullSubgroupsBitExt = 4,
        [Obsolete("Deprecated in favour of \"NoTaskShaderBitExt\"")]
        [NativeName("Name", "VK_SHADER_CREATE_NO_TASK_SHADER_BIT_EXT")]
        ShaderCreateNoTaskShaderBitExt = 8,
        [Obsolete("Deprecated in favour of \"DispatchBaseBitExt\"")]
        [NativeName("Name", "VK_SHADER_CREATE_DISPATCH_BASE_BIT_EXT")]
        ShaderCreateDispatchBaseBitExt = 16,
        [Obsolete("Deprecated in favour of \"FragmentShadingRateAttachmentBitExt\"")]
        [NativeName("Name", "VK_SHADER_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_EXT")]
        ShaderCreateFragmentShadingRateAttachmentBitExt = 32,
        [Obsolete("Deprecated in favour of \"FragmentDensityMapAttachmentBitExt\"")]
        [NativeName("Name", "VK_SHADER_CREATE_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
        ShaderCreateFragmentDensityMapAttachmentBitExt = 64,
        [Obsolete("Deprecated in favour of \"IndirectBindableBitExt\"")]
        [NativeName("Name", "VK_SHADER_CREATE_INDIRECT_BINDABLE_BIT_EXT")]
        ShaderCreateIndirectBindableBitExt = 128,
        [NativeName("Name", "VK_SHADER_CREATE_LINK_STAGE_BIT_EXT")]
        LinkStageBitExt = 1,
        [NativeName("Name", "VK_SHADER_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT")]
        AllowVaryingSubgroupSizeBitExt = 2,
        [NativeName("Name", "VK_SHADER_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT")]
        RequireFullSubgroupsBitExt = 4,
        [NativeName("Name", "VK_SHADER_CREATE_NO_TASK_SHADER_BIT_EXT")]
        NoTaskShaderBitExt = 8,
        [NativeName("Name", "VK_SHADER_CREATE_DISPATCH_BASE_BIT_EXT")]
        DispatchBaseBitExt = 16,
        [NativeName("Name", "VK_SHADER_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_EXT")]
        FragmentShadingRateAttachmentBitExt = 32,
        [NativeName("Name", "VK_SHADER_CREATE_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
        FragmentDensityMapAttachmentBitExt = 64,
        [NativeName("Name", "VK_SHADER_CREATE_INDIRECT_BINDABLE_BIT_EXT")]
        IndirectBindableBitExt = 128,
    }
}
