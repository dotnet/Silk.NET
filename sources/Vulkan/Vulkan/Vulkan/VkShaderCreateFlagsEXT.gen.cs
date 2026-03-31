// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "EXT")]
[NativeName("VkShaderCreateFlagBitsEXT")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkShaderCreateFlagsEXT : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
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
    VkShaderCreateLinkStageBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
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
    VkShaderCreateAllowVaryingSubgroupSizeBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
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
    VkShaderCreateRequireFullSubgroupsBit = 0x00000004,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
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
    VkShaderCreateNoTaskShaderBit = 0x00000008,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
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
    VkShaderCreateDispatchBaseBit = 0x00000010,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
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
    VkShaderCreateFragmentShadingRateAttachmentBit = 0x00000020,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
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
    VkShaderCreateFragmentDensityMapAttachmentBit = 0x00000040,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
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
    VkShaderCreateIndirectBindableBit = 0x00000080,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_SHADER_CREATE_64_BIT_INDEXING_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_64bit_indexing"],
        ImpliesSets = [
            "VK_EXT_shader_64bit_indexing+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_64bit_indexing+VK_VERSION_1_1",
        ]
    )]
    VkShaderCreate64BitIndexingBit = 0x00008000,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_SHADER_CREATE_FLAG_BITS_MAX_ENUM_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    VkShaderCreateFlagBitsMaxEnum = 0x7FFFFFFF,
}
