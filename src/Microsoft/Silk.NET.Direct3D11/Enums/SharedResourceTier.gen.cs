// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_SHARED_RESOURCE_TIER")]
    public enum SharedResourceTier
    {
        [NativeName("Name", "D3D11_SHARED_RESOURCE_TIER_0")]
        SharedResourceTier0 = 0x0,
        [NativeName("Name", "D3D11_SHARED_RESOURCE_TIER_1")]
        SharedResourceTier1 = 0x1,
        [NativeName("Name", "D3D11_SHARED_RESOURCE_TIER_2")]
        SharedResourceTier2 = 0x2,
        [NativeName("Name", "D3D11_SHARED_RESOURCE_TIER_3")]
        SharedResourceTier3 = 0x3,
    }
}
