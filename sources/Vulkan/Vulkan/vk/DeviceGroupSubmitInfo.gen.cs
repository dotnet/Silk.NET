// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDeviceGroupSubmitInfo")]
public unsafe partial struct DeviceGroupSubmitInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DeviceGroupSubmitInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("waitSemaphoreCount")]
    public uint WaitSemaphoreCount;

    [NativeName("pWaitSemaphoreDeviceIndices")]
    public uint* PWaitSemaphoreDeviceIndices;

    [NativeName("commandBufferCount")]
    public uint CommandBufferCount;

    [NativeName("pCommandBufferDeviceMasks")]
    public uint* PCommandBufferDeviceMasks;

    [NativeName("signalSemaphoreCount")]
    public uint SignalSemaphoreCount;

    [NativeName("pSignalSemaphoreDeviceIndices")]
    public uint* PSignalSemaphoreDeviceIndices;

    public DeviceGroupSubmitInfo() { }
}
