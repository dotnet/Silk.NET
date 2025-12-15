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
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_TILE_RANGE_FLAG_NONE")]
        TileRangeFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Null\"")]
        [NativeName("Name", "D3D12_TILE_RANGE_FLAG_NULL")]
        TileRangeFlagNull = 0x1,
        [Obsolete("Deprecated in favour of \"Skip\"")]
        [NativeName("Name", "D3D12_TILE_RANGE_FLAG_SKIP")]
        TileRangeFlagSkip = 0x2,
        [Obsolete("Deprecated in favour of \"ReuseSingleTile\"")]
        [NativeName("Name", "D3D12_TILE_RANGE_FLAG_REUSE_SINGLE_TILE")]
        TileRangeFlagReuseSingleTile = 0x4,
        [NativeName("Name", "D3D12_TILE_RANGE_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_TILE_RANGE_FLAG_NULL")]
        Null = 0x1,
        [NativeName("Name", "D3D12_TILE_RANGE_FLAG_SKIP")]
        Skip = 0x2,
        [NativeName("Name", "D3D12_TILE_RANGE_FLAG_REUSE_SINGLE_TILE")]
        ReuseSingleTile = 0x4,
    }
}
