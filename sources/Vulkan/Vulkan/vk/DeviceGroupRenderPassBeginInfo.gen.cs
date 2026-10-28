// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDeviceGroupRenderPassBeginInfo")]
public unsafe partial struct DeviceGroupRenderPassBeginInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DeviceGroupRenderPassBeginInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("deviceMask")]
    public uint DeviceMask;

    [NativeName("deviceRenderAreaCount")]
    public uint DeviceRenderAreaCount;

    [NativeName("pDeviceRenderAreas")]
    public Rect2D* PDeviceRenderAreas;

    public DeviceGroupRenderPassBeginInfo() { }
}
