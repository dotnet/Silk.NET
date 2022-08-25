// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_TILE_COPY_FLAG")]
    public enum TileCopyFlag : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"NoOverwrite\"")]
        [NativeName("Name", "D3D11_TILE_COPY_NO_OVERWRITE")]
        TileCopyNoOverwrite = 0x1,
        [Obsolete("Deprecated in favour of \"LinearBufferToSwizzledTiledResource\"")]
        [NativeName("Name", "D3D11_TILE_COPY_LINEAR_BUFFER_TO_SWIZZLED_TILED_RESOURCE")]
        TileCopyLinearBufferToSwizzledTiledResource = 0x2,
        [Obsolete("Deprecated in favour of \"SwizzledTiledResourceToLinearBuffer\"")]
        [NativeName("Name", "D3D11_TILE_COPY_SWIZZLED_TILED_RESOURCE_TO_LINEAR_BUFFER")]
        TileCopySwizzledTiledResourceToLinearBuffer = 0x4,
        [NativeName("Name", "D3D11_TILE_COPY_NO_OVERWRITE")]
        NoOverwrite = 0x1,
        [NativeName("Name", "D3D11_TILE_COPY_LINEAR_BUFFER_TO_SWIZZLED_TILED_RESOURCE")]
        LinearBufferToSwizzledTiledResource = 0x2,
        [NativeName("Name", "D3D11_TILE_COPY_SWIZZLED_TILED_RESOURCE_TO_LINEAR_BUFFER")]
        SwizzledTiledResourceToLinearBuffer = 0x4,
    }
}
