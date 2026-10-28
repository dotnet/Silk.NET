// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBuildAccelerationStructureFlagsKHR")]
[Flags]
public enum BuildAccelerationStructureFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_KHR")]
    AllowUpdateBit = 0x1,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_KHR")]
    AllowCompactionBit = 0x2,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR")]
    PreferFastTraceBit = 0x4,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_KHR")]
    PreferFastBuildBit = 0x8,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_KHR")]
    LowMemoryBit = 0x10,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_MOTION_BIT_NV")]
    MotionBitNV = 0x20,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_DATA_UPDATE_BIT_EXT")]
    AllowOpacityMicromapDataUpdateBitEXT = 0x100,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISPLACEMENT_MICROMAP_UPDATE_BIT_NV")]
    AllowDisplacementMicromapUpdateBitNV = 0x200,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DATA_ACCESS_BIT_KHR")]
    AllowDataAccessBit = 0x800,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_CLUSTER_OPACITY_MICROMAPS_BIT_NV")]
    AllowClusterOpacityMicromapsBitNV = 0x1000,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_UPDATE_BIT_KHR")]
    AllowOpacityMicromapUpdateBit = 0x40,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISABLE_OPACITY_MICROMAPS_BIT_KHR")]
    AllowDisableOpacityMicromapsBit = 0x80,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_MICROMAP_LOSSY_BIT_KHR")]
    MicromapLossyBit = 0x400,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_NV")]
    AllowUpdateBitNV = AllowUpdateBit,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_NV")]
    AllowCompactionBitNV = AllowCompactionBit,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_NV")]
    PreferFastTraceBitNV = PreferFastTraceBit,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_NV")]
    PreferFastBuildBitNV = PreferFastBuildBit,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_NV")]
    LowMemoryBitNV = LowMemoryBit,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_UPDATE_BIT_EXT")]
    AllowOpacityMicromapUpdateBitEXT = AllowOpacityMicromapUpdateBit,

    [NativeName("VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISABLE_OPACITY_MICROMAPS_BIT_EXT")]
    AllowDisableOpacityMicromapsBitEXT = AllowDisableOpacityMicromapsBit,
}
