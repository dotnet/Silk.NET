// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureGeometryMicromapDataKHR")]
public unsafe partial struct AccelerationStructureGeometryMicromapDataKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.AccelerationStructureGeometryMicromapDataKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("usageCountsCount")]
    public uint UsageCountsCount;

    [NativeName("pUsageCounts")]
    public MicromapUsageKHR* PUsageCounts;

    [NativeName("ppUsageCounts")]
    public MicromapUsageKHR** PpUsageCounts;

    [NativeName("data")]
    public ulong Data;

    [NativeName("triangleArray")]
    public ulong TriangleArray;

    [NativeName("triangleArrayStride")]
    public ulong TriangleArrayStride;

    public AccelerationStructureGeometryMicromapDataKHR() { }
}
