// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSwapchainStateSamplerVulkanFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SwapchainStateSamplerVulkanFB
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_vulkan"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_vulkan_enable", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.SwapchainStateSamplerVulkanFB;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_vulkan"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_vulkan_enable", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("minFilter")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_vulkan"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_vulkan_enable", "XR_VERSION_1_0"]
    )]
    public VkFilter MinFilter;

    [NativeName("magFilter")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_vulkan"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_vulkan_enable", "XR_VERSION_1_0"]
    )]
    public VkFilter MagFilter;

    [NativeName("mipmapMode")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_vulkan"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_vulkan_enable", "XR_VERSION_1_0"]
    )]
    public VkSamplerMipmapMode MipmapMode;

    [NativeName("wrapModeS")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_vulkan"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_vulkan_enable", "XR_VERSION_1_0"]
    )]
    public VkSamplerAddressMode WrapModeS;

    [NativeName("wrapModeT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_vulkan"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_vulkan_enable", "XR_VERSION_1_0"]
    )]
    public VkSamplerAddressMode WrapModeT;

    [NativeName("swizzleRed")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_vulkan"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_vulkan_enable", "XR_VERSION_1_0"]
    )]
    public VkComponentSwizzle SwizzleRed;

    [NativeName("swizzleGreen")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_vulkan"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_vulkan_enable", "XR_VERSION_1_0"]
    )]
    public VkComponentSwizzle SwizzleGreen;

    [NativeName("swizzleBlue")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_vulkan"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_vulkan_enable", "XR_VERSION_1_0"]
    )]
    public VkComponentSwizzle SwizzleBlue;

    [NativeName("swizzleAlpha")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_vulkan"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_vulkan_enable", "XR_VERSION_1_0"]
    )]
    public VkComponentSwizzle SwizzleAlpha;

    [NativeName("maxAnisotropy")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_vulkan"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_vulkan_enable", "XR_VERSION_1_0"]
    )]
    public float MaxAnisotropy;

    [NativeName("borderColor")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_vulkan"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_vulkan_enable", "XR_VERSION_1_0"]
    )]
    public Color4F BorderColor;

    [SupportedApiProfile(
        "openxr",
        ["XR_FB_swapchain_update_state_vulkan"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_KHR_vulkan_enable", "XR_VERSION_1_0"]
    )]
    public SwapchainStateSamplerVulkanFB() { }
}
