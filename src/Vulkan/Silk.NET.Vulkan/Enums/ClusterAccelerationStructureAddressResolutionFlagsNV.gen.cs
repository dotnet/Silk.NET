// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkClusterAccelerationStructureAddressResolutionFlagsNV")]
    public enum ClusterAccelerationStructureAddressResolutionFlagsNV : int
    {
        [Obsolete("Deprecated in favour of \"NoneNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_NONE_NV")]
        ClusterAccelerationStructureAddressResolutionNoneNV = 0,
        [Obsolete("Deprecated in favour of \"IndirectedDstImplicitDataBitNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_IMPLICIT_DATA_BIT_NV")]
        ClusterAccelerationStructureAddressResolutionIndirectedDstImplicitDataBitNV = 1,
        [Obsolete("Deprecated in favour of \"IndirectedScratchDataBitNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SCRATCH_DATA_BIT_NV")]
        ClusterAccelerationStructureAddressResolutionIndirectedScratchDataBitNV = 2,
        [Obsolete("Deprecated in favour of \"IndirectedDstAddressArrayBitNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_ADDRESS_ARRAY_BIT_NV")]
        ClusterAccelerationStructureAddressResolutionIndirectedDstAddressArrayBitNV = 4,
        [Obsolete("Deprecated in favour of \"IndirectedDstSizesArrayBitNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_SIZES_ARRAY_BIT_NV")]
        ClusterAccelerationStructureAddressResolutionIndirectedDstSizesArrayBitNV = 8,
        [Obsolete("Deprecated in favour of \"IndirectedSrcInfosArrayBitNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SRC_INFOS_ARRAY_BIT_NV")]
        ClusterAccelerationStructureAddressResolutionIndirectedSrcInfosArrayBitNV = 16,
        [Obsolete("Deprecated in favour of \"IndirectedSrcInfosCountBitNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SRC_INFOS_COUNT_BIT_NV")]
        ClusterAccelerationStructureAddressResolutionIndirectedSrcInfosCountBitNV = 32,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_NONE_NV")]
        NoneNV = 0,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_IMPLICIT_DATA_BIT_NV")]
        IndirectedDstImplicitDataBitNV = 1,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SCRATCH_DATA_BIT_NV")]
        IndirectedScratchDataBitNV = 2,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_ADDRESS_ARRAY_BIT_NV")]
        IndirectedDstAddressArrayBitNV = 4,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_SIZES_ARRAY_BIT_NV")]
        IndirectedDstSizesArrayBitNV = 8,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SRC_INFOS_ARRAY_BIT_NV")]
        IndirectedSrcInfosArrayBitNV = 16,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SRC_INFOS_COUNT_BIT_NV")]
        IndirectedSrcInfosCountBitNV = 32,
    }
}
