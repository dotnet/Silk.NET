// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_TEXTURE_COPY_TYPE")]
    public enum TextureCopyType : int
    {
        [NativeName("Name", "D3D12_TEXTURE_COPY_TYPE_SUBRESOURCE_INDEX")]
        TextureCopyTypeSubresourceIndex = 0x0,
        [NativeName("Name", "D3D12_TEXTURE_COPY_TYPE_PLACED_FOOTPRINT")]
        TextureCopyTypePlacedFootprint = 0x1,
    }
}
