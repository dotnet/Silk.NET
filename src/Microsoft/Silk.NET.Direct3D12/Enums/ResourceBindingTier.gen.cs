// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RESOURCE_BINDING_TIER")]
    public enum ResourceBindingTier : int
    {
        [NativeName("Name", "D3D12_RESOURCE_BINDING_TIER_1")]
        ResourceBindingTier1 = 0x1,
        [NativeName("Name", "D3D12_RESOURCE_BINDING_TIER_2")]
        ResourceBindingTier2 = 0x2,
        [NativeName("Name", "D3D12_RESOURCE_BINDING_TIER_3")]
        ResourceBindingTier3 = 0x3,
    }
}
