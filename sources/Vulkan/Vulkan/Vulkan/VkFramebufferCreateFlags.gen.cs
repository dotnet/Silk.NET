// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkFramebufferCreateFlags
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_imageless_framebuffer"],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_get_physical_device_properties2+VK_KHR_maintenance2",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT_KHR = VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_0", "VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.0"
    )]
    VK_FRAMEBUFFER_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}
