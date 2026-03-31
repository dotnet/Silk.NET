// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSurfaceCapabilities2EXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkSurfaceCapabilities2EXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    public void* PNext;

    [NativeName("minImageCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    public uint MinImageCount;

    [NativeName("maxImageCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    public uint MaxImageCount;

    [NativeName("currentExtent")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    public VkExtent2D CurrentExtent;

    [NativeName("minImageExtent")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    public VkExtent2D MinImageExtent;

    [NativeName("maxImageExtent")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    public VkExtent2D MaxImageExtent;

    [NativeName("maxImageArrayLayers")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    public uint MaxImageArrayLayers;

    [NativeName("supportedTransforms")]
    [NativeTypeName("VkSurfaceTransformFlagsKHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    public VkSurfaceTransformFlagsKHR SupportedTransforms;

    [NativeName("currentTransform")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    public VkSurfaceTransformFlagsKHR CurrentTransform;

    [NativeName("supportedCompositeAlpha")]
    [NativeTypeName("VkCompositeAlphaFlagsKHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    public VkCompositeAlphaFlagsKHR SupportedCompositeAlpha;

    [NativeName("supportedUsageFlags")]
    [NativeTypeName("VkImageUsageFlags")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    public VkImageUsageFlags SupportedUsageFlags;

    [NativeName("supportedSurfaceCounters")]
    [NativeTypeName("VkSurfaceCounterFlagsEXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_surface_counter"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    public VkSurfaceCounterFlagsEXT SupportedSurfaceCounters;
}
