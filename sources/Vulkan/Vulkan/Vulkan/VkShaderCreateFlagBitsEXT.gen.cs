// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum ShaderCreateFlagsEXT : uint
{
    None = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    LinkStageBitEXT = 0x00000001,

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
    AllowVaryingSubgroupSizeBitEXT = 0x00000002,

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
    RequireFullSubgroupsBitEXT = 0x00000004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object+VK_EXT_mesh_shader", "VK_EXT_shader_object+VK_NV_mesh_shader"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    NoTaskShaderBitEXT = 0x00000008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object+VK_KHR_device_group", "VK_EXT_shader_object+VK_VERSION_1_1"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    DispatchBaseBitEXT = 0x00000010,

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
    FragmentShadingRateAttachmentBitEXT = 0x00000020,

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
    FragmentDensityMapAttachmentBitEXT = 0x00000040,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    IndirectBindableBitEXT = 0x00000080,
}
