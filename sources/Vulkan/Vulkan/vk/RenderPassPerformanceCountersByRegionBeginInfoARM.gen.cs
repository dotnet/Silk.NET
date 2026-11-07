// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRenderPassPerformanceCountersByRegionBeginInfoARM")]
public unsafe partial struct RenderPassPerformanceCountersByRegionBeginInfoARM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.RenderPassPerformanceCountersByRegionBeginInfoARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("counterAddressCount")]
    public uint CounterAddressCount;

    [NativeName("pCounterAddresses")]
    public ulong* PCounterAddresses;

    [NativeName("serializeRegions")]
    public MaybeBool<uint> SerializeRegions;

    [NativeName("counterIndexCount")]
    public uint CounterIndexCount;

    [NativeName("pCounterIndices")]
    public uint* PCounterIndices;

    public RenderPassPerformanceCountersByRegionBeginInfoARM() { }
}
