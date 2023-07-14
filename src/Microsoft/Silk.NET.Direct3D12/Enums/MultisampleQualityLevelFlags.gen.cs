// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_MULTISAMPLE_QUALITY_LEVEL_FLAGS")]
    public enum MultisampleQualityLevelFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_MULTISAMPLE_QUALITY_LEVELS_FLAG_NONE")]
        MultisampleQualityLevelsFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"TiledResource\"")]
        [NativeName("Name", "D3D12_MULTISAMPLE_QUALITY_LEVELS_FLAG_TILED_RESOURCE")]
        MultisampleQualityLevelsFlagTiledResource = 0x1,
        [NativeName("Name", "D3D12_MULTISAMPLE_QUALITY_LEVELS_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_MULTISAMPLE_QUALITY_LEVELS_FLAG_TILED_RESOURCE")]
        TiledResource = 0x1,
    }
}
