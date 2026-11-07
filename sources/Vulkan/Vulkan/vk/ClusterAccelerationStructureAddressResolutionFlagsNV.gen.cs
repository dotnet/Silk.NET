// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkClusterAccelerationStructureAddressResolutionFlagsNV")]
[Flags]
public enum ClusterAccelerationStructureAddressResolutionFlagsNV : uint
{
    [NativeName("VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_NONE_NV")]
    None = 0x0,

    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_IMPLICIT_DATA_BIT_NV"
    )]
    IndirectedDstImplicitDataBit = 0x1,

    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SCRATCH_DATA_BIT_NV"
    )]
    IndirectedScratchDataBit = 0x2,

    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_ADDRESS_ARRAY_BIT_NV"
    )]
    IndirectedDstAddressArrayBit = 0x4,

    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_SIZES_ARRAY_BIT_NV"
    )]
    IndirectedDstSizesArrayBit = 0x8,

    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SRC_INFOS_ARRAY_BIT_NV"
    )]
    IndirectedSrcInfosArrayBit = 0x10,

    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SRC_INFOS_COUNT_BIT_NV"
    )]
    IndirectedSrcInfosCountBit = 0x20,
}
