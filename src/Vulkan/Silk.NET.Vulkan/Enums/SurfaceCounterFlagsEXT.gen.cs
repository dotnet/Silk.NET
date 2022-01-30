// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSurfaceCounterFlagsEXT")]
    public enum SurfaceCounterFlagsEXT : int
    {
        [NativeName("Name", "VK_SURFACE_COUNTER_VBLANK_BIT_EXT")]
        SurfaceCounterVblankBitExt = 1,
        [NativeName("Name", "VK_SURFACE_COUNTER_VBLANK_EXT")]
        SurfaceCounterVblankExt = 1,
    }
}
