// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkMemoryUnmapFlagsKHR")]
    public enum MemoryUnmapFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ReserveBitExt\"")]
        [NativeName("Name", "VK_MEMORY_UNMAP_RESERVE_BIT_EXT")]
        MemoryUnmapReserveBitExt = 1,
        [NativeName("Name", "VK_MEMORY_UNMAP_RESERVE_BIT_EXT")]
        ReserveBitExt = 1,
    }
}
