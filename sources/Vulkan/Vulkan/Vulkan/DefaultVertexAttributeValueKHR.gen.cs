// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkDefaultVertexAttributeValueKHR")]
[SupportedApiProfile("vulkan")]
public enum DefaultVertexAttributeValueKHR : uint
{
    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_DEFAULT_VERTEX_ATTRIBUTE_VALUE_ZERO_ZERO_ZERO_ZERO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance9"],
        ImpliesSets = [
            "VK_KHR_maintenance9+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance9+VK_VERSION_1_1",
        ]
    )]
    ZeroZeroZeroZerokhr = 0,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_DEFAULT_VERTEX_ATTRIBUTE_VALUE_ZERO_ZERO_ZERO_ONE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance9"],
        ImpliesSets = [
            "VK_KHR_maintenance9+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance9+VK_VERSION_1_1",
        ]
    )]
    ZeroZeroZeroOnekhr = 1,
}
