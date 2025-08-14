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
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_TILE_COPY_FLAG_NONE")]
        TileCopyFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"NoHazard\"")]
        [NativeName("Name", "D3D12_TILE_COPY_FLAG_NO_HAZARD")]
        TileCopyFlagNoHazard = 0x1,
        [Obsolete("Deprecated in favour of \"LinearBufferToSwizzledTiledResource\"")]
        [NativeName("Name", "D3D12_TILE_COPY_FLAG_LINEAR_BUFFER_TO_SWIZZLED_TILED_RESOURCE")]
        TileCopyFlagLinearBufferToSwizzledTiledResource = 0x2,
        [Obsolete("Deprecated in favour of \"SwizzledTiledResourceToLinearBuffer\"")]
        [NativeName("Name", "D3D12_TILE_COPY_FLAG_SWIZZLED_TILED_RESOURCE_TO_LINEAR_BUFFER")]
        TileCopyFlagSwizzledTiledResourceToLinearBuffer = 0x4,
        [NativeName("Name", "D3D12_TILE_COPY_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_TILE_COPY_FLAG_NO_HAZARD")]
        NoHazard = 0x1,
        [NativeName("Name", "D3D12_TILE_COPY_FLAG_LINEAR_BUFFER_TO_SWIZZLED_TILED_RESOURCE")]
        LinearBufferToSwizzledTiledResource = 0x2,
        [NativeName("Name", "D3D12_TILE_COPY_FLAG_SWIZZLED_TILED_RESOURCE_TO_LINEAR_BUFFER")]
        SwizzledTiledResourceToLinearBuffer = 0x4,
    }
}
