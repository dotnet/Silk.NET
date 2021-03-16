// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_MULTISAMPLE_QUALITY_LEVEL_FLAGS")]
    public enum MultisampleQualityLevelFlags : int
    {
        [NativeName("Name", "D3D12_MULTISAMPLE_QUALITY_LEVELS_FLAG_NONE")]
        MultisampleQualityLevelsFlagNone = 0x0,
        [NativeName("Name", "D3D12_MULTISAMPLE_QUALITY_LEVELS_FLAG_TILED_RESOURCE")]
        MultisampleQualityLevelsFlagTiledResource = 0x1,
    }
}
