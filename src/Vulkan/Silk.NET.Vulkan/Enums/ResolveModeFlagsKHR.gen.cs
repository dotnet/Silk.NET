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
    [NativeName("Name", "VkResolveModeFlagsKHR")]
    public enum ResolveModeFlagsKHR : int
    {
        [NativeName("Name", "VK_RESOLVE_MODE_NONE")]
        ResolveModeNone = 0,
        [NativeName("Name", "VK_RESOLVE_MODE_SAMPLE_ZERO_BIT")]
        ResolveModeSampleZeroBit = 1,
        [NativeName("Name", "VK_RESOLVE_MODE_AVERAGE_BIT")]
        ResolveModeAverageBit = 2,
        [NativeName("Name", "VK_RESOLVE_MODE_MIN_BIT")]
        ResolveModeMinBit = 4,
        [NativeName("Name", "VK_RESOLVE_MODE_MAX_BIT")]
        ResolveModeMaxBit = 8,
    }
}
