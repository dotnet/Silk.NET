// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceRobustness2FeaturesKHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceRobustness2FeaturesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_robustness2"],
        ImpliesSets = [
            "VK_KHR_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_robustness2+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_robustness2"],
        ImpliesSets = [
            "VK_KHR_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_robustness2+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("robustBufferAccess2")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_robustness2"],
        ImpliesSets = [
            "VK_KHR_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_robustness2+VK_VERSION_1_1",
        ]
    )]
    public uint RobustBufferAccess2;

    [NativeName("robustImageAccess2")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_robustness2"],
        ImpliesSets = [
            "VK_KHR_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_robustness2+VK_VERSION_1_1",
        ]
    )]
    public uint RobustImageAccess2;

    [NativeName("nullDescriptor")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_robustness2"],
        ImpliesSets = [
            "VK_KHR_robustness2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_robustness2+VK_VERSION_1_1",
        ]
    )]
    public uint NullDescriptor;
}
