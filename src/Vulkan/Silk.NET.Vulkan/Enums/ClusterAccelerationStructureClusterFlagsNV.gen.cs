// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkClusterAccelerationStructureClusterFlagsNV")]
    public enum ClusterAccelerationStructureClusterFlagsNV : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"AllowDisableOpacityMicromapsNV\"")]
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_CLUSTER_ALLOW_DISABLE_OPACITY_MICROMAPS_NV")]
        ClusterAccelerationStructureClusterAllowDisableOpacityMicromapsNV = 1,
        [NativeName("Name", "VK_CLUSTER_ACCELERATION_STRUCTURE_CLUSTER_ALLOW_DISABLE_OPACITY_MICROMAPS_NV")]
        AllowDisableOpacityMicromapsNV = 1,
    }
}
