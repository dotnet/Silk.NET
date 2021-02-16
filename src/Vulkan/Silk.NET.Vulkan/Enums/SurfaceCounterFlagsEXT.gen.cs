// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkSurfaceCounterFlagsEXT")]
    public enum SurfaceCounterFlagsEXT : int
    {
        [NativeName("Name", "VK_SURFACE_COUNTER_VBLANK_BIT_EXT")]
        SurfaceCounterVblankBitExt = 1,
        [NativeName("Name", "VK_SURFACE_COUNTER_VBLANK_EXT")]
        SurfaceCounterVblankExt = 1,
    }
}
