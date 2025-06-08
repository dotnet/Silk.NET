// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkDependencyFlags
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_DEPENDENCY_BY_REGION_BIT = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_DEPENDENCY_DEVICE_GROUP_BIT = 0x00000004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_DEPENDENCY_VIEW_LOCAL_BIT = 0x00000002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_attachment_feedback_loop_layout"],
        ImpliesSets = [
            "VK_EXT_attachment_feedback_loop_layout+VK_KHR_get_physical_device_properties2",
            "VK_EXT_attachment_feedback_loop_layout+VK_VERSION_1_1",
        ]
    )]
    VK_DEPENDENCY_FEEDBACK_LOOP_BIT_EXT = 0x00000008,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance8"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_DEPENDENCY_QUEUE_FAMILY_OWNERSHIP_TRANSFER_USE_ALL_STAGES_BIT_KHR = 0x00000020,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_multiview"],
        ImpliesSets = [
            "VK_KHR_multiview+VK_KHR_get_physical_device_properties2",
            "VK_KHR_multiview+VK_VERSION_1_1",
        ]
    )]
    VK_DEPENDENCY_VIEW_LOCAL_BIT_KHR = VK_DEPENDENCY_VIEW_LOCAL_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    VK_DEPENDENCY_DEVICE_GROUP_BIT_KHR = VK_DEPENDENCY_DEVICE_GROUP_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_DEPENDENCY_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}
