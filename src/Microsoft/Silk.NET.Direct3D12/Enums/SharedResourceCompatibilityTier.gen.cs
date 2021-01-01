// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER")]
    public enum SharedResourceCompatibilityTier : int
    {
        [NativeName("Name", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_0")]
        SharedResourceCompatibilityTier0 = 0x0,
        [NativeName("Name", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_1")]
        SharedResourceCompatibilityTier1 = 0x1,
        [NativeName("Name", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_2")]
        SharedResourceCompatibilityTier2 = 0x2,
    }
}
