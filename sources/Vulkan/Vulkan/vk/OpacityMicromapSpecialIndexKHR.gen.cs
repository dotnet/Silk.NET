// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkOpacityMicromapSpecialIndexKHR")]
[SupportedApiProfile("vulkan")]
public enum OpacityMicromapSpecialIndexKHR
{
    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_TRANSPARENT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    FullyTransparent = -1,

    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_OPAQUE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    FullyOpaque = -2,

    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_TRANSPARENT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    FullyUnknownTransparent = -3,

    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_OPAQUE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    FullyUnknownOpaque = -4,

    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_CLUSTER_GEOMETRY_DISABLE_OPACITY_MICROMAP_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap", "VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    ClusterGeometryDisableOpacityMicromapNV = -5,

    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_TRANSPARENT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    FullyTransparentEXT = FullyTransparent,

    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_OPAQUE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    FullyOpaqueEXT = FullyOpaque,

    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_TRANSPARENT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    FullyUnknownTransparentEXT = FullyUnknownTransparent,

    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_OPAQUE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    FullyUnknownOpaqueEXT = FullyUnknownOpaque,
}
