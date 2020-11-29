// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_MEMORY_POOL")]
    public enum MemoryPool
    {
        [NativeName("Name", "D3D12_MEMORY_POOL_UNKNOWN")]
        MemoryPoolUnknown = 0x0,
        [NativeName("Name", "D3D12_MEMORY_POOL_L0")]
        MemoryPoolL0 = 0x1,
        [NativeName("Name", "D3D12_MEMORY_POOL_L1")]
        MemoryPoolL1 = 0x2,
    }
}
