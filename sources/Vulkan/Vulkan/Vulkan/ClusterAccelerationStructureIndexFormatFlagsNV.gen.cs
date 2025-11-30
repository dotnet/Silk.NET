// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkClusterAccelerationStructureIndexFormatFlagBitsNV")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum ClusterAccelerationStructureIndexFormatFlagsNV : uint
{
    None = 0x0,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_CLUSTER_ACCELERATION_STRUCTURE_INDEX_FORMAT_8BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    Format8Bitnv = 0x1,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_CLUSTER_ACCELERATION_STRUCTURE_INDEX_FORMAT_16BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    Format16Bitnv = 0x2,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_CLUSTER_ACCELERATION_STRUCTURE_INDEX_FORMAT_32BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    Format32Bitnv = 0x4,
}
