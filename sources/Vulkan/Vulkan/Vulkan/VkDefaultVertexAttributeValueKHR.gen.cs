// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "KHR")]
[NativeName("VkDefaultVertexAttributeValueKHR")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkDefaultVertexAttributeValueKHR : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_DEFAULT_VERTEX_ATTRIBUTE_VALUE_ZERO_ZERO_ZERO_ZERO_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance9"],
        ImpliesSets = [
            "VK_KHR_maintenance9+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance9+VK_VERSION_1_1",
        ]
    )]
    VkDefaultVertexAttributeValueZeroZeroZeroZero = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_DEFAULT_VERTEX_ATTRIBUTE_VALUE_ZERO_ZERO_ZERO_ONE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance9"],
        ImpliesSets = [
            "VK_KHR_maintenance9+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance9+VK_VERSION_1_1",
        ]
    )]
    VkDefaultVertexAttributeValueZeroZeroZeroOne = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_DEFAULT_VERTEX_ATTRIBUTE_VALUE_MAX_ENUM_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance9"],
        ImpliesSets = [
            "VK_KHR_maintenance9+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance9+VK_VERSION_1_1",
        ]
    )]
    VkDefaultVertexAttributeValueMaxEnum = 0x7FFFFFFF,
}
