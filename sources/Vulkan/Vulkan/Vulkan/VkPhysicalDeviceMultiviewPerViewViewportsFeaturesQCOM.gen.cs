// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_multiview_per_view_viewports"],
        ImpliesSets = [
            "VK_QCOM_multiview_per_view_viewports+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_multiview_per_view_viewports+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_multiview_per_view_viewports"],
        ImpliesSets = [
            "VK_QCOM_multiview_per_view_viewports+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_multiview_per_view_viewports+VK_VERSION_1_1",
        ]
    )]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_multiview_per_view_viewports"],
        ImpliesSets = [
            "VK_QCOM_multiview_per_view_viewports+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_multiview_per_view_viewports+VK_VERSION_1_1",
        ]
    )]
    public uint multiviewPerViewViewports;
}
