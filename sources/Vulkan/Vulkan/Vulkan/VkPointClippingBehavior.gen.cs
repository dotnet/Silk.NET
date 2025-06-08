// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkPointClippingBehavior
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY = 1,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES_KHR = VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY_KHR =
        VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_POINT_CLIPPING_BEHAVIOR_MAX_ENUM = 0x7FFFFFFF,
}
