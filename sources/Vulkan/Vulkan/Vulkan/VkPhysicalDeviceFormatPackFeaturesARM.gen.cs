// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceFormatPackFeaturesARM")]
[NameAffix("Suffix", "KhronosVendor", "ARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceFormatPackFeaturesARM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("formatPack")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_format_pack"],
        ImpliesSets = [
            "VK_ARM_format_pack+VK_KHR_get_physical_device_properties2",
            "VK_ARM_format_pack+VK_VERSION_1_1",
        ]
    )]
    public uint FormatPack;
}
