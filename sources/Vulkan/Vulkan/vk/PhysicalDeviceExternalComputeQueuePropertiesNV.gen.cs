// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceExternalComputeQueuePropertiesNV")]
public unsafe partial struct PhysicalDeviceExternalComputeQueuePropertiesNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceExternalComputeQueuePropertiesNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("externalDataSize")]
    public uint ExternalDataSize;

    [NativeName("maxExternalQueues")]
    public uint MaxExternalQueues;

    public PhysicalDeviceExternalComputeQueuePropertiesNV() { }
}
