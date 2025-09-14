// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkClusterAccelerationStructureOpModeNV")]
    public enum ClusterAccelerationStructureOpModeNV : int
    {
        [Obsolete("Deprecated in favour of \"ImplicitDestinationsNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_IMPLICIT_DESTINATIONS_NV")]
        ClusterAccelerationStructureOpModeImplicitDestinationsNV = 0,
        [Obsolete("Deprecated in favour of \"ExplicitDestinationsNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_EXPLICIT_DESTINATIONS_NV")]
        ClusterAccelerationStructureOpModeExplicitDestinationsNV = 1,
        [Obsolete("Deprecated in favour of \"ComputeSizesNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_COMPUTE_SIZES_NV")]
        ClusterAccelerationStructureOpModeComputeSizesNV = 2,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_IMPLICIT_DESTINATIONS_NV")]
        ImplicitDestinationsNV = 0,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_EXPLICIT_DESTINATIONS_NV")]
        ExplicitDestinationsNV = 1,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_MODE_COMPUTE_SIZES_NV")]
        ComputeSizesNV = 2,
    }
}
