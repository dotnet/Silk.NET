// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum ResolveModeFlags
    {
        ResolveModeNone = 0,
        ResolveModeSampleZeroBit = 1,
        ResolveModeAverageBit = 2,
        ResolveModeMinBit = 4,
        ResolveModeMaxBit = 8,
    }
}
