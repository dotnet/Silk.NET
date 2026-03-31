// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "KHR")]
[NativeName("VkComponentTypeKHR")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkComponentTypeKHR : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COMPONENT_TYPE_FLOAT16_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeFloat16 = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COMPONENT_TYPE_FLOAT32_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeFloat32 = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COMPONENT_TYPE_FLOAT64_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeFloat64 = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COMPONENT_TYPE_SINT8_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeSint8 = 3,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COMPONENT_TYPE_SINT16_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeSint16 = 4,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COMPONENT_TYPE_SINT32_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeSint32 = 5,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COMPONENT_TYPE_SINT64_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeSint64 = 6,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COMPONENT_TYPE_UINT8_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeUint8 = 7,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COMPONENT_TYPE_UINT16_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeUint16 = 8,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COMPONENT_TYPE_UINT32_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeUint32 = 9,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COMPONENT_TYPE_UINT64_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeUint64 = 10,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
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
    VkComponentTypeBfloat16 = 1000141000,

    [NativeName("VK_COMPONENT_TYPE_SINT8_PACKED_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeSint8PackedNV = 1000491000,

    [NativeName("VK_COMPONENT_TYPE_UINT8_PACKED_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeUint8PackedNV = 1000491001,

    [NativeName("VK_COMPONENT_TYPE_FLOAT8_E4M3_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_float8", "VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_EXT_shader_float8+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_float8+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkComponentTypeFloat8E4M3EXT = 1000491002,

    [NativeName("VK_COMPONENT_TYPE_FLOAT8_E5M2_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_float8", "VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_EXT_shader_float8+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_float8+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VkComponentTypeFloat8E5M2EXT = 1000491003,

    [NativeName("VK_COMPONENT_TYPE_FLOAT16_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeFloat16NV = VkComponentTypeFloat16,

    [NativeName("VK_COMPONENT_TYPE_FLOAT32_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeFloat32NV = VkComponentTypeFloat32,

    [NativeName("VK_COMPONENT_TYPE_FLOAT64_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeFloat64NV = VkComponentTypeFloat64,

    [NativeName("VK_COMPONENT_TYPE_SINT8_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeSint8NV = VkComponentTypeSint8,

    [NativeName("VK_COMPONENT_TYPE_SINT16_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeSint16NV = VkComponentTypeSint16,

    [NativeName("VK_COMPONENT_TYPE_SINT32_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeSint32NV = VkComponentTypeSint32,

    [NativeName("VK_COMPONENT_TYPE_SINT64_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeSint64NV = VkComponentTypeSint64,

    [NativeName("VK_COMPONENT_TYPE_UINT8_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeUint8NV = VkComponentTypeUint8,

    [NativeName("VK_COMPONENT_TYPE_UINT16_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeUint16NV = VkComponentTypeUint16,

    [NativeName("VK_COMPONENT_TYPE_UINT32_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeUint32NV = VkComponentTypeUint32,

    [NativeName("VK_COMPONENT_TYPE_UINT64_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeUint64NV = VkComponentTypeUint64,

    [NativeName("VK_COMPONENT_TYPE_FLOAT_E4M3_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeFloatE4M3NV = VkComponentTypeFloat8E4M3EXT,

    [NativeName("VK_COMPONENT_TYPE_FLOAT_E5M2_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeFloatE5M2NV = VkComponentTypeFloat8E5M2EXT,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COMPONENT_TYPE_MAX_ENUM_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_vector"],
        ImpliesSets = [
            "VK_NV_cooperative_vector+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_vector+VK_VERSION_1_1",
        ]
    )]
    VkComponentTypeMaxEnum = 0x7FFFFFFF,
}
