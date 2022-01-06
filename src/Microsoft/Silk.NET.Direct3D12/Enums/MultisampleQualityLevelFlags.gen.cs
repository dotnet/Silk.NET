// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_MULTISAMPLE_QUALITY_LEVEL_FLAGS")]
    public enum MultisampleQualityLevelFlags : int
    {
        [NativeName("Name", "D3D12_MULTISAMPLE_QUALITY_LEVELS_FLAG_NONE")]
        MultisampleQualityLevelsFlagNone = 0x0,
        [NativeName("Name", "D3D12_MULTISAMPLE_QUALITY_LEVELS_FLAG_TILED_RESOURCE")]
        MultisampleQualityLevelsFlagTiledResource = 0x1,
    }
}
