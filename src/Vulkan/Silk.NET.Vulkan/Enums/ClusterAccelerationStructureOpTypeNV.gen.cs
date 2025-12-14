// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkClusterAccelerationStructureOpTypeNV")]
    public enum ClusterAccelerationStructureOpTypeNV : int
    {
        [Obsolete("Deprecated in favour of \"MoveObjectsNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_MOVE_OBJECTS_NV")]
        ClusterAccelerationStructureOpTypeMoveObjectsNV = 0,
        [Obsolete("Deprecated in favour of \"BuildClustersBottomLevelNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_BUILD_CLUSTERS_BOTTOM_LEVEL_NV")]
        ClusterAccelerationStructureOpTypeBuildClustersBottomLevelNV = 1,
        [Obsolete("Deprecated in favour of \"BuildTriangleClusterNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_BUILD_TRIANGLE_CLUSTER_NV")]
        ClusterAccelerationStructureOpTypeBuildTriangleClusterNV = 2,
        [Obsolete("Deprecated in favour of \"BuildTriangleClusterTemplateNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_BUILD_TRIANGLE_CLUSTER_TEMPLATE_NV")]
        ClusterAccelerationStructureOpTypeBuildTriangleClusterTemplateNV = 3,
        [Obsolete("Deprecated in favour of \"InstantiateTriangleClusterNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_INSTANTIATE_TRIANGLE_CLUSTER_NV")]
        ClusterAccelerationStructureOpTypeInstantiateTriangleClusterNV = 4,
        [Obsolete("Deprecated in favour of \"GetClusterTemplateIndicesNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_GET_CLUSTER_TEMPLATE_INDICES_NV")]
        ClusterAccelerationStructureOpTypeGetClusterTemplateIndicesNV = 5,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_MOVE_OBJECTS_NV")]
        MoveObjectsNV = 0,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_BUILD_CLUSTERS_BOTTOM_LEVEL_NV")]
        BuildClustersBottomLevelNV = 1,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_BUILD_TRIANGLE_CLUSTER_NV")]
        BuildTriangleClusterNV = 2,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_BUILD_TRIANGLE_CLUSTER_TEMPLATE_NV")]
        BuildTriangleClusterTemplateNV = 3,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_INSTANTIATE_TRIANGLE_CLUSTER_NV")]
        InstantiateTriangleClusterNV = 4,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_OP_TYPE_GET_CLUSTER_TEMPLATE_INDICES_NV")]
        GetClusterTemplateIndicesNV = 5,
    }
}
