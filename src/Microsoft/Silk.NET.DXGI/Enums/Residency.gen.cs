// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_RESIDENCY")]
    public enum Residency
    {
        [NativeName("Name", "DXGI_RESIDENCY_FULLY_RESIDENT")]
        ResidencyFullyResident = 0x1,
        [NativeName("Name", "DXGI_RESIDENCY_RESIDENT_IN_SHARED_MEMORY")]
        ResidencyResidentInSharedMemory = 0x2,
        [NativeName("Name", "DXGI_RESIDENCY_EVICTED_TO_DISK")]
        ResidencyEvictedToDisk = 0x3,
    }
}
