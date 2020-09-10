// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_TEXTURE_COPY_TYPE")]
    public enum TextureCopyType
    {
        [NativeName("Name", "D3D12_TEXTURE_COPY_TYPE_SUBRESOURCE_INDEX")]
        TextureCopyTypeSubresourceIndex = 0x0,
        [NativeName("Name", "D3D12_TEXTURE_COPY_TYPE_PLACED_FOOTPRINT")]
        TextureCopyTypePlacedFootprint = 0x1,
    }
}
