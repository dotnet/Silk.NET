// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NativeName("VkMultiviewPerViewAttributesInfoNVX")]
[NameAffix("Suffix", "KhronosVendor", "NVX")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkMultiviewPerViewAttributesInfoNVX
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_dynamic_rendering",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_multiview",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_dynamic_rendering",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_multiview",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("perViewAttributes")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_dynamic_rendering",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_multiview",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_1",
        ]
    )]
    public uint PerViewAttributes;

    [NativeName("perViewAttributesPositionXOnly")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_dynamic_rendering",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_NVX_multiview_per_view_attributes+VK_KHR_multiview",
            "VK_NVX_multiview_per_view_attributes+VK_VERSION_1_1",
        ]
    )]
    public uint PerViewAttributesPositionXOnly;
}
