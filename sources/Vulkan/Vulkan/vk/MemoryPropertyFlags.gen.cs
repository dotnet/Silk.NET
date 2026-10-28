// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkMemoryPropertyFlags")]
[Flags]
public enum MemoryPropertyFlags : uint
{
    None = 0x0,

    [NativeName("VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT")]
    DeviceLocalBit = 0x1,

    [NativeName("VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT")]
    HostVisibleBit = 0x2,

    [NativeName("VK_MEMORY_PROPERTY_HOST_COHERENT_BIT")]
    HostCoherentBit = 0x4,

    [NativeName("VK_MEMORY_PROPERTY_HOST_CACHED_BIT")]
    HostCachedBit = 0x8,

    [NativeName("VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT")]
    LazilyAllocatedBit = 0x10,

    [NativeName("VK_MEMORY_PROPERTY_PROTECTED_BIT")]
    ProtectedBit = 0x20,

    [NativeName("VK_MEMORY_PROPERTY_DEVICE_COHERENT_BIT_AMD")]
    DeviceCoherentBitAMD = 0x40,

    [NativeName("VK_MEMORY_PROPERTY_DEVICE_UNCACHED_BIT_AMD")]
    DeviceUncachedBitAMD = 0x80,

    [NativeName("VK_MEMORY_PROPERTY_RDMA_CAPABLE_BIT_NV")]
    RdmaCapableBitNV = 0x100,
}
