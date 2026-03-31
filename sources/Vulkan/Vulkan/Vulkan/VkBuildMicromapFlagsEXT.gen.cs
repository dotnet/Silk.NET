// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "EXT")]
[NativeName("VkBuildMicromapFlagBitsEXT")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkBuildMicromapFlagsEXT : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_BUILD_MICROMAP_PREFER_FAST_TRACE_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VkBuildMicromapPreferFastTraceBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_BUILD_MICROMAP_PREFER_FAST_BUILD_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VkBuildMicromapPreferFastBuildBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_BUILD_MICROMAP_ALLOW_COMPACTION_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VkBuildMicromapAllowCompactionBit = 0x00000004,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_BUILD_MICROMAP_FLAG_BITS_MAX_ENUM_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    VkBuildMicromapFlagBitsMaxEnum = 0x7FFFFFFF,
}
