// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBindImageMemoryDeviceGroupInfo")]
public unsafe partial struct BindImageMemoryDeviceGroupInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.BindImageMemoryDeviceGroupInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("deviceIndexCount")]
    public uint DeviceIndexCount;

    [NativeName("pDeviceIndices")]
    public uint* PDeviceIndices;

    [NativeName("splitInstanceBindRegionCount")]
    public uint SplitInstanceBindRegionCount;

    [NativeName("pSplitInstanceBindRegions")]
    public Rect2D* PSplitInstanceBindRegions;

    public BindImageMemoryDeviceGroupInfo() { }
}
