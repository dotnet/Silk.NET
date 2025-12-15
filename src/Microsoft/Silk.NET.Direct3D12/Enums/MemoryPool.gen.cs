// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_MEMORY_POOL")]
    public enum MemoryPool : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "D3D12_MEMORY_POOL_UNKNOWN")]
        MemoryPoolUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"L0\"")]
        [NativeName("Name", "D3D12_MEMORY_POOL_L0")]
        MemoryPoolL0 = 0x1,
        [Obsolete("Deprecated in favour of \"L1\"")]
        [NativeName("Name", "D3D12_MEMORY_POOL_L1")]
        MemoryPoolL1 = 0x2,
        [NativeName("Name", "D3D12_MEMORY_POOL_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "D3D12_MEMORY_POOL_L0")]
        L0 = 0x1,
        [NativeName("Name", "D3D12_MEMORY_POOL_L1")]
        L1 = 0x2,
    }
}
