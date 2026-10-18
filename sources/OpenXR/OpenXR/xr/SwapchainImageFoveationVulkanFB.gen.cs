// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSwapchainImageFoveationVulkanFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SwapchainImageFoveationVulkanFB
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_vulkan"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.SwapchainImageFoveationVulkanFB;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_vulkan"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("image")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_vulkan"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    public VkImageHandle Image;

    [NativeName("width")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_vulkan"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    public uint Width;

    [NativeName("height")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_vulkan"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    public uint Height;

    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_vulkan"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    public SwapchainImageFoveationVulkanFB() { }
}
