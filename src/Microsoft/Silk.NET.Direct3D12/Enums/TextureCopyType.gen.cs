// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_TEXTURE_COPY_TYPE")]
    public enum TextureCopyType : int
    {
        [Obsolete("Deprecated in favour of \"SubresourceIndex\"")]
        [NativeName("Name", "D3D12_TEXTURE_COPY_TYPE_SUBRESOURCE_INDEX")]
        TextureCopyTypeSubresourceIndex = 0x0,
        [Obsolete("Deprecated in favour of \"PlacedFootprint\"")]
        [NativeName("Name", "D3D12_TEXTURE_COPY_TYPE_PLACED_FOOTPRINT")]
        TextureCopyTypePlacedFootprint = 0x1,
        [NativeName("Name", "D3D12_TEXTURE_COPY_TYPE_SUBRESOURCE_INDEX")]
        SubresourceIndex = 0x0,
        [NativeName("Name", "D3D12_TEXTURE_COPY_TYPE_PLACED_FOOTPRINT")]
        PlacedFootprint = 0x1,
    }
}
