// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceASTCDecodeFeaturesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceASTCDecodeFeaturesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_astc_decode_mode"],
        ImpliesSets = [
            "VK_EXT_astc_decode_mode+VK_KHR_get_physical_device_properties2",
            "VK_EXT_astc_decode_mode+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_astc_decode_mode"],
        ImpliesSets = [
            "VK_EXT_astc_decode_mode+VK_KHR_get_physical_device_properties2",
            "VK_EXT_astc_decode_mode+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("decodeModeSharedExponent")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_astc_decode_mode"],
        ImpliesSets = [
            "VK_EXT_astc_decode_mode+VK_KHR_get_physical_device_properties2",
            "VK_EXT_astc_decode_mode+VK_VERSION_1_1",
        ]
    )]
    public uint DecodeModeSharedExponent;
}
