// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_CONSERVATIVE_RASTERIZATION_TIER")]
    public enum ConservativeRasterizationTier
    {
        [NativeName("Name", "D3D11_CONSERVATIVE_RASTERIZATION_NOT_SUPPORTED")]
        ConservativeRasterizationNotSupported = 0x0,
        [NativeName("Name", "D3D11_CONSERVATIVE_RASTERIZATION_TIER_1")]
        ConservativeRasterizationTier1 = 0x1,
        [NativeName("Name", "D3D11_CONSERVATIVE_RASTERIZATION_TIER_2")]
        ConservativeRasterizationTier2 = 0x2,
        [NativeName("Name", "D3D11_CONSERVATIVE_RASTERIZATION_TIER_3")]
        ConservativeRasterizationTier3 = 0x3,
    }
}
