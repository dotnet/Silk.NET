// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDeviceCreateInfo")]
public unsafe partial struct DeviceCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DeviceCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public uint Flags;

    [NativeName("queueCreateInfoCount")]
    public uint QueueCreateInfoCount;

    [NativeName("pQueueCreateInfos")]
    public DeviceQueueCreateInfo* PQueueCreateInfos;

    [NativeName("enabledLayerCount")]
    public uint EnabledLayerCount;

    [NativeName("ppEnabledLayerNames")]
    public sbyte** PpEnabledLayerNames;

    [NativeName("enabledExtensionCount")]
    public uint EnabledExtensionCount;

    [NativeName("ppEnabledExtensionNames")]
    public sbyte** PpEnabledExtensionNames;

    [NativeName("pEnabledFeatures")]
    public PhysicalDeviceFeatures* PEnabledFeatures;

    public DeviceCreateInfo() { }
}
