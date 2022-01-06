// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_TILE_RANGE_FLAGS")]
    public enum TileRangeFlags : int
    {
        [NativeName("Name", "D3D12_TILE_RANGE_FLAG_NONE")]
        TileRangeFlagNone = 0x0,
        [NativeName("Name", "D3D12_TILE_RANGE_FLAG_NULL")]
        TileRangeFlagNull = 0x1,
        [NativeName("Name", "D3D12_TILE_RANGE_FLAG_SKIP")]
        TileRangeFlagSkip = 0x2,
        [NativeName("Name", "D3D12_TILE_RANGE_FLAG_REUSE_SINGLE_TILE")]
        TileRangeFlagReuseSingleTile = 0x4,
    }
}
