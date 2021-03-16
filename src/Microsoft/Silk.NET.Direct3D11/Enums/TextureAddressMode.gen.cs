// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
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
