// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkTilePropertiesQCOM
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    public void* pNext;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    public VkExtent3D tileSize;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    public VkExtent2D apronSize;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    public VkOffset2D origin;
}
