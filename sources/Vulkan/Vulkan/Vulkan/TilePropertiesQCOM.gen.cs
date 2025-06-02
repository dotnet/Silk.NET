// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct TilePropertiesQCOM
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    public Extent3D TileSize;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    public Extent2D ApronSize;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_tile_properties"],
        ImpliesSets = [
            "VK_QCOM_tile_properties+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_tile_properties+VK_VERSION_1_1",
        ]
    )]
    public Offset2D Origin;
}
