// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkIndexType
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_INDEX_TYPE_UINT16 = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_INDEX_TYPE_UINT32 = 1,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_INDEX_TYPE_UINT8 = 1000265000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    VK_INDEX_TYPE_NONE_KHR = 1000165000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    VK_INDEX_TYPE_NONE_NV = VK_INDEX_TYPE_NONE_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_index_type_uint8"],
        ImpliesSets = [
            "VK_EXT_index_type_uint8+VK_KHR_get_physical_device_properties2",
            "VK_EXT_index_type_uint8+VK_VERSION_1_1",
        ]
    )]
    VK_INDEX_TYPE_UINT8_EXT = VK_INDEX_TYPE_UINT8,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_index_type_uint8"],
        ImpliesSets = [
            "VK_KHR_index_type_uint8+VK_KHR_get_physical_device_properties2",
            "VK_KHR_index_type_uint8+VK_VERSION_1_1",
        ]
    )]
    VK_INDEX_TYPE_UINT8_KHR = VK_INDEX_TYPE_UINT8,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_INDEX_TYPE_MAX_ENUM = 0x7FFFFFFF,
}
