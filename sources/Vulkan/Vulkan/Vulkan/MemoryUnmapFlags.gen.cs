// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkMemoryUnmapFlagBits")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum MemoryUnmapFlags : uint
{
    None = 0x0,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_MEMORY_UNMAP_RESERVE_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    ReserveBitEXT = 0x1,
}
