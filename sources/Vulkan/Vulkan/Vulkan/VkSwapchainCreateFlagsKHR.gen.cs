// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "KHR")]
[NativeName("VkSwapchainCreateFlagBitsKHR")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkSwapchainCreateFlagsKHR : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    VkSwapchainCreateSplitInstanceBindRegionsBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    VkSwapchainCreateProtectedBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_SWAPCHAIN_CREATE_MUTABLE_FORMAT_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_mutable_format"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_maintenance2+VK_KHR_image_format_list",
            "VK_KHR_swapchain+VK_KHR_maintenance2+VK_VERSION_1_2",
            "VK_KHR_swapchain+VK_VERSION_1_1+VK_KHR_image_format_list",
            "VK_KHR_swapchain+VK_VERSION_1_1+VK_VERSION_1_2",
        ]
    )]
    VkSwapchainCreateMutableFormatBit = 0x00000004,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_SWAPCHAIN_CREATE_PRESENT_ID_2_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id2"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface", "VK_KHR_swapchain"]
    )]
    VkSwapchainCreatePresentId2Bit = 0x00000040,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_SWAPCHAIN_CREATE_PRESENT_WAIT_2_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_wait2"],
        ImpliesSets = [
            "VK_KHR_get_surface_capabilities2",
            "VK_KHR_present_id2",
            "VK_KHR_surface",
            "VK_KHR_swapchain",
        ]
    )]
    VkSwapchainCreatePresentWait2Bit = 0x00000080,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_SWAPCHAIN_CREATE_DEFERRED_MEMORY_ALLOCATION_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    VkSwapchainCreateDeferredMemoryAllocationBit = 0x00000008,

    [NativeName("VK_SWAPCHAIN_CREATE_DEFERRED_MEMORY_ALLOCATION_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    VkSwapchainCreateDeferredMemoryAllocationBitEXT = VkSwapchainCreateDeferredMemoryAllocationBit,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_SWAPCHAIN_CREATE_FLAG_BITS_MAX_ENUM_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    VkSwapchainCreateFlagBitsMaxEnum = 0x7FFFFFFF,
}
