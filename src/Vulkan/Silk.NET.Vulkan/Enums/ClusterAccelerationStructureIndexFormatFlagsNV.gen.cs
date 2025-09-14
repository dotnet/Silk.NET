// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkClusterAccelerationStructureIndexFormatFlagsNV")]
    public enum ClusterAccelerationStructureIndexFormatFlagsNV : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Format8BitNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_INDEX_FORMAT_8BIT_NV")]
        ClusterAccelerationStructureIndexFormat8BitNV = 1,
        [Obsolete("Deprecated in favour of \"Format16BitNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_INDEX_FORMAT_16BIT_NV")]
        ClusterAccelerationStructureIndexFormat16BitNV = 2,
        [Obsolete("Deprecated in favour of \"Format32BitNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_INDEX_FORMAT_32BIT_NV")]
        ClusterAccelerationStructureIndexFormat32BitNV = 4,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_INDEX_FORMAT_8BIT_NV")]
        Format8BitNV = 1,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_INDEX_FORMAT_16BIT_NV")]
        Format16BitNV = 2,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_INDEX_FORMAT_32BIT_NV")]
        Format32BitNV = 4,
    }
}
