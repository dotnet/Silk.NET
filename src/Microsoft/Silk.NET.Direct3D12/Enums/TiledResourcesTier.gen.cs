// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_TILED_RESOURCES_TIER")]
    public enum TiledResourcesTier : int
    {
        [NativeName("Name", "D3D12_TILED_RESOURCES_TIER_NOT_SUPPORTED")]
        TiledResourcesTierNotSupported = 0x0,
        [NativeName("Name", "D3D12_TILED_RESOURCES_TIER_1")]
        TiledResourcesTier1 = 0x1,
        [NativeName("Name", "D3D12_TILED_RESOURCES_TIER_2")]
        TiledResourcesTier2 = 0x2,
        [NativeName("Name", "D3D12_TILED_RESOURCES_TIER_3")]
        TiledResourcesTier3 = 0x3,
        [NativeName("Name", "D3D12_TILED_RESOURCES_TIER_4")]
        TiledResourcesTier4 = 0x4,
    }
}
