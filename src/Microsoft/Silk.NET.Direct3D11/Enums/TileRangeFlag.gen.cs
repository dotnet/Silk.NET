// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_TILE_RANGE_FLAG")]
    public enum TileRangeFlag : int
    {
        [NativeName("Name", "D3D11_TILE_RANGE_NULL")]
        TileRangeNull = 0x1,
        [NativeName("Name", "D3D11_TILE_RANGE_SKIP")]
        TileRangeSkip = 0x2,
        [NativeName("Name", "D3D11_TILE_RANGE_REUSE_SINGLE_TILE")]
        TileRangeReuseSingleTile = 0x4,
    }
}
