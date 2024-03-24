// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkMemoryMapFlags")]
    public enum MemoryMapFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"PlacedBitExt\"")]
        [NativeName("Name", "VK_MEMORY_MAP_PLACED_BIT_EXT")]
        MemoryMapPlacedBitExt = 1,
        [NativeName("Name", "VK_MEMORY_MAP_PLACED_BIT_EXT")]
        PlacedBitExt = 1,
    }
}
