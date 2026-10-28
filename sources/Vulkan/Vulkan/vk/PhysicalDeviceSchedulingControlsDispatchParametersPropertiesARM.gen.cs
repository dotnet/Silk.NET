// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM")]
public unsafe partial struct PhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM
{
    [NativeName("sType")]
    public StructureType SType =
        StructureType.PhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("schedulingControlsMaxWarpsCount")]
    public uint SchedulingControlsMaxWarpsCount;

    [NativeName("schedulingControlsMaxQueuedBatchesCount")]
    public uint SchedulingControlsMaxQueuedBatchesCount;

    [NativeName("schedulingControlsMaxWorkGroupBatchSize")]
    public uint SchedulingControlsMaxWorkGroupBatchSize;

    public PhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM() { }
}
