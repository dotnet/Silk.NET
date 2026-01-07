// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkClusterAccelerationStructureGeometryFlagsNV")]
    public enum ClusterAccelerationStructureGeometryFlagsNV : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"CullDisableBitNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_GEOMETRY_CULL_DISABLE_BIT_NV")]
        ClusterAccelerationStructureGeometryCullDisableBitNV = 1,
        [Obsolete("Deprecated in favour of \"NoDuplicateAnyhitInvocationBitNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_GEOMETRY_NO_DUPLICATE_ANYHIT_INVOCATION_BIT_NV")]
        ClusterAccelerationStructureGeometryNoDuplicateAnyhitInvocationBitNV = 2,
        [Obsolete("Deprecated in favour of \"OpaqueBitNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_GEOMETRY_OPAQUE_BIT_NV")]
        ClusterAccelerationStructureGeometryOpaqueBitNV = 4,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_GEOMETRY_CULL_DISABLE_BIT_NV")]
        CullDisableBitNV = 1,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_GEOMETRY_NO_DUPLICATE_ANYHIT_INVOCATION_BIT_NV")]
        NoDuplicateAnyhitInvocationBitNV = 2,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_GEOMETRY_OPAQUE_BIT_NV")]
        OpaqueBitNV = 4,
    }
}
