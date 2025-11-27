// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("EXT", 0)]
[NativeName("VkShaderCreateFlagBitsEXT")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum ShaderCreateFlagsEXT : uint
{
    None = 0x0,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_SHADER_CREATE_LINK_STAGE_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    CreateLinkStageBitEXT = 0x1,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_SHADER_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_shader_object+VK_EXT_subgroup_size_control",
            "VK_EXT_shader_object+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    CreateAllowVaryingSubgroupSizeBitEXT = 0x2,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_SHADER_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_shader_object+VK_EXT_subgroup_size_control",
            "VK_EXT_shader_object+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    CreateRequireFullSubgroupsBitEXT = 0x4,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_SHADER_CREATE_NO_TASK_SHADER_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object+VK_EXT_mesh_shader", "VK_EXT_shader_object+VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    CreateNoTaskShaderBitEXT = 0x8,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_SHADER_CREATE_DISPATCH_BASE_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object+VK_KHR_device_group", "VK_EXT_shader_object+VK_VERSION_1_1"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    CreateDispatchBaseBitEXT = 0x10,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_SHADER_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object", "VK_KHR_fragment_shading_rate"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    CreateFragmentShadingRateAttachmentBitEXT = 0x20,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_SHADER_CREATE_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map", "VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    CreateFragmentDensityMapAttachmentBitEXT = 0x40,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_SHADER_CREATE_INDIRECT_BINDABLE_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    CreateIndirectBindableBitEXT = 0x80,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_SHADER_CREATE_64_BIT_INDEXING_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_64bit_indexing"],
        ImpliesSets = [
            "VK_EXT_shader_64bit_indexing+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_64bit_indexing+VK_VERSION_1_1",
        ]
    )]
    Create64BitIndexingBitEXT = 0x8000,
}
