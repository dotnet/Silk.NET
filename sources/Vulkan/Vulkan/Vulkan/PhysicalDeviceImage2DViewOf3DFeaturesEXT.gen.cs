// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceImage2DViewOf3DFeaturesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceImage2DViewOf3DFeaturesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_2d_view_of_3d"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_2d_view_of_3d"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("image2DViewOf3D")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_2d_view_of_3d"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    public uint Image2DViewOf3D;

    [NativeName("sampler2DViewOf3D")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_2d_view_of_3d"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    public uint Sampler2DViewOf3D;
}
