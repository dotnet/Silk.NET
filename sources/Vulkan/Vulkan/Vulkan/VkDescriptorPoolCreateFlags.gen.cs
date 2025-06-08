// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkDescriptorPoolCreateFlags
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT = 0x00000002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mutable_descriptor_type"],
        ImpliesSets = [
            "VK_EXT_mutable_descriptor_type+VK_KHR_maintenance3",
            "VK_EXT_mutable_descriptor_type+VK_VERSION_1_1",
        ]
    )]
    VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_EXT = 0x00000004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_descriptor_pool_overallocation"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_SETS_BIT_NV = 0x00000008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_descriptor_pool_overallocation"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_POOLS_BIT_NV = 0x00000010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT_EXT =
        VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_mutable_descriptor_type"],
        ImpliesSets = ["VK_KHR_maintenance3"]
    )]
    VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_VALVE = VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_EXT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_DESCRIPTOR_POOL_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}
