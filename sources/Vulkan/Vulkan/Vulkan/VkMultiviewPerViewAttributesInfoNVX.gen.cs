// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkMultiviewPerViewAttributesInfoNVX
{
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
    public VkStructureType sType;

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
    public void* pNext;

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
    public uint perViewAttributes;

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
    public uint perViewAttributesPositionXOnly;
}
