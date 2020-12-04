// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TILE_RANGE_FLAG")]
    public enum TileRangeFlag
    {
        [NativeName("Name", "D3D11_TILE_RANGE_NULL")]
        TileRangeNull = 0x1,
        [NativeName("Name", "D3D11_TILE_RANGE_SKIP")]
        TileRangeSkip = 0x2,
        [NativeName("Name", "D3D11_TILE_RANGE_REUSE_SINGLE_TILE")]
        TileRangeReuseSingleTile = 0x4,
    }
}
