// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "EXT")]
[NativeName("VkConditionalRenderingFlagBitsEXT")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkConditionalRenderingFlagsEXT : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_CONDITIONAL_RENDERING_INVERTED_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conditional_rendering"],
        ImpliesSets = [
            "VK_EXT_conditional_rendering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conditional_rendering+VK_VERSION_1_1",
        ]
    )]
    VkConditionalRenderingInvertedBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_CONDITIONAL_RENDERING_FLAG_BITS_MAX_ENUM_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conditional_rendering"],
        ImpliesSets = [
            "VK_EXT_conditional_rendering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conditional_rendering+VK_VERSION_1_1",
        ]
    )]
    VkConditionalRenderingFlagBitsMaxEnum = 0x7FFFFFFF,
}
