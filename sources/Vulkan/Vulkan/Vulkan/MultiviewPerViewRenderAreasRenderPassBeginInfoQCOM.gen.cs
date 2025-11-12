// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct MultiviewPerViewRenderAreasRenderPassBeginInfoQCOM
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_multiview_per_view_render_areas"],
        ImpliesSets = [
            "VK_QCOM_multiview_per_view_render_areas+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_multiview_per_view_render_areas+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_multiview_per_view_render_areas"],
        ImpliesSets = [
            "VK_QCOM_multiview_per_view_render_areas+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_multiview_per_view_render_areas+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_multiview_per_view_render_areas"],
        ImpliesSets = [
            "VK_QCOM_multiview_per_view_render_areas+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_multiview_per_view_render_areas+VK_VERSION_1_1",
        ]
    )]
    public uint PerViewRenderAreaCount;

    [NativeTypeName("const VkRect2D *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_multiview_per_view_render_areas"],
        ImpliesSets = [
            "VK_QCOM_multiview_per_view_render_areas+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_multiview_per_view_render_areas+VK_VERSION_1_1",
        ]
    )]
    public Rect2D* PPerViewRenderAreas;
}
