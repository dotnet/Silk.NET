// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "KHR")]
[NativeName("VkScopeKHR")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkScopeKHR : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_SCOPE_DEVICE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_KHR_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_KHR_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkScopeDevice = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_SCOPE_WORKGROUP_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_KHR_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_KHR_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkScopeWorkgroup = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_SCOPE_SUBGROUP_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_KHR_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_KHR_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkScopeSubgroup = 3,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_SCOPE_QUEUE_FAMILY_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_KHR_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_KHR_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkScopeQueueFamily = 5,

    [NativeName("VK_SCOPE_DEVICE_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkScopeDeviceNV = VkScopeDevice,

    [NativeName("VK_SCOPE_WORKGROUP_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkScopeWorkgroupNV = VkScopeWorkgroup,

    [NativeName("VK_SCOPE_SUBGROUP_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkScopeSubgroupNV = VkScopeSubgroup,

    [NativeName("VK_SCOPE_QUEUE_FAMILY_NV")]
    [NameAffix("Suffix", "KhronosVendor", "NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkScopeQueueFamilyNV = VkScopeQueueFamily,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_SCOPE_MAX_ENUM_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_cooperative_matrix"],
        ImpliesSets = [
            "VK_KHR_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_KHR_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    VkScopeMaxEnum = 0x7FFFFFFF,
}
