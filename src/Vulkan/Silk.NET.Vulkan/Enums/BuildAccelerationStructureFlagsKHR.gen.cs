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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"AllowUpdateBitKhr\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_KHR")]
        BuildAccelerationStructureAllowUpdateBitKhr = 1,
        [Obsolete("Deprecated in favour of \"AllowCompactionBitKhr\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_KHR")]
        BuildAccelerationStructureAllowCompactionBitKhr = 2,
        [Obsolete("Deprecated in favour of \"PreferFastTraceBitKhr\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR")]
        BuildAccelerationStructurePreferFastTraceBitKhr = 4,
        [Obsolete("Deprecated in favour of \"PreferFastBuildBitKhr\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_KHR")]
        BuildAccelerationStructurePreferFastBuildBitKhr = 8,
        [Obsolete("Deprecated in favour of \"LowMemoryBitKhr\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_KHR")]
        BuildAccelerationStructureLowMemoryBitKhr = 16,
        [Obsolete("Deprecated in favour of \"MotionBitNV\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_MOTION_BIT_NV")]
        BuildAccelerationStructureMotionBitNV = 32,
        [Obsolete("Deprecated in favour of \"AllowOpacityMicromapUpdateExt\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_UPDATE_EXT")]
        BuildAccelerationStructureAllowOpacityMicromapUpdateExt = 64,
        [Obsolete("Deprecated in favour of \"AllowDisableOpacityMicromapsExt\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISABLE_OPACITY_MICROMAPS_EXT")]
        BuildAccelerationStructureAllowDisableOpacityMicromapsExt = 128,
        [Obsolete("Deprecated in favour of \"AllowOpacityMicromapDataUpdateExt\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_DATA_UPDATE_EXT")]
        BuildAccelerationStructureAllowOpacityMicromapDataUpdateExt = 256,
        [Obsolete("Deprecated in favour of \"AllowDisplacementMicromapUpdateNV\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISPLACEMENT_MICROMAP_UPDATE_NV")]
        BuildAccelerationStructureAllowDisplacementMicromapUpdateNV = 512,
        [Obsolete("Deprecated in favour of \"AllowDataAccessKhr\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DATA_ACCESS_KHR")]
        BuildAccelerationStructureAllowDataAccessKhr = 2048,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_KHR")]
        AllowUpdateBitKhr = 1,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_KHR")]
        AllowCompactionBitKhr = 2,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR")]
        PreferFastTraceBitKhr = 4,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_KHR")]
        PreferFastBuildBitKhr = 8,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_KHR")]
        LowMemoryBitKhr = 16,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_MOTION_BIT_NV")]
        MotionBitNV = 32,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_UPDATE_EXT")]
        AllowOpacityMicromapUpdateExt = 64,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISABLE_OPACITY_MICROMAPS_EXT")]
        AllowDisableOpacityMicromapsExt = 128,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_DATA_UPDATE_EXT")]
        AllowOpacityMicromapDataUpdateExt = 256,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISPLACEMENT_MICROMAP_UPDATE_NV")]
        AllowDisplacementMicromapUpdateNV = 512,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DATA_ACCESS_KHR")]
        AllowDataAccessKhr = 2048,
    }
}
