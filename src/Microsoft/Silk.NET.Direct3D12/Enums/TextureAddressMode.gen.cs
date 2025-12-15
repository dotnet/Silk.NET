// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_TEXTURE_ADDRESS_MODE")]
    public enum TextureAddressMode : int
    {
        [Obsolete("Deprecated in favour of \"Wrap\"")]
        [NativeName("Name", "D3D12_TEXTURE_ADDRESS_MODE_WRAP")]
        TextureAddressModeWrap = 0x1,
        [Obsolete("Deprecated in favour of \"Mirror\"")]
        [NativeName("Name", "D3D12_TEXTURE_ADDRESS_MODE_MIRROR")]
        TextureAddressModeMirror = 0x2,
        [Obsolete("Deprecated in favour of \"Clamp\"")]
        [NativeName("Name", "D3D12_TEXTURE_ADDRESS_MODE_CLAMP")]
        TextureAddressModeClamp = 0x3,
        [Obsolete("Deprecated in favour of \"Border\"")]
        [NativeName("Name", "D3D12_TEXTURE_ADDRESS_MODE_BORDER")]
        TextureAddressModeBorder = 0x4,
        [Obsolete("Deprecated in favour of \"MirrorOnce\"")]
        [NativeName("Name", "D3D12_TEXTURE_ADDRESS_MODE_MIRROR_ONCE")]
        TextureAddressModeMirrorOnce = 0x5,
        [NativeName("Name", "D3D12_TEXTURE_ADDRESS_MODE_WRAP")]
        Wrap = 0x1,
        [NativeName("Name", "D3D12_TEXTURE_ADDRESS_MODE_MIRROR")]
        Mirror = 0x2,
        [NativeName("Name", "D3D12_TEXTURE_ADDRESS_MODE_CLAMP")]
        Clamp = 0x3,
        [NativeName("Name", "D3D12_TEXTURE_ADDRESS_MODE_BORDER")]
        Border = 0x4,
        [NativeName("Name", "D3D12_TEXTURE_ADDRESS_MODE_MIRROR_ONCE")]
        MirrorOnce = 0x5,
    }
}
