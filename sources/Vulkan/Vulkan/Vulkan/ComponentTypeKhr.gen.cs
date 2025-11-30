// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkComponentTypeKHR")]
[SupportedApiProfile("vulkan")]
public enum ComponentTypeKhr : uint
{
    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_COMPONENT_TYPE_FLOAT16_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    Float16Khr = 0,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_COMPONENT_TYPE_FLOAT32_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    Float32Khr = 1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_COMPONENT_TYPE_FLOAT64_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    Float64Khr = 2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_COMPONENT_TYPE_SINT8_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    Sint8Khr = 3,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_COMPONENT_TYPE_SINT16_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    Sint16Khr = 4,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_COMPONENT_TYPE_SINT32_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    Sint32Khr = 5,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_COMPONENT_TYPE_SINT64_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    Sint64Khr = 6,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_COMPONENT_TYPE_UINT8_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    Uint8Khr = 7,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_COMPONENT_TYPE_UINT16_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    Uint16Khr = 8,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_COMPONENT_TYPE_UINT32_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    Uint32Khr = 9,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_COMPONENT_TYPE_UINT64_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    Uint64Khr = 10,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_COMPONENT_TYPE_BFLOAT16_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix", "VK_KHR_shader_bfloat16"],
        ImpliesSets = [
            "VK_KHR_shader_bfloat16+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_bfloat16+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    Bfloat16Khr = 1000141000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COMPONENT_TYPE_SINT8_PACKED_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    Sint8Packednv = 1000491000,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COMPONENT_TYPE_UINT8_PACKED_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    Uint8Packednv = 1000491001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COMPONENT_TYPE_FLOAT8_E4M3_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_float8", "VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_EXT_shader_float8+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_float8+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    Float8E4M3Ext = 1000491002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COMPONENT_TYPE_FLOAT8_E5M2_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_float8", "VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_EXT_shader_float8+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_float8+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    Float8E5M2Ext = 1000491003,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COMPONENT_TYPE_FLOAT16_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Float16Nv = Float16Khr,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COMPONENT_TYPE_FLOAT32_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Float32Nv = Float32Khr,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COMPONENT_TYPE_FLOAT64_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Float64Nv = Float64Khr,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COMPONENT_TYPE_SINT8_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Sint8Nv = Sint8Khr,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COMPONENT_TYPE_SINT16_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Sint16Nv = Sint16Khr,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COMPONENT_TYPE_SINT32_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Sint32Nv = Sint32Khr,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COMPONENT_TYPE_SINT64_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Sint64Nv = Sint64Khr,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COMPONENT_TYPE_UINT8_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Uint8Nv = Uint8Khr,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COMPONENT_TYPE_UINT16_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Uint16Nv = Uint16Khr,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COMPONENT_TYPE_UINT32_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Uint32Nv = Uint32Khr,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COMPONENT_TYPE_UINT64_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    Uint64Nv = Uint64Khr,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COMPONENT_TYPE_FLOAT_E4M3_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    FloatE4M3Nv = Float8E4M3Ext,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COMPONENT_TYPE_FLOAT_E5M2_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    FloatE5M2Nv = Float8E5M2Ext,
}
