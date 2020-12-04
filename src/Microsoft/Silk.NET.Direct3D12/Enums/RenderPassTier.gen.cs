// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RENDER_PASS_TIER")]
    public enum RenderPassTier
    {
        [NativeName("Name", "D3D12_RENDER_PASS_TIER_0")]
        RenderPassTier0 = 0x0,
        [NativeName("Name", "D3D12_RENDER_PASS_TIER_1")]
        RenderPassTier1 = 0x1,
        [NativeName("Name", "D3D12_RENDER_PASS_TIER_2")]
        RenderPassTier2 = 0x2,
    }
}
