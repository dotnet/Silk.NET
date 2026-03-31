// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceRawAccessChainsFeaturesNV")]
[NameAffix("Suffix", "KhronosVendor", "NV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceRawAccessChainsFeaturesNV
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_raw_access_chains"],
        ImpliesSets = [
            "VK_NV_raw_access_chains+VK_KHR_get_physical_device_properties2",
            "VK_NV_raw_access_chains+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_raw_access_chains"],
        ImpliesSets = [
            "VK_NV_raw_access_chains+VK_KHR_get_physical_device_properties2",
            "VK_NV_raw_access_chains+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("shaderRawAccessChains")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_raw_access_chains"],
        ImpliesSets = [
            "VK_NV_raw_access_chains+VK_KHR_get_physical_device_properties2",
            "VK_NV_raw_access_chains+VK_VERSION_1_1",
        ]
    )]
    public uint ShaderRawAccessChains;
}
