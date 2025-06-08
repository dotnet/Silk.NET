// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkSubmitFlags
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_SUBMIT_PROTECTED_BIT = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_synchronization2"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_VERSION_1_1",
        ]
    )]
    VK_SUBMIT_PROTECTED_BIT_KHR = VK_SUBMIT_PROTECTED_BIT,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_SUBMIT_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}
