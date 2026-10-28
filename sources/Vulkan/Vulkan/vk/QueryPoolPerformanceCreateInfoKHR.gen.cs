// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkQueryPoolPerformanceCreateInfoKHR")]
public unsafe partial struct QueryPoolPerformanceCreateInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.QueryPoolPerformanceCreateInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("queueFamilyIndex")]
    public uint QueueFamilyIndex;

    [NativeName("counterIndexCount")]
    public uint CounterIndexCount;

    [NativeName("pCounterIndices")]
    public uint* PCounterIndices;

    public QueryPoolPerformanceCreateInfoKHR() { }
}
