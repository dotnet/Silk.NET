// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_RENDER_PASS_TIER")]
    public enum RenderPassTier : int
    {
        [NativeName("Name", "D3D12_RENDER_PASS_TIER_0")]
        RenderPassTier0 = 0x0,
        [NativeName("Name", "D3D12_RENDER_PASS_TIER_1")]
        RenderPassTier1 = 0x1,
        [NativeName("Name", "D3D12_RENDER_PASS_TIER_2")]
        RenderPassTier2 = 0x2,
    }
}
