// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum MemoryPropertyFlags
    {
        MemoryPropertyDeviceLocalBit = 1,
        MemoryPropertyHostVisibleBit = 2,
        MemoryPropertyHostCoherentBit = 4,
        MemoryPropertyHostCachedBit = 8,
        MemoryPropertyLazilyAllocatedBit = 16,
        MemoryPropertyDeviceCoherentBitAmd = 64,
        MemoryPropertyDeviceUncachedBitAmd = 128,
        MemoryPropertyProtectedBit = 32,
    }
}
