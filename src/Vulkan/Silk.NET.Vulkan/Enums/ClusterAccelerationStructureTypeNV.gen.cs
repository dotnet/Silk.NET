// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkClusterAccelerationStructureTypeNV")]
    public enum ClusterAccelerationStructureTypeNV : int
    {
        [Obsolete("Deprecated in favour of \"ClustersBottomLevelNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_TYPE_CLUSTERS_BOTTOM_LEVEL_NV")]
        ClusterAccelerationStructureTypeClustersBottomLevelNV = 0,
        [Obsolete("Deprecated in favour of \"TriangleClusterNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_TYPE_TRIANGLE_CLUSTER_NV")]
        ClusterAccelerationStructureTypeTriangleClusterNV = 1,
        [Obsolete("Deprecated in favour of \"TriangleClusterTemplateNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_TYPE_TRIANGLE_CLUSTER_TEMPLATE_NV")]
        ClusterAccelerationStructureTypeTriangleClusterTemplateNV = 2,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_TYPE_CLUSTERS_BOTTOM_LEVEL_NV")]
        ClustersBottomLevelNV = 0,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_TYPE_TRIANGLE_CLUSTER_NV")]
        TriangleClusterNV = 1,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_TYPE_TRIANGLE_CLUSTER_TEMPLATE_NV")]
        TriangleClusterTemplateNV = 2,
    }
}
