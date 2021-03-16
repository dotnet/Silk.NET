// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_TIER")]
    public enum RaytracingTier : int
    {
        [NativeName("Name", "D3D12_RAYTRACING_TIER_NOT_SUPPORTED")]
        RaytracingTierNotSupported = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_TIER_1_0")]
        RaytracingTier10 = 0xA,
        [NativeName("Name", "D3D12_RAYTRACING_TIER_1_1")]
        RaytracingTier11 = 0xB,
    }
}
