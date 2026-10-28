// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkMicromapBuildInfoEXT")]
public unsafe partial struct MicromapBuildInfoEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.MicromapBuildInfoEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("type")]
    public MicromapTypeEXT Type;

    [NativeName("flags")]
    public BuildMicromapFlagsEXT Flags;

    [NativeName("mode")]
    public BuildMicromapModeEXT Mode;

    [NativeName("dstMicromap")]
    public MicromapHandleEXT DstMicromap;

    [NativeName("usageCountsCount")]
    public uint UsageCountsCount;

    [NativeName("pUsageCounts")]
    public MicromapUsageEXT* PUsageCounts;

    [NativeName("ppUsageCounts")]
    public MicromapUsageEXT** PpUsageCounts;

    [NativeName("data")]
    public DeviceOrHostAddressConstKHR Data;

    [NativeName("scratchData")]
    public DeviceOrHostAddressKHR ScratchData;

    [NativeName("triangleArray")]
    public DeviceOrHostAddressConstKHR TriangleArray;

    [NativeName("triangleArrayStride")]
    public ulong TriangleArrayStride;

    public MicromapBuildInfoEXT() { }
}
