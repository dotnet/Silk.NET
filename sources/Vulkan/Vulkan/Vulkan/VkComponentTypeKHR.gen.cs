// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkComponentTypeKHR : uint
{
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COMPONENT_TYPE_FLOAT16_KHR = 0,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COMPONENT_TYPE_FLOAT32_KHR = 1,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COMPONENT_TYPE_FLOAT64_KHR = 2,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COMPONENT_TYPE_SINT8_KHR = 3,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COMPONENT_TYPE_SINT16_KHR = 4,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COMPONENT_TYPE_SINT32_KHR = 5,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COMPONENT_TYPE_SINT64_KHR = 6,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COMPONENT_TYPE_UINT8_KHR = 7,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COMPONENT_TYPE_UINT16_KHR = 8,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COMPONENT_TYPE_UINT32_KHR = 9,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COMPONENT_TYPE_UINT64_KHR = 10,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix", "VK_KHR_shader_bfloat16"],
        ImpliesSets = [
            "VK_KHR_shader_bfloat16+VK_KHR_get_physical_device_properties2",
            "VK_KHR_shader_bfloat16+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    VK_COMPONENT_TYPE_BFLOAT16_KHR = 1000141000,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COMPONENT_TYPE_SINT8_PACKED_NV = 1000491000,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COMPONENT_TYPE_UINT8_PACKED_NV = 1000491001,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COMPONENT_TYPE_FLOAT_E4M3_NV = 1000491002,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COMPONENT_TYPE_FLOAT_E5M2_NV = 1000491003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VK_COMPONENT_TYPE_FLOAT16_NV = VK_COMPONENT_TYPE_FLOAT16_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VK_COMPONENT_TYPE_FLOAT32_NV = VK_COMPONENT_TYPE_FLOAT32_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VK_COMPONENT_TYPE_FLOAT64_NV = VK_COMPONENT_TYPE_FLOAT64_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VK_COMPONENT_TYPE_SINT8_NV = VK_COMPONENT_TYPE_SINT8_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VK_COMPONENT_TYPE_SINT16_NV = VK_COMPONENT_TYPE_SINT16_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VK_COMPONENT_TYPE_SINT32_NV = VK_COMPONENT_TYPE_SINT32_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VK_COMPONENT_TYPE_SINT64_NV = VK_COMPONENT_TYPE_SINT64_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VK_COMPONENT_TYPE_UINT8_NV = VK_COMPONENT_TYPE_UINT8_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VK_COMPONENT_TYPE_UINT16_NV = VK_COMPONENT_TYPE_UINT16_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VK_COMPONENT_TYPE_UINT32_NV = VK_COMPONENT_TYPE_UINT32_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VK_COMPONENT_TYPE_UINT64_NV = VK_COMPONENT_TYPE_UINT64_KHR,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COMPONENT_TYPE_MAX_ENUM_KHR = 0x7FFFFFFF,
}
