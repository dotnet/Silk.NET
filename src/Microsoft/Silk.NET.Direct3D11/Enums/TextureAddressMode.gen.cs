// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_TEXTURE_ADDRESS_MODE")]
    public enum TextureAddressMode : int
    {
        [NativeName("Name", "D3D11_TEXTURE_ADDRESS_WRAP")]
        TextureAddressWrap = 0x1,
        [NativeName("Name", "D3D11_TEXTURE_ADDRESS_MIRROR")]
        TextureAddressMirror = 0x2,
        [NativeName("Name", "D3D11_TEXTURE_ADDRESS_CLAMP")]
        TextureAddressClamp = 0x3,
        [NativeName("Name", "D3D11_TEXTURE_ADDRESS_BORDER")]
        TextureAddressBorder = 0x4,
        [NativeName("Name", "D3D11_TEXTURE_ADDRESS_MIRROR_ONCE")]
        TextureAddressMirrorOnce = 0x5,
    }
}
