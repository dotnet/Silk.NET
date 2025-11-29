// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkClusterAccelerationStructureClusterFlagBitsNV")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum ClusterAccelerationStructureClusterFlagsNV : uint
{
    None = 0x0,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_CLUSTER_ACCELERATION_STRUCTURE_CLUSTER_ALLOW_DISABLE_OPACITY_MICROMAPS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    AllowDisableOpacityMicromapsNV = 0x1,
}
