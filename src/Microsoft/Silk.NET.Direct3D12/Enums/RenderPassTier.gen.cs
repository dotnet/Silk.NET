// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RENDER_PASS_TIER")]
    public enum RenderPassTier : int
    {
        [Obsolete("Deprecated in favour of \"Tier0\"")]
        [NativeName("Name", "D3D12_RENDER_PASS_TIER_0")]
        RenderPassTier0 = 0x0,
        [Obsolete("Deprecated in favour of \"Tier1\"")]
        [NativeName("Name", "D3D12_RENDER_PASS_TIER_1")]
        RenderPassTier1 = 0x1,
        [Obsolete("Deprecated in favour of \"Tier2\"")]
        [NativeName("Name", "D3D12_RENDER_PASS_TIER_2")]
        RenderPassTier2 = 0x2,
        [NativeName("Name", "D3D12_RENDER_PASS_TIER_0")]
        Tier0 = 0x0,
        [NativeName("Name", "D3D12_RENDER_PASS_TIER_1")]
        Tier1 = 0x1,
        [NativeName("Name", "D3D12_RENDER_PASS_TIER_2")]
        Tier2 = 0x2,
    }
}
