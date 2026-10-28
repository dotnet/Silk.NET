// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkMemoryHeapFlags")]
[Flags]
public enum MemoryHeapFlags : uint
{
    None = 0x0,

    [NativeName("VK_MEMORY_HEAP_DEVICE_LOCAL_BIT")]
    DeviceLocalBit = 0x1,

    [NativeName("VK_MEMORY_HEAP_MULTI_INSTANCE_BIT")]
    MultiInstanceBit = 0x2,

    [NativeName("VK_MEMORY_HEAP_TILE_MEMORY_BIT_QCOM")]
    TileMemoryBitQCOM = 0x8,

    [NativeName("VK_MEMORY_HEAP_MULTI_INSTANCE_BIT_KHR")]
    MultiInstanceBitKHR = MultiInstanceBit,
}
