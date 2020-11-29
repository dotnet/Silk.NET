// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_TILE_MAPPING_FLAGS")]
    public enum TileMappingFlags
    {
        [NativeName("Name", "D3D12_TILE_MAPPING_FLAG_NONE")]
        TileMappingFlagNone = 0x0,
        [NativeName("Name", "D3D12_TILE_MAPPING_FLAG_NO_HAZARD")]
        TileMappingFlagNoHazard = 0x1,
    }
}
