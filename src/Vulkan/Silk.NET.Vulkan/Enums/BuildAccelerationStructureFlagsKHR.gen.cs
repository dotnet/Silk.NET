// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkBuildAccelerationStructureFlagsKHR")]
    public enum BuildAccelerationStructureFlagsKHR : int
    {
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_KHR")]
        BuildAccelerationStructureAllowUpdateBitKhr = 1,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_KHR")]
        BuildAccelerationStructureAllowCompactionBitKhr = 2,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR")]
        BuildAccelerationStructurePreferFastTraceBitKhr = 4,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_KHR")]
        BuildAccelerationStructurePreferFastBuildBitKhr = 8,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_KHR")]
        BuildAccelerationStructureLowMemoryBitKhr = 16,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_MOTION_BIT_NV")]
        BuildAccelerationStructureMotionBitNV = 32,
    }
}
