// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDevicePerformanceCountersByRegionPropertiesARM")]
public unsafe partial struct PhysicalDevicePerformanceCountersByRegionPropertiesARM
{
    [NativeName("sType")]
    public StructureType SType =
        StructureType.PhysicalDevicePerformanceCountersByRegionPropertiesARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxPerRegionPerformanceCounters")]
    public uint MaxPerRegionPerformanceCounters;

    [NativeName("performanceCounterRegionSize")]
    public Extent2D PerformanceCounterRegionSize;

    [NativeName("rowStrideAlignment")]
    public uint RowStrideAlignment;

    [NativeName("regionAlignment")]
    public uint RegionAlignment;

    [NativeName("identityTransformOrder")]
    public MaybeBool<uint> IdentityTransformOrder;

    public PhysicalDevicePerformanceCountersByRegionPropertiesARM() { }
}
