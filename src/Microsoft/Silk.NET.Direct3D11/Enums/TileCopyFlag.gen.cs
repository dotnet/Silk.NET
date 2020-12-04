// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TILE_COPY_FLAG")]
    public enum TileCopyFlag
    {
        [NativeName("Name", "D3D11_TILE_COPY_NO_OVERWRITE")]
        TileCopyNoOverwrite = 0x1,
        [NativeName("Name", "D3D11_TILE_COPY_LINEAR_BUFFER_TO_SWIZZLED_TILED_RESOURCE")]
        TileCopyLinearBufferToSwizzledTiledResource = 0x2,
        [NativeName("Name", "D3D11_TILE_COPY_SWIZZLED_TILED_RESOURCE_TO_LINEAR_BUFFER")]
        TileCopySwizzledTiledResourceToLinearBuffer = 0x4,
    }
}
