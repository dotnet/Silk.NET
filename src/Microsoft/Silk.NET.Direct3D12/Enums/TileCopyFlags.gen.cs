// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_TILE_COPY_FLAGS")]
    public enum TileCopyFlags : int
    {
        [NativeName("Name", "D3D12_TILE_COPY_FLAG_NONE")]
        TileCopyFlagNone = 0x0,
        [NativeName("Name", "D3D12_TILE_COPY_FLAG_NO_HAZARD")]
        TileCopyFlagNoHazard = 0x1,
        [NativeName("Name", "D3D12_TILE_COPY_FLAG_LINEAR_BUFFER_TO_SWIZZLED_TILED_RESOURCE")]
        TileCopyFlagLinearBufferToSwizzledTiledResource = 0x2,
        [NativeName("Name", "D3D12_TILE_COPY_FLAG_SWIZZLED_TILED_RESOURCE_TO_LINEAR_BUFFER")]
        TileCopyFlagSwizzledTiledResourceToLinearBuffer = 0x4,
    }
}
