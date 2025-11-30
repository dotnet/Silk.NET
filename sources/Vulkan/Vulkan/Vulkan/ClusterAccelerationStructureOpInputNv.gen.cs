// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkClusterAccelerationStructureOpInputNV")]
[StructLayout(LayoutKind.Explicit)]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ClusterAccelerationStructureOpInputNv
{
    [NativeName("pClustersBottomLevel")]
    [FieldOffset(0)]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ClusterAccelerationStructureClustersBottomLevelInputNv* PClustersBottomLevel;

    [NativeName("pTriangleClusters")]
    [FieldOffset(0)]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ClusterAccelerationStructureTriangleClusterInputNv* PTriangleClusters;

    [NativeName("pMoveObjects")]
    [FieldOffset(0)]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    public ClusterAccelerationStructureMoveObjectsInputNv* PMoveObjects;
}
