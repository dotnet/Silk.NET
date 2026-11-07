// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkShaderCreateFlagsEXT")]
[Flags]
public enum ShaderCreateFlagsEXT : uint
{
    None = 0x0,

    [NativeName("VK_SHADER_CREATE_LINK_STAGE_BIT_EXT")]
    CreateLinkStageBit = 0x1,

    [NativeName("VK_SHADER_CREATE_DESCRIPTOR_HEAP_BIT_EXT")]
    CreateDescriptorHeapBit = 0x400,

    [NativeName("VK_SHADER_CREATE_INSTRUMENT_SHADER_BIT_ARM")]
    CreateInstrumentShaderBitARM = 0x800,

    [NativeName("VK_SHADER_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT")]
    CreateAllowVaryingSubgroupSizeBit = 0x2,

    [NativeName("VK_SHADER_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT")]
    CreateRequireFullSubgroupsBit = 0x4,

    [NativeName("VK_SHADER_CREATE_NO_TASK_SHADER_BIT_EXT")]
    CreateNoTaskShaderBit = 0x8,

    [NativeName("VK_SHADER_CREATE_DISPATCH_BASE_BIT_EXT")]
    CreateDispatchBaseBit = 0x10,

    [NativeName("VK_SHADER_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_EXT")]
    CreateFragmentShadingRateAttachmentBit = 0x20,

    [NativeName("VK_SHADER_CREATE_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
    CreateFragmentDensityMapAttachmentBit = 0x40,

    [NativeName("VK_SHADER_CREATE_INDIRECT_BINDABLE_BIT_EXT")]
    CreateIndirectBindableBit = 0x80,

    [NativeName("VK_SHADER_CREATE_OPACITY_MICROMAP_DISALLOW_MIXED_SPECIAL_INDEX_BIT_EXT")]
    CreateOpacityMicromapDisallowMixedSpecialIndexBit = 0x1000,

    [NativeName("VK_SHADER_CREATE_64_BIT_INDEXING_BIT_EXT")]
    Create64BitIndexingBit = 0x8000,

    [NativeName("VK_SHADER_CREATE_INDEPENDENT_SETS_BIT_KHR")]
    CreateIndependentSetsBitKHR = 0x40000,
}
