// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkTessellationDomainOrigin
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT = 1,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT_KHR = VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance2"])]
    VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT_KHR = VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_TESSELLATION_DOMAIN_ORIGIN_MAX_ENUM = 0x7FFFFFFF,
}
