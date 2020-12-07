// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_HEAP_SERIALIZATION_TIER")]
    public enum HeapSerializationTier
    {
        [NativeName("Name", "D3D12_HEAP_SERIALIZATION_TIER_0")]
        HeapSerializationTier0 = 0x0,
        [NativeName("Name", "D3D12_HEAP_SERIALIZATION_TIER_10")]
        HeapSerializationTier10 = 0xA,
    }
}
