// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceImageCompressionControlSwapchainFeaturesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control_swapchain"],
        ImpliesSets = ["VK_EXT_image_compression_control"]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control_swapchain"],
        ImpliesSets = ["VK_EXT_image_compression_control"]
    )]
    public void* PNext;

    [NativeName("imageCompressionControlSwapchain")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control_swapchain"],
        ImpliesSets = ["VK_EXT_image_compression_control"]
    )]
    public uint ImageCompressionControlSwapchain;
}
