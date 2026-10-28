// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkComputeOccupancyPriorityParametersNV")]
public unsafe partial struct ComputeOccupancyPriorityParametersNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.ComputeOccupancyPriorityParametersNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("occupancyPriority")]
    public float OccupancyPriority;

    [NativeName("occupancyThrottling")]
    public float OccupancyThrottling;

    public ComputeOccupancyPriorityParametersNV() { }
}
